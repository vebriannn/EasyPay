namespace EASYPAY.FormTopup.Bank
{
    partial class bayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bayar));
            textNoRek = new TextBox();
            textSaldo = new TextBox();
            btnKonfir = new Button();
            pictureBox1 = new PictureBox();
            labelNama = new Label();
            labelTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textNoRek
            // 
            textNoRek.BorderStyle = BorderStyle.None;
            textNoRek.Location = new Point(253, 242);
            textNoRek.Name = "textNoRek";
            textNoRek.Size = new Size(243, 16);
            textNoRek.TabIndex = 0;
            // 
            // textSaldo
            // 
            textSaldo.BorderStyle = BorderStyle.None;
            textSaldo.Location = new Point(253, 342);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(243, 16);
            textSaldo.TabIndex = 1;
            // 
            // btnKonfir
            // 
            btnKonfir.Location = new Point(339, 403);
            btnKonfir.Name = "btnKonfir";
            btnKonfir.Size = new Size(75, 23);
            btnKonfir.TabIndex = 2;
            btnKonfir.Text = "Konfirmasi";
            btnKonfir.UseVisualStyleBackColor = true;
            btnKonfir.Click += btnKonfir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank_logo;
            pictureBox1.Location = new Point(253, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            labelNama.TabIndex = 85;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(86, 122);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 86;
            labelTP.Text = "Maise Ivena L.";
            // 
            // bayar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(pictureBox1);
            Controls.Add(btnKonfir);
            Controls.Add(textSaldo);
            Controls.Add(textNoRek);
            DoubleBuffered = true;
            Name = "bayar";
            Text = "bayar";
            Load += bayar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNoRek;
        private TextBox textSaldo;
        private Button btnKonfir;
        private PictureBox pictureBox1;
        private Label labelNama;
        private Label labelTP;
    }
}