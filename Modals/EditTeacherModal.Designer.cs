namespace school_management_system.Modals
{
    partial class EditTeacherModal
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
            this.label7 = new System.Windows.Forms.Label();
            this.university_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.degree_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status_in = new System.Windows.Forms.ComboBox();
            this.dob_in = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.home_in = new System.Windows.Forms.TextBox();
            this.contact_in = new System.Windows.Forms.TextBox();
            this.mail_in = new System.Windows.Forms.TextBox();
            this.name_in = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gender_in = new System.Windows.Forms.ComboBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.subject_in = new System.Windows.Forms.ComboBox();
            this.classes_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 102;
            this.label7.Text = "Subject";
            // 
            // university_in
            // 
            this.university_in.BackColor = System.Drawing.SystemColors.Window;
            this.university_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.university_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.university_in.Location = new System.Drawing.Point(400, 151);
            this.university_in.Name = "university_in";
            this.university_in.Size = new System.Drawing.Size(369, 24);
            this.university_in.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "University";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Edit Teacher Details";
            // 
            // degree_in
            // 
            this.degree_in.BackColor = System.Drawing.SystemColors.Window;
            this.degree_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.degree_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_in.Location = new System.Drawing.Point(400, 95);
            this.degree_in.Name = "degree_in";
            this.degree_in.Size = new System.Drawing.Size(369, 24);
            this.degree_in.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 92;
            this.label12.Text = "Degree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 107;
            this.label5.Text = "Status";
            // 
            // status_in
            // 
            this.status_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_in.FormattingEnabled = true;
            this.status_in.Items.AddRange(new object[] {
            "Pending",
            "Registered",
            "Suspended",
            "Pentioned"});
            this.status_in.Location = new System.Drawing.Point(400, 385);
            this.status_in.Name = "status_in";
            this.status_in.Size = new System.Drawing.Size(368, 26);
            this.status_in.TabIndex = 108;
            // 
            // dob_in
            // 
            this.dob_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_in.Location = new System.Drawing.Point(36, 201);
            this.dob_in.Name = "dob_in";
            this.dob_in.Size = new System.Drawing.Size(276, 22);
            this.dob_in.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 119;
            this.label3.Text = "Date of Birth";
            // 
            // home_in
            // 
            this.home_in.BackColor = System.Drawing.SystemColors.Window;
            this.home_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_in.Location = new System.Drawing.Point(36, 384);
            this.home_in.Multiline = true;
            this.home_in.Name = "home_in";
            this.home_in.Size = new System.Drawing.Size(276, 117);
            this.home_in.TabIndex = 118;
            // 
            // contact_in
            // 
            this.contact_in.BackColor = System.Drawing.SystemColors.Window;
            this.contact_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_in.Location = new System.Drawing.Point(36, 332);
            this.contact_in.Name = "contact_in";
            this.contact_in.Size = new System.Drawing.Size(276, 24);
            this.contact_in.TabIndex = 117;
            // 
            // mail_in
            // 
            this.mail_in.BackColor = System.Drawing.SystemColors.Window;
            this.mail_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_in.Location = new System.Drawing.Point(36, 281);
            this.mail_in.Name = "mail_in";
            this.mail_in.Size = new System.Drawing.Size(276, 24);
            this.mail_in.TabIndex = 116;
            // 
            // name_in
            // 
            this.name_in.BackColor = System.Drawing.SystemColors.Window;
            this.name_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(36, 96);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(276, 24);
            this.name_in.TabIndex = 114;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 113;
            this.label10.Text = "Home Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 112;
            this.label8.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "Teacher Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(397, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Classes";
            // 
            // gender_in
            // 
            this.gender_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_in.FormattingEnabled = true;
            this.gender_in.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_in.Location = new System.Drawing.Point(36, 148);
            this.gender_in.Name = "gender_in";
            this.gender_in.Size = new System.Drawing.Size(276, 26);
            this.gender_in.TabIndex = 123;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Salmon;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.del_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.del_btn.Location = new System.Drawing.Point(596, 457);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(173, 44);
            this.del_btn.TabIndex = 126;
            this.del_btn.Text = "Delete Teacher";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.upd_btn.FlatAppearance.BorderSize = 0;
            this.upd_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.upd_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_btn.ForeColor = System.Drawing.Color.Azure;
            this.upd_btn.Location = new System.Drawing.Point(400, 457);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(173, 44);
            this.upd_btn.TabIndex = 125;
            this.upd_btn.Text = "Edit Teacher";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // subject_in
            // 
            this.subject_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_in.FormattingEnabled = true;
            this.subject_in.Location = new System.Drawing.Point(400, 332);
            this.subject_in.Name = "subject_in";
            this.subject_in.Size = new System.Drawing.Size(369, 26);
            this.subject_in.TabIndex = 127;
            // 
            // classes_list
            // 
            this.classes_list.BackColor = System.Drawing.SystemColors.Window;
            this.classes_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classes_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_list.Location = new System.Drawing.Point(400, 226);
            this.classes_list.Multiline = true;
            this.classes_list.Name = "classes_list";
            this.classes_list.ReadOnly = true;
            this.classes_list.Size = new System.Drawing.Size(368, 79);
            this.classes_list.TabIndex = 128;
            // 
            // EditTeacherModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.classes_list);
            this.Controls.Add(this.subject_in);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.gender_in);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dob_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.home_in);
            this.Controls.Add(this.contact_in);
            this.Controls.Add(this.mail_in);
            this.Controls.Add(this.name_in);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.status_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.university_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degree_in);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditTeacherModal";
            this.Text = "Edit Teacher Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox university_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox degree_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status_in;
        private System.Windows.Forms.DateTimePicker dob_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox home_in;
        private System.Windows.Forms.TextBox contact_in;
        private System.Windows.Forms.TextBox mail_in;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox gender_in;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.ComboBox subject_in;
        private System.Windows.Forms.TextBox classes_list;
    }
}