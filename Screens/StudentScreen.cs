using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.Screens.Student
{
    public partial class StudentScreen : Form
    {
        StudentDashboardPanel dashboardScreen;
        StudentAssignmentsPanel assignmentScreen;

        public StudentScreen(int id)
        {
            InitializeComponent();
            dashboardScreen = new StudentDashboardPanel(id);
            assignmentScreen = new StudentAssignmentsPanel(id);
            dashboardScreen.TopLevel = false;
            assignmentScreen.TopLevel = false;
            main_panel.Controls.Add(dashboardScreen);
            main_panel.Controls.Add(assignmentScreen);
            dashboardScreen.Visible = true;
            assignmentScreen.Visible = false;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            assignments.BackColor = Color.CadetBlue;
            dashboard.BackColor = Color.Azure;
            dashboardScreen.Visible = true;
            assignmentScreen.Visible = false;
        }

        private void assignment_label_Click(object sender, EventArgs e)
        {
            assignments.BackColor= Color.Azure;
            dashboard.BackColor = Color.CadetBlue;
            assignmentScreen.Visible = true;
            dashboardScreen.Visible = false;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
