namespace EASYPAY
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            pictureBox1 = new PictureBox();
            textNomor = new TextBox();
            textPin = new TextBox();
            BtnLinkSignUp = new Button();
            BtnSignIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textNomor
            // 
            textNomor.BorderStyle = BorderStyle.None;
            textNomor.Location = new Point(269, 176);
            textNomor.Multiline = true;
            textNomor.Name = "textNomor";
            textNomor.Size = new Size(259, 22);
            textNomor.TabIndex = 6;
            // 
            // textPin
            // 
            textPin.BorderStyle = BorderStyle.None;
            textPin.Location = new Point(270, 271);
            textPin.Multiline = true;
            textPin.Name = "textPin";
            textPin.Size = new Size(259, 23);
            textPin.TabIndex = 7;
            // 
            // BtnLinkSignUp
            // 
            BtnLinkSignUp.BackColor = Color.White;
            BtnLinkSignUp.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLinkSignUp.Location = new Point(437, 312);
            BtnLinkSignUp.Name = "BtnLinkSignUp";
            BtnLinkSignUp.Size = new Size(67, 26);
            BtnLinkSignUp.TabIndex = 9;
            BtnLinkSignUp.Text = "Sign Up";
            BtnLinkSignUp.UseVisualStyleBackColor = false;
            // 
            // BtnSignIn
            // 
            BtnSignIn.BackColor = Color.White;
            BtnSignIn.Font = new Font("Poppins", 14F);
            BtnSignIn.Location = new Point(333, 349);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(101, 36);
            BtnSignIn.TabIndex = 11;
            BtnSignIn.Text = "Sign In";
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // FormSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSignIn);
            Controls.Add(BtnLinkSignUp);
            Controls.Add(textPin);
            Controls.Add(textNomor);
            Controls.Add(pictureBox1);
            Name = "FormSignIn";
            Text = "Signin";
            Load += FormSignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textNomor;
        private TextBox textPin;
        private Button BtnLinkSignUp;
        private Button BtnSignIn;
    }
}