namespace EASYPAY.FormResi.DetailResi
{
    partial class DetailPulsaData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPulsaData));
            pictureBox1 = new PictureBox();
            labelNoTrx = new Label();
            labelHarga = new Label();
            labelTgl = new Label();
            labelKP = new Label();
            labelNomor = new Label();
            labelP = new Label();
            labelS = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 503);
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
            labelNoTrx.Location = new Point(399, 174);
            labelNoTrx.Name = "labelNoTrx";
            labelNoTrx.Size = new Size(40, 19);
            labelNoTrx.TabIndex = 3;
            labelNoTrx.Text = "label1";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = SystemColors.ActiveCaptionText;
            labelHarga.Font = new Font("Poppins", 8F);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(399, 247);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(40, 19);
            labelHarga.TabIndex = 9;
            labelHarga.Text = "label1";
            // 
            // labelTgl
            // 
            labelTgl.AutoSize = true;
            labelTgl.BackColor = SystemColors.ActiveCaptionText;
            labelTgl.Font = new Font("Poppins", 8F);
            labelTgl.ForeColor = Color.White;
            labelTgl.Location = new Point(399, 282);
            labelTgl.Name = "labelTgl";
            labelTgl.Size = new Size(40, 19);
            labelTgl.TabIndex = 10;
            labelTgl.Text = "label1";
            // 
            // labelKP
            // 
            labelKP.AutoSize = true;
            labelKP.BackColor = SystemColors.ActiveCaptionText;
            labelKP.Font = new Font("Poppins", 8F);
            labelKP.ForeColor = Color.White;
            labelKP.Location = new Point(399, 192);
            labelKP.Name = "labelKP";
            labelKP.Size = new Size(40, 19);
            labelKP.TabIndex = 11;
            labelKP.Text = "label1";
            // 
            // labelNomor
            // 
            labelNomor.AutoSize = true;
            labelNomor.BackColor = SystemColors.ActiveCaptionText;
            labelNomor.Font = new Font("Poppins", 8F);
            labelNomor.ForeColor = Color.White;
            labelNomor.Location = new Point(399, 211);
            labelNomor.Name = "labelNomor";
            labelNomor.Size = new Size(40, 19);
            labelNomor.TabIndex = 12;
            labelNomor.Text = "label1";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = SystemColors.ActiveCaptionText;
            labelP.Font = new Font("Poppins", 8F);
            labelP.ForeColor = Color.White;
            labelP.Location = new Point(399, 229);
            labelP.Name = "labelP";
            labelP.Size = new Size(40, 19);
            labelP.TabIndex = 13;
            labelP.Text = "label1";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.BackColor = SystemColors.ActiveCaptionText;
            labelS.Font = new Font("Poppins", 8F);
            labelS.ForeColor = Color.White;
            labelS.Location = new Point(399, 264);
            labelS.Name = "labelS";
            labelS.Size = new Size(40, 19);
            labelS.TabIndex = 14;
            labelS.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(71, 433);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 15;
            button1.Text = "Kembali ke Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DetailPulsaData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button1);
            Controls.Add(labelS);
            Controls.Add(labelP);
            Controls.Add(labelNomor);
            Controls.Add(labelKP);
            Controls.Add(labelTgl);
            Controls.Add(labelHarga);
            Controls.Add(labelNoTrx);
            Controls.Add(pictureBox1);
            Name = "DetailPulsaData";
            Text = "DetailPulsaData";
            Load += DetailPulsaData_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNoTrx;
        private Label labelHarga;
        private Label labelTgl;
        private Label labelKP;
        private Label labelNomor;
        private Label labelP;
        private Label labelS;
        private Button button1;
    }
}