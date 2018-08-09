using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace E_Tolling_System
{
    public partial class Register_User : Form
    {
        public SerialPort aSerialPort = new SerialPort(); // thisport is a reference of the serial port to be used in the program
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Register_User()
        {
            InitializeComponent();
            getAvailablePorts();
            btnadduser.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_User myMenu = new View_User();
            myMenu.Show();
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames(); // gets the available port names
            add_comboBox.Items.AddRange(ports);  // populates the combobox with free ports
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO mainDatabase (Idnumber, name, Gender, Dateofbirth, Mobilenumber, Email, City, Address, Country, VehicleNumber, LicenseNumber, RechargeAmount, TagNumber) values('" + idnumber_txtBox.Text + "' ,'" + username_txtBox.Text + "','" + gender_txtBox.SelectedItem.ToString() + "','" + dateTimePicker1.Text + "','" + mobilenumber_txtBox.Text + "','" + email_txtBox.Text + "' ,'" + city_txtBox.Text + "','" + address_txtBox.Text + "','" + country_txtBox.Text + "','" + vehicleType_TxtBox.Text + "','" + licensenumber_TxtBox.Text + "','"+ rechargeAmnt_txtBox.Text +"','" + rfidTag_TxtBox.Text + "')";

                OpenConn();
                cmd = new SqlCommand(insertQuery, myConn);
                int x = cmd.ExecuteNonQuery();
                CloseConn();
                MessageBox.Show(x.ToString() + "record(s) saved.");

              if (aSerialPort.IsOpen)
               {
                  aSerialPort.Close();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OpenConn()
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
        }

        public void CloseConn()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }
        public void executeQuery(string query)
        {
            try
            {
                OpenConn();
                cmd = new SqlCommand(query, myConn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConn();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnadduser.Enabled = true;
            try
            {
                aSerialPort.PortName = add_comboBox.Text; // the open serial port from the machine
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "portname empty");
            }
            aSerialPort.BaudRate = 9600;  //baudrate of the serial communication system
            aSerialPort.DataBits = 8;
            aSerialPort.Parity = Parity.None;
            aSerialPort.StopBits = StopBits.One;
            aSerialPort.DataBits = 8;
            aSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                if (!aSerialPort.IsOpen)
                {
                    aSerialPort.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Port Not Available");
            }
        }

        private void DataReceivedHandler(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sData = sender as SerialPort;
                string w = sData.ReadExisting();

                if (w != String.Empty)
                {
                    Invoke(new Action(() => rfidTag_TxtBox.AppendText(w)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Conflict");
            }
        }
    }
}