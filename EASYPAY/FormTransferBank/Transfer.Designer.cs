namespace EASYPAY.FormTransferBank
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            namaBank = new Label();
            textNomorBk = new TextBox();
            textSaldoBk = new TextBox();
            textPesan = new TextBox();
            btnTranfer = new Button();
            SuspendLayout();
            // 
            // namaBank
            // 
            namaBank.AutoSize = true;
            namaBank.Location = new Point(252, 172);
            namaBank.Name = "namaBank";
            namaBank.Size = new Size(38, 15);
            namaBank.TabIndex = 0;
            namaBank.Text = "label1";
            // 
            // textNomorBk
            // 
            textNomorBk.BorderStyle = BorderStyle.None;
            textNomorBk.Location = new Point(230, 262);
            textNomorBk.Name = "textNomorBk";
            textNomorBk.Size = new Size(243, 16);
            textNomorBk.TabIndex = 1;
            // 
            // textSaldoBk
            // 
            textSaldoBk.BorderStyle = BorderStyle.None;
            textSaldoBk.Location = new Point(230, 341);
            textSaldoBk.Name = "textSaldoBk";
            textSaldoBk.Size = new Size(243, 16);
            textSaldoBk.TabIndex = 2;
            // 
            // textPesan
            // 
            textPesan.BorderStyle = BorderStyle.None;
            textPesan.Location = new Point(530, 259);
            textPesan.Multiline = true;
            textPesan.Name = "textPesan";
            textPesan.Size = new Size(203, 94);
            textPesan.TabIndex = 3;
            // 
            // btnTranfer
            // 
            btnTranfer.Location = new Point(432, 412);
            btnTranfer.Name = "btnTranfer";
            btnTranfer.Size = new Size(117, 23);
            btnTranfer.TabIndex = 4;
            btnTranfer.Text = "Transfer Sekarang";
            btnTranfer.UseVisualStyleBackColor = true;
            btnTranfer.Click += btnTranfer_Click;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(btnTranfer);
            Controls.Add(textPesan);
            Controls.Add(textSaldoBk);
            Controls.Add(textNomorBk);
            Controls.Add(namaBank);
            DoubleBuffered = true;
            Name = "Transfer";
            Text = "Transfer";
            Load += Transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namaBank;
        private TextBox textNomorBk;
        private TextBox textSaldoBk;
        private TextBox textPesan;
        private Button btnTranfer;
    }
}