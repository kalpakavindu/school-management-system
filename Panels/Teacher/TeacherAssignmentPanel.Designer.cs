namespace school_management_system
{
    partial class TeacherAssignmentPanel
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
            this.show_details_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.desc_in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.title_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.assignment_table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(864, 620);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.show_details_btn);
            this.panel8.Controls.Add(this.upd_btn);
            this.panel8.Controls.Add(this.desc_in);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.title_in);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.add_btn);
            this.panel8.Location = new System.Drawing.Point(14, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 546);
            this.panel8.TabIndex = 3;
            // 
            // show_details_btn
            // 
            this.show_details_btn.BackColor = System.Drawing.Color.Azure;
            this.show_details_btn.FlatAppearance.BorderSize = 2;
            this.show_details_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show_details_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.show_details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_details_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_details_btn.ForeColor = System.Drawing.Color.CadetBlue;
            this.show_details_btn.Location = new System.Drawing.Point(23, 411);
            this.show_details_btn.Name = "show_details_btn";
            this.show_details_btn.Size = new System.Drawing.Size(251, 33);
            this.show_details_btn.TabIndex = 10;
            this.show_details_btn.Text = "See More Details";
            this.show_details_btn.UseVisualStyleBackColor = false;
            this.show_details_btn.Click += new System.EventHandler(this.show_details_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.upd_btn.FlatAppearance.BorderSize = 0;
            this.upd_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.upd_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upd_btn.Location = new System.Drawing.Point(23, 489);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(251, 33);
            this.upd_btn.TabIndex = 9;
            this.upd_btn.Text = "Update Assignment";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // desc_in
            // 
            this.desc_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_in.Location = new System.Drawing.Point(23, 89);
            this.desc_in.Multiline = true;
            this.desc_in.Name = "desc_in";
            this.desc_in.Size = new System.Drawing.Size(251, 300);
            this.desc_in.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Assignement Description";
            // 
            // title_in
            // 
            this.title_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_in.Location = new System.Drawing.Point(23, 37);
            this.title_in.Name = "title_in";
            this.title_in.Size = new System.Drawing.Size(251, 24);
            this.title_in.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Assignement Title";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Azure;
            this.add_btn.Location = new System.Drawing.Point(23, 450);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(251, 33);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add Assignment";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.assignment_table);
            this.panel7.Location = new System.Drawing.Point(329, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(523, 546);
            this.panel7.TabIndex = 1;
            // 
            // assignment_table
            // 
            this.assignment_table.AllowUserToAddRows = false;
            this.assignment_table.AllowUserToDeleteRows = false;
            this.assignment_table.AllowUserToResizeRows = false;
            this.assignment_table.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assignment_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assignment_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assignment_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.assignment_table.Location = new System.Drawing.Point(4, 4);
            this.assignment_table.MultiSelect = false;
            this.assignment_table.Name = "assignment_table";
            this.assignment_table.ReadOnly = true;
            this.assignment_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignment_table.Size = new System.Drawing.Size(516, 539);
            this.assignment_table.TabIndex = 0;
            this.assignment_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignment_table_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Assignments";
            // 
            // TeacherAssignmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(864, 620);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherAssignmentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignments - School Management System";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignment_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox desc_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox title_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button show_details_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.DataGridView assignment_table;
    }
}