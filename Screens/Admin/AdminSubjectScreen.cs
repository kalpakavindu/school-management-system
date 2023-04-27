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
    public partial class AdminSubjectScreen : Form
    {
        Functions connection;

        public AdminSubjectScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _loadSubjects();
        }

        private void _loadSubjects()
        {
            string query = "SELECT * FROM SubjectTable";
            subject_table.DataSource = connection.GetData(query);
        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            if(subject_name_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.");
            }
            else
            {
                string subject_name = subject_name_in.Text;

                string save_subject_query = "INSERT INTO SubjectTable values('{0}')";
                save_subject_query = string.Format(save_subject_query, subject_name);
                connection.SetData(save_subject_query);
                MessageBox.Show("New Subject has been saved successfully.");
                _loadSubjects();
                subject_name_in.Text = "";
            }
        }
    }
}
