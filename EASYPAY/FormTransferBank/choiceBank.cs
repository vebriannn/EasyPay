using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormTransferBank
{
    public partial class choiceBank : Form
    {
        public static string namaBank = "";


        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        public choiceBank()
        {
            InitializeComponent();
        }

        private void choiceBank_Load(object sender, EventArgs e)
        {
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void btnBca_Click(object sender, EventArgs e)
        {
            namaBank = "Bank Central Indonesia (BCA)";
            checkBtnClick();
        }

        private void btnBni_Click(object sender, EventArgs e)
        {
            namaBank = "Bank Negara Indonesia (BNI)";
            checkBtnClick();
        }

        private void tbnBri_Click(object sender, EventArgs e)
        {
            namaBank = "Bank Rakyat Indonesia (BRI)";
            checkBtnClick();
        }

        private void btnBtn_Click(object sender, EventArgs e)
        {
            namaBank = "Bank Tabungan Negara (BTN)";
            checkBtnClick();
        }

        private void btnMandiri_Click(object sender, EventArgs e)
        {
            namaBank = "Bank Mandiri";
            checkBtnClick();
        }

        private void btnCimb_Click(object sender, EventArgs e)
        {
            namaBank = " Commerce International Merchant Bankers Berhad (CIMB)";
            checkBtnClick();
        }

        private void checkBtnClick()
        {
            if(namaBank != "")
            {
                FormTransferBank.Transfer tf = new FormTransferBank.Transfer();
                tf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Anda Harus Memilih Bank Terlebih Dahulu");
            }
        }
    }
}
