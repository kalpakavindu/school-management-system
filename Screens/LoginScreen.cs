using school_management_system.Screens;
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
                AdminScreen adminScreen = new AdminScreen();
                adminScreen.FormClosed += adminScreen_Closed;
                adminScreen.Show();
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
                                if (password_in.Text == (string)teacherData.Rows[0]["password"])
                                {
                                    TeacherScreen teacherScreen = new TeacherScreen((int)teacherData.Rows[0]["id"]);
                                    teacherScreen.FormClosed += teacherScreen_Closed;
                                    teacherScreen.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("The password you entered is invalid", "Error", MessageBoxButtons.OK);
                                }
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
                            if (password_in.Text == (string)studentData.Rows[0]["password"])
                            {
                                StudentScreen studentScreen = new StudentScreen((int)studentData.Rows[0]["id"]);
                                studentScreen.FormClosed += studentScreen_Closed;
                                studentScreen.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("The password you entered is invalid", "Error", MessageBoxButtons.OK);
                            }
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

        private void adminScreen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void teacherScreen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void studentScreen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
