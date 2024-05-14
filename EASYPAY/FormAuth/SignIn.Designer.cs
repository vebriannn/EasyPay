namespace EASYPAY.FormAuth
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            BtnSignIn = new Button();
            textNomor = new TextBox();
            textPin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnSignIn
            // 
            BtnSignIn.BackColor = Color.White;
            BtnSignIn.Font = new Font("Poppins", 10F);
            BtnSignIn.Location = new Point(369, 317);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(71, 28);
            BtnSignIn.TabIndex = 14;
            BtnSignIn.Text = "Sign In";
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // textNomor
            // 
            textNomor.BorderStyle = BorderStyle.None;
            textNomor.Location = new Point(276, 207);
            textNomor.Multiline = true;
            textNomor.Name = "textNomor";
            textNomor.Size = new Size(249, 21);
            textNomor.TabIndex = 18;
            // 
            // textPin
            // 
            textPin.BorderStyle = BorderStyle.None;
            textPin.Location = new Point(276, 275);
            textPin.Multiline = true;
            textPin.Name = "textPin";
            textPin.Size = new Size(249, 21);
            textPin.TabIndex = 19;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(textPin);
            Controls.Add(textNomor);
            Controls.Add(BtnSignIn);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            Text = "SignIn";
            Load += SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnSignIn;
        private TextBox textNomor;
        private TextBox textPin;
    }
}