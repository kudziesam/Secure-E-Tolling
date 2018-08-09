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
using System.IO;
using System.Data.SqlClient;

namespace E_Tolling_System
{
    public partial class View_User : Form
    {
        #region 
        public SerialPort aSerialPort = new SerialPort(); // thisport is a reference of the serial port to be used in the program
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        #endregion
        int id = 0;
        int i = 0;
        int cnt = 0;
        int count = 0;
        public View_User()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames(); // gets the available port names
            add_comboBox.Items.AddRange(ports);  // populates the combobox with free ports
        }

        private void addNew_bttn_Click(object sender, EventArgs e)
        {
            cnt = 0;
            count = 0;
            aSerialPort.Close();
            this.Hide();
            Register_User newUser = new Register_User();
            newUser.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM mainDatabase", myConn))
                    {
                        DataTable dt = new DataTable("students");
                        da.Fill(dt);
                        tolling_dataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DataReceivedHandler(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sData = sender as SerialPort;
                string w = sData.ReadExisting();

                if (w != String.Empty)
                {
                    Invoke(new Action(() => tagnumber_txtBox.AppendText(w)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Conflict");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void tagnumber_txtBox_TextChanged(object sender, EventArgs e)
        {
            i = 0;
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }

            string query = "SELECT * FROM RegisterComplaint WHERE TagNumberOne = '" + tagnumber_txtBox.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(query, myConn);
            myDataAdapter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0 && cnt == 0)
            {
                cnt = 1;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = myConn;
                cmd.CommandText = "Select *FROM mainDatabase where TagNumber LIKE '%'+@name+'%'";
                cmd.Parameters.AddWithValue("@name", tagnumber_txtBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                tolling_dataGridView.DataSource = ds.Tables[0];

                MessageBox.Show("ACCESS GRANTED");
                aSerialPort.WriteLine("Y");
                tagnumber_txtBox.Clear();
            }
            else if(count == 0)
            {
                count = 1;
                cnt = 1;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = myConn;
                cmd.CommandText = "Select *FROM mainDatabase where TagNumber LIKE '%'+@name+'%'";
                cmd.Parameters.AddWithValue("@name", tagnumber_txtBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                tolling_dataGridView.DataSource = ds.Tables[0];

                MessageBox.Show("ACCESS DENIED REPORT TO THE AUTHORITIES");
                aSerialPort.WriteLine("N");
                tagnumber_txtBox.Clear();
            }
            CloseConn();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            cnt = 0;
            count = 0;
            aSerialPort.Close();
            this.Hide();
            Welcome_Admin thisone = new Welcome_Admin();
            thisone.Show();
        }


        private void tolling_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(tolling_dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM mainDatabase where Id =" + id + "";
            OpenConn();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                id_txtBox.Text = dr["Id"].ToString();
                users_txtBox.Text = dr["Idnumber"].ToString();
                names_txtBox.Text = dr["name"].ToString();
                gender_cmboBox.Text = dr["Gender"].ToString();
                Dateofbirth.Text = dr["Dateofbirth"].ToString();
                mobilenbumber.Text = dr["Mobilenumber"].ToString();
                email_txtBox.Text = dr["Email"].ToString();
                city_txtBox.Text = dr["City"].ToString();
                address_txtBox.Text = dr["Address"].ToString();
                country_txtBox.Text = dr["Country"].ToString();
                vehicleType_TxtBox.Text = dr["VehicleNumber"].ToString();
                licensenumber_TxtBox.Text = dr["LicenseNumber"].ToString();
                accountbalance_TxtBox.Text = dr["RechargeAmount"].ToString();
            }
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            OpenConn();
            string updateQuery = "UPDATE mainDatabase SET RechargeAmount='" + accountbalance_TxtBox.Text + "' WHERE Id = " + int.Parse(id_txtBox.Text);
            executeQuery(updateQuery);
        }
    }
}