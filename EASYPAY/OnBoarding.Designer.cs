namespace EASYPAY
{
    partial class OnBoarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnBoarding));
            pictureBox1 = new PictureBox();
            BtnLinkSignIn = new Button();
            label1 = new Label();
            BtnLinkSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 458);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnLinkSignIn
            // 
            BtnLinkSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnLinkSignIn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLinkSignIn.Location = new Point(518, 281);
            BtnLinkSignIn.Name = "BtnLinkSignIn";
            BtnLinkSignIn.Size = new Size(60, 28);
            BtnLinkSignIn.TabIndex = 1;
            BtnLinkSignIn.Text = "Sign In";
            BtnLinkSignIn.UseVisualStyleBackColor = true;
            BtnLinkSignIn.Click += BtnLinkSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.95F);
            label1.Location = new Point(575, 283);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 2;
            label1.Text = "or";
            // 
            // BtnLinkSignUp
            // 
            BtnLinkSignUp.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLinkSignUp.Location = new Point(598, 280);
            BtnLinkSignUp.Name = "BtnLinkSignUp";
            BtnLinkSignUp.Size = new Size(67, 28);
            BtnLinkSignUp.TabIndex = 3;
            BtnLinkSignUp.Text = "Sign Up";
            BtnLinkSignUp.UseVisualStyleBackColor = true;
            BtnLinkSignUp.Click += BtnLinkSignUp_Click;
            // 
            // FormOnBoarding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLinkSignUp);
            Controls.Add(label1);
            Controls.Add(BtnLinkSignIn);
            Controls.Add(pictureBox1);
            Name = "FormOnBoarding";
            StartPosition = FormStartPosition.Manual;
            Text = "onboarding";
            Load += onboarding_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnLinkSignIn;
        private Label label1;
        private Button BtnLinkSignUp;
    }
}