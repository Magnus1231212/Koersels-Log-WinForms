namespace Kørsels_Log
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            update_user = new Button();
            label1 = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // update_user
            // 
            update_user.BackColor = Color.FromArgb(89, 100, 242);
            update_user.FlatAppearance.BorderSize = 0;
            update_user.FlatStyle = FlatStyle.Flat;
            update_user.ForeColor = Color.White;
            update_user.Location = new Point(45, 199);
            update_user.Name = "update_user";
            update_user.Size = new Size(235, 31);
            update_user.TabIndex = 5;
            update_user.Text = "Edit User";
            update_user.UseVisualStyleBackColor = false;
            update_user.Click += update_user_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 6;
            label1.Text = "Edit User";
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
            password_textBox.PlaceholderText = "New Password";
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
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(300, 13);
            label2.TabIndex = 16;
            label2.Text = "Leave blank to keep unchanged.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(324, 276);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(label1);
            Controls.Add(update_user);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditUser";
            Text = "EditUser - Kørsels Log";
            FormClosing += EditUser_FormClosing;
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update_user;
        private Label label1;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label label4;
        private Label label2;
    }
}