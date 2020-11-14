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

        public Form1()
        {
            InitializeComponent();

            port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 115200;
            port.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox1.Text);
            Thread.Sleep(200);
            richTextBox1.Text += port.ReadExisting();
        }
    }
}
