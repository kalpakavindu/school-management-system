using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class TeacherStudentScreen : Form
    {
        Functions connection;
        private int _editKey;
        private int _teacher_id;

        public TeacherStudentScreen(int id)
        {
            InitializeComponent();
            connection = new Functions();
            _teacher_id = id;
            show_profile_btn.Visible = false;
            _loadStudents();
        }

        private void _loadStudents()
        {
            try
            {
                string query = $"SELECT * FROM ClassTable WHERE class_teacher='{_teacher_id}'";
                DataTable classData = connection.GetData(query);

                // new DataTable for student data
                DataTable studentData = new DataTable();
                studentData.Columns.Add("id", typeof(int));
                studentData.Columns.Add("name", typeof(string));
                studentData.Columns.Add("gender", typeof(string));
                studentData.Columns.Add("dob", typeof(string));
                studentData.Columns.Add("contact_number", typeof(string));
                studentData.Columns.Add("email_address", typeof(string));
                studentData.Columns.Add("home_address", typeof(string));
                studentData.Columns.Add("father_name", typeof(string));
                studentData.Columns.Add("father_work", typeof(string));
                studentData.Columns.Add("father_contact", typeof(string));
                studentData.Columns.Add("mother_name", typeof(string));
                studentData.Columns.Add("mother_work", typeof(string));
                studentData.Columns.Add("mother_contact", typeof(string));
                studentData.Columns.Add("class", typeof(int));
                studentData.Columns.Add("password", typeof(string));


                foreach (DataRow r in classData.Rows)
                {
                    query = $"SELECT * FROM StudentTable WHERE class={(int)r["id"]}";
                    studentData.Merge(connection.GetData(query));
                }

                // remove unnessecery columns
                studentData.Columns.Remove("password");
                studentData.Columns.Remove("class");
                studentData.Columns.Remove("home_address");
                studentData.Columns.Remove("father_work");
                studentData.Columns.Remove("mother_work");

                students_table.DataSource = studentData;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void students_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _editKey = Convert.ToInt32(students_table.SelectedRows[0].Cells[0].Value.ToString());
            show_profile_btn.Visible = true;
        }

        private void show_profile_btn_Click(object sender, EventArgs e)
        {
            StudentDetailsModal studentDetailsModal = new StudentDetailsModal(_editKey);
            studentDetailsModal.FormClosed += studentDetailsModal_Close;
            studentDetailsModal.ShowDialog();
        }

        private void studentDetailsModal_Close(object sender, FormClosedEventArgs e) 
        {
            _loadStudents();
            show_profile_btn.Visible = false;
            _editKey = 0;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            TeacherDashboardScreen dashboardScreen = new TeacherDashboardScreen(_teacher_id);
            dashboardScreen.Show();
            this.Close();
        }

        private void assignment_label_Click(object sender, EventArgs e)
        {
            TeacherAssignmentScreen assignmentScreen = new TeacherAssignmentScreen(_teacher_id);
            assignmentScreen.Show();
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
