namespace school_management_system.Screens.Admin
{
    partial class AdminStudentPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.upd_student_btn = new System.Windows.Forms.Button();
            this.show_add_student_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.students_table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.upd_student_btn);
            this.panel6.Controls.Add(this.show_add_student_btn);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(-2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(864, 620);
            this.panel6.TabIndex = 4;
            // 
            // upd_student_btn
            // 
            this.upd_student_btn.BackColor = System.Drawing.Color.Azure;
            this.upd_student_btn.FlatAppearance.BorderSize = 2;
            this.upd_student_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upd_student_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upd_student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_student_btn.ForeColor = System.Drawing.Color.CadetBlue;
            this.upd_student_btn.Location = new System.Drawing.Point(494, 567);
            this.upd_student_btn.Name = "upd_student_btn";
            this.upd_student_btn.Size = new System.Drawing.Size(168, 41);
            this.upd_student_btn.TabIndex = 3;
            this.upd_student_btn.Text = "Update Student";
            this.upd_student_btn.UseVisualStyleBackColor = false;
            this.upd_student_btn.Click += new System.EventHandler(this.upd_student_btn_Click);
            // 
            // show_add_student_btn
            // 
            this.show_add_student_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.show_add_student_btn.FlatAppearance.BorderSize = 0;
            this.show_add_student_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.show_add_student_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.show_add_student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_add_student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_add_student_btn.ForeColor = System.Drawing.Color.Azure;
            this.show_add_student_btn.Location = new System.Drawing.Point(684, 567);
            this.show_add_student_btn.Name = "show_add_student_btn";
            this.show_add_student_btn.Size = new System.Drawing.Size(168, 41);
            this.show_add_student_btn.TabIndex = 2;
            this.show_add_student_btn.Text = "Add New Student";
            this.show_add_student_btn.UseVisualStyleBackColor = false;
            this.show_add_student_btn.Click += new System.EventHandler(this.show_add_student_btn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.students_table);
            this.panel7.Location = new System.Drawing.Point(14, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(838, 486);
            this.panel7.TabIndex = 1;
            // 
            // students_table
            // 
            this.students_table.AllowUserToAddRows = false;
            this.students_table.AllowUserToDeleteRows = false;
            this.students_table.AllowUserToResizeRows = false;
            this.students_table.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.students_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.students_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.students_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.students_table.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.students_table.Location = new System.Drawing.Point(3, 3);
            this.students_table.MultiSelect = false;
            this.students_table.Name = "students_table";
            this.students_table.ReadOnly = true;
            this.students_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.students_table.ShowEditingIcon = false;
            this.students_table.Size = new System.Drawing.Size(832, 480);
            this.students_table.TabIndex = 0;
            this.students_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.students_table_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manage Students";
            // 
            // AdminStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(862, 620);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Students - School Management System";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.students_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button show_add_student_btn;
        private System.Windows.Forms.DataGridView students_table;
        private System.Windows.Forms.Button upd_student_btn;
    }
}