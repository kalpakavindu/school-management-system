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

        public StudentAssignmentScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _loadAssignments();
        }

        private void _loadAssignments()
        {
            try
            {
                string query = "SELECT * FROM AssignmentTable";
                DataTable assignementData = connection.GetData(query);
                assignementData.Columns.Add("teacher", typeof(string));

                // new datatable to completed assignments
                DataTable completedAssignments = new DataTable();
                completedAssignments.Columns.Add("id", typeof(int));
                completedAssignments.Columns.Add("teacher_id", typeof(int));
                completedAssignments.Columns.Add("assignment_file", typeof(string));
                completedAssignments.Columns.Add("title", typeof(string));
                completedAssignments.Columns.Add("description", typeof(string));
                completedAssignments.Columns.Add("teacher",typeof(string));

                foreach (DataRow r in assignementData.Rows)
                {
                    r["teacher"] = _getTeacherName((int)r["teacher_id"]);
                    try
                    {
                        query = "SELECT * FROM AnswerTable WHERE assignment_id={0}";
                        query = string.Format(query, r["id"].ToString());
                        DataTable answerData = connection.GetData(query);
                        if (answerData.Rows.Count != 0)
                        {
                            assignementData.Rows.Remove(r);
                            completedAssignments.Rows.Add(r);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                    }
                }

                assignementData.Columns.Remove("teacher_id");
                assignments_table.DataSource = assignementData;
                completedAssignments.Columns.Remove("teacher_id");
                completed_assignments_table.DataSource = completedAssignments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private string _getTeacherName(int teacher_id)
        {
            try
            {
                string query = "SELECT name FROM TeacherTable WHERE id={0}";
                query = string.Format(query, teacher_id);
                DataTable teacherData = connection.GetData(query);

                return (string)teacherData.Rows[0]["name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
