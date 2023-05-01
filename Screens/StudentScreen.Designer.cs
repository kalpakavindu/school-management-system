namespace school_management_system.Screens.Student
{
    partial class StudentScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.logout_label = new System.Windows.Forms.Label();
            this.assignments = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.assignment_label = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.assignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.assignments);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 620);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.logout_label);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 576);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 44);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::school_management_system.Properties.Resources.logout_circle_line_dark;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.InitialImage = global::school_management_system.Properties.Resources.logout_circle_line_dark;
            this.pictureBox4.Location = new System.Drawing.Point(16, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 28);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.Location = new System.Drawing.Point(150, 12);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(54, 18);
            this.logout_label.TabIndex = 0;
            this.logout_label.Text = "Logout";
            this.logout_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_label.Click += new System.EventHandler(this.logout_label_Click);
            // 
            // assignments
            // 
            this.assignments.BackColor = System.Drawing.Color.CadetBlue;
            this.assignments.Controls.Add(this.pictureBox3);
            this.assignments.Controls.Add(this.assignment_label);
            this.assignments.Location = new System.Drawing.Point(0, 135);
            this.assignments.Name = "assignments";
            this.assignments.Size = new System.Drawing.Size(214, 44);
            this.assignments.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::school_management_system.Properties.Resources.book_open_fill_dark;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = global::school_management_system.Properties.Resources.book_open_fill_dark;
            this.pictureBox3.Location = new System.Drawing.Point(16, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // assignment_label
            // 
            this.assignment_label.AutoSize = true;
            this.assignment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignment_label.Location = new System.Drawing.Point(111, 11);
            this.assignment_label.Name = "assignment_label";
            this.assignment_label.Size = new System.Drawing.Size(93, 18);
            this.assignment_label.TabIndex = 0;
            this.assignment_label.Text = "Assignments";
            this.assignment_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assignment_label.Click += new System.EventHandler(this.assignment_label_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Azure;
            this.dashboard.Controls.Add(this.pictureBox1);
            this.dashboard.Controls.Add(this.dashboard_label);
            this.dashboard.Location = new System.Drawing.Point(0, 85);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(214, 44);
            this.dashboard.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::school_management_system.Properties.Resources.dashboard_fill_dark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::school_management_system.Properties.Resources.dashboard_fill_dark;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard_label
            // 
            this.dashboard_label.AutoSize = true;
            this.dashboard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label.Location = new System.Drawing.Point(123, 13);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(81, 18);
            this.dashboard_label.TabIndex = 0;
            this.dashboard_label.Text = "Dashboard";
            this.dashboard_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management\r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_panel.Location = new System.Drawing.Point(215, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(869, 620);
            this.main_panel.TabIndex = 3;
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1084, 620);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.Name = "StudentScreen";
            this.Text = "Student - School Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.assignments.ResumeLayout(false);
            this.assignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Panel assignments;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label assignment_label;
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dashboard_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel main_panel;
    }
}