namespace school_management_system.Screens.Admin
{
    partial class AdminSubjectPanel
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
            this.upd_subject_btn = new System.Windows.Forms.Button();
            this.del_subject_btn = new System.Windows.Forms.Button();
            this.add_subject_btn = new System.Windows.Forms.Button();
            this.subject_name_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.subject_table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_table)).BeginInit();
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
            this.panel6.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.upd_subject_btn);
            this.panel8.Controls.Add(this.del_subject_btn);
            this.panel8.Controls.Add(this.add_subject_btn);
            this.panel8.Controls.Add(this.subject_name_in);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(14, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(254, 538);
            this.panel8.TabIndex = 2;
            // 
            // upd_subject_btn
            // 
            this.upd_subject_btn.BackColor = System.Drawing.Color.Azure;
            this.upd_subject_btn.FlatAppearance.BorderSize = 2;
            this.upd_subject_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upd_subject_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upd_subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_subject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_subject_btn.ForeColor = System.Drawing.Color.CadetBlue;
            this.upd_subject_btn.Location = new System.Drawing.Point(19, 492);
            this.upd_subject_btn.Name = "upd_subject_btn";
            this.upd_subject_btn.Size = new System.Drawing.Size(102, 28);
            this.upd_subject_btn.TabIndex = 10;
            this.upd_subject_btn.Text = "Update";
            this.upd_subject_btn.UseVisualStyleBackColor = false;
            this.upd_subject_btn.Click += new System.EventHandler(this.upd_subject_btn_Click);
            // 
            // del_subject_btn
            // 
            this.del_subject_btn.BackColor = System.Drawing.Color.Salmon;
            this.del_subject_btn.FlatAppearance.BorderSize = 0;
            this.del_subject_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.del_subject_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.del_subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_subject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_subject_btn.Location = new System.Drawing.Point(130, 492);
            this.del_subject_btn.Name = "del_subject_btn";
            this.del_subject_btn.Size = new System.Drawing.Size(102, 28);
            this.del_subject_btn.TabIndex = 9;
            this.del_subject_btn.Text = "Remove";
            this.del_subject_btn.UseVisualStyleBackColor = false;
            this.del_subject_btn.Click += new System.EventHandler(this.del_subject_btn_Click);
            // 
            // add_subject_btn
            // 
            this.add_subject_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.add_subject_btn.FlatAppearance.BorderSize = 0;
            this.add_subject_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add_subject_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_subject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_subject_btn.ForeColor = System.Drawing.Color.Azure;
            this.add_subject_btn.Location = new System.Drawing.Point(19, 458);
            this.add_subject_btn.Name = "add_subject_btn";
            this.add_subject_btn.Size = new System.Drawing.Size(213, 28);
            this.add_subject_btn.TabIndex = 8;
            this.add_subject_btn.Text = "Add";
            this.add_subject_btn.UseVisualStyleBackColor = false;
            this.add_subject_btn.Click += new System.EventHandler(this.add_subject_btn_Click);
            // 
            // subject_name_in
            // 
            this.subject_name_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_name_in.Location = new System.Drawing.Point(19, 44);
            this.subject_name_in.Name = "subject_name_in";
            this.subject_name_in.Size = new System.Drawing.Size(213, 24);
            this.subject_name_in.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subject Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.subject_table);
            this.panel7.Location = new System.Drawing.Point(289, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 538);
            this.panel7.TabIndex = 1;
            // 
            // subject_table
            // 
            this.subject_table.AllowUserToAddRows = false;
            this.subject_table.AllowUserToDeleteRows = false;
            this.subject_table.AllowUserToResizeRows = false;
            this.subject_table.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subject_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subject_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.subject_table.Location = new System.Drawing.Point(4, 3);
            this.subject_table.MultiSelect = false;
            this.subject_table.Name = "subject_table";
            this.subject_table.ReadOnly = true;
            this.subject_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subject_table.ShowEditingIcon = false;
            this.subject_table.Size = new System.Drawing.Size(556, 530);
            this.subject_table.TabIndex = 0;
            this.subject_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subject_table_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manage Subjects";
            // 
            // AdminSubjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(864, 620);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSubjectPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subjects - School Management System";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subject_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button upd_subject_btn;
        private System.Windows.Forms.Button del_subject_btn;
        private System.Windows.Forms.Button add_subject_btn;
        private System.Windows.Forms.TextBox subject_name_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView subject_table;
    }
}