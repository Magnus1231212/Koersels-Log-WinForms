namespace Kørsels_Log
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            create_log = new Button();
            label3 = new Label();
            label4 = new Label();
            edit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(30, 31, 34);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(261, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 360);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(261, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "Your Logs";
            label2.Click += label2_Click;
            // 
            // create_log
            // 
            create_log.BackColor = Color.FromArgb(89, 100, 242);
            create_log.FlatAppearance.BorderSize = 0;
            create_log.FlatStyle = FlatStyle.Flat;
            create_log.ForeColor = Color.White;
            create_log.Location = new Point(12, 107);
            create_log.Name = "create_log";
            create_log.Size = new Size(235, 31);
            create_log.TabIndex = 4;
            create_log.Text = "Create New Log";
            create_log.UseVisualStyleBackColor = false;
            create_log.Click += create_log_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 5;
            label3.Text = "Actions";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 49);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(533, 2);
            label4.TabIndex = 6;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(89, 100, 242);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = FlatStyle.Flat;
            edit.ForeColor = Color.White;
            edit.Location = new Point(12, 159);
            edit.Name = "edit";
            edit.Size = new Size(235, 31);
            edit.TabIndex = 7;
            edit.Text = "Edit Selected Log";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(557, 450);
            Controls.Add(edit);
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
            Name = "Home";
            Text = "Home - Kørsels Log";
            FormClosing += Home_FormClosing;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Button create_log;
        private Label label3;
        private Label label4;
        private Button edit;
    }
}