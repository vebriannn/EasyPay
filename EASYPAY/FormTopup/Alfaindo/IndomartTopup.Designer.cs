namespace EASYPAY.FormTopup.Alfaindo
{
    partial class IndomartTopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndomartTopup));
            textSaldo = new TextBox();
            btnBayar = new Button();
            labelTP = new Label();
            labelNama = new Label();
            SuspendLayout();
            // 
            // textSaldo
            // 
            textSaldo.BorderStyle = BorderStyle.None;
            textSaldo.Location = new Point(243, 227);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(239, 16);
            textSaldo.TabIndex = 1;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(265, 414);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(181, 23);
            btnBayar.TabIndex = 2;
            btnBayar.Text = "Konfirmasi Pembayaran";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(87, 124);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 87;
            labelTP.Text = "Maise Ivena L.";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(86, 111);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 88;
            labelNama.Text = "Maise Ivena L.";
            // 
            // IndomartTopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(btnBayar);
            Controls.Add(textSaldo);
            Controls.Add(labelNama);
            DoubleBuffered = true;
            Name = "IndomartTopup";
            Text = "IndomartTopup";
            Load += IndomartTopup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textSaldo;
        private Button btnBayar;
        private Label labelTP;
        private Label labelNama;
    }
}