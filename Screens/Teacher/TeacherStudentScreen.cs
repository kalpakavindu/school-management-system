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

        public TeacherStudentScreen()
        {
            InitializeComponent();
            connection = new Functions();
            show_profile_btn.Visible = false;
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
            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                foreach (DataRow r in classData.Rows)
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
    }
}
