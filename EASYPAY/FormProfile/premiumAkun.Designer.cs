namespace EASYPAY.FormProfile
{
    partial class premiumAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(premiumAkun));
            picture = new PictureBox();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = Properties.Resources.Frame_502;
            picture.Location = new Point(335, 216);
            picture.Name = "picture";
            picture.Size = new Size(269, 133);
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(418, 407);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(103, 23);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload Identitas";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // premiumAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(btnUpload);
            Controls.Add(picture);
            DoubleBuffered = true;
            Name = "premiumAkun";
            Text = "premiumAkun";
            Load += premiumAkun_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picture;
        private Button btnUpload;
    }
}