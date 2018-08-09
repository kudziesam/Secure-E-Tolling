using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace E_Tolling_System
{
    public partial class Cashier_Box : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gigabyte\Documents\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Cashier_Box()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginfrm = new Login();
            loginfrm.Show();

        }
        private void print_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO ManualPayment (NumberPlate, AmountPaid) values('" + numberPlate_txtBox.Text + "','" + enterAmount_txtBox.Text + "')";
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

            string var = "This car with Number Plate :";
            string var1 = " Paid $";
            print_richTextBox.AppendText(var + numberPlate_txtBox.Text + var1 + enterAmount_txtBox.Text);

            PrintDocument myPrintDoc = new PrintDocument();
            PrintDialog myPrintDialog = new PrintDialog();

            myPrintDoc.PrintPage += new PrintPageEventHandler(myPrintDoc_PrintPage);
            myPrintDialog.Document = myPrintDoc;

            if (myPrintDialog.ShowDialog() == DialogResult.OK)
            {
                myPrintDoc.Print();
            }

            MessageBox.Show("Tollgate Opened");
        }

        void myPrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {            
            Bitmap mybitmap = new Bitmap(print_richTextBox.Width, print_richTextBox.Height);
            print_richTextBox.DrawToBitmap(mybitmap, new Rectangle(0, 0, print_richTextBox.Width, print_richTextBox.Height));
            e.Graphics.DrawImage(mybitmap, 0, 0);
            mybitmap.Dispose();
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
