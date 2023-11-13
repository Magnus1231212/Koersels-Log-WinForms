namespace Kørsels_Log
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            login_btn = new Button();
            Username_textBox = new TextBox();
            Password_textBox = new TextBox();
            RememberMe = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 37);
            label1.Name = "label1";
            label1.Size = new Size(327, 42);
            label1.TabIndex = 0;
            label1.Text = "Velkommen tilbage";
            label1.Click += label1_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(89, 100, 242);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(49, 268);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(327, 31);
            login_btn.TabIndex = 1;
            login_btn.Text = "Log ind";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_Click;
            // 
            // Username_textBox
            // 
            Username_textBox.BackColor = Color.FromArgb(30, 31, 34);
            Username_textBox.BorderStyle = BorderStyle.None;
            Username_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Username_textBox.ForeColor = Color.White;
            Username_textBox.Location = new Point(49, 131);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.PlaceholderText = "Username";
            Username_textBox.Size = new Size(327, 26);
            Username_textBox.TabIndex = 2;
            // 
            // Password_textBox
            // 
            Password_textBox.BackColor = Color.FromArgb(30, 31, 34);
            Password_textBox.BorderStyle = BorderStyle.None;
            Password_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textBox.ForeColor = Color.White;
            Password_textBox.Location = new Point(49, 173);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PasswordChar = '*';
            Password_textBox.PlaceholderText = "Password";
            Password_textBox.Size = new Size(327, 26);
            Password_textBox.TabIndex = 3;
            // 
            // RememberMe
            // 
            RememberMe.AutoSize = true;
            RememberMe.BackColor = Color.Transparent;
            RememberMe.FlatAppearance.BorderSize = 0;
            RememberMe.FlatStyle = FlatStyle.Flat;
            RememberMe.ForeColor = Color.White;
            RememberMe.Location = new Point(49, 205);
            RememberMe.Name = "RememberMe";
            RememberMe.Size = new Size(101, 19);
            RememberMe.TabIndex = 4;
            RememberMe.Text = "Remember me";
            RememberMe.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(427, 408);
            Controls.Add(RememberMe);
            Controls.Add(Password_textBox);
            Controls.Add(Username_textBox);
            Controls.Add(login_btn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login - Kørsels Log";
            FormClosing += Login_FormClosing;
            Load += Login_Load_1;
            Shown += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button login_btn;
        private TextBox Username_textBox;
        private TextBox Password_textBox;
        private CheckBox RememberMe;
    }
}