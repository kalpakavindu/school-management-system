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
    public partial class AdminTeacherScreen : Form
    {
        Functions connection;
        private int _key;

        public AdminTeacherScreen()
        { 
            InitializeComponent();
            connection = new Functions();
            upd_teacher_btn.Visible = false;

            // load all data for teachers_table
            _loadTeachers();
        }

        private void _loadTeachers()
        {
            // get all data from TeacherTable
            string query = "SELECT * FROM TeacherTable";
            DataTable teacherData = connection.GetData(query);

            // get all data from SubjectTable
            query = "SELECT * FROM SubjectTable";
            DataTable subjectData = connection.GetData(query);

            // add new column to assign subject names
            teacherData.Columns.Add("subject_name", typeof(string));

            // assign subject names into new column
            for(int i=0; i<teacherData.Rows.Count; i++)
            {
                foreach(DataRow r in subjectData.Rows)
                {
                    if (r["id"].Equals(teacherData.Rows[i]["subject"]))
                    {
                        teacherData.Rows[i]["subject_name"] = r["name"];
                    }
                }
            }

            // Remove unnecessary columns
            teacherData.Columns.Remove("subject");
            teacherData.Columns.Remove("password");

            // set datasource to teacherData
            teachers_table.DataSource = teacherData;
        }

        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            Modals.AddTeacherModal addTeacherModal = new Modals.AddTeacherModal();
            addTeacherModal.FormClosed += addTeacherModal_Closed;
            addTeacherModal.ShowDialog();
        }

        private void upd_teacher_btn_Click(object sender, EventArgs e)
        {
            if (_key == 0)
            {
                MessageBox.Show("Selecet teacher first", "Select Teacher", MessageBoxButtons.OK);
            }
            else
            {
                Modals.EditTeacherModal editTeacherModal = new Modals.EditTeacherModal(_key);
                editTeacherModal.FormClosed += editTeacherModal_Closed;
                editTeacherModal.ShowDialog();
            }
        }

        private void teachers_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _key = Convert.ToInt32(teachers_table.SelectedRows[0].Cells[0].Value.ToString());
            upd_teacher_btn.Visible = true;
        }

        private void addTeacherModal_Closed(object sender, FormClosedEventArgs e)
        {
            upd_teacher_btn.Visible = false;
            _key = 0;
            _loadTeachers();
        }
        private void editTeacherModal_Closed(object sender,FormClosedEventArgs e)
        {
            upd_teacher_btn.Visible = false;
            _key = 0;
            _loadTeachers();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            AdminDashboardScreen adminDashboardScreen = new AdminDashboardScreen();
            adminDashboardScreen.Show();
            this.Close();
        }

        private void student_label_Click(object sender, EventArgs e)
        {
            AdminStudentScreen adminStudentScreen = new AdminStudentScreen();
            adminStudentScreen.Show();
            this.Close();
        }

        private void classes_label_Click(object sender, EventArgs e)
        {
            AdminClassScreen adminClassScreen = new AdminClassScreen();
            adminClassScreen.Show();
            this.Close();
        }

        private void subject_label_Click(object sender, EventArgs e)
        {
            AdminSubjectScreen adminSubjectScreen = new AdminSubjectScreen();
            adminSubjectScreen.Show();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
