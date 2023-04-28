using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Modals
{
    public partial class EditStudentModal : Form
    {
        Functions connection;
        private int _editKey;

        public EditStudentModal(int key)
        {
            InitializeComponent();
            connection = new Functions();
            _editKey = key;
            _loadClasses();
            _loadCurrentStudent();
        }

        private void _loadClasses()
        {
            string query = "SELECT name FROM ClassTable";
            DataTable classData = connection.GetData(query);
            for (int i = 0; i < classData.Rows.Count; i++)
            {
                class_in.Items.Insert(i, classData.Rows[i]["name"]);
            }
        }

        private void _loadCurrentStudent()
        {
            try 
            {
                string query = "SELECT * FROM StudentTable WHERE id={0}";
                query = string.Format(query, _editKey);
                DataTable studentData = connection.GetData(query);

                name_in.Text = (string)studentData.Rows[0]["name"];
                gender_in.SelectedItem = (string)studentData.Rows[0]["gender"];
                
                // convert date into DateTime and set it to dob_in.Value
                string dob = (string)studentData.Rows[0]["dob"];
                dob_in.Value = DateTime.ParseExact(dob, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                mail_in.Text = (string)studentData.Rows[0]["email_address"];
                contact_in.Text = (string)studentData.Rows[0]["contact_number"];
                home_in.Text = (string)studentData.Rows[0]["home_address"];
                father_name_in.Text = (string)studentData.Rows[0]["father_name"];
                father_work_in.Text = (string)studentData.Rows[0]["father_work"];
                father_contact_in.Text = (string)studentData.Rows[0]["father_contact"];
                mother_name_in.Text = (string)studentData.Rows[0]["mother_name"];
                mother_work_in.Text = (string)studentData.Rows[0]["mother_work"];
                mother_contact_in.Text = (string)studentData.Rows[0]["mother_contact"];

                // get class name from class id and set it into class_in.SelectedItem
                int classId = (int)studentData.Rows[0]["class"];
                query = "SELECT name FROM ClassTable WHERE id={0}";
                query = string.Format(query, classId.ToString());
                DataTable classNameData = connection.GetData(query);
                class_in.SelectedItem = (string)classNameData.Rows[0]["name"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (name_in.Text == "" || gender_in.Text == "" || dob_in.Text == "" || contact_in.Text == "" || mail_in.Text == "" || home_in.Text == "" || father_name_in.Text == "" || father_work_in.Text == "" || father_contact_in.Text == "" || mother_name_in.Text == "" || mother_work_in.Text == "" || mother_contact_in.Text == "" || class_in.Text == "")
            {
                MessageBox.Show("You've missed some important credentials. Please fillout all the feilds in the form.", "Error - Missing Credentials", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string get_class_query = "SELECT id FROM ClassTable WHERE name='{0}'";
                    get_class_query = string.Format(get_class_query, class_in.Text);
                    DataTable classData = connection.GetData(get_class_query);
                    int classId = (int)classData.Rows[0]["id"];

                    dob_in.Format = DateTimePickerFormat.Custom;
                    dob_in.CustomFormat = "dd/MM/yyyy";
                    string birthday = dob_in.Value.Date.ToString("dd/MM/yyyy");

                    string save_student_query = "UPDATE StudentTable SET name='{0}',gender='{1}',dob='{2}',contact_number='{3}',email_address='{4}',home_address='{5}',father_name='{6}',father_work='{7}',father_contact='{8}',mother_name='{9}',mother_work='{10}',mother_contact='{11}',class={12} WHERE id={13}";
                    save_student_query = string.Format(save_student_query, name_in.Text, gender_in.Text, birthday, contact_in.Text, mail_in.Text, home_in.Text, father_name_in.Text, father_work_in.Text, father_contact_in.Text, mother_name_in.Text, mother_work_in.Text, mother_contact_in.Text, classId.ToString(),_editKey);
                    connection.SetData(save_student_query);
                    if (MessageBox.Show("Student details has been successfully updated.", "Success - Details updated successfully", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                string query = "DELETE FROM StudentTable WHERE id={0}";
                query = string.Format(query, _editKey);
                connection.SetData(query);
                if(MessageBox.Show("Student deleted sucessfully","Success - Datails deleted successfully",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }
    }
}
