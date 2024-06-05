namespace EASYPAY.FormResi
{
    partial class ResiTF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResiTF));
            labelSend = new Label();
            labelAmount = new Label();
            labelDate = new Label();
            labelFee = new Label();
            SuspendLayout();
            // 
            // labelSend
            // 
            labelSend.AutoSize = true;
            labelSend.BackColor = SystemColors.ActiveCaptionText;
            labelSend.Font = new Font("Poppins", 8F);
            labelSend.ForeColor = Color.White;
            labelSend.Location = new Point(409, 201);
            labelSend.Name = "labelSend";
            labelSend.Size = new Size(40, 19);
            labelSend.TabIndex = 1;
            labelSend.Text = "label1";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.BackColor = SystemColors.ActiveCaptionText;
            labelAmount.Font = new Font("Poppins", 8F);
            labelAmount.ForeColor = Color.White;
            labelAmount.Location = new Point(409, 220);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(40, 19);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "label1";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = SystemColors.ActiveCaptionText;
            labelDate.Font = new Font("Poppins", 8F);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(409, 239);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(40, 19);
            labelDate.TabIndex = 3;
            labelDate.Text = "label1";
            // 
            // labelFee
            // 
            labelFee.AutoSize = true;
            labelFee.BackColor = SystemColors.ActiveCaptionText;
            labelFee.Font = new Font("Poppins", 8F);
            labelFee.ForeColor = Color.White;
            labelFee.Location = new Point(409, 258);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(40, 19);
            labelFee.TabIndex = 4;
            labelFee.Text = "label1";
            // 
            // ResiTF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelFee);
            Controls.Add(labelDate);
            Controls.Add(labelAmount);
            Controls.Add(labelSend);
            DoubleBuffered = true;
            Name = "ResiTF";
            Text = "ResiTF";
            Load += ResiTF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSend;
        private Label labelAmount;
        private Label labelDate;
        private Label labelFee;
    }
}