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
    public partial class AdminDashboardScreen : Form
    {
        Functions connection;
        public AdminDashboardScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _loadData();
        }

        private void _loadData()
        {
            try
            {
                string query = "SELECT * FROM TeacherTable WHERE status='PENTIONED'";
                DataTable pantionedTeachersData = connection.GetData(query);
                int pantionedTeachers = pantionedTeachersData.Rows.Count;
                pantioned_teacher.Text = pantionedTeachers.ToString();

                query = "SELECT * FROM TeacherTable";
                DataTable teachersData = connection.GetData(query);
                int teachers = teachersData.Rows.Count;
                total_teachers.Text = teachers.ToString();

                query = "SELECT * FROM StudentTable";
                DataTable studentsData = connection.GetData(query);
                int students = studentsData.Rows.Count;
                total_students.Text = students.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void manage_students_btn_Click(object sender, EventArgs e)
        {
            AdminStudentScreen studentScreen = new AdminStudentScreen();
            studentScreen.Show();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teacher_label_Click(object sender, EventArgs e)
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

        private void subject_label_Click(object sender, EventArgs e)
        {
            AdminSubjectScreen subjectScreen = new AdminSubjectScreen();
            subjectScreen.Show();
            this.Close();
        }

        private void student_label_Click(object sender, EventArgs e)
        {
            AdminStudentScreen studentScreen = new AdminStudentScreen();
            studentScreen.Show();
            this.Close();
        }

        private void manage_teachers_btn_Click(object sender, EventArgs e)
        {
            AdminTeacherScreen adminTeacherScreen = new AdminTeacherScreen();
            adminTeacherScreen.Show();
            this.Close();
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
