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
    public partial class TeacherAssignmentScreen : Form
    {
        Functions connection;
        private int _teacher_id;
        private int _keyToEdit;

        public TeacherAssignmentScreen(int id)
        {
            InitializeComponent();
            connection = new Functions();
            _teacher_id = id;
            _keyToEdit = 0;
            _loadAssignments();
        }

        private void _loadAssignments()
        {
            try
            {
                string query = $"SELECT * FROM AssignmentTable WHERE teacher_id={_teacher_id}";
                DataTable assignmentData = connection.GetData(query);
                assignmentData.Columns.Remove("teacher_id");
                assignment_table.DataSource = assignmentData;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void _clearEntries()
        {
            title_in.Text = "";
            desc_in.Text = "";
            _keyToEdit = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(title_in.Text == "" || desc_in.Text == "")
            {
                MessageBox.Show("Fillout all the feilds to proceed.", "Missing data", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO AssignmentTable VALUES({_teacher_id},'{title_in.Text}','{desc_in.Text}')";
                    connection.SetData(query);
                    _loadAssignments();
                    _clearEntries();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if(_keyToEdit == 0)
            {
                MessageBox.Show("Select an assignment first!", "No assignment selected", MessageBoxButtons.OK);
            }
            else
            {
                try 
                {
                    string query = $"UPDATE AssignmentTable SET title='{title_in.Text}',description='{desc_in.Text}' WHERE id={_keyToEdit}";
                    connection.SetData(query);
                    MessageBox.Show("Assignment updated successfully!", "Success", MessageBoxButtons.OK);
                    _loadAssignments();
                    _clearEntries();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void show_details_btn_Click(object sender, EventArgs e)
        {
            if (_keyToEdit == 0)
            {
                MessageBox.Show("Select an assignment first!", "No assignment selected", MessageBoxButtons.OK);
            }
            else
            {
                AssignmentDetailsModal detailsModal = new AssignmentDetailsModal(_keyToEdit);
                detailsModal.FormClosed += detailsModal_Close;
                detailsModal.ShowDialog();
            }
        }

        private void detailsModal_Close(object sender,FormClosedEventArgs e)
        {
            _loadAssignments();
        }

        private void assignment_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            title_in.Text = assignment_table.SelectedRows[0].Cells[1].Value.ToString();
            desc_in.Text = assignment_table.SelectedRows[0].Cells[2].Value.ToString();
            _keyToEdit = Convert.ToInt32(assignment_table.SelectedRows[0].Cells[0].Value.ToString());
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

        private void students_label_Click(object sender, EventArgs e)
        {
            TeacherStudentScreen studentScreen = new TeacherStudentScreen(_teacher_id);
            studentScreen.Show();
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
