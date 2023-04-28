using school_management_system.Screens;
using school_management_system.Screens.Admin;
using school_management_system.Screens.Student;
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
        Functions connection;
        public LoginScreen()
        {
            InitializeComponent();
            connection = new Functions();
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
                try 
                {
                    string query = $"SELECT * FROM StudentTable WHERE email_address='{mail_in.Text}'";
                    DataTable studentData = connection.GetData(query);
                    if(studentData.Rows.Count == 0)
                    {
                        query = $"SELECT * FROM TeacherTable WHERE email_address='{mail_in.Text}'";
                        DataTable teacherData = connection.GetData(query);
                        if(teacherData.Rows.Count == 0)
                        {
                            MessageBox.Show("The email you entered was not found in the database. Plese contact the admin to solve this issue.", "Email not found", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (teacherData.Rows[0].IsNull("password"))
                            {
                                if(MessageBox.Show("You've not registered to your account yet. Please signup with this email.","Not registered yet",MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    SignupScreen signupScreen = new SignupScreen();
                                    signupScreen.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                TeacherDashboardScreen teacherDashboardScreen = new TeacherDashboardScreen((int)teacherData.Rows[0]["id"]);
                                teacherDashboardScreen.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        if (studentData.Rows[0].IsNull("password"))
                        {
                            if (MessageBox.Show("You've not registered to your account yet. Please signup with this email.", "Not registered yet", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                SignupScreen signupScreen = new SignupScreen();
                                signupScreen.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            StudentDashboardScreen studentDashboard = new StudentDashboardScreen();
                            studentDashboard.Show();
                            this.Hide();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goto_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupScreen signupScreen = new SignupScreen();
            signupScreen.Show();
            this.Hide();
        }
    }
}
