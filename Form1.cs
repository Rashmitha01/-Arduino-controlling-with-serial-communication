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


namespace recieve_save_data
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        private string in_data;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //myport.WriteLine("start");
            myport.DataReceived += Myport_DataReceived;

        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata_event));
             in_data = myport.ReadLine();           
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            value_tb.AppendText(time + "\t\t\t\t" + in_data + "\n");
            //status of data in progress bar 
            int data_value = Convert.ToInt32(in_data);
            value_pb.Value = data_value;
        }

        private void Init()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = port_tb.Text;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "please fill all the fields");
            }
            
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "COM Port error!!!Error opening port");
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "COM port error!! cannot close the port");
            }
        }

        private void datasave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = @"C:\Users\User\Desktop\DATA";
                string filename = "serial_data";
                System.IO.File.WriteAllText(filepath + filename, value_tb.Text);
                MessageBox.Show("serial data is being saved to " + filepath, "Save File");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while saving data to file");
            }
            
      
        }
    }
}
