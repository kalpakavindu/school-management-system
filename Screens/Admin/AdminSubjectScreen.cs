using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Screens.Admin
{
    public partial class AdminSubjectScreen : Form
    {
        Functions connection;
        private int _keyToEdit = 0;

        public AdminSubjectScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _loadSubjects();
        }

        private void _loadSubjects()
        {
            string query = "SELECT * FROM SubjectTable";
            subject_table.DataSource = connection.GetData(query);
        }

        private void _clearEntries()
        {
            subject_name_in.Text = "";
            _keyToEdit = 0;
        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            if(subject_name_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.", "Error - Missing credentials",MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string subject_name = subject_name_in.Text;

                    string save_subject_query = "INSERT INTO SubjectTable values('{0}')";
                    save_subject_query = string.Format(save_subject_query, subject_name);
                    connection.SetData(save_subject_query);
                    _loadSubjects();
                    _clearEntries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void subject_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subject_name_in.Text = subject_table.SelectedRows[0].Cells[1].Value.ToString();

            if(subject_name_in.Text == "")
            {
                _keyToEdit = 0;
            }
            else
            {
                _keyToEdit = Convert.ToInt32(subject_table.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void upd_subject_btn_Click(object sender, EventArgs e)
        {
            if (subject_name_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.", "Error - Missing credentials.",MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string subject_name = subject_name_in.Text;

                    string save_subject_query = "UPDATE SubjectTable SET name='{0}' WHERE id={1}";
                    save_subject_query = string.Format(save_subject_query, subject_name, _keyToEdit);
                    connection.SetData(save_subject_query);
                    _loadSubjects();
                    _clearEntries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void del_subject_btn_Click(object sender, EventArgs e)
        {
            if (_keyToEdit == 0)
            {
                MessageBox.Show("Select a Subject first.","Select a subject", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string subject_name = subject_name_in.Text;

                    string save_subject_query = "DELETE FROM SubjectTable WHERE id={0}";
                    save_subject_query = string.Format(save_subject_query, _keyToEdit);
                    connection.SetData(save_subject_query);
                    _loadSubjects();
                    _clearEntries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            AdminDashboardScreen adminDashboardScreen = new AdminDashboardScreen();
            adminDashboardScreen.Show();
            this.Close();
        }

        private void students_label_Click(object sender, EventArgs e)
        {
            AdminStudentScreen adminStudentScreen = new AdminStudentScreen();
            adminStudentScreen.Show();
            this.Close();
        }

        private void teachers_label_Click(object sender, EventArgs e)
        {
            AdminTeacherScreen adminTeacherScreen = new AdminTeacherScreen();
            adminTeacherScreen.Show();
            this.Close();
        }

        private void classes_label_Click(object sender, EventArgs e)
        {
            AdminClassScreen adminClassScreen = new AdminClassScreen();
            adminClassScreen.Show();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
