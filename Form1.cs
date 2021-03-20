using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBL_CTRL
{
    public partial class Form1 : Form
    {
        SerialPort port;
        bool isConnected = false;
        bool isPenDown = false;
        double x, y;
        string message;
        string response;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            port.BaudRate = 115200;
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox1.Text);
            //Thread.Sleep(200);
            //richTextBox1.Text += port.ReadExisting();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            comboBox1.Items.Clear();
            foreach (var port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        
        private void conBtn_Click(object sender, EventArgs e)
        {
            if(isConnected == true) //disconnect
            {
                port.Close();
                conBtn.Text = "Connect";
                conBtn.BackColor = Color.Green;
                button1.Enabled = false;
            } else //connect
            {
                if (comboBox1.SelectedItem != null)
                {
                    port.PortName = comboBox1.SelectedItem.ToString();
                    port.Open();
                } else return;
                conBtn.Text = "Disconnect";
                conBtn.BackColor = Color.Red;
                button1.Enabled = true;
            }
            isConnected = !isConnected;
        }

        private void penBtn_Click(object sender, EventArgs e)
        {
            if(isPenDown)
            {
                penBtn.Text = "penUp";
            }
            else
            {
                penBtn.Text = "penDown";
            }
            isPenDown = !isPenDown;
        }

        private string getFeedRate()
        {
            if (radioButton1.Checked) return "100";
            else if (radioButton2.Checked) return "500";
            else return "1000";
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            x++;
            ChangeAndSendCoord();
        }        

        private void leftBtn_Click(object sender, EventArgs e)
        {
            x--;
            ChangeAndSendCoord();
        }
        private void upBtn_Click(object sender, EventArgs e)
        {
            y--;
            ChangeAndSendCoord();
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            y++;
            ChangeAndSendCoord();            
        }

        private void ChangeAndSendCoord()
        {
            labelX.Text = "X: " + x;
            labelY.Text = "Y: " + y;
            message = "G0 X" + x + " Y" + y + " F" + getFeedRate() + "\n";
            richTextBox1.Text += message;
            send(message);
        }

        private void send(string cmd)
        {
            
            
            if (!isConnected)
            {
                MessageBox.Show("Подключись!!!");
            }
            else
            {
                port.Write(cmd);                
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            string[] lines = fileText.Split('\n');
            foreach(var line in lines)
            {
                send(line + '\n');
            }
            
            //richTextBox1.Text = fileText;
        }

        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //sp.ReadLine();
            string indata = sp.ReadExisting();
            response = indata;
            richTextBox1.Invoke((MethodInvoker)delegate
            {
                richTextBox1.Text += indata;
            });
        }
    }
}
