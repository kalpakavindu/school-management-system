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
    public partial class TeacherDashboardScreen : Form
    {
        Functions connection;
        private int _teacher_id;

        public TeacherDashboardScreen(int id)
        {
            InitializeComponent();
            connection = new Functions();
            _teacher_id = id;
            _loadData();
        }

        private void _loadData()
        {
            try 
            {
                int totalAs = 0;
                string query = $"SELECT name FROM TeacherTable WHERE id={_teacher_id}";
                teacher_name.Text = (string)connection.GetData(query).Rows[0]["name"];

                query = "SELECT * FROM StudentTable";
                int totalStudents = connection.GetData(query).Rows.Count;
                total_students.Text = totalStudents.ToString();

                query = $"SELECT * FROM AssignmentTable WHERE teacher_id={_teacher_id}";
                DataTable assignmentData = connection.GetData(query);
                total_assignments.Text = assignmentData.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manage_students_btn_Click(object sender, EventArgs e)
        {
            TeacherStudentScreen studentScreen = new TeacherStudentScreen(_teacher_id);
            studentScreen.Show();
            this.Close();
        }

        private void manage_assignments_btn_Click(object sender, EventArgs e)
        {
            TeacherAssignmentScreen assignmentScreen = new TeacherAssignmentScreen(_teacher_id);
            assignmentScreen.Show();
            this.Close();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            TeacherDetailsModal detailsModal = new TeacherDetailsModal(_teacher_id);
            detailsModal.ShowDialog();
        }

        private void students_lable_Click(object sender, EventArgs e)
        {
            TeacherStudentScreen studentScreen = new TeacherStudentScreen(_teacher_id);
            studentScreen.Show();
            this.Close();
        }

        private void assignments_label_Click(object sender, EventArgs e)
        {
            TeacherAssignmentScreen assignmentScreen = new TeacherAssignmentScreen(_teacher_id);
            assignmentScreen.Show();
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
