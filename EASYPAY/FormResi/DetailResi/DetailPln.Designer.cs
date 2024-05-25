namespace EASYPAY.FormResi.DetailResi
{
    partial class DetailPln
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPln));
            pictureBox1 = new PictureBox();
            labelNoTrx = new Label();
            labelNama = new Label();
            labelKwh = new Label();
            labelHarga = new Label();
            labelToken = new Label();
            labelMeteran = new Label();
            labelTgl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNoTrx
            // 
            labelNoTrx.AutoSize = true;
            labelNoTrx.BackColor = SystemColors.ActiveCaptionText;
            labelNoTrx.Font = new Font("Poppins", 8F);
            labelNoTrx.ForeColor = Color.White;
            labelNoTrx.Location = new Point(411, 175);
            labelNoTrx.Name = "labelNoTrx";
            labelNoTrx.Size = new Size(40, 19);
            labelNoTrx.TabIndex = 1;
            labelNoTrx.Text = "label1";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = SystemColors.ActiveCaptionText;
            labelNama.Font = new Font("Poppins", 8F);
            labelNama.ForeColor = Color.White;
            labelNama.Location = new Point(411, 193);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(40, 19);
            labelNama.TabIndex = 2;
            labelNama.Text = "label1";
            // 
            // labelKwh
            // 
            labelKwh.AutoSize = true;
            labelKwh.BackColor = SystemColors.ActiveCaptionText;
            labelKwh.Font = new Font("Poppins", 8F);
            labelKwh.ForeColor = Color.White;
            labelKwh.Location = new Point(411, 229);
            labelKwh.Name = "labelKwh";
            labelKwh.Size = new Size(40, 19);
            labelKwh.TabIndex = 3;
            labelKwh.Text = "label1";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = SystemColors.ActiveCaptionText;
            labelHarga.Font = new Font("Poppins", 8F);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(411, 247);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(40, 19);
            labelHarga.TabIndex = 4;
            labelHarga.Text = "label1";
            // 
            // labelToken
            // 
            labelToken.AutoSize = true;
            labelToken.BackColor = SystemColors.ActiveCaptionText;
            labelToken.Font = new Font("Poppins", 8F);
            labelToken.ForeColor = Color.White;
            labelToken.Location = new Point(411, 265);
            labelToken.Name = "labelToken";
            labelToken.Size = new Size(40, 19);
            labelToken.TabIndex = 5;
            labelToken.Text = "label1";
            // 
            // labelMeteran
            // 
            labelMeteran.AutoSize = true;
            labelMeteran.BackColor = SystemColors.ActiveCaptionText;
            labelMeteran.Font = new Font("Poppins", 8F);
            labelMeteran.ForeColor = Color.White;
            labelMeteran.Location = new Point(411, 211);
            labelMeteran.Name = "labelMeteran";
            labelMeteran.Size = new Size(40, 19);
            labelMeteran.TabIndex = 6;
            labelMeteran.Text = "label1";
            // 
            // labelTgl
            // 
            labelTgl.AutoSize = true;
            labelTgl.BackColor = SystemColors.ActiveCaptionText;
            labelTgl.Font = new Font("Poppins", 8F);
            labelTgl.ForeColor = Color.White;
            labelTgl.Location = new Point(411, 284);
            labelTgl.Name = "labelTgl";
            labelTgl.Size = new Size(40, 19);
            labelTgl.TabIndex = 7;
            labelTgl.Text = "label1";
            labelTgl.Click += labelTgl_Click;
            // 
            // DetailPln
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTgl);
            Controls.Add(labelMeteran);
            Controls.Add(labelToken);
            Controls.Add(labelHarga);
            Controls.Add(labelKwh);
            Controls.Add(labelNama);
            Controls.Add(labelNoTrx);
            Controls.Add(pictureBox1);
            Name = "DetailPln";
            Text = "Detail";
            Load += Detail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNoTrx;
        private Label labelNama;
        private Label labelKwh;
        private Label labelHarga;
        private Label labelToken;
        private Label labelMeteran;
        private Label labelTgl;
    }
}