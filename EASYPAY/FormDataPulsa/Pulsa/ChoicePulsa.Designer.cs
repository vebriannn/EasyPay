namespace EASYPAY.FormDataPulsa.Pulsa
{
    partial class ChoicePulsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoicePulsa));
            pictureBox1 = new PictureBox();
            btn50 = new Button();
            btn100 = new Button();
            btn150 = new Button();
            btn200 = new Button();
            btn250 = new Button();
            btn300 = new Button();
            checkBoxBalance = new CheckBox();
            BtnConfirmBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn50
            // 
            btn50.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn50.Font = new Font("Poppins", 10F);
            btn50.Location = new Point(317, 202);
            btn50.Name = "btn50";
            btn50.Size = new Size(48, 24);
            btn50.TabIndex = 4;
            btn50.Text = "Pilih";
            btn50.UseVisualStyleBackColor = true;
            btn50.Click += btn50_Click;
            // 
            // btn100
            // 
            btn100.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn100.Font = new Font("Poppins", 10F);
            btn100.Location = new Point(500, 202);
            btn100.Name = "btn100";
            btn100.Size = new Size(48, 24);
            btn100.TabIndex = 5;
            btn100.Text = "Pilih";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += btn100_Click;
            // 
            // btn150
            // 
            btn150.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn150.Font = new Font("Poppins", 10F);
            btn150.Location = new Point(684, 202);
            btn150.Name = "btn150";
            btn150.Size = new Size(48, 24);
            btn150.TabIndex = 6;
            btn150.Text = "Pilih";
            btn150.UseVisualStyleBackColor = true;
            btn150.Click += btn150_Click;
            // 
            // btn200
            // 
            btn200.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn200.Font = new Font("Poppins", 10F);
            btn200.Location = new Point(317, 321);
            btn200.Name = "btn200";
            btn200.Size = new Size(48, 24);
            btn200.TabIndex = 7;
            btn200.Text = "Pilih";
            btn200.UseVisualStyleBackColor = true;
            btn200.Click += btn200_Click;
            // 
            // btn250
            // 
            btn250.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn250.Font = new Font("Poppins", 10F);
            btn250.Location = new Point(500, 321);
            btn250.Name = "btn250";
            btn250.Size = new Size(48, 24);
            btn250.TabIndex = 8;
            btn250.Text = "Pilih";
            btn250.UseVisualStyleBackColor = true;
            btn250.Click += btn250_Click;
            // 
            // btn300
            // 
            btn300.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn300.Font = new Font("Poppins", 10F);
            btn300.Location = new Point(684, 321);
            btn300.Name = "btn300";
            btn300.Size = new Size(48, 24);
            btn300.TabIndex = 9;
            btn300.Text = "Pilih";
            btn300.UseVisualStyleBackColor = true;
            btn300.Click += btn300_Click;
            // 
            // checkBoxBalance
            // 
            checkBoxBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxBalance.AutoSize = true;
            checkBoxBalance.Font = new Font("Poppins", 8F);
            checkBoxBalance.Location = new Point(226, 406);
            checkBoxBalance.Name = "checkBoxBalance";
            checkBoxBalance.Size = new Size(72, 23);
            checkBoxBalance.TabIndex = 10;
            checkBoxBalance.Text = "E Wallet";
            checkBoxBalance.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxBalance.UseVisualStyleBackColor = false;
            checkBoxBalance.CheckedChanged += checkBoxBalance_CheckedChanged;
            // 
            // BtnConfirmBuy
            // 
            BtnConfirmBuy.Location = new Point(226, 435);
            BtnConfirmBuy.Name = "BtnConfirmBuy";
            BtnConfirmBuy.Size = new Size(148, 29);
            BtnConfirmBuy.TabIndex = 12;
            BtnConfirmBuy.Text = "Beli Sekarang";
            BtnConfirmBuy.UseVisualStyleBackColor = true;
            BtnConfirmBuy.Visible = false;
            BtnConfirmBuy.Click += BtnConfirmBuy_Click_1;
            // 
            // ChoicePulsa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(BtnConfirmBuy);
            Controls.Add(checkBoxBalance);
            Controls.Add(btn300);
            Controls.Add(btn250);
            Controls.Add(btn200);
            Controls.Add(btn150);
            Controls.Add(btn100);
            Controls.Add(btn50);
            Controls.Add(pictureBox1);
            Name = "ChoicePulsa";
            Text = "ChoicePulsa";
            Load += ChoicePulsa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn50;
        private Button btn100;
        private Button btn150;
        private Button btn200;
        private Button btn250;
        private Button btn300;
        private CheckBox checkBoxBalance;
        private Button BtnConfirmBuy;
    }
}