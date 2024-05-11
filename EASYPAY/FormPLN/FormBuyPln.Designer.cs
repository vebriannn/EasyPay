namespace EASYPAY.FormPLN
{
    partial class FormBuyPln
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyPln));
            pictureBox1 = new PictureBox();
            labelNomor = new Label();
            Btn50 = new Button();
            Btn100 = new Button();
            Btn150 = new Button();
            Btn300 = new Button();
            checkBoxBalance = new CheckBox();
            checkBoxSavings = new CheckBox();
            BtnConfirmBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNomor
            // 
            labelNomor.AutoSize = true;
            labelNomor.BackColor = Color.Transparent;
            labelNomor.Font = new Font("Poppins", 9F);
            labelNomor.Location = new Point(236, 150);
            labelNomor.Margin = new Padding(0);
            labelNomor.Name = "labelNomor";
            labelNomor.Size = new Size(106, 22);
            labelNomor.TabIndex = 1;
            labelNomor.Text = "089659058894";
            labelNomor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn50
            // 
            Btn50.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn50.Font = new Font("Poppins", 8F);
            Btn50.Location = new Point(257, 248);
            Btn50.Name = "Btn50";
            Btn50.Size = new Size(48, 20);
            Btn50.TabIndex = 2;
            Btn50.Text = "Pilih";
            Btn50.UseVisualStyleBackColor = true;
            Btn50.Click += Btn50_Click;
            // 
            // Btn100
            // 
            Btn100.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn100.Font = new Font("Poppins", 8F);
            Btn100.Location = new Point(391, 248);
            Btn100.Name = "Btn100";
            Btn100.Size = new Size(48, 20);
            Btn100.TabIndex = 3;
            Btn100.Text = "Pilih";
            Btn100.UseVisualStyleBackColor = true;
            Btn100.Click += Btn100_Click;
            // 
            // Btn150
            // 
            Btn150.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn150.Font = new Font("Poppins", 8F);
            Btn150.Location = new Point(523, 247);
            Btn150.Name = "Btn150";
            Btn150.Size = new Size(48, 20);
            Btn150.TabIndex = 4;
            Btn150.Text = "Pilih";
            Btn150.UseVisualStyleBackColor = true;
            Btn150.Click += Btn150_Click;
            // 
            // Btn300
            // 
            Btn300.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn300.Font = new Font("Poppins", 8F);
            Btn300.Location = new Point(658, 247);
            Btn300.Name = "Btn300";
            Btn300.Size = new Size(48, 20);
            Btn300.TabIndex = 5;
            Btn300.Text = "Pilih";
            Btn300.UseVisualStyleBackColor = true;
            Btn300.Click += Btn300_Click;
            // 
            // checkBoxBalance
            // 
            checkBoxBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxBalance.AutoSize = true;
            checkBoxBalance.Font = new Font("Poppins", 6F);
            checkBoxBalance.Location = new Point(225, 333);
            checkBoxBalance.Name = "checkBoxBalance";
            checkBoxBalance.Size = new Size(57, 18);
            checkBoxBalance.TabIndex = 6;
            checkBoxBalance.Text = "E Wallet";
            checkBoxBalance.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxBalance.UseVisualStyleBackColor = false;
            checkBoxBalance.CheckedChanged += checkBoxBalance_CheckedChanged;
            // 
            // checkBoxSavings
            // 
            checkBoxSavings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxSavings.AutoSize = true;
            checkBoxSavings.Font = new Font("Poppins", 6F);
            checkBoxSavings.Location = new Point(329, 333);
            checkBoxSavings.Name = "checkBoxSavings";
            checkBoxSavings.Size = new Size(56, 18);
            checkBoxSavings.TabIndex = 7;
            checkBoxSavings.Text = "Savings";
            checkBoxSavings.TextAlign = ContentAlignment.BottomLeft;
            checkBoxSavings.UseVisualStyleBackColor = false;
            checkBoxSavings.CheckedChanged += checkBoxSavings_CheckedChanged;
            // 
            // BtnConfirmBuy
            // 
            BtnConfirmBuy.Location = new Point(225, 368);
            BtnConfirmBuy.Name = "BtnConfirmBuy";
            BtnConfirmBuy.Size = new Size(160, 29);
            BtnConfirmBuy.TabIndex = 8;
            BtnConfirmBuy.Text = "Beli Sekarang";
            BtnConfirmBuy.UseVisualStyleBackColor = true;
            BtnConfirmBuy.Visible = false;
            BtnConfirmBuy.Click += BtnConfirmBuy_Click;
            // 
            // FormBuyPln
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConfirmBuy);
            Controls.Add(checkBoxSavings);
            Controls.Add(checkBoxBalance);
            Controls.Add(Btn300);
            Controls.Add(Btn150);
            Controls.Add(Btn100);
            Controls.Add(Btn50);
            Controls.Add(labelNomor);
            Controls.Add(pictureBox1);
            Name = "FormBuyPln";
            Text = "FormBuyPln";
            Load += FormBuyPln_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNomor;
        private Button Btn50;
        private Button Btn100;
        private Button Btn150;
        private Button Btn300;
        private CheckBox checkBoxBalance;
        private CheckBox checkBoxSavings;
        private Button BtnConfirmBuy;
    }
}