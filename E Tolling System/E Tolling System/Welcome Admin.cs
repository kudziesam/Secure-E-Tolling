using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Tolling_System
{
    public partial class Welcome_Admin : Form
    {
        public Welcome_Admin()
        {
            InitializeComponent();
        }

        private void Welcome_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void addvehiclebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_User mainFrm = new View_User();
            mainFrm.Show();

        }

        private void btnRegisterNewT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_New_TollGate here = new Register_New_TollGate();
            here.Show();

        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginfrm = new Login();
            loginfrm.Show();
            //close the entire Aplication
        }

        private void already_registered_user_bttn_Click(object sender, EventArgs e)
        {
            user_alreadyRegistered thisUser = new user_alreadyRegistered();
            thisUser.Show();
            this.Hide();
        }
    }
}
