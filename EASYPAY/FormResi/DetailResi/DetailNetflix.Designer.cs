namespace EASYPAY.FormResi.DetailResi
{
    partial class DetailNetflix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailNetflix));
            labelNoTrx = new Label();
            labelTgl = new Label();
            labelHarga = new Label();
            labelKP = new Label();
            labelP = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNoTrx
            // 
            labelNoTrx.AutoSize = true;
            labelNoTrx.BackColor = SystemColors.ActiveCaptionText;
            labelNoTrx.Font = new Font("Poppins", 8F);
            labelNoTrx.ForeColor = Color.White;
            labelNoTrx.Location = new Point(410, 191);
            labelNoTrx.Name = "labelNoTrx";
            labelNoTrx.Size = new Size(40, 19);
            labelNoTrx.TabIndex = 3;
            labelNoTrx.Text = "label1";
            // 
            // labelTgl
            // 
            labelTgl.AutoSize = true;
            labelTgl.BackColor = SystemColors.ActiveCaptionText;
            labelTgl.Font = new Font("Poppins", 8F);
            labelTgl.ForeColor = Color.White;
            labelTgl.Location = new Point(410, 264);
            labelTgl.Name = "labelTgl";
            labelTgl.Size = new Size(40, 19);
            labelTgl.TabIndex = 10;
            labelTgl.Text = "label1";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = SystemColors.ActiveCaptionText;
            labelHarga.Font = new Font("Poppins", 8F);
            labelHarga.ForeColor = Color.White;
            labelHarga.Location = new Point(410, 245);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(40, 19);
            labelHarga.TabIndex = 11;
            labelHarga.Text = "label1";
            // 
            // labelKP
            // 
            labelKP.AutoSize = true;
            labelKP.BackColor = SystemColors.ActiveCaptionText;
            labelKP.Font = new Font("Poppins", 8F);
            labelKP.ForeColor = Color.White;
            labelKP.Location = new Point(410, 210);
            labelKP.Name = "labelKP";
            labelKP.Size = new Size(40, 19);
            labelKP.TabIndex = 12;
            labelKP.Text = "label1";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = SystemColors.ActiveCaptionText;
            labelP.Font = new Font("Poppins", 8F);
            labelP.ForeColor = Color.White;
            labelP.Location = new Point(410, 229);
            labelP.Name = "labelP";
            labelP.Size = new Size(40, 19);
            labelP.TabIndex = 14;
            labelP.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(68, 437);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 15;
            button1.Text = "Kembali ke Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DetailNetflix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button1);
            Controls.Add(labelP);
            Controls.Add(labelKP);
            Controls.Add(labelHarga);
            Controls.Add(labelTgl);
            Controls.Add(labelNoTrx);
            DoubleBuffered = true;
            Name = "DetailNetflix";
            Text = "DetailNetflix";
            Load += DetailNetflix_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNoTrx;
        private Label labelTgl;
        private Label labelHarga;
        private Label labelKP;
        private Label labelP;
        private Button button1;
    }
}