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
        private int _st_id;

        public StudentScreen(int id)
        {
            InitializeComponent();
            _st_id = id;

            StudentDashboardPanel dashboardPanel = new StudentDashboardPanel(_st_id);
            dashboardPanel.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            StudentDashboardPanel dashboardPanel = new StudentDashboardPanel(_st_id);
            dashboardPanel.TopLevel = false;

            assignments.BackColor = Color.CadetBlue;
            dashboard.BackColor = Color.Azure;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboardPanel);
            dashboardPanel.Visible = true;
        }

        private void assignment_label_Click(object sender, EventArgs e)
        {
            StudentAssignmentsPanel assignmentsPanel = new StudentAssignmentsPanel(_st_id);
            assignmentsPanel.TopLevel = false;

            assignments.BackColor= Color.Azure;
            dashboard.BackColor = Color.CadetBlue;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(assignmentsPanel);
            assignmentsPanel.Visible = true;
        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
