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
    public partial class AdminStudentPanel : Form
    {
        Functions connection;
        private int _key;

        public AdminStudentPanel()
        {
            InitializeComponent();
            connection = new Functions();
            upd_student_btn.Visible = false;
            _loadStudents();
        }

        private void _loadStudents()
        {
            // get all data from StudentTable
            string query = "SELECT * FROM StudentTable";
            DataTable studentData = connection.GetData(query);

            // get all data from ClassTable
            query = "SELECT * FROM ClassTable";
            DataTable classData = connection.GetData(query);

            // Add new column to assign class names
            studentData.Columns.Add("class_name", typeof(string));

            // assign class names into new column
            for(int i = 0; i< studentData.Rows.Count; i++)
            {
                foreach(DataRow r in classData.Rows)
                {
                    if (r["id"].Equals(studentData.Rows[i]["class"]))
                    {
                        studentData.Rows[i]["class_name"] = r["name"];
                    }
                }
            }

            //remove unnecessary columns
            studentData.Columns.Remove("class");
            studentData.Columns.Remove("password");

            // set datasource to studentData
            students_table.DataSource = studentData;
        }

        private void show_add_student_btn_Click(object sender, EventArgs e)
        {
            // show the AddStudentModal as a dialog from this form
            Modals.AddStudentModal addStudentModal = new Modals.AddStudentModal();
            addStudentModal.FormClosed += addStudentModal_Closed;
            addStudentModal.ShowDialog();
        }

        private void upd_student_btn_Click(object sender, EventArgs e)
        {
            if (_key == 0)
            {
                MessageBox.Show("Select a student first.", "Select a student", MessageBoxButtons.OK);
            }
            else
            {
                // Show the EditStudentModal as a dialog from this form and pass the selected student id as key
                Modals.EditStudentModal editStudentModal = new Modals.EditStudentModal(_key);
                editStudentModal.FormClosed += editStudentModal_Closed;
                editStudentModal.ShowDialog();
            }
        }

        private void students_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _key = Convert.ToInt32(students_table.SelectedRows[0].Cells[0].Value.ToString());
            upd_student_btn.Visible = true;
        }

        private void addStudentModal_Closed(object sender, FormClosedEventArgs e)
        {
            upd_student_btn.Visible = false;
            _key = 0;
            _loadStudents();
        }
        
        private void editStudentModal_Closed(object sender, FormClosedEventArgs e)
        {
            upd_student_btn.Visible = false;
            _key = 0;
            _loadStudents();
        }
    }
}
