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
    public partial class AdminTeacherScreen : Form
    {
        Functions connection;
        public AdminTeacherScreen()
        { 
            InitializeComponent();
            connection = new Functions();
            _loadTeachers();
        }

        private void _loadTeachers()
        {
            string query = "SELECT * FROM TeacherTable";
            teachers_table.DataSource = connection.GetData(query);
        }

        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            Modals.AddTeacherModal addTeacherModal = new Modals.AddTeacherModal();
            addTeacherModal.FormClosed += addTeacherModal_Closed;
            addTeacherModal.ShowDialog();
        }

        private void addTeacherModal_Closed(object sender, FormClosedEventArgs e)
        {
            _loadTeachers();
        }
    }
}
