namespace MidProject
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            Closebtn = new Button();
            button2 = new Button();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-8, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 447);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_removebg_preview__1_;
            pictureBox2.Location = new Point(92, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(22, 158);
            label1.Name = "label1";
            label1.Size = new Size(311, 180);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Faculty \r\nWorkload and \r\nResource Allocation \r\nSystem";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(139, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Closebtn);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(331, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 405);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.InactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(206, 289);
            button3.Name = "button3";
            button3.Size = new Size(150, 36);
            button3.TabIndex = 6;
            button3.Text = "Forgot Password?";
            button3.UseVisualStyleBackColor = false;
            // 
            // Closebtn
            // 
            Closebtn.BackColor = SystemColors.InactiveCaption;
            Closebtn.FlatAppearance.BorderColor = SystemColors.InactiveCaption;
            Closebtn.FlatStyle = FlatStyle.Flat;
            Closebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Closebtn.ForeColor = SystemColors.HotTrack;
            Closebtn.Location = new Point(328, 2);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(40, 37);
            Closebtn.TabIndex = 2;
            Closebtn.Text = "X";
            Closebtn.UseVisualStyleBackColor = false;
            Closebtn.Click += closebtn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.InactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(8, 289);
            button2.Name = "button2";
            button2.Size = new Size(77, 36);
            button2.TabIndex = 5;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(8, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 44);
            panel4.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(58, 7);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(286, 26);
            textBox2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(8, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 44);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(58, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(286, 26);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(84, 125);
            label2.Name = "label2";
            label2.Size = new Size(216, 30);
            label2.TabIndex = 2;
            label2.Text = "Login to your account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private Button Closebtn;
        private Button button2;
        private Button button3;
    }
}
