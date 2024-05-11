using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormPLN
{
    public partial class FormResultsTrxPln : Form
    {

        string nomor_pembelian = FormBuyPln.nomor_pembelian;
        string harga = FormBuyPln.pilihHarga.ToString();
        string date = FormBuyPln.tanggalPembelianString;
        public FormResultsTrxPln()
        {
            InitializeComponent();
        }

        private void FormResultsTrxPln_Load(object sender, EventArgs e)
        {
            labelNoTrx.Text = nomor_pembelian;
            labelJP.Text = "Pln";
            labelHarga.Text = harga;
            labelDate.Text = date;
        }
    }
}
