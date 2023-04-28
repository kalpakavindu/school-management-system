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

namespace school_management_system.Screens
{
    public partial class SignupScreen : Form
    {
        Functions connection;

        public SignupScreen()
        {
            InitializeComponent();
            connection = new Functions();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(mail_in.Text == "" || pass_in.Text == "" || cpass_in.Text == "")
            {
                MessageBox.Show("Please fillout all the feilds", "Missing credentials", MessageBoxButtons.OK);
            }
            else if(pass_in.Text != cpass_in.Text)
            {
                MessageBox.Show("Passwords you entered are not same.", "Password cinfrimation error", MessageBoxButtons.OK);
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
                            MessageBox.Show("The Email address you entered was not found in the database. Contact admin to solve this issue.", "Email not found", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (!teacherData.Rows[0].IsNull("password")) 
                            {
                                if(MessageBox.Show("You've already registered. Please login.","Already have an account",MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    LoginScreen loginScreen = new LoginScreen();
                                    loginScreen.Show();
                                    this.Close();
                                }
                            }
                            else
                            {
                                query = $"UPDATE TeacherTable SET password='{pass_in.Text}',status='REGISTERED' WHERE id='{(int)teacherData.Rows[0]["id"]}'";
                                connection.SetData(query);
                                MessageBox.Show("Well Done! Now you can login with the password and email you used here.", "Done", MessageBoxButtons.OK);
                                LoginScreen loginScreen = new LoginScreen();
                                loginScreen.Show();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        query = $"UPDATE StudentTable SET password='{pass_in.Text}' WHERE id='{(int)studentData.Rows[0]["id"]}'";
                        connection.SetData(query);
                        MessageBox.Show("Well Done! Now you can login with the password and email you used here.", "Done", MessageBoxButtons.OK);
                        LoginScreen loginScreen = new LoginScreen();
                        loginScreen.Show();
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }
    }
}
