using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Screens.Student
{
    public partial class StudentDashboardScreen : Form
    {
        Functions connection;
        private int _st_id;

        public StudentDashboardScreen(int id)
        {
            InitializeComponent();
            connection = new Functions();
            _st_id = id;
            _loadData();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assignment_label_Click(object sender, EventArgs e)
        {
            StudentAssignmentScreen assignmentScreen = new StudentAssignmentScreen(_st_id);
            assignmentScreen.Show();
            this.Close();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            StudentDetailsModal detailsModal = new StudentDetailsModal(_st_id);
            detailsModal.ShowDialog();
        }

        private void _loadData()
        {
            try
            {
                string query = $"SELECT * FROM StudentTable WHERE id={_st_id}";
                DataTable studentData = connection.GetData(query);

                query = $"SELECT * FROM AnswerTable WHERE student_id={_st_id}";
                DataTable allAnswerData = connection.GetData(query);

                int totalAs = 0;

                // new datatable to show graded assignments
                DataTable grades = new DataTable();
                grades.Columns.Add("id", typeof(int));
                grades.Columns.Add("grade", typeof(string));
                grades.Columns.Add("assignment_title", typeof(string));

                foreach (DataRow r in allAnswerData.Rows)
                {
                    if (!r.IsNull("grade") && (string)r["grade"] == "A")
                    {
                        totalAs++;
                    }

                    if (!r.IsNull("grade"))
                    {
                        DataRow r2 = grades.NewRow();
                        r2["id"] = (int)r["id"];
                        r2["grade"] = (string)r["grade"];

                        query = $"SELECT title FROM AssignmentTable WHERE id={(int)r["assignment_id"]}";
                        r2["assignment_title"] = (string)connection.GetData(query).Rows[0]["title"];

                        grades.Rows.Add(r2);
                    }
                }

                total_a.Text = totalAs.ToString();
                total_assignments.Text = allAnswerData.Rows.Count.ToString();
                grades_table.DataSource = grades;
                name_label.Text = (string)studentData.Rows[0]["name"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Somthing went wrong", MessageBoxButtons.OK);
            }
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
