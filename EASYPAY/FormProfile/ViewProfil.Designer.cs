namespace EASYPAY.profile
{
    partial class ViewProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfil));
            pictureBox1 = new PictureBox();
            labelEmail = new Label();
            labelNama = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Poppins", 5F);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(82, 124);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(93, 12);
            labelEmail.TabIndex = 39;
            labelEmail.Text = "maisecantik@gmail.com";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(80, 110);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 38;
            labelNama.Text = "Maise Ivena L.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 117);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 40;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 181);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 41;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 245);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 42;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 314);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 43;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 116);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 44;
            label5.Text = "label5";
            // 
            // ViewProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelEmail);
            Controls.Add(labelNama);
            Controls.Add(pictureBox1);
            Name = "ViewProfil";
            Text = "ViewProfil";
            Load += ViewProfil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelEmail;
        private Label labelNama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}