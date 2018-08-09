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

namespace E_Tolling_System
{
    public partial class Register_New_TollGate : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Register_New_TollGate()
        {
            InitializeComponent();
        }

        private void cancel_Bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome_Admin newAdmin = new Welcome_Admin();
            newAdmin.Show();
        }

        private void logout_Bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginfrm = new Login();
            loginfrm.Show();
        }

        private void submit_Bttn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Tollgate (TollgateID, TallgateName, HighWayName) values('" + Tollgate_txtBox.Text + "' ,'" + tollgateName_txtBox.Text + "','" + highwayName_comboBox.SelectedItem.ToString() + "')";

                OpenConn();
                cmd = new SqlCommand(insertQuery, myConn);
                int x = cmd.ExecuteNonQuery();
                CloseConn();
                MessageBox.Show(x.ToString() + "record(s) saved.");
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
    }
}
