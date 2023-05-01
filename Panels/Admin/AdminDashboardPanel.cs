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
    public partial class AdminDashboardPanel : Form
    {
        Functions connection;
        public AdminDashboardPanel()
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
    }
}
