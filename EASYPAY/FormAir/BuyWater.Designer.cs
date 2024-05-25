namespace EASYPAY.FormAir
{
    partial class BuyWater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyWater));
            pictureBox1 = new PictureBox();
            Btn50 = new Button();
            labelNomor = new Label();
            checkBoxBalance = new CheckBox();
            BtnConfirmBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Btn50
            // 
            Btn50.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn50.Font = new Font("Poppins", 10F);
            Btn50.Location = new Point(289, 307);
            Btn50.Name = "Btn50";
            Btn50.Size = new Size(48, 24);
            Btn50.TabIndex = 4;
            Btn50.Text = "Pilih";
            Btn50.UseVisualStyleBackColor = true;
            Btn50.Click += Btn50_Click;
            // 
            // labelNomor
            // 
            labelNomor.AutoSize = true;
            labelNomor.BackColor = Color.Transparent;
            labelNomor.Font = new Font("Poppins", 9F);
            labelNomor.Location = new Point(251, 174);
            labelNomor.Margin = new Padding(0);
            labelNomor.Name = "labelNomor";
            labelNomor.Size = new Size(106, 22);
            labelNomor.TabIndex = 5;
            labelNomor.Text = "089659058894";
            labelNomor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxBalance
            // 
            checkBoxBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxBalance.AutoSize = true;
            checkBoxBalance.Font = new Font("Poppins", 8F);
            checkBoxBalance.Location = new Point(236, 390);
            checkBoxBalance.Name = "checkBoxBalance";
            checkBoxBalance.Size = new Size(72, 23);
            checkBoxBalance.TabIndex = 8;
            checkBoxBalance.Text = "E Wallet";
            checkBoxBalance.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxBalance.UseVisualStyleBackColor = false;
            checkBoxBalance.CheckedChanged += checkBoxBalance_CheckedChanged;
            // 
            // BtnConfirmBuy
            // 
            BtnConfirmBuy.Location = new Point(236, 419);
            BtnConfirmBuy.Name = "BtnConfirmBuy";
            BtnConfirmBuy.Size = new Size(149, 29);
            BtnConfirmBuy.TabIndex = 10;
            BtnConfirmBuy.Text = "Beli Sekarang";
            BtnConfirmBuy.UseVisualStyleBackColor = true;
            BtnConfirmBuy.Visible = false;
            BtnConfirmBuy.Click += BtnConfirmBuy_Click;
            // 
            // BuyWater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(BtnConfirmBuy);
            Controls.Add(checkBoxBalance);
            Controls.Add(labelNomor);
            Controls.Add(Btn50);
            Controls.Add(pictureBox1);
            Name = "BuyWater";
            Text = "BuyWater";
            Load += BuyWater_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Btn50;
        private Label labelNomor;
        private CheckBox checkBoxBalance;
        private Button BtnConfirmBuy;
    }
}