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

namespace school_management_system
{
    public partial class StudentDetailsModal : Form
    {
        Functions connection;
        private int _editKey;

        public StudentDetailsModal(int key)
        {
            InitializeComponent();
            connection = new Functions();
            _editKey = key;
            _loadCurrentStudentData();
        }

        private void _loadCurrentStudentData()
        {
            try
            {
                string query = "SELECT * FROM StudentTable WHERE id={0}";
                query = string.Format(query, _editKey);
                DataTable studentData = connection.GetData(query);

                name.Text = (string)studentData.Rows[0]["name"];
                gender.Text = (string)studentData.Rows[0]["gender"];
                dob.Text = (string)studentData.Rows[0]["dob"];
                mail.Text = (string)studentData.Rows[0]["email_address"];
                contact.Text = (string)studentData.Rows[0]["contact_number"];
                home.Text = (string)studentData.Rows[0]["home_address"];
                father_name.Text = (string)studentData.Rows[0]["father_name"];
                father_work.Text = (string)studentData.Rows[0]["father_work"];
                father_contact.Text = (string)studentData.Rows[0]["father_contact"];
                mother_name.Text = (string)studentData.Rows[0]["mother_name"];
                mother_work.Text = (string)studentData.Rows[0]["mother_work"];
                mother_contact.Text = (string)studentData.Rows[0]["mother_contact"];

                // get class name from class id and set it into class_name.Text
                int classId = (int)studentData.Rows[0]["class"];
                query = "SELECT name FROM ClassTable WHERE id={0}";
                query = string.Format(query, classId.ToString());
                DataTable classNameData = connection.GetData(query);
                class_name.Text = (string)classNameData.Rows[0]["name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK);
            }
        }
    }
}
