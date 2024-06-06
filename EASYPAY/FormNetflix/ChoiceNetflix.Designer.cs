namespace EASYPAY.FormNetflix
{
    partial class ChoiceNetflix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceNetflix));
            btn30 = new Button();
            btn55 = new Button();
            btn70 = new Button();
            btn85 = new Button();
            btn110 = new Button();
            btn125 = new Button();
            BtnConfirmBuy = new Button();
            labelNama = new Label();
            labelTP = new Label();
            SuspendLayout();
            // 
            // btn30
            // 
            btn30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn30.Font = new Font("Poppins", 10F);
            btn30.Location = new Point(322, 235);
            btn30.Name = "btn30";
            btn30.Size = new Size(48, 24);
            btn30.TabIndex = 6;
            btn30.Text = "Pilih";
            btn30.UseVisualStyleBackColor = true;
            btn30.Click += btn30_Click;
            // 
            // btn55
            // 
            btn55.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn55.Font = new Font("Poppins", 10F);
            btn55.Location = new Point(504, 236);
            btn55.Name = "btn55";
            btn55.Size = new Size(48, 24);
            btn55.TabIndex = 7;
            btn55.Text = "Pilih";
            btn55.UseVisualStyleBackColor = true;
            btn55.Click += btn55_Click;
            // 
            // btn70
            // 
            btn70.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn70.Font = new Font("Poppins", 10F);
            btn70.Location = new Point(684, 236);
            btn70.Name = "btn70";
            btn70.Size = new Size(48, 24);
            btn70.TabIndex = 8;
            btn70.Text = "Pilih";
            btn70.UseVisualStyleBackColor = true;
            btn70.Click += btn70_Click;
            // 
            // btn85
            // 
            btn85.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn85.Font = new Font("Poppins", 10F);
            btn85.Location = new Point(322, 375);
            btn85.Name = "btn85";
            btn85.Size = new Size(48, 24);
            btn85.TabIndex = 9;
            btn85.Text = "Pilih";
            btn85.UseVisualStyleBackColor = true;
            btn85.Click += btn85_Click;
            // 
            // btn110
            // 
            btn110.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn110.Font = new Font("Poppins", 10F);
            btn110.Location = new Point(504, 375);
            btn110.Name = "btn110";
            btn110.Size = new Size(48, 24);
            btn110.TabIndex = 10;
            btn110.Text = "Pilih";
            btn110.UseVisualStyleBackColor = true;
            btn110.Click += btn110_Click;
            // 
            // btn125
            // 
            btn125.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn125.Font = new Font("Poppins", 10F);
            btn125.Location = new Point(684, 375);
            btn125.Name = "btn125";
            btn125.Size = new Size(48, 24);
            btn125.TabIndex = 11;
            btn125.Text = "Pilih";
            btn125.UseVisualStyleBackColor = true;
            btn125.Click += btn125_Click;
            // 
            // BtnConfirmBuy
            // 
            BtnConfirmBuy.Location = new Point(226, 424);
            BtnConfirmBuy.Name = "BtnConfirmBuy";
            BtnConfirmBuy.Size = new Size(148, 29);
            BtnConfirmBuy.TabIndex = 13;
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
            labelNama.TabIndex = 42;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(85, 124);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 85;
            labelTP.Text = "Maise Ivena L.";
            // 
            // ChoiceNetflix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(BtnConfirmBuy);
            Controls.Add(btn125);
            Controls.Add(btn110);
            Controls.Add(btn85);
            Controls.Add(btn70);
            Controls.Add(btn55);
            Controls.Add(btn30);
            DoubleBuffered = true;
            Name = "ChoiceNetflix";
            Text = "ChoiceNetflix";
            Load += ChoiceNetflix_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn30;
        private Button btn55;
        private Button btn70;
        private Button btn85;
        private Button btn110;
        private Button btn125;
        private Button BtnConfirmBuy;
        private Label labelNama;
        private Label labelTP;
    }
}