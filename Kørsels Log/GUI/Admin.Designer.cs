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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            create_log = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(89, 100, 242);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 155);
            button1.Name = "button1";
            button1.Size = new Size(235, 31);
            button1.TabIndex = 15;
            button1.Text = "Edit Selected Log";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // create_log
            // 
            create_log.BackColor = Color.FromArgb(89, 100, 242);
            create_log.FlatAppearance.BorderSize = 0;
            create_log.FlatStyle = FlatStyle.Flat;
            create_log.ForeColor = Color.White;
            create_log.Location = new Point(12, 103);
            create_log.Name = "create_log";
            create_log.Size = new Size(235, 31);
            create_log.TabIndex = 12;
            create_log.Text = "Create New Log";
            create_log.UseVisualStyleBackColor = false;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(89, 100, 242);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 205);
            button2.Name = "button2";
            button2.Size = new Size(235, 31);
            button2.TabIndex = 19;
            button2.Text = "Edit Selected Log";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(89, 100, 242);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 256);
            button3.Name = "button3";
            button3.Size = new Size(235, 31);
            button3.TabIndex = 20;
            button3.Text = "Edit Selected Log";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(89, 100, 242);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 306);
            button4.Name = "button4";
            button4.Size = new Size(235, 31);
            button4.TabIndex = 21;
            button4.Text = "Edit Selected Log";
            button4.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(856, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(create_log);
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

        private Button button1;
        private Label label4;
        private Label label3;
        private Button create_log;
        private Label label2;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}