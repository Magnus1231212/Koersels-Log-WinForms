namespace Kørsels_Log
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            edit_log = new Button();
            label4 = new Label();
            label3 = new Label();
            delete_log = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            delete_user = new Button();
            edit_user = new Button();
            create_user = new Button();
            add_log = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // edit_log
            // 
            edit_log.BackColor = Color.FromArgb(89, 100, 242);
            edit_log.FlatAppearance.BorderSize = 0;
            edit_log.FlatStyle = FlatStyle.Flat;
            edit_log.ForeColor = Color.White;
            edit_log.Location = new Point(12, 100);
            edit_log.Name = "edit_log";
            edit_log.Size = new Size(235, 31);
            edit_log.TabIndex = 15;
            edit_log.Text = "Edit Selected Log";
            edit_log.UseVisualStyleBackColor = false;
            edit_log.Visible = false;
            edit_log.Click += edit_log_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 49);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(832, 2);
            label4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 13;
            label3.Text = "Actions";
            // 
            // delete_log
            // 
            delete_log.BackColor = Color.FromArgb(89, 100, 242);
            delete_log.FlatAppearance.BorderSize = 0;
            delete_log.FlatStyle = FlatStyle.Flat;
            delete_log.ForeColor = Color.White;
            delete_log.Location = new Point(12, 150);
            delete_log.Name = "delete_log";
            delete_log.Size = new Size(235, 31);
            delete_log.TabIndex = 12;
            delete_log.Text = "Delete Selected Log";
            delete_log.UseVisualStyleBackColor = false;
            delete_log.Visible = false;
            delete_log.Click += delete_log_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(261, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 11;
            label2.Text = "Users";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(30, 31, 34);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(261, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 360);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 9;
            label1.Text = "Welcome Back!";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 394);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(30, 31, 34);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.ForeColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(560, 65);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(284, 360);
            listBox2.TabIndex = 16;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(560, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 17;
            label5.Text = "Logs";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(30, 31, 34);
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(560, 74);
            label6.Name = "label6";
            label6.Size = new Size(284, 27);
            label6.TabIndex = 18;
            label6.Text = "Select a user to show logs";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // delete_user
            // 
            delete_user.BackColor = Color.FromArgb(89, 100, 242);
            delete_user.FlatAppearance.BorderSize = 0;
            delete_user.FlatStyle = FlatStyle.Flat;
            delete_user.ForeColor = Color.White;
            delete_user.Location = new Point(12, 200);
            delete_user.Name = "delete_user";
            delete_user.Size = new Size(235, 31);
            delete_user.TabIndex = 19;
            delete_user.Text = "Delete Selected User";
            delete_user.UseVisualStyleBackColor = false;
            delete_user.Click += delete_user_Click;
            // 
            // edit_user
            // 
            edit_user.BackColor = Color.FromArgb(89, 100, 242);
            edit_user.FlatAppearance.BorderSize = 0;
            edit_user.FlatStyle = FlatStyle.Flat;
            edit_user.ForeColor = Color.White;
            edit_user.Location = new Point(12, 150);
            edit_user.Name = "edit_user";
            edit_user.Size = new Size(235, 31);
            edit_user.TabIndex = 20;
            edit_user.Text = "Edit Selected User";
            edit_user.UseVisualStyleBackColor = false;
            edit_user.Click += edit_user_Click;
            // 
            // create_user
            // 
            create_user.BackColor = Color.FromArgb(89, 100, 242);
            create_user.FlatAppearance.BorderSize = 0;
            create_user.FlatStyle = FlatStyle.Flat;
            create_user.ForeColor = Color.White;
            create_user.Location = new Point(12, 346);
            create_user.Name = "create_user";
            create_user.Size = new Size(235, 31);
            create_user.TabIndex = 21;
            create_user.Text = "Create New User";
            create_user.UseVisualStyleBackColor = false;
            create_user.Click += create_user_Click;
            // 
            // add_log
            // 
            add_log.BackColor = Color.FromArgb(89, 100, 242);
            add_log.FlatAppearance.BorderSize = 0;
            add_log.FlatStyle = FlatStyle.Flat;
            add_log.ForeColor = Color.White;
            add_log.Location = new Point(12, 100);
            add_log.Name = "add_log";
            add_log.Size = new Size(235, 31);
            add_log.TabIndex = 22;
            add_log.Text = "Add Log To Selected User";
            add_log.UseVisualStyleBackColor = false;
            add_log.Click += add_log_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 306);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 23;
            label7.Text = "Create User";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(856, 450);
            Controls.Add(label7);
            Controls.Add(add_log);
            Controls.Add(create_user);
            Controls.Add(edit_user);
            Controls.Add(delete_user);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(edit_log);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(delete_log);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Admin";
            Text = "Admin";
            FormClosing += Admin_FormClosing;
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button edit_log;
        private Label label4;
        private Label label3;
        private Button delete_log;
        private Label label2;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private Button delete_user;
        private Button edit_user;
        private Button create_user;
        private Button add_log;
        private Label label7;
    }
}