namespace EASYPAY.FormWallet
{
    partial class walletView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(walletView));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            historyDG = new DataGridView();
            np = new DataGridViewTextBoxColumn();
            jp = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            tgl = new DataGridViewTextBoxColumn();
            labelSaldo = new Label();
            labelprofile = new Label();
            labelDashboard = new Label();
            labelEwallet = new Label();
            labelNama = new Label();
            labelTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyDG).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // historyDG
            // 
            historyDG.BorderStyle = BorderStyle.None;
            historyDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDG.Columns.AddRange(new DataGridViewColumn[] { np, jp, harga, tgl });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            historyDG.DefaultCellStyle = dataGridViewCellStyle7;
            historyDG.Location = new Point(240, 293);
            historyDG.Name = "historyDG";
            historyDG.Size = new Size(443, 157);
            historyDG.TabIndex = 1;
            historyDG.CellContentClick += historyDG_CellContentClick;
            // 
            // np
            // 
            np.HeaderText = "No Transaksi";
            np.Name = "np";
            // 
            // jp
            // 
            jp.HeaderText = "Jenis Pembelian";
            jp.Name = "jp";
            // 
            // harga
            // 
            harga.HeaderText = "Harga";
            harga.Name = "harga";
            // 
            // tgl
            // 
            tgl.HeaderText = "Tanggal Transaksi";
            tgl.Name = "tgl";
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.ForeColor = Color.White;
            labelSaldo.Location = new Point(385, 123);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(51, 15);
            labelSaldo.TabIndex = 75;
            labelSaldo.Text = "Rp. 1000";
            // 
            // labelprofile
            // 
            labelprofile.AutoSize = true;
            labelprofile.Location = new Point(85, 157);
            labelprofile.Name = "labelprofile";
            labelprofile.Size = new Size(41, 15);
            labelprofile.TabIndex = 91;
            labelprofile.Text = "Profile";
            labelprofile.Click += labelprofile_Click;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.Location = new Point(85, 185);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(64, 15);
            labelDashboard.TabIndex = 92;
            labelDashboard.Text = "Dashboard";
            labelDashboard.Click += labelDashboard_Click;
            // 
            // labelEwallet
            // 
            labelEwallet.AutoSize = true;
            labelEwallet.Location = new Point(86, 213);
            labelEwallet.Name = "labelEwallet";
            labelEwallet.Size = new Size(40, 15);
            labelEwallet.TabIndex = 93;
            labelEwallet.Text = "Wallet";
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
            labelNama.TabIndex = 94;
            labelNama.Text = "Maise Ivena L.";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Poppins", 7.25F);
            labelTP.ForeColor = Color.Black;
            labelTP.Location = new Point(88, 124);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(76, 17);
            labelTP.TabIndex = 95;
            labelTP.Text = "Maise Ivena L.";
            // 
            // walletView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTP);
            Controls.Add(labelNama);
            Controls.Add(labelEwallet);
            Controls.Add(labelDashboard);
            Controls.Add(labelprofile);
            Controls.Add(labelSaldo);
            Controls.Add(historyDG);
            Controls.Add(pictureBox1);
            Name = "walletView";
            Text = "walletView";
            Load += walletView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView historyDG;
        private DataGridViewTextBoxColumn np;
        private DataGridViewTextBoxColumn jp;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn tgl;
        private Label labelSaldo;
        private Label labelprofile;
        private Label labelDashboard;
        private Label labelEwallet;
        private Label labelNama;
        private Label labelTP;
    }
}