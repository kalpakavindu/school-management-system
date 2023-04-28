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
    public partial class StudentAssignmentScreen : Form
    {
        Functions connection;
        private int _st_id;
        private int _keyToEdit;

        public StudentAssignmentScreen(int id)
        {
            InitializeComponent();
            connection = new Functions();
            _st_id = id;
            _keyToEdit = 0;
            _loadAssignments();
        }

        private void _loadAssignments()
        {
            try
            {
                string query = $"SELECT * FROM StudentTable WHERE id={_st_id}";
                DataTable studentData = connection.GetData(query);

                query = $"SELECT * FROM ClassTable WHERE id={(int)studentData.Rows[0]["class"]}";
                DataTable classTeacherData = connection.GetData(query);

                query = $"SELECT * FROM AssignmentTable WHERE teacher_id={(int)classTeacherData.Rows[0]["class_teacher"]}";
                DataTable assignmentData = connection.GetData(query);
                DataTable assignmentClone = assignmentData.Copy();

                // new datatable to completed assignments
                DataTable completedAssignments = new DataTable();
                completedAssignments.Columns.Add("id", typeof(int));
                completedAssignments.Columns.Add("teacher_id", typeof(int));
                completedAssignments.Columns.Add("title", typeof(string));
                completedAssignments.Columns.Add("description", typeof(string));

                // get all answers submitted by this student
                query = $"SELECT * FROM AnswerTable WHERE student_id={_st_id}";
                DataTable answerData = connection.GetData(query);

                foreach (DataRow r in assignmentData.Rows)
                {
                    foreach(DataRow r2 in answerData.Rows)
                    {
                        if (r2["assignment_id"].Equals(r["id"]))
                        {
                            completedAssignments.ImportRow(r);
                            DataRow[] rowsToRemove = assignmentClone.Select($"id={r["id"]}");
                            assignmentClone.Rows.Remove(rowsToRemove[0]);
                        }
                    }
                }

                assignmentClone.Columns.Remove("teacher_id");
                assignments_table.DataSource = assignmentClone;
                completedAssignments.Columns.Remove("teacher_id");
                completed_assignments_table.DataSource = completedAssignments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            StudentDashboardScreen dashboardScreen = new StudentDashboardScreen(_st_id);
            dashboardScreen.Show();
            this.Close();
        }

        private void send_ans_btn_Click(object sender, EventArgs e)
        {
            if(_keyToEdit == 0)
            {
                MessageBox.Show("Select an assignment first.", "Error", MessageBoxButtons.OK);
            }
            else if(ans_in.Text == "")
            {
                MessageBox.Show("Enter your answer first.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try 
                {
                    string query = $"INSERT INTO AnswerTable VALUES({_keyToEdit},{_st_id},null,'{ans_in.Text}')";
                    connection.SetData(query);
                    MessageBox.Show("Your answer has been successfully submitted", "Success", MessageBoxButtons.OK);
                    _loadAssignments();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void assignments_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            title.Text = assignments_table.SelectedRows[0].Cells[1].Value.ToString();
            desc.Text = assignments_table.SelectedRows[0].Cells[2].Value.ToString();
            _keyToEdit = Convert.ToInt32(assignments_table.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
