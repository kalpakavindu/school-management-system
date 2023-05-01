using school_management_system.Screens.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Screens
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            AdminDashboardPanel dashboardPanel = new AdminDashboardPanel();
            dashboardPanel.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            AdminDashboardPanel dashboardPanel = new AdminDashboardPanel();
            dashboardPanel.TopLevel = false;

            dashboard.BackColor = Color.Azure;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void student_label_Click(object sender, EventArgs e)
        {
            AdminStudentPanel studentPanel = new AdminStudentPanel();
            studentPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.Azure;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(studentPanel);
            studentPanel.Visible = true;
        }

        private void teacher_label_Click(object sender, EventArgs e)
        {
            AdminTeacherPanel teacherPanel = new AdminTeacherPanel();
            teacherPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.Azure;
            classes.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(teacherPanel);
            teacherPanel.Visible = true;
        }

        private void classes_label_Click(object sender, EventArgs e)
        {
            AdminClassPanel classPanel = new AdminClassPanel();
            classPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.Azure;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(classPanel);
            classPanel.Visible = true;
        }

        private void subject_label_Click(object sender, EventArgs e)
        {
            AdminSubjectPanel subjectPanel = new AdminSubjectPanel();
            subjectPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.Azure;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(subjectPanel);
            subjectPanel.Visible = true;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
