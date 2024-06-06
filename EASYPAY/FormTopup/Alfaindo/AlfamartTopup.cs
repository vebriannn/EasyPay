using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormTopup.Alfaindo
{
    public partial class AlfamartTopup : Form
    {

        int saldo = 0;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        public AlfamartTopup()
        {
            InitializeComponent();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (textSaldo.Text != "")
            {
                saldo = Convert.ToInt32(textSaldo.Text);

                FormTopup.Alfaindo.bayar br = new FormTopup.Alfaindo.bayar(saldo);
                br.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Anda Harus Mengisi Nominal!!!");
            }
        }

        private void AlfamartTopup_Load(object sender, EventArgs e)
        {
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnBayar.ForeColor = Color.White;

            textSaldo.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;

        }
    }
}
