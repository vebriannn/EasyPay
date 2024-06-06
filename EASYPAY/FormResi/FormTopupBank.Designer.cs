namespace EASYPAY.FormResi
{
    partial class FormTopupBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopupBank));
            labelAN = new Label();
            labelJumlah = new Label();
            labeltanggal = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelAN
            // 
            labelAN.AutoSize = true;
            labelAN.BackColor = SystemColors.ActiveCaptionText;
            labelAN.Font = new Font("Poppins", 8F);
            labelAN.ForeColor = Color.White;
            labelAN.Location = new Point(414, 208);
            labelAN.Name = "labelAN";
            labelAN.Size = new Size(40, 19);
            labelAN.TabIndex = 2;
            labelAN.Text = "label1";
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.BackColor = SystemColors.ActiveCaptionText;
            labelJumlah.Font = new Font("Poppins", 8F);
            labelJumlah.ForeColor = Color.White;
            labelJumlah.Location = new Point(414, 227);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(40, 19);
            labelJumlah.TabIndex = 3;
            labelJumlah.Text = "label1";
            // 
            // labeltanggal
            // 
            labeltanggal.AutoSize = true;
            labeltanggal.BackColor = SystemColors.ActiveCaptionText;
            labeltanggal.Font = new Font("Poppins", 8F);
            labeltanggal.ForeColor = Color.White;
            labeltanggal.Location = new Point(414, 246);
            labeltanggal.Name = "labeltanggal";
            labeltanggal.Size = new Size(40, 19);
            labeltanggal.TabIndex = 4;
            labeltanggal.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(73, 435);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 6;
            button1.Text = "Kembali ke Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormTopupBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button1);
            Controls.Add(labeltanggal);
            Controls.Add(labelJumlah);
            Controls.Add(labelAN);
            DoubleBuffered = true;
            Name = "FormTopupBank";
            Text = "FormTopupBank";
            Load += FormTopupBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAN;
        private Label labelJumlah;
        private Label labeltanggal;
        private Button button1;
    }
}