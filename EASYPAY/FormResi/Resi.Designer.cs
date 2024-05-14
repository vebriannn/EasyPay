using EASYPAY.FormPLN;

namespace EASYPAY.FormHslPbyr
{
    partial class Resi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resi));
            labelNoTrx = new Label();
            labelJP = new Label();
            labelHarga = new Label();
            labelDate = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNoTrx
            // 
            labelNoTrx.AutoSize = true;
            labelNoTrx.BackColor = SystemColors.ActiveCaptionText;
            labelNoTrx.Font = new Font("Poppins", 7F);
            labelNoTrx.ForeColor = Color.White;
            labelNoTrx.Location = new Point(412, 300);
            labelNoTrx.Name = "labelNoTrx";
            labelNoTrx.Size = new Size(35, 17);
            labelNoTrx.TabIndex = 0;
            labelNoTrx.Text = "label1";
            // 
            // labelJP
            // 
            labelJP.AutoSize = true;
            labelJP.BackColor = SystemColors.ActiveCaptionText;
            labelJP.Font = new Font("Poppins", 7F);
            labelJP.ForeColor = Color.White;
            labelJP.Location = new Point(412, 317);
            labelJP.Name = "labelJP";
            labelJP.Size = new Size(35, 17);
            labelJP.TabIndex = 1;
            labelJP.Text = "label1";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = SystemColors.ActiveCaptionText;
            labelHarga.Font = new Font("Poppins", 7F);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(412, 334);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(35, 17);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "label1";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = SystemColors.ActiveCaptionText;
            labelDate.Font = new Font("Poppins", 7F);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(412, 351);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 17);
            labelDate.TabIndex = 3;
            labelDate.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Resi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelDate);
            Controls.Add(labelHarga);
            Controls.Add(labelJP);
            Controls.Add(labelNoTrx);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Resi";
            Text = "ResultsTrx";
            Load += Resi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNoTrx;
        private Label labelJP;
        private Label labelHarga;
        private Label labelDate;
        private PictureBox pictureBox1;
    }
}