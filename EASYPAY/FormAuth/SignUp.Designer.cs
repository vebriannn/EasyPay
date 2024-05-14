namespace EASYPAY.FormAuth
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            BtnSignUp = new Button();
            textCreateNama = new TextBox();
            textCreateEmail = new TextBox();
            textCreateNomor = new TextBox();
            textCreatePin = new TextBox();
            textKonfirmasiPin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnSignUp
            // 
            BtnSignUp.BackColor = Color.White;
            BtnSignUp.Font = new Font("Poppins", 10F);
            BtnSignUp.Location = new Point(370, 424);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(71, 28);
            BtnSignUp.TabIndex = 13;
            BtnSignUp.Text = "Sign Up";
            BtnSignUp.UseVisualStyleBackColor = false;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // textCreateNama
            // 
            textCreateNama.BorderStyle = BorderStyle.None;
            textCreateNama.Location = new Point(275, 111);
            textCreateNama.Multiline = true;
            textCreateNama.Name = "textCreateNama";
            textCreateNama.Size = new Size(249, 21);
            textCreateNama.TabIndex = 15;
            // 
            // textCreateEmail
            // 
            textCreateEmail.BorderStyle = BorderStyle.None;
            textCreateEmail.Location = new Point(275, 178);
            textCreateEmail.Multiline = true;
            textCreateEmail.Name = "textCreateEmail";
            textCreateEmail.Size = new Size(249, 21);
            textCreateEmail.TabIndex = 16;
            // 
            // textCreateNomor
            // 
            textCreateNomor.BorderStyle = BorderStyle.None;
            textCreateNomor.Location = new Point(276, 246);
            textCreateNomor.Multiline = true;
            textCreateNomor.Name = "textCreateNomor";
            textCreateNomor.Size = new Size(249, 21);
            textCreateNomor.TabIndex = 17;
            // 
            // textCreatePin
            // 
            textCreatePin.BorderStyle = BorderStyle.None;
            textCreatePin.Location = new Point(276, 313);
            textCreatePin.Multiline = true;
            textCreatePin.Name = "textCreatePin";
            textCreatePin.Size = new Size(249, 21);
            textCreatePin.TabIndex = 18;
            // 
            // textKonfirmasiPin
            // 
            textKonfirmasiPin.BorderStyle = BorderStyle.None;
            textKonfirmasiPin.Location = new Point(276, 381);
            textKonfirmasiPin.Multiline = true;
            textKonfirmasiPin.Name = "textKonfirmasiPin";
            textKonfirmasiPin.Size = new Size(249, 21);
            textKonfirmasiPin.TabIndex = 19;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(textKonfirmasiPin);
            Controls.Add(textCreatePin);
            Controls.Add(textCreateNomor);
            Controls.Add(textCreateEmail);
            Controls.Add(textCreateNama);
            Controls.Add(BtnSignUp);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnSignUp;
        private TextBox textCreateNama;
        private TextBox textCreateEmail;
        private TextBox textCreateNomor;
        private TextBox textCreatePin;
        private TextBox textKonfirmasiPin;
    }
}