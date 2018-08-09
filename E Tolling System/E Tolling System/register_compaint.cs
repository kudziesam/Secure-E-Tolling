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
using System.IO;

namespace E_Tolling_System
{
    public partial class register_compaint : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SerialPort aSerialData = new SerialPort();
        public register_compaint()
        {
            InitializeComponent();
        }

        private void submit_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO RegisterComplaint (DateOfReg, TagNumberOne, ComplaintDescription) values('" + dateofRegistration_Datetimepicker.Text + "' ,'" + tag_txtBox.Text + "','" + complaint_txtBox.Text + "')";
                OpenConn();
                cmd = new SqlCommand(insertQuery, myConn);
                int x = cmd.ExecuteNonQuery();
                CloseConn();
                MessageBox.Show(x.ToString() + "record(s) saved.");
                //aSerialData.WriteLine("R");
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

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            user_alreadyRegistered thisone = new user_alreadyRegistered();
            thisone.Show();
        }
    }
}
