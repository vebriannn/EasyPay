namespace EASYPAY
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            pictureBox1 = new PictureBox();
            textCreateNama = new TextBox();
            textCreateNomor = new TextBox();
            textCreatePin = new TextBox();
            BtnLinkSignIn = new Button();
            BtnSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-104, -80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1004, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textCreateNama
            // 
            textCreateNama.BorderStyle = BorderStyle.None;
            textCreateNama.Location = new Point(273, 119);
            textCreateNama.Multiline = true;
            textCreateNama.Name = "textCreateNama";
            textCreateNama.Size = new Size(249, 22);
            textCreateNama.TabIndex = 7;
            // 
            // textCreateNomor
            // 
            textCreateNomor.BorderStyle = BorderStyle.None;
            textCreateNomor.Location = new Point(273, 205);
            textCreateNomor.Multiline = true;
            textCreateNomor.Name = "textCreateNomor";
            textCreateNomor.Size = new Size(249, 22);
            textCreateNomor.TabIndex = 8;
            // 
            // textCreatePin
            // 
            textCreatePin.BorderStyle = BorderStyle.None;
            textCreatePin.Location = new Point(273, 290);
            textCreatePin.Multiline = true;
            textCreatePin.Name = "textCreatePin";
            textCreatePin.Size = new Size(249, 22);
            textCreatePin.TabIndex = 9;
            // 
            // BtnLinkSignIn
            // 
            BtnLinkSignIn.BackColor = Color.White;
            BtnLinkSignIn.Font = new Font("Poppins", 8F);
            BtnLinkSignIn.Location = new Point(397, 325);
            BtnLinkSignIn.Name = "BtnLinkSignIn";
            BtnLinkSignIn.Size = new Size(54, 26);
            BtnLinkSignIn.TabIndex = 10;
            BtnLinkSignIn.Text = "Sign In";
            BtnLinkSignIn.UseVisualStyleBackColor = false;
            BtnLinkSignIn.Click += BtnLinkSignIn_Click;
            // 
            // BtnSignUp
            // 
            BtnSignUp.BackColor = Color.White;
            BtnSignUp.Font = new Font("Poppins", 12F);
            BtnSignUp.Location = new Point(350, 359);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(95, 35);
            BtnSignUp.TabIndex = 12;
            BtnSignUp.Text = "Sign Up";
            BtnSignUp.UseVisualStyleBackColor = false;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSignUp);
            Controls.Add(BtnLinkSignIn);
            Controls.Add(textCreatePin);
            Controls.Add(textCreateNomor);
            Controls.Add(textCreateNama);
            Controls.Add(pictureBox1);
            Name = "FormSignUp";
            Text = "FormSignUp";
            Load += FormSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textCreateNama;
        private TextBox textCreateNomor;
        private TextBox textCreatePin;
        private Button BtnLinkSignIn;
        private Button BtnSignUp;
    }
}