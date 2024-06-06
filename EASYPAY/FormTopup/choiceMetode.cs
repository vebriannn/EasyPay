using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormTopup
{
    public partial class choiceMetode : Form
    {

        public static Image url_images;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;
        public choiceMetode()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormTopup.Alfaindo.AlfamartTopup at = new FormTopup.Alfaindo.AlfamartTopup();
            at.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormTopup.Alfaindo.IndomartTopup at = new FormTopup.Alfaindo.IndomartTopup();
            at.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            url_images = Properties.Resources.bank_logo__1_;
            FormTopup.Bank.bayar b = new FormTopup.Bank.bayar();
            b.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            url_images = Properties.Resources.transaction_type;
            FormTopup.Bank.bayar b = new FormTopup.Bank.bayar();
            b.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            url_images = Properties.Resources.bank_logo;
            FormTopup.Bank.bayar b = new FormTopup.Bank.bayar();
            b.Show();
            this.Hide();
        }

        private void choiceMetode_Load(object sender, EventArgs e)
        {
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }
    }
}
