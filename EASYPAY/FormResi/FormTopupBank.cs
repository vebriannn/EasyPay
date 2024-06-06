using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EASYPAY.FormResi
{
    public partial class FormTopupBank : Form
    {
        string Nama;
        int Jumlah;
        DateTime Tanggal;

        public FormTopupBank(string nama, int jumlah, DateTime tanggal)
        {
            InitializeComponent();
            this.Nama = nama;
            this.Jumlah = jumlah;
            this.Tanggal = tanggal;
        }

        private void FormTopupBank_Load(object sender, EventArgs e)
        {
            labelAN.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelJumlah.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labeltanggal.BackColor = ColorTranslator.FromHtml("#41A6F4");

            labelAN.Text = Nama;
            labelJumlah.Text = Jumlah.ToString("N0");
            labeltanggal.Text = Tanggal.ToString();
        }
    }
}
