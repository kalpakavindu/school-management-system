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
        TeacherDashboardPanel dashboardPanel;
        TeacherStudentPanel studentPanel;
        TeacherAssignmentPanel assignmentPanel;

        public TeacherScreen(int id)
        {
            InitializeComponent();
            dashboardPanel = new TeacherDashboardPanel(id);
            studentPanel = new TeacherStudentPanel(id);
            assignmentPanel = new TeacherAssignmentPanel(id);
            dashboardPanel.TopLevel = false;
            studentPanel.TopLevel = false;
            assignmentPanel.TopLevel = false;

            main_panel.Controls.Add(dashboardPanel);
            main_panel.Controls.Add(assignmentPanel);
            main_panel.Controls.Add(studentPanel);

            assignmentPanel.Visible = false;
            studentPanel.Visible = false;
            dashboardPanel.Visible = true;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.Azure;
            students.BackColor = Color.CadetBlue;
            assignments.BackColor = Color.CadetBlue;
            assignmentPanel.Visible = false;
            studentPanel.Visible = false;
            dashboardPanel.Visible = true;
        }

        private void students_lable_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.Azure;
            assignments.BackColor = Color.CadetBlue;
            assignmentPanel.Visible = false;
            studentPanel.Visible = true;
            dashboardPanel.Visible = false;
        }

        private void assignments_label_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.CadetBlue;
            students.BackColor = Color.CadetBlue;
            assignments.BackColor = Color.Azure;
            assignmentPanel.Visible = true;
            studentPanel.Visible = false;
            dashboardPanel.Visible = false;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
