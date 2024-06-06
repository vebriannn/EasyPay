namespace EASYPAY.FormPLN
{
    partial class BuyTokenPln
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTokenPln));
            pictureBox1 = new PictureBox();
            labelNomor = new Label();
            Btn50 = new Button();
            Btn150 = new Button();
            Btn300 = new Button();
            checkBoxBalance = new CheckBox();
            BtnConfirmBuy = new Button();
            labelNama = new Label();
            labelTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNomor
            // 
            labelNomor.AutoSize = true;
            labelNomor.BackColor = Color.Transparent;
            labelNomor.Font = new Font("Poppins", 9F);
            labelNomor.Location = new Point(248, 174);
            labelNomor.Margin = new Padding(0);
            labelNomor.Name = "labelNomor";
            labelNomor.Size = new Size(106, 22);
            labelNomor.TabIndex = 2;
            labelNomor.Text = "089659058894";
            labelNomor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn50
            // 
            Btn50.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn50.Font = new Font("Poppins", 10F);
            Btn50.Location = new Point(284, 318);
            Btn50.Name = "Btn50";
            Btn50.Size = new Size(48, 24);
            Btn50.TabIndex = 3;
            Btn50.Text = "Pilih";
            Btn50.UseVisualStyleBackColor = true;
            Btn50.Click += Btn50_Click;
            // 
            // Btn150
            // 
            Btn150.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn150.Font = new Font("Poppins", 10F);
            Btn150.Location = new Point(468, 319);
            Btn150.Name = "Btn150";
            Btn150.Size = new Size(48, 23);
            Btn150.TabIndex = 5;
            Btn150.Text = "Pilih";
            Btn150.UseVisualStyleBackColor = true;
            Btn150.Click += Btn150_Click;
            // 
            // Btn300
            // 
            Btn300.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn300.Font = new Font("Poppins", 10F);
            Btn300.Location = new Point(655, 319);
            Btn300.Name = "Btn300";
            Btn300.Size = new Size(48, 23);
            Btn300.TabIndex = 6;
            Btn300.Text = "Pilih";
            Btn300.UseVisualStyleBackColor = true;
            Btn300.Click += Btn300_Click;
            // 
            // checkBoxBalance
            // 
            checkBoxBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxBalance.AutoSize = true;
            checkBoxBalance.Font = new Font("Poppins", 8F);
            checkBoxBalance.Location = new Point(234, 399);
            checkBoxBalance.Name = "checkBoxBalance";
            checkBoxBalance.Size = new Size(72, 23);
            checkBoxBalance.TabIndex = 7;
            checkBoxBalance.Text = "E Wallet";
            checkBoxBalance.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxBalance.UseVisualStyleBackColor = false;
            checkBoxBalance.CheckedChanged += checkBoxBalance_CheckedChanged;
            // 
            // BtnConfirmBuy
            // 
            BtnConfirmBuy.Location = new Point(234, 428);
            BtnConfirmBuy.Name = "BtnConfirmBuy";
            BtnConfirmBuy.Size = new Size(148, 29);
            BtnConfirmBuy.TabIndex = 9;
            BtnConfirmBuy.Text = "Beli Sekarang";
            BtnConfirmBuy.UseVisualStyleBackColor = true;
            BtnConfirmBuy.Visible = false;
            BtnConfirmBuy.Click += BtnConfirmBuy_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(84, 110);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 41;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(86, 123);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 84;
            labelTP.Text = "Maise Ivena L.";
            // 
            // BuyTokenPln
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(BtnConfirmBuy);
            Controls.Add(checkBoxBalance);
            Controls.Add(Btn300);
            Controls.Add(Btn150);
            Controls.Add(Btn50);
            Controls.Add(labelNomor);
            Controls.Add(pictureBox1);
            Name = "BuyTokenPln";
            Text = "BuyTokenListrik";
            Load += Buy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNomor;
        private Button Btn50;
        private Button Btn150;
        private Button Btn300;
        private CheckBox checkBoxBalance;
        private Button BtnConfirmBuy;
        private Label labelNama;
        private Label labelTP;
    }
}