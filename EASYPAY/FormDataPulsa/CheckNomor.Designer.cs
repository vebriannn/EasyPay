namespace EASYPAY.FormDataPulsa
{
    partial class CheckNomor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckNomor));
            pictureBox1 = new PictureBox();
            btnPulsa = new Button();
            btnData = new Button();
            btnCheckNumber = new Button();
            textNumber = new TextBox();
            labelNama = new Label();
            labelTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPulsa
            // 
            btnPulsa.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPulsa.Location = new Point(273, 227);
            btnPulsa.Name = "btnPulsa";
            btnPulsa.Size = new Size(51, 23);
            btnPulsa.TabIndex = 1;
            btnPulsa.Text = "Pulsa";
            btnPulsa.UseVisualStyleBackColor = true;
            btnPulsa.Click += btnPulsa_Click;
            // 
            // btnData
            // 
            btnData.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnData.Location = new Point(273, 275);
            btnData.Name = "btnData";
            btnData.Size = new Size(47, 23);
            btnData.TabIndex = 2;
            btnData.Text = "Data";
            btnData.UseVisualStyleBackColor = true;
            btnData.Click += btnData_Click;
            // 
            // btnCheckNumber
            // 
            btnCheckNumber.Font = new Font("Poppins", 8F);
            btnCheckNumber.Location = new Point(467, 171);
            btnCheckNumber.Name = "btnCheckNumber";
            btnCheckNumber.Size = new Size(120, 24);
            btnCheckNumber.TabIndex = 3;
            btnCheckNumber.Text = "Check Nomor";
            btnCheckNumber.UseVisualStyleBackColor = true;
            btnCheckNumber.Click += btnCheckNumber_Click;
            // 
            // textNumber
            // 
            textNumber.BorderStyle = BorderStyle.None;
            textNumber.Location = new Point(234, 176);
            textNumber.Name = "textNumber";
            textNumber.Size = new Size(217, 16);
            textNumber.TabIndex = 4;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(82, 108);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 43;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(83, 122);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 86;
            labelTP.Text = "Maise Ivena L.";
            // 
            // CheckNomor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(textNumber);
            Controls.Add(btnCheckNumber);
            Controls.Add(btnData);
            Controls.Add(btnPulsa);
            Controls.Add(pictureBox1);
            Name = "CheckNomor";
            Text = "CheckNomor";
            Load += CheckNomor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPulsa;
        private Button btnData;
        private Button btnCheckNumber;
        private TextBox textNumber;
        private Label labelNama;
        private Label labelTP;
    }
}