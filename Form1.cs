using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_Control_Serial
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void On_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("ON");

            on_btn.Enabled = false;
            off_btn.Enabled = true; 
        }



        private void Init()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM4";
                myport.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("COM port error! Couldn't connect to the port COM4");
            }

            on_btn.Enabled = true;
            off_btn.Enabled = false;
        }

        private void Off_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("OFF");

            on_btn.Enabled = true;
            off_btn.Enabled = false;
        }
    }
}
