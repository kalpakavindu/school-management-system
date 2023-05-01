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
    public partial class TeacherDashboardPanel : Form
    {
        Functions connection;
        private int _teacher_id;

        public TeacherDashboardPanel(int id)
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

        private void profile_btn_Click(object sender, EventArgs e)
        {
            TeacherDetailsModal detailsModal = new TeacherDetailsModal(_teacher_id);
            detailsModal.ShowDialog();
        }
    }
}
