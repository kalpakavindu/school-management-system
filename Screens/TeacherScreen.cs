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
    public partial class TeacherScreen : Form
    {
        private int _teacher_id;

        public TeacherScreen(int id)
        {
            InitializeComponent();
            _teacher_id = id;
            TeacherDashboardPanel dashboardPanel = new TeacherDashboardPanel(_teacher_id);
            dashboardPanel.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            TeacherDashboardPanel dashboardPanel = new TeacherDashboardPanel(_teacher_id);
            dashboardPanel.TopLevel = false;

            dashboard.BackColor = Color.Azure;
            students.BackColor = Color.CadetBlue;
            assignments.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void students_lable_Click(object sender, EventArgs e)
        {
            TeacherStudentPanel studentPanel = new TeacherStudentPanel(_teacher_id);
            studentPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.Azure;
            assignments.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(studentPanel);
            studentPanel.Visible = true;
        }

        private void assignments_label_Click(object sender, EventArgs e)
        {
            TeacherAssignmentPanel assignmentPanel = new TeacherAssignmentPanel(_teacher_id);
            assignmentPanel.TopLevel = false;

            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            assignments.BackColor = Color.Azure;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(assignmentPanel);
            assignmentPanel.Visible = true;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
