﻿namespace EASYPAY.profile
{
    partial class ViewProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfil));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUpgrade = new Button();
            btnEdit = new Button();
            labelNama = new Label();
            labelTP = new Label();
            labelprofile = new Label();
            labelDashboard = new Label();
            labelEwallet = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 117);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 40;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 181);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 41;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 245);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 42;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 314);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 43;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 116);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 44;
            label5.Text = "label5";
            // 
            // btnUpgrade
            // 
            btnUpgrade.Font = new Font("Poppins", 8F);
            btnUpgrade.Location = new Point(673, 112);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(75, 25);
            btnUpgrade.TabIndex = 45;
            btnUpgrade.Text = "Upgrade";
            btnUpgrade.UseVisualStyleBackColor = true;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Poppins", 8F);
            btnEdit.Location = new Point(306, 366);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 25);
            btnEdit.TabIndex = 46;
            btnEdit.Text = "Edit Data";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(83, 112);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 47;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(85, 128);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 83;
            labelTP.Text = "Maise Ivena L.";
            // 
            // labelprofile
            // 
            labelprofile.AutoSize = true;
            labelprofile.BackColor = Color.Transparent;
            labelprofile.Location = new Point(86, 156);
            labelprofile.Name = "labelprofile";
            labelprofile.Size = new Size(41, 15);
            labelprofile.TabIndex = 91;
            labelprofile.Text = "Profile";
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Location = new Point(86, 181);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(64, 15);
            labelDashboard.TabIndex = 92;
            labelDashboard.Text = "Dashboard";
            labelDashboard.Click += labelDashboard_Click;
            // 
            // labelEwallet
            // 
            labelEwallet.AutoSize = true;
            labelEwallet.BackColor = Color.Transparent;
            labelEwallet.Location = new Point(87, 210);
            labelEwallet.Name = "labelEwallet";
            labelEwallet.Size = new Size(40, 15);
            labelEwallet.TabIndex = 93;
            labelEwallet.Text = "Wallet";
            labelEwallet.Click += labelEwallet_Click;
            // 
            // ViewProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelEwallet);
            Controls.Add(labelDashboard);
            Controls.Add(labelprofile);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(btnEdit);
            Controls.Add(btnUpgrade);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ViewProfil";
            Text = "ViewProfil";
            Load += ViewProfil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnUpgrade;
        private Button btnEdit;
        private Label labelNama;
        private Label labelTP;
        private Label labelprofile;
        private Label labelDashboard;
        private Label labelEwallet;
    }
}