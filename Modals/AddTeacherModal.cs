using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Modals
{
    public partial class AddTeacherModal : Form
    {
        Functions connection;
        public AddTeacherModal()
        {
            InitializeComponent();
            connection = new Functions();
            _setSubjectDropdownItems();
        }

        private void _setSubjectDropdownItems()
        {
            string query = "SELECT name FROM SubjectTable";
            DataTable subData = connection.GetData(query);
            for(int i =0;i<subData.Rows.Count;i++)
            {
                subject_in.Items.Insert(i, subData.Rows[i]["name"]);
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if(name_in.Text == "" || gender_in.Text=="" || dob_in.Text=="" || contact_in.Text=="" || mail_in.Text==""||home_in.Text==""||degree_in.Text == "" || university_in.Text == "" || subject_in.Text == "")
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

                    string save_teacher_query = "INSERT INTO TeacherTable values('{0}','{1}','{2}','{3}','{4}','{5}',null,'{6}','{7}',{8},DEFAULT)";
                    save_teacher_query = string.Format(save_teacher_query, name_in.Text, gender_in.Text, birthday, contact_in.Text, mail_in.Text, home_in.Text, degree_in.Text, university_in.Text, subjectId.ToString());
                    connection.SetData(save_teacher_query);

                    if (MessageBox.Show("New Teacher details has been saved successfully. Now the teacher can SignUp to add new password.", "Success - Details saved Successfully", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
                }
            }
        }
    }
}
