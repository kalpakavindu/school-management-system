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
    public partial class AdminStudentScreen : Form
    {
        Functions connection;
        public AdminStudentScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _loadStudents();
        }

        private void _loadStudents()
        {
            string query = "SELECT * FROM StudentTable";
            students_table.DataSource = connection.GetData(query);
        }

        private void show_add_student_btn_Click(object sender, EventArgs e)
        {
            Modals.AddStudentModal addStudentModal = new Modals.AddStudentModal();
            addStudentModal.FormClosed += addStudentModal_Closed;
            addStudentModal.ShowDialog();
        }

        private void addStudentModal_Closed(object sender,FormClosedEventArgs e)
        {
            _loadStudents();
        }
    }
}
