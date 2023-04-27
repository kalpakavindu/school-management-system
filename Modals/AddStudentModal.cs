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
    public partial class AddStudentModal : Form
    {
        Functions connection;

        public AddStudentModal()
        {
            InitializeComponent();
            connection = new Functions();
            setClassList();
        }

        private void setClassList()
        {
            string query = "SELECT name FROM ClassTable";
            DataTable classData = connection.GetData(query);
            for (int i = 0; i < classData.Rows.Count; i++)
            {
                class_in.Items.Insert(i, classData.Rows[i]["name"]);
            }
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            if(name_in.Text == "" || gender_in.Text == "" || dob_in.Text == "" || contact_in.Text == "" || mail_in.Text == "" || home_in.Text == "" || father_name_in.Text == "" || father_work_in.Text == "" || father_contact_in.Text == "" || mother_name_in.Text == ""|| mother_work_in.Text == ""||mother_contact_in.Text == "" ||class_in.Text == "")
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

                    string save_student_query = "INSERT INTO StudentTable values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12},null)";
                    save_student_query = string.Format(save_student_query, name_in.Text, gender_in.Text,birthday,contact_in.Text,mail_in.Text,home_in.Text,father_name_in.Text,father_work_in.Text,father_contact_in.Text,mother_name_in.Text,mother_work_in.Text,mother_contact_in.Text,classId.ToString());
                    connection.SetData(save_student_query);
                    if(MessageBox.Show("Student details has been successfully saved. The student now can SignUp to create new password.","Success - Details saved successfully",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }

                }catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
