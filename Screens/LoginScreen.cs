using school_management_system.Screens.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            if(mail_in.Text == "" || password_in.Text == "")
            {
                MessageBox.Show("Please fillout all the feilds.", "Missing credentials", MessageBoxButtons.OK);
            }else if(mail_in.Text == "admin@gmail.com" && password_in.Text == "password")
            {
                AdminDashboardScreen adminDashboardScreen = new AdminDashboardScreen();
                adminDashboardScreen.Show();
                this.Hide();
            }
            else
            {
                mail_in.Text = "";
                password_in.Text = "";
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
