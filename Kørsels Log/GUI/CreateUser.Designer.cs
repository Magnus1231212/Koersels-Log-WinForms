namespace Kørsels_Log
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            create_user = new Button();
            label1 = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            label4 = new Label();
            admin_checkBox = new CheckBox();
            SuspendLayout();
            // 
            // create_user
            // 
            create_user.BackColor = Color.FromArgb(89, 100, 242);
            create_user.FlatAppearance.BorderSize = 0;
            create_user.FlatStyle = FlatStyle.Flat;
            create_user.ForeColor = Color.White;
            create_user.Location = new Point(45, 207);
            create_user.Name = "create_user";
            create_user.Size = new Size(235, 31);
            create_user.TabIndex = 5;
            create_user.Text = "Create User";
            create_user.UseVisualStyleBackColor = false;
            create_user.Click += create_user_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 6;
            label1.Text = "Create New User";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // username_textBox
            // 
            username_textBox.BackColor = Color.FromArgb(30, 31, 34);
            username_textBox.BorderStyle = BorderStyle.None;
            username_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_textBox.ForeColor = Color.White;
            username_textBox.Location = new Point(45, 93);
            username_textBox.Name = "username_textBox";
            username_textBox.PlaceholderText = "Username";
            username_textBox.Size = new Size(235, 26);
            username_textBox.TabIndex = 7;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.FromArgb(30, 31, 34);
            password_textBox.BorderStyle = BorderStyle.None;
            password_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.ForeColor = Color.White;
            password_textBox.Location = new Point(45, 134);
            password_textBox.Name = "password_textBox";
            password_textBox.PlaceholderText = "Password";
            password_textBox.Size = new Size(235, 26);
            password_textBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 60);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(303, 2);
            label4.TabIndex = 15;
            // 
            // admin_checkBox
            // 
            admin_checkBox.AutoSize = true;
            admin_checkBox.ForeColor = Color.White;
            admin_checkBox.Location = new Point(45, 166);
            admin_checkBox.Name = "admin_checkBox";
            admin_checkBox.Size = new Size(94, 19);
            admin_checkBox.TabIndex = 16;
            admin_checkBox.Text = "Make Admin";
            admin_checkBox.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(324, 276);
            Controls.Add(admin_checkBox);
            Controls.Add(label4);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(label1);
            Controls.Add(create_user);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateUser";
            Text = "CreateUser - Kørsels Log";
            FormClosing += CreateUser_FormClosing;
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_user;
        private Label label1;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label label4;
        private CheckBox admin_checkBox;
    }
}