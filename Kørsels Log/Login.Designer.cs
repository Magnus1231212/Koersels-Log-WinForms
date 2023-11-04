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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(89, 100, 242);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 268);
            button1.Name = "button1";
            button1.Size = new Size(327, 31);
            button1.TabIndex = 1;
            button1.Text = "Log ind";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 31, 34);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(49, 131);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(327, 26);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 31, 34);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(49, 173);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(327, 26);
            textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.FlatAppearance.BorderSize = 0;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(49, 205);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(427, 408);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login - Kørsels Log";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
    }
}