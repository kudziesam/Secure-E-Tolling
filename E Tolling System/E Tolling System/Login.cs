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
    public partial class Login : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void enter_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                myConn.Open();
                string query = "SELECT * FROM Login WHERE Username = '" + usernamecomboBox.Text + "' and Password='" + Pass_txtBox.Text + "'"; //creates a connection to the database
                DataTable dt = new DataTable();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(query, myConn);
                myDataAdapter.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("You have entered wrong Credentials");
                }
                else
                {
                    if (usernamecomboBox.Text == "admin")
                    {
                        Welcome_Admin myMenu = new Welcome_Admin();
                        this.Hide();
                        myMenu.Show();
                    }
                    else
                    {
                        this.Hide();
                        Cashier_Box cashbox = new Cashier_Box();
                        cashbox.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }
    }
}
