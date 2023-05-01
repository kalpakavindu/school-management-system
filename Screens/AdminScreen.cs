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
        AdminDashboardPanel dashboardPanel;
        AdminStudentPanel studentPanel;
        AdminSubjectPanel subjectPanel;
        AdminTeacherPanel teacherPanel;
        AdminClassPanel classPanel;

        public AdminScreen()
        {
            InitializeComponent();

            dashboardPanel = new AdminDashboardPanel();
            studentPanel = new AdminStudentPanel();
            subjectPanel = new AdminSubjectPanel();
            teacherPanel = new AdminTeacherPanel();
            classPanel = new AdminClassPanel();

            dashboardPanel.TopLevel = false;
            studentPanel.TopLevel = false;
            subjectPanel.TopLevel = false;
            teacherPanel.TopLevel = false;
            classPanel.TopLevel = false;

            main_panel.Controls.Add(dashboardPanel);
            main_panel.Controls.Add(studentPanel);
            main_panel.Controls.Add(subjectPanel);
            main_panel.Controls.Add(teacherPanel);
            main_panel.Controls.Add(classPanel);

            dashboardPanel.Visible = true;
            studentPanel.Visible = false;
            subjectPanel.Visible = false;
            teacherPanel.Visible = false;
            classPanel.Visible = false;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.Azure;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            dashboardPanel.Visible = true;
            studentPanel.Visible = false;
            subjectPanel.Visible = false;
            teacherPanel.Visible = false;
            classPanel.Visible = false;
        }

        private void student_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.Azure;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            dashboardPanel.Visible = false;
            studentPanel.Visible = true;
            subjectPanel.Visible = false;
            teacherPanel.Visible = false;
            classPanel.Visible = false;
        }

        private void teacher_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.Azure;
            classes.BackColor = Color.CadetBlue;

            dashboardPanel.Visible = false;
            studentPanel.Visible = false;
            subjectPanel.Visible = false;
            teacherPanel.Visible = true;
            classPanel.Visible = false;
        }

        private void classes_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.CadetBlue;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.Azure;

            dashboardPanel.Visible = false;
            studentPanel.Visible = false;
            subjectPanel.Visible = false;
            teacherPanel.Visible = false;
            classPanel.Visible = true;
        }

        private void subject_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            subjects.BackColor = Color.Azure;
            teachers.BackColor = Color.CadetBlue;
            classes.BackColor = Color.CadetBlue;

            dashboardPanel.Visible = false;
            studentPanel.Visible = false;
            subjectPanel.Visible = true;
            teacherPanel.Visible = false;
            classPanel.Visible = false;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
