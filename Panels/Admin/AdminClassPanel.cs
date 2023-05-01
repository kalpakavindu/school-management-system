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
    public partial class AdminClassPanel : Form
    {
        Functions connection;
        private int _keyToEdit = 0;

        public AdminClassPanel()
        {
            InitializeComponent();
            connection = new Functions();

            // set values to comboboxes in this form
            _setTeachersDropdownItems();

            // load all class data
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
            string query_to_get_teacher = "SELECT * FROM TeacherTable";
            DataTable teacherData = connection.GetData(query_to_get_teacher);
            DataTable classData = connection.GetData(query);

            // add ne column to teacher name
            classData.Columns.Add("teacher", typeof(string));
            
            // assign teacher name to the new column
            for(int i = 0; i < classData.Rows.Count;i++)
            {
                foreach (DataRow r in teacherData.Rows)
                {
                    if (r["id"].Equals(classData.Rows[i]["class_teacher"]))
                    {
                        classData.Rows[i]["teacher"] = r["name"];
                    }
                }
            }
            // remove unnecessery columns
            classData.Columns.Remove("class_teacher");

            // set datasource to classData
            class_table.DataSource = classData;
        }

        private void _clearEntries()
        {
            class_name_in.Text = "";
            class_details_in.Text = "";
            class_teacher_in.Text = "";
            _keyToEdit = 0;
        }

        private int _getTeacherId(string name)
        {
            string get_class_techer_id_query = "SELECT id FROM TeacherTable WHERE name='{0}'";
            get_class_techer_id_query = string.Format(get_class_techer_id_query, name);
            DataTable teacher_id_table = connection.GetData(get_class_techer_id_query);
            return (int)teacher_id_table.Rows[0]["id"];
        }

        private void add_class_btn_Click(object sender, EventArgs e)
        {
            if(class_name_in.Text == "" || class_teacher_in.Text == "" || class_details_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.", "Error - Missing Information", MessageBoxButtons.OK);
            }
            else
            {
                try {
                    string class_name = class_name_in.Text;
                    string class_teacher_name = class_teacher_in.Text;
                    string class_details = class_details_in.Text;
                    int teacher_id = _getTeacherId(class_teacher_name);

                    string add_class_query = "INSERT INTO ClassTable values('{0}',{1},'{2}')";
                    add_class_query = string.Format(add_class_query, class_name, teacher_id, class_details);
                    connection.SetData(add_class_query);
                    _loadClasses();
                    _clearEntries();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void class_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // set data to class data entries
            class_name_in.Text = class_table.SelectedRows[0].Cells[1].Value.ToString();
            class_teacher_in.SelectedItem = class_table.SelectedRows[0].Cells[3].Value;
            class_details_in.Text = class_table.SelectedRows[0].Cells[2].Value.ToString();

            if(class_name_in.Text == "")
            {
                _keyToEdit = 0;
            }
            else
            {
                _keyToEdit = Convert.ToInt32(class_table.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void upd_class_btn_Click(object sender, EventArgs e)
        {
            if (class_name_in.Text == "" || class_teacher_in.Text == "" || class_details_in.Text == "")
            {
                MessageBox.Show("You've missed some informations. Please fillout all the feilds in the form.", "Error - Missing Information", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string class_name = class_name_in.Text;
                    string class_teacher_name = class_teacher_in.Text;
                    string class_details = class_details_in.Text;
                    int teacher_id = _getTeacherId(class_teacher_name);

                    string upd_class_query = "UPDATE ClassTable SET name='{0}',class_teacher={1},details='{2}' WHERE id={3}";
                    upd_class_query = string.Format(upd_class_query, class_name, teacher_id, class_details,_keyToEdit);
                    connection.SetData(upd_class_query);
                    _loadClasses();
                    _clearEntries();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void del_class_btn_Click(object sender, EventArgs e)
        {
            if (_keyToEdit == 0)
            {
                MessageBox.Show("Select a Class first.", "Select a class", MessageBoxButtons.OK);
            }   
            else
            {
                try
                {
                    string subject_name = class_name_in.Text;

                    string save_subject_query = "DELETE FROM ClassTable WHERE id={0}";
                    save_subject_query = string.Format(save_subject_query, _keyToEdit);
                    connection.SetData(save_subject_query);
                    _loadClasses();
                    _clearEntries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }
    }
}
