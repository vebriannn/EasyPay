namespace EASYPAY.FormProfile
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            pictureBox1 = new PictureBox();
            btnGanti = new Button();
            btnCancel = new Button();
            textNama = new TextBox();
            textGender = new TextBox();
            textNomor = new TextBox();
            textPin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnGanti
            // 
            btnGanti.Font = new Font("Poppins", 8F);
            btnGanti.Location = new Point(262, 366);
            btnGanti.Name = "btnGanti";
            btnGanti.Size = new Size(75, 25);
            btnGanti.TabIndex = 47;
            btnGanti.Text = "Perbarui";
            btnGanti.UseVisualStyleBackColor = true;
            btnGanti.Click += btnGanti_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Poppins", 8F);
            btnCancel.Location = new Point(390, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 25);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Batal Perbarui";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textNama
            // 
            textNama.BorderStyle = BorderStyle.None;
            textNama.Location = new Point(251, 114);
            textNama.Multiline = true;
            textNama.Name = "textNama";
            textNama.Size = new Size(221, 18);
            textNama.TabIndex = 49;
            // 
            // textGender
            // 
            textGender.BorderStyle = BorderStyle.None;
            textGender.Location = new Point(251, 179);
            textGender.Multiline = true;
            textGender.Name = "textGender";
            textGender.Size = new Size(221, 18);
            textGender.TabIndex = 50;
            // 
            // textNomor
            // 
            textNomor.BorderStyle = BorderStyle.None;
            textNomor.Location = new Point(251, 244);
            textNomor.Multiline = true;
            textNomor.Name = "textNomor";
            textNomor.Size = new Size(221, 18);
            textNomor.TabIndex = 51;
            // 
            // textPin
            // 
            textPin.BorderStyle = BorderStyle.None;
            textPin.Location = new Point(251, 315);
            textPin.Multiline = true;
            textPin.Name = "textPin";
            textPin.Size = new Size(221, 18);
            textPin.TabIndex = 52;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(textPin);
            Controls.Add(textNomor);
            Controls.Add(textGender);
            Controls.Add(textNama);
            Controls.Add(btnCancel);
            Controls.Add(btnGanti);
            Controls.Add(pictureBox1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGanti;
        private Button btnCancel;
        private TextBox textNama;
        private TextBox textGender;
        private TextBox textNomor;
        private TextBox textPin;
    }
}