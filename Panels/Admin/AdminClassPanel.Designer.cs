namespace school_management_system.Screens.Admin
{
    partial class AdminClassPanel
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.upd_class_btn = new System.Windows.Forms.Button();
            this.del_class_btn = new System.Windows.Forms.Button();
            this.add_class_btn = new System.Windows.Forms.Button();
            this.class_details_in = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.class_teacher_in = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.class_name_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.class_table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(864, 620);
            this.panel6.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.upd_class_btn);
            this.panel8.Controls.Add(this.del_class_btn);
            this.panel8.Controls.Add(this.add_class_btn);
            this.panel8.Controls.Add(this.class_details_in);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.class_teacher_in);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.class_name_in);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(14, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(254, 524);
            this.panel8.TabIndex = 2;
            // 
            // upd_class_btn
            // 
            this.upd_class_btn.BackColor = System.Drawing.Color.Azure;
            this.upd_class_btn.FlatAppearance.BorderSize = 2;
            this.upd_class_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upd_class_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upd_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_class_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_class_btn.ForeColor = System.Drawing.Color.CadetBlue;
            this.upd_class_btn.Location = new System.Drawing.Point(17, 478);
            this.upd_class_btn.Name = "upd_class_btn";
            this.upd_class_btn.Size = new System.Drawing.Size(102, 28);
            this.upd_class_btn.TabIndex = 10;
            this.upd_class_btn.Text = "Update Class";
            this.upd_class_btn.UseVisualStyleBackColor = false;
            this.upd_class_btn.Click += new System.EventHandler(this.upd_class_btn_Click);
            // 
            // del_class_btn
            // 
            this.del_class_btn.BackColor = System.Drawing.Color.Salmon;
            this.del_class_btn.FlatAppearance.BorderSize = 0;
            this.del_class_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.del_class_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.del_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_class_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_class_btn.Location = new System.Drawing.Point(128, 478);
            this.del_class_btn.Name = "del_class_btn";
            this.del_class_btn.Size = new System.Drawing.Size(102, 28);
            this.del_class_btn.TabIndex = 9;
            this.del_class_btn.Text = "Remove Class";
            this.del_class_btn.UseVisualStyleBackColor = false;
            this.del_class_btn.Click += new System.EventHandler(this.del_class_btn_Click);
            // 
            // add_class_btn
            // 
            this.add_class_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.add_class_btn.FlatAppearance.BorderSize = 0;
            this.add_class_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add_class_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_class_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_class_btn.ForeColor = System.Drawing.Color.Azure;
            this.add_class_btn.Location = new System.Drawing.Point(17, 444);
            this.add_class_btn.Name = "add_class_btn";
            this.add_class_btn.Size = new System.Drawing.Size(213, 28);
            this.add_class_btn.TabIndex = 8;
            this.add_class_btn.Text = "Add Class";
            this.add_class_btn.UseVisualStyleBackColor = false;
            this.add_class_btn.Click += new System.EventHandler(this.add_class_btn_Click);
            // 
            // class_details_in
            // 
            this.class_details_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_details_in.Location = new System.Drawing.Point(17, 160);
            this.class_details_in.Multiline = true;
            this.class_details_in.Name = "class_details_in";
            this.class_details_in.Size = new System.Drawing.Size(213, 250);
            this.class_details_in.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Details";
            // 
            // class_teacher_in
            // 
            this.class_teacher_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_teacher_in.FormattingEnabled = true;
            this.class_teacher_in.Location = new System.Drawing.Point(17, 98);
            this.class_teacher_in.Name = "class_teacher_in";
            this.class_teacher_in.Size = new System.Drawing.Size(213, 26);
            this.class_teacher_in.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Class Teacher";
            // 
            // class_name_in
            // 
            this.class_name_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_in.Location = new System.Drawing.Point(17, 31);
            this.class_name_in.Name = "class_name_in";
            this.class_name_in.Size = new System.Drawing.Size(213, 24);
            this.class_name_in.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Class Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.class_table);
            this.panel7.Location = new System.Drawing.Point(289, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 524);
            this.panel7.TabIndex = 1;
            // 
            // class_table
            // 
            this.class_table.AllowUserToAddRows = false;
            this.class_table.AllowUserToDeleteRows = false;
            this.class_table.AllowUserToResizeRows = false;
            this.class_table.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.class_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.class_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.class_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.class_table.Location = new System.Drawing.Point(4, 3);
            this.class_table.MultiSelect = false;
            this.class_table.Name = "class_table";
            this.class_table.ReadOnly = true;
            this.class_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.class_table.ShowEditingIcon = false;
            this.class_table.Size = new System.Drawing.Size(556, 518);
            this.class_table.TabIndex = 0;
            this.class_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.class_table_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manage Classes";
            // 
            // AdminClassPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(865, 620);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminClassPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Classes - School Management System";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.class_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox class_teacher_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox class_name_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button upd_class_btn;
        private System.Windows.Forms.Button del_class_btn;
        private System.Windows.Forms.Button add_class_btn;
        private System.Windows.Forms.TextBox class_details_in;
        private System.Windows.Forms.DataGridView class_table;
    }
}