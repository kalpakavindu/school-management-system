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
    public partial class EditTeacherModal : Form
    {
        Functions connection;
        private int _editKey;

        public EditTeacherModal(int key)
        {
            InitializeComponent();
            connection = new Functions();
            _editKey = key;
            _loadDropdowns();
            _loadCurrentTeacher();
        }

        private void _loadDropdowns()
        {
            string query = "SELECT name FROM SubjectTable";
            DataTable subjectData = connection.GetData(query);
            for(int j = 0; j<subjectData.Rows.Count; j++)
            {
                subject_in.Items.Insert(j, subjectData.Rows[j]["name"]);
            }
        }

        private string convertTeacherStatus(string constant)
        {
            switch (constant)
            {
                case "REGISTERED":
                    return "Registered";
                case "Registered":
                    return "REGISTERED";
                case "PANTIONED":
                    return "Pantioned";
                case "Pantioned":
                    return "PANTIONED";
                case "SUPENDED":
                    return "Suspended";
                case "Suspended":
                    return "SUSPENDED";
                case "Pending":
                    return "PENDING";
                default:
                    return "Pending";
            }
        }

        private void _loadCurrentTeacher()
        {
            try
            {
                string query = "SELECT * FROM TeacherTable WHERE id={0}";
                query = string.Format(query, _editKey);
                DataTable teacherData = connection.GetData(query);

                name_in.Text = (string)teacherData.Rows[0]["name"];
                gender_in.SelectedItem = (string)teacherData.Rows[0]["gender"];

                string dob = (string)teacherData.Rows[0]["dob"];
                dob_in.Value = DateTime.ParseExact(dob, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                mail_in.Text = (string)teacherData.Rows[0]["email_address"];
                contact_in.Text = (string)teacherData.Rows[0]["contact_number"];
                home_in.Text = (string)teacherData.Rows[0]["home_address"];
                degree_in.Text = (string)teacherData.Rows[0]["degree"];
                university_in.Text = (string)teacherData.Rows[0]["university"];

                int subjectId = (int)teacherData.Rows[0]["subject"];
                query = "SELECT name FROM SubjectTable WHERE id={0}";
                query = string.Format(query, subjectId.ToString());
                DataTable subjectNameData = connection.GetData(query);

                subject_in.SelectedItem = (string)subjectNameData.Rows[0]["name"];

                query = "SELECT name FROM ClassTable WHERE class_teacher={0}";
                int teacherId = (int)teacherData.Rows[0]["id"];
                query = string.Format(query, teacherId.ToString());
                DataTable classData = connection.GetData(query);

                if (classData.Rows.Count == 0)
                {
                    classes_list.Text = "Unassigned";
                }
                else
                {
                    foreach(DataRow r in classData.Rows)
                    {
                        classes_list.Text += string.Format("{0}  ",(string)r["name"]);
                    }
                }

                status_in.SelectedItem = convertTeacherStatus((string)teacherData.Rows[0]["status"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }


        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (name_in.Text == "" || gender_in.Text == "" || dob_in.Text == "" || contact_in.Text == "" || mail_in.Text == "" || home_in.Text == "" || degree_in.Text == "" || university_in.Text == "" || subject_in.Text == "")
            {
                MessageBox.Show("You've missed some important credentials. Please fillout all the feilds in the form.", "Error - Missing Credentials", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string get_subject_query = "SELECT id FROM SubjectTable WHERE name='{0}'";
                    get_subject_query = string.Format(get_subject_query, subject_in.Text);
                    DataTable subData = connection.GetData(get_subject_query);
                    int subjectId = (int)subData.Rows[0]["id"];

                    dob_in.Format = DateTimePickerFormat.Custom;
                    dob_in.CustomFormat = "dd/MM/yyyy";
                    string birthday = dob_in.Value.Date.ToString("dd/MM/yyyy");

                    string status = convertTeacherStatus(status_in.Text);

                    string save_teacher_query = "UPDATE TeacherTable SET name='{0}',gender='{1}',dob='{2}',contact_number='{3}',email_address='{4}',home_address='{5}',degree='{6}',university='{7}',subject={8},status='{9}' WHERE id={10}";
                    save_teacher_query = string.Format(save_teacher_query, name_in.Text, gender_in.Text, birthday, contact_in.Text, mail_in.Text, home_in.Text, degree_in.Text, university_in.Text, subjectId.ToString(),status,_editKey);
                    connection.SetData(save_teacher_query);

                    if (MessageBox.Show("New Teacher details has been updated successfully.", "Success - Details updated Successfully", MessageBoxButtons.OK) == DialogResult.OK)
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
                string query = "DELETE FROM TeacherTable WHERE id={0}";
                query = string.Format(query, _editKey);
                connection.SetData(query);
                if(MessageBox.Show("Teacher Deleted Successfully","Success - Deleted successfully",MessageBoxButtons.OK)== DialogResult.OK)
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
