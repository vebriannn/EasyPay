namespace EASYPAY.FormTransferEasyPay
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
            textNumber = new TextBox();
            textJumlah = new TextBox();
            textPesan = new TextBox();
            btnKonfir = new Button();
            labelNama = new Label();
            labelTP = new Label();
            SuspendLayout();
            // 
            // textNumber
            // 
            textNumber.BorderStyle = BorderStyle.None;
            textNumber.Location = new Point(241, 171);
            textNumber.Name = "textNumber";
            textNumber.Size = new Size(194, 16);
            textNumber.TabIndex = 0;
            // 
            // textJumlah
            // 
            textJumlah.BorderStyle = BorderStyle.None;
            textJumlah.Location = new Point(241, 233);
            textJumlah.Name = "textJumlah";
            textJumlah.Size = new Size(194, 16);
            textJumlah.TabIndex = 1;
            // 
            // textPesan
            // 
            textPesan.BorderStyle = BorderStyle.None;
            textPesan.Location = new Point(241, 298);
            textPesan.Multiline = true;
            textPesan.Name = "textPesan";
            textPesan.Size = new Size(194, 61);
            textPesan.TabIndex = 2;
            // 
            // btnKonfir
            // 
            btnKonfir.Location = new Point(288, 397);
            btnKonfir.Name = "btnKonfir";
            btnKonfir.Size = new Size(103, 23);
            btnKonfir.TabIndex = 3;
            btnKonfir.Text = "Konfirmasi";
            btnKonfir.UseVisualStyleBackColor = true;
            btnKonfir.Click += btnKonfir_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(85, 109);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 40;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(87, 123);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 84;
            labelTP.Text = "Maise Ivena L.";
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(btnKonfir);
            Controls.Add(textPesan);
            Controls.Add(textJumlah);
            Controls.Add(textNumber);
            DoubleBuffered = true;
            Name = "Transfer";
            Text = "Transfer";
            Load += Transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNumber;
        private TextBox textJumlah;
        private TextBox textPesan;
        private Button btnKonfir;
        private Label labelNama;
        private Label labelTP;
    }
}