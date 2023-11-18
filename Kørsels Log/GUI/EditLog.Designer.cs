namespace Kørsels_Log
{
    partial class EditLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLog));
            create_log = new Button();
            label1 = new Label();
            from_textBox = new TextBox();
            to_textBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // create_log
            // 
            create_log.BackColor = Color.FromArgb(89, 100, 242);
            create_log.FlatAppearance.BorderSize = 0;
            create_log.FlatStyle = FlatStyle.Flat;
            create_log.ForeColor = Color.White;
            create_log.Location = new Point(45, 199);
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
            // from_textBox
            // 
            from_textBox.BackColor = Color.FromArgb(30, 31, 34);
            from_textBox.BorderStyle = BorderStyle.None;
            from_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            from_textBox.ForeColor = Color.White;
            from_textBox.Location = new Point(45, 93);
            from_textBox.Name = "from_textBox";
            from_textBox.PlaceholderText = "From";
            from_textBox.Size = new Size(235, 26);
            from_textBox.TabIndex = 7;
            // 
            // to_textBox
            // 
            to_textBox.BackColor = Color.FromArgb(30, 31, 34);
            to_textBox.BorderStyle = BorderStyle.None;
            to_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            to_textBox.ForeColor = Color.White;
            to_textBox.Location = new Point(45, 134);
            to_textBox.Name = "to_textBox";
            to_textBox.PlaceholderText = "To";
            to_textBox.Size = new Size(235, 26);
            to_textBox.TabIndex = 8;
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
            // EditLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(324, 276);
            Controls.Add(label4);
            Controls.Add(to_textBox);
            Controls.Add(from_textBox);
            Controls.Add(label1);
            Controls.Add(create_log);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditLog";
            Text = "EditLog";
            FormClosing += EditLog_FormClosing;
            Load += EditLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_log;
        private Label label1;
        private TextBox from_textBox;
        private TextBox to_textBox;
        private Label label4;
    }
}