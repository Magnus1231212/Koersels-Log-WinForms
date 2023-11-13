namespace Kørsels_Log
{
    partial class CreateLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLog));
            create_log = new Button();
            label1 = new Label();
            Username_textBox = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // create_log
            // 
            create_log.BackColor = Color.FromArgb(89, 100, 242);
            create_log.FlatAppearance.BorderSize = 0;
            create_log.FlatStyle = FlatStyle.Flat;
            create_log.ForeColor = Color.White;
            create_log.Location = new Point(45, 207);
            create_log.Name = "create_log";
            create_log.Size = new Size(235, 31);
            create_log.TabIndex = 5;
            create_log.Text = "Create Log";
            create_log.UseVisualStyleBackColor = false;
            create_log.Click += create_log_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 6;
            label1.Text = "Create New Log";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Username_textBox
            // 
            Username_textBox.BackColor = Color.FromArgb(30, 31, 34);
            Username_textBox.BorderStyle = BorderStyle.None;
            Username_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Username_textBox.ForeColor = Color.White;
            Username_textBox.Location = new Point(45, 88);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.PlaceholderText = "From";
            Username_textBox.Size = new Size(235, 26);
            Username_textBox.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 31, 34);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(45, 129);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "To";
            textBox1.Size = new Size(235, 26);
            textBox1.TabIndex = 8;
            // 
            // CreateLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(324, 276);
            Controls.Add(textBox1);
            Controls.Add(Username_textBox);
            Controls.Add(label1);
            Controls.Add(create_log);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateLog";
            Text = "CreateLog";
            FormClosing += CreateLog_FormClosing;
            Load += CreateLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_log;
        private Label label1;
        private TextBox Username_textBox;
        private TextBox textBox1;
    }
}