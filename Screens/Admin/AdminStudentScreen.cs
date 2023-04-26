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
    }
}
