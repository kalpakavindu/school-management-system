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
    public partial class AssignmentDetailsModal : Form
    {
        Functions connection;
        private int _key,_keyToEdit;

        public AssignmentDetailsModal(int key)
        {
            InitializeComponent();
            connection = new Functions();
            _key = key;
            _keyToEdit = 0;
            _loadData();
        }

        private void pending_res_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ans.Text = pending_res_table.SelectedRows[0].Cells[2].Value.ToString();
            _keyToEdit = Convert.ToInt32(pending_res_table.SelectedRows[0].Cells[0].Value.ToString());
        }
        
        private void res_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ans.Text = res_table.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void grade_btn_Click(object sender, EventArgs e)
        {
            if(_keyToEdit == 0)
            {
                MessageBox.Show("Select pending response first.","Error",MessageBoxButtons.OK);
            }
            else if(grade_in.Text == "")
            {
                MessageBox.Show("Select a grade first!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string query = $"UPDATE AnswerTable SET grade='{grade_in.Text}' WHERE id={_keyToEdit}";
                    connection.SetData(query);
                    _loadData();
                    grade_in.Text = "";
                    ans.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM AnswerTable WHERE assignment_id='{_key}'";
                connection.SetData(query);
                query = $"DELETE FROM AssignmentTable WHERE id={_key}";
                connection.SetData(query);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void _loadData()
        {
            //TODO:ADD try catch
            string query = $"SELECT title FROM AssignmentTable WHERE id={_key}";
            DataTable assignmentData = connection.GetData(query);
            title.Text = (string)assignmentData.Rows[0]["title"];

            query = $"SELECT * FROM AnswerTable WHERE assignment_id={_key}";
            DataTable answerData = connection.GetData(query);
            answerData.Columns.Add("student_name", typeof(string));

            // new DataTable for responded answers
            DataTable respondedAnswerData = new DataTable();
            respondedAnswerData.Columns.Add("id", typeof(int));
            respondedAnswerData.Columns.Add("assignment_id", typeof(int));
            respondedAnswerData.Columns.Add("student_id", typeof(int));
            respondedAnswerData.Columns.Add("grade", typeof(string));
            respondedAnswerData.Columns.Add("answers", typeof(string));
            respondedAnswerData.Columns.Add("student_name", typeof(string));

            // new datatable for pending answers
            DataTable pendingAnswerData = new DataTable();
            pendingAnswerData.Columns.Add("id", typeof(int));
            pendingAnswerData.Columns.Add("assignment_id", typeof(int));
            pendingAnswerData.Columns.Add("student_id", typeof(int));
            pendingAnswerData.Columns.Add("grade", typeof(string));
            pendingAnswerData.Columns.Add("answers", typeof(string));
            pendingAnswerData.Columns.Add("student_name", typeof(string));

            for ( int i = 0; i < answerData.Rows.Count;i++)
            {
            string st_name = _getStudentName((int)answerData.Rows[i]["student_id"]);
                answerData.Rows[i]["student_name"] = st_name;
                if (!answerData.Rows[i].IsNull("grade"))
                {
                    respondedAnswerData.ImportRow(answerData.Rows[i]);
                }
                else
                {
                    pendingAnswerData.ImportRow(answerData.Rows[i]);
                }
            }
            pendingAnswerData.Columns.Remove("assignment_id");
            pendingAnswerData.Columns.Remove("student_id");
            respondedAnswerData.Columns.Remove("student_id");
            respondedAnswerData.Columns.Remove("assignment_id");
            res_table.DataSource = respondedAnswerData;
            pending_res_table.DataSource = pendingAnswerData;
           
        }

        private string _getStudentName(int id)
        {
            string query = $"SELECT name FROM StudentTable WHERE id={id}";
            return (string)connection.GetData(query).Rows[0]["name"];
        }
    }
}
