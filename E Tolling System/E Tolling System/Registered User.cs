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
    public partial class user_alreadyRegistered : Form
    {
        public user_alreadyRegistered()
        {
            InitializeComponent();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Admin myadmin = new Welcome_Admin();
            myadmin.Show();
        }

        private void registerComplaint_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_compaint showme = new register_compaint();
            showme.Show();
        }
    }
}
