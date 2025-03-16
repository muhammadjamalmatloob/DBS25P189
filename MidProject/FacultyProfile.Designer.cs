using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidProject
{
    partial class FacultyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyProfile));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(949, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MidProject.Properties.Resources.logo_removebg_preview;
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(30, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(86, 82);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MidProject.Properties.Resources.logo_removebg_preview;
            this.pictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox8.Location = new System.Drawing.Point(24, 171);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(17, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(234, 48);
            this.button8.TabIndex = 8;
            this.button8.Text = "Profile";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox6.Location = new System.Drawing.Point(24, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(24, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(24, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(17, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(234, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "Assigned Courses";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(17, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "         Assigned Final Year \r\n        Project Supervision";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(156, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(156, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 130);
            this.panel1.TabIndex = 23;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.Location = new System.Drawing.Point(3261, 234);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(675, 370);
            this.profile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(89, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Workload and Resource Allocation System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(17, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(24, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(156, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 431);
            this.panel2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(17, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(273, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 431);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FacultyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button button8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button button7;
        private Button button6;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel profile;
        private Label label1;
        private Button button3;
        private PictureBox pictureBox3;
        private Label label5;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
    }
}