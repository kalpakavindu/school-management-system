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
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            if(student_name_in.Text == "" || student_gender_in.Text == "" || student_home_in.Text == "" || student_mail_in.Text == "" || student_contact_in.Text == "" || student_dob_in.Text == "" || student_father_contact_in.Text == "" || student_father_name_in.Text == ""|| student_father_work_in.Text == "" || student_mother_contact_in.Text ==""|| student_mother_name_in.Text == ""|| student_mother_work_in.Text == "" || student_class_in.Text == "")
            {
                MessageBox.Show("You missed some important credentials. Please fillout all the feilds to proceed.");
            }
            else
            {
                try
                {
                    string student_name = student_name_in.Text;
                    string gender = student_gender_in.Text;
                    string birthday = student_dob_in.Text;
                    string contact_no = student_contact_in.Text;
                    string email = student_mail_in.Text;
                    string father_name = student_father_name_in.Text;
                    string father_work = student_father_work_in.Text;
                    string father_contact = student_father_contact_in.Text;
                    string mother_name = student_mother_name_in.Text;
                    string mother_work = student_mother_work_in.Text;
                    string mother_contact = student_mother_contact_in.Text;
                    string student_class = student_class_in.Text;
                    string home_address = student_home_in.Text;

                    string get_class_query = "SELECT id FROM ClassTable WHERE name='{class}'";
                    get_class_query = string.Format(get_class_query, student_class);
                    DataTable class_id_table = connection.GetData(get_class_query);
                    int class_id = (int)class_id_table.Rows[0]["id"];

                    string save_student_query = "INSERT INTO StudentTable values('{name}','{gender}','{dob}','{contact}','{mail}','{home}','{fname}','{fwork}','{fcontact}','{mname}','{mwork}','{mcontact}','{class}')";
                    save_student_query = string.Format(save_student_query, student_name, gender, birthday, contact_no, email, home_address, father_name, father_work, father_contact, mother_name, mother_work, mother_contact, class_id.ToString());

                    connection.SetData(save_student_query);
                    MessageBox.Show("New student has been saved successfully. Now the student can signup to add new password");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
