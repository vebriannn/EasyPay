namespace EASYPAY.FormPLN
{
    partial class CheckPln
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPln));
            pictureBox1 = new PictureBox();
            textCheckNomor = new TextBox();
            BtnCheckReg = new Button();
            labelNama = new Label();
            labelTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textCheckNomor
            // 
            textCheckNomor.BorderStyle = BorderStyle.None;
            textCheckNomor.Location = new Point(241, 176);
            textCheckNomor.Margin = new Padding(2);
            textCheckNomor.Name = "textCheckNomor";
            textCheckNomor.Size = new Size(217, 16);
            textCheckNomor.TabIndex = 34;
            // 
            // BtnCheckReg
            // 
            BtnCheckReg.Font = new Font("Poppins", 8F);
            BtnCheckReg.Location = new Point(254, 212);
            BtnCheckReg.Name = "BtnCheckReg";
            BtnCheckReg.Size = new Size(193, 23);
            BtnCheckReg.TabIndex = 39;
            BtnCheckReg.Text = "Check Meteran";
            BtnCheckReg.UseVisualStyleBackColor = true;
            BtnCheckReg.Click += BtnCheckReg_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(81, 110);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 40;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(83, 124);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 83;
            labelTP.Text = "Maise Ivena L.";
            // 
            // CheckPln
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(BtnCheckReg);
            Controls.Add(textCheckNomor);
            Controls.Add(pictureBox1);
            Name = "CheckPln";
            Text = "CheckPln";
            Load += CheckPln_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textCheckNomor;
        private Button BtnCheckReg;
        private Label labelNama;
        private Label labelTP;
    }
}