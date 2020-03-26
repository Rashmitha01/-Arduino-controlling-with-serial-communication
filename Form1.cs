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


        private void exit_btn_click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();//update the available port(s) on combobox
        }


        private void updatePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                port_name_cb.Items.Add(port);
            }
        }

        private void connect_btn_click(object sender, EventArgs e)
        {
            try
            {
                if (myport.IsOpen)
                {
                    disconnect();
                }
                else
                {
                    connect();
                }
            }catch(Exception)
            {
                MessageBox.Show("please connect you device \n check: may be your device not detected by the sysetem", "COM port Error");
            }


        }

        private void connect()
        {

            //check if all settings have been selected
            if(port_name_cb.SelectedIndex != -1 & baud_rate_cb.SelectedIndex != -1 & parity_cb.SelectedIndex != -1 & data_bits_cb.SelectedIndex != -1 & stop_bits_cb.SelectedIndex != -1)
            {
                //if yes then set the ports settings and open the port fro communication
                Init();

            }
            else
            {
                MessageBox.Show("Please select all the COM Port Settings","Error!" );
            }
            //if the port is open, chnage the connect button to Diconnct , enable the serial monitor.
            if (myport.IsOpen)
            {
                connect_btn.Text = "Disconnect";
                serial_monitor_gb.Enabled = true;
            }
        }

        private void Init()
        {
                myport = new SerialPort();
                myport.BaudRate = int.Parse(baud_rate_cb.Text);
                myport.PortName = port_name_cb.Text;
                myport.Parity = (Parity)Enum.Parse(typeof(Parity), parity_cb.Text);
                myport.DataBits = int.Parse(data_bits_cb.Text);
                myport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop_bits_cb.Text);
           
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "COM Port error!!!Error opening port");
            }
        }

        private void disconnect()
        {
            myport.Close();
            connect_btn.Text = "Connect";
            serial_monitor_gb.Enabled = false;
        }


    }
}
