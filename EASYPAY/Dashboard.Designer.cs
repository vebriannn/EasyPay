namespace EASYPAY
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            aktifitasDG = new DataGridView();
            Uang_keluar = new DataGridViewTextBoxColumn();
            Uang_Masuk = new DataGridViewTextBoxColumn();
            labelNama = new Label();
            labelWallet = new PictureBox();
            labelSaldo = new Label();
            labelTP = new Label();
            labelPln = new Label();
            labelAir = new Label();
            labelNetflix = new Label();
            labelPulsaData = new Label();
            labelTfBank = new Label();
            labelIsiSaldo = new Label();
            labelPayment = new Label();
            labelprofile = new Label();
            labelDashboard = new Label();
            labelEwallet = new Label();
            ((System.ComponentModel.ISupportInitialize)aktifitasDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelWallet).BeginInit();
            SuspendLayout();
            // 
            // aktifitasDG
            // 
            aktifitasDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aktifitasDG.Columns.AddRange(new DataGridViewColumn[] { Uang_keluar, Uang_Masuk });
            aktifitasDG.Location = new Point(449, 258);
            aktifitasDG.Name = "aktifitasDG";
            aktifitasDG.Size = new Size(240, 186);
            aktifitasDG.TabIndex = 63;
            // 
            // Uang_keluar
            // 
            Uang_keluar.HeaderText = "Uang Masuk";
            Uang_keluar.Name = "Uang_keluar";
            // 
            // Uang_Masuk
            // 
            Uang_Masuk.HeaderText = "Uang Keluar";
            Uang_Masuk.Name = "Uang_Masuk";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(80, 111);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(84, 19);
            labelNama.TabIndex = 38;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelWallet
            // 
            labelWallet.Image = (Image)resources.GetObject("labelWallet.Image");
            labelWallet.Location = new Point(-2, -1);
            labelWallet.Name = "labelWallet";
            labelWallet.Size = new Size(806, 508);
            labelWallet.SizeMode = PictureBoxSizeMode.StretchImage;
            labelWallet.TabIndex = 0;
            labelWallet.TabStop = false;
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.ForeColor = Color.White;
            labelSaldo.Location = new Point(277, 396);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(51, 15);
            labelSaldo.TabIndex = 74;
            labelSaldo.Text = "Rp. 1000";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(81, 126);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 82;
            labelTP.Text = "Maise Ivena L.";
            // 
            // labelPln
            // 
            labelPln.AutoSize = true;
            labelPln.Location = new Point(292, 127);
            labelPln.Name = "labelPln";
            labelPln.Size = new Size(29, 15);
            labelPln.TabIndex = 83;
            labelPln.Text = "PLN";
            labelPln.Click += labelPln_Click;
            // 
            // labelAir
            // 
            labelAir.AutoSize = true;
            labelAir.Location = new Point(388, 127);
            labelAir.Name = "labelAir";
            labelAir.Size = new Size(41, 15);
            labelAir.TabIndex = 84;
            labelAir.Text = "PDAM";
            labelAir.Click += labelAir_Click;
            // 
            // labelNetflix
            // 
            labelNetflix.AutoSize = true;
            labelNetflix.Location = new Point(485, 126);
            labelNetflix.Name = "labelNetflix";
            labelNetflix.Size = new Size(50, 15);
            labelNetflix.TabIndex = 85;
            labelNetflix.Text = "NETFLIX";
            labelNetflix.Click += labelNetflix_Click;
            // 
            // labelPulsaData
            // 
            labelPulsaData.AutoSize = true;
            labelPulsaData.Location = new Point(579, 126);
            labelPulsaData.Name = "labelPulsaData";
            labelPulsaData.Size = new Size(73, 15);
            labelPulsaData.TabIndex = 86;
            labelPulsaData.Text = "PULSA DATA";
            labelPulsaData.Click += labelPulsaData_Click;
            // 
            // labelTfBank
            // 
            labelTfBank.AutoSize = true;
            labelTfBank.Location = new Point(258, 205);
            labelTfBank.Name = "labelTfBank";
            labelTfBank.Size = new Size(96, 15);
            labelTfBank.TabIndex = 87;
            labelTfBank.Text = "TRANSFER BANK";
            labelTfBank.Click += labelTfBank_Click;
            // 
            // labelIsiSaldo
            // 
            labelIsiSaldo.AutoSize = true;
            labelIsiSaldo.Location = new Point(387, 204);
            labelIsiSaldo.Name = "labelIsiSaldo";
            labelIsiSaldo.Size = new Size(43, 15);
            labelIsiSaldo.TabIndex = 88;
            labelIsiSaldo.Text = "TOPUP";
            labelIsiSaldo.Click += labelIsiSaldo_Click;
            // 
            // labelPayment
            // 
            labelPayment.AutoSize = true;
            labelPayment.Location = new Point(478, 204);
            labelPayment.Name = "labelPayment";
            labelPayment.Size = new Size(59, 15);
            labelPayment.TabIndex = 89;
            labelPayment.Text = "PAYMENT";
            labelPayment.Click += labelPayment_Click;
            // 
            // labelprofile
            // 
            labelprofile.AutoSize = true;
            labelprofile.Location = new Point(91, 160);
            labelprofile.Name = "labelprofile";
            labelprofile.Size = new Size(41, 15);
            labelprofile.TabIndex = 90;
            labelprofile.Text = "Profile";
            labelprofile.Click += labelprofile_Click;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.Location = new Point(91, 187);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(64, 15);
            labelDashboard.TabIndex = 91;
            labelDashboard.Text = "Dashboard";
            // 
            // labelEwallet
            // 
            labelEwallet.AutoSize = true;
            labelEwallet.Location = new Point(91, 216);
            labelEwallet.Name = "labelEwallet";
            labelEwallet.Size = new Size(40, 15);
            labelEwallet.TabIndex = 92;
            labelEwallet.Text = "Wallet";
            labelEwallet.Click += labelEwallet_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 500);
            Controls.Add(labelEwallet);
            Controls.Add(labelDashboard);
            Controls.Add(labelprofile);
            Controls.Add(labelPayment);
            Controls.Add(labelIsiSaldo);
            Controls.Add(labelTfBank);
            Controls.Add(labelPulsaData);
            Controls.Add(labelNetflix);
            Controls.Add(labelAir);
            Controls.Add(labelPln);
            Controls.Add(labelTP);
            Controls.Add(labelSaldo);
            Controls.Add(aktifitasDG);
            Controls.Add(labelNama);
            Controls.Add(labelWallet);
            Name = "Dashboard";
            Text = "FormDashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)aktifitasDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelWallet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView aktifitasDG;
        private Label labelNama;
        private PictureBox labelWallet;
        private Label labelSaldo;
        private DataGridViewTextBoxColumn Uang_keluar;
        private DataGridViewTextBoxColumn Uang_Masuk;
        private Label labelTP;
        private Label labelPln;
        private Label labelAir;
        private Label labelNetflix;
        private Label labelPulsaData;
        private Label labelTfBank;
        private Label labelIsiSaldo;
        private Label labelPayment;
        private Label labelprofile;
        private Label labelDashboard;
        private Label labelEwallet;
    }
}