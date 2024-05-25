namespace EASYPAY.FormResi.DetailResi
{
    partial class DetailPdam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPdam));
            pictureBox1 = new PictureBox();
            labelNoTrx = new Label();
            labelNama = new Label();
            labelMeteran = new Label();
            labelHarga = new Label();
            labelTgl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 504);
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
            labelNoTrx.Location = new Point(410, 196);
            labelNoTrx.Name = "labelNoTrx";
            labelNoTrx.Size = new Size(40, 19);
            labelNoTrx.TabIndex = 2;
            labelNoTrx.Text = "label1";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = SystemColors.ActiveCaptionText;
            labelNama.Font = new Font("Poppins", 8F);
            labelNama.ForeColor = Color.White;
            labelNama.Location = new Point(410, 214);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(40, 19);
            labelNama.TabIndex = 3;
            labelNama.Text = "label1";
            // 
            // labelMeteran
            // 
            labelMeteran.AutoSize = true;
            labelMeteran.BackColor = SystemColors.ActiveCaptionText;
            labelMeteran.Font = new Font("Poppins", 8F);
            labelMeteran.ForeColor = Color.White;
            labelMeteran.Location = new Point(410, 233);
            labelMeteran.Name = "labelMeteran";
            labelMeteran.Size = new Size(40, 19);
            labelMeteran.TabIndex = 7;
            labelMeteran.Text = "label1";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = SystemColors.ActiveCaptionText;
            labelHarga.Font = new Font("Poppins", 8F);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(410, 252);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(40, 19);
            labelHarga.TabIndex = 8;
            labelHarga.Text = "label1";
            // 
            // labelTgl
            // 
            labelTgl.AutoSize = true;
            labelTgl.BackColor = SystemColors.ActiveCaptionText;
            labelTgl.Font = new Font("Poppins", 8F);
            labelTgl.ForeColor = Color.White;
            labelTgl.Location = new Point(410, 270);
            labelTgl.Name = "labelTgl";
            labelTgl.Size = new Size(40, 19);
            labelTgl.TabIndex = 9;
            labelTgl.Text = "label1";
            // 
            // DetailPdam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTgl);
            Controls.Add(labelHarga);
            Controls.Add(labelMeteran);
            Controls.Add(labelNama);
            Controls.Add(labelNoTrx);
            Controls.Add(pictureBox1);
            Name = "DetailPdam";
            Text = "DetailPdam";
            Load += DetailPdam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNoTrx;
        private Label labelNama;
        private Label labelMeteran;
        private Label labelHarga;
        private Label labelTgl;
    }
}