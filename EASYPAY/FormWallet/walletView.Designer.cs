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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            historyDG = new DataGridView();
            np = new DataGridViewTextBoxColumn();
            jp = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            tgl = new DataGridViewTextBoxColumn();
            labelSaldo = new Label();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            historyDG.DefaultCellStyle = dataGridViewCellStyle1;
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
            // walletView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
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
    }
}