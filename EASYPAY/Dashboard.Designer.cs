namespace EASYPAY
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dataGridView1 = new DataGridView();
            Uang_keluar = new DataGridViewTextBoxColumn();
            Uang_Masuk = new DataGridViewTextBoxColumn();
            labelEmail = new Label();
            labelNama = new Label();
            pictureBackground = new PictureBox();
            label8 = new Label();
            labelDashboard = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureDashboard = new PictureBox();
            pictureBox1 = new PictureBox();
            labelSaldo = new Label();
            pictureListrik = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureListrik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Uang_keluar, Uang_Masuk });
            dataGridView1.Location = new Point(449, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 186);
            dataGridView1.TabIndex = 63;
            // 
            // Uang_keluar
            // 
            Uang_keluar.HeaderText = "Uang Keluar";
            Uang_keluar.Name = "Uang_keluar";
            // 
            // Uang_Masuk
            // 
            Uang_Masuk.HeaderText = "Uang Masuk";
            Uang_Masuk.Name = "Uang_Masuk";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Poppins", 5F);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(82, 124);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(93, 12);
            labelEmail.TabIndex = 39;
            labelEmail.Text = "maisecantik@gmail.com";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(80, 110);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 38;
            labelNama.Text = "Maise Ivena L.";
            // 
            // pictureBackground
            // 
            pictureBackground.Image = (Image)resources.GetObject("pictureBackground.Image");
            pictureBackground.Location = new Point(-2, -1);
            pictureBackground.Name = "pictureBackground";
            pictureBackground.Size = new Size(806, 508);
            pictureBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBackground.TabIndex = 0;
            pictureBackground.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(86, 299);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 73;
            label8.Text = "Saving";
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDashboard.ForeColor = Color.FromArgb(31, 148, 243);
            labelDashboard.Location = new Point(86, 198);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(59, 15);
            labelDashboard.TabIndex = 72;
            labelDashboard.Text = "Dashboard";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(86, 231);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 71;
            label5.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(85, 264);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 70;
            label4.Text = "Wallet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(85, 166);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 69;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.wallet;
            pictureBox5.Location = new Point(58, 261);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 68;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.card_receive;
            pictureBox4.Location = new Point(58, 295);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.wallet_add;
            pictureBox3.Location = new Point(58, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // pictureDashboard
            // 
            pictureDashboard.BackColor = Color.Transparent;
            pictureDashboard.Image = Properties.Resources.hashtag;
            pictureDashboard.Location = new Point(58, 195);
            pictureDashboard.Name = "pictureDashboard";
            pictureDashboard.Size = new Size(19, 21);
            pictureDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDashboard.TabIndex = 65;
            pictureDashboard.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.person__1_1;
            pictureBox1.Location = new Point(58, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.ForeColor = Color.White;
            labelSaldo.Location = new Point(277, 396);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(51, 15);
            labelSaldo.TabIndex = 74;
            labelSaldo.Text = "Rp. 1000";
            // 
            // pictureListrik
            // 
            pictureListrik.Image = (Image)resources.GetObject("pictureListrik.Image");
            pictureListrik.Location = new Point(277, 83);
            pictureListrik.Name = "pictureListrik";
            pictureListrik.Size = new Size(34, 35);
            pictureListrik.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureListrik.TabIndex = 75;
            pictureListrik.TabStop = false;
            pictureListrik.Click += pictureListrik_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(351, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 76;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(423, 83);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 77;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icon__3_;
            pictureBox7.Location = new Point(500, 83);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 78;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureListrik);
            Controls.Add(labelSaldo);
            Controls.Add(label8);
            Controls.Add(labelDashboard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureDashboard);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelEmail);
            Controls.Add(labelNama);
            Controls.Add(pictureBackground);
            Name = "Dashboard";
            Text = "FormDashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureListrik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Uang_keluar;
        private DataGridViewTextBoxColumn Uang_Masuk;
        private Label labelEmail;
        private Label labelNama;
        private PictureBox pictureBackground;
        private Label label8;
        private Label labelDashboard;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureDashboard;
        private PictureBox pictureBox1;
        private Label labelSaldo;
        private PictureBox pictureListrik;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}