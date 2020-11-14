using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            port.BaudRate = 115200;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox1.Text);
            Thread.Sleep(200);
            richTextBox1.Text += port.ReadExisting();
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
    }
}
