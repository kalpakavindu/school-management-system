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
    public partial class AdminClassScreen : Form
    {
        Functions connection;

        public AdminClassScreen()
        {
            InitializeComponent();
            connection = new Functions();
            _setTeachersDropdownItems();
            _loadClasses();
        }

        private void _setTeachersDropdownItems()
        {
            string query = "SELECT name FROM TeacherTable";
            DataTable teacherData = connection.GetData(query);
            for(int i = 0; i < teacherData.Rows.Count; i++)
            {
                class_teacher_in.Items.Insert(i, teacherData.Rows[i]["name"]);
            }
        }

        private void _loadClasses()
        {
            string query = "SELECT * FROM ClassTable";
            class_table.DataSource = connection.GetData(query);
        }

        private void add_class_btn_Click(object sender, EventArgs e)
        {
            if(class_name_in.Text == "" || class_teacher_in.Text == "" || class_details_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.", "Error - Missing Information", MessageBoxButtons.OK);
            }
            else
            {
                string class_name = class_name_in.Text;
                string class_teacher_name = class_teacher_in.Text;
                string class_details = class_details_in.Text;

                string get_class_techer_id_query = "SELECT id FROM TeacherTable WHERE name='{0}'";
                get_class_techer_id_query = string.Format(get_class_techer_id_query, class_teacher_name);
                DataTable teacher_id_table = connection.GetData(get_class_techer_id_query);
                int teacher_id = (int)teacher_id_table.Rows[0]["id"];

                string add_class_query = "INSERT INTO ClassTable values('{0}',{1},'{2}')";
                add_class_query = string.Format(add_class_query, class_name, teacher_id, class_details);
                connection.SetData(add_class_query);
                MessageBox.Show("New class has been successfully created.","Success - Details saved successfully",MessageBoxButtons.OK);
                _loadClasses();
            }
        }
    }
}
