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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace school_management_system
{
    public partial class TeacherDetailsModal : Form
    {
        Functions connection;
        private int _editKey;

        public TeacherDetailsModal(int key)
        {
            InitializeComponent();
            connection = new Functions();
            _editKey = key;
            _loadCurrentTeacher();
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

                name.Text = (string)teacherData.Rows[0]["name"];
                gender.Text = (string)teacherData.Rows[0]["gender"];
                dob.Text = (string)teacherData.Rows[0]["dob"];
                mail.Text = (string)teacherData.Rows[0]["email_address"];
                contact.Text = (string)teacherData.Rows[0]["contact_number"];
                home.Text = (string)teacherData.Rows[0]["home_address"];
                degree.Text = (string)teacherData.Rows[0]["degree"];
                university.Text = (string)teacherData.Rows[0]["university"];
                status.Text = convertTeacherStatus((string)teacherData.Rows[0]["status"]);

                // get subject name from subject id and set it to subject.Text
                int subjectId = (int)teacherData.Rows[0]["subject"];
                query = "SELECT name FROM SubjectTable WHERE id={0}";
                query = string.Format(query, subjectId.ToString());
                DataTable subjectNameData = connection.GetData(query);
                subject.Text = (string)subjectNameData.Rows[0]["name"];

                // get class names from teacher_id and set them to classes_list.Text
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
                    foreach (DataRow r in classData.Rows)
                    {
                        classes_list.Text += string.Format("{0}  ", (string)r["name"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }
    }
}
