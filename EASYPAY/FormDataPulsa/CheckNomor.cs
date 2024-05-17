using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormDataPulsa
{
    public partial class CheckNomor : Form
    {

        private string nomorTujuan = "";

        public CheckNomor()
        {
            InitializeComponent();
        }

        private void CheckNomor_Load(object sender, EventArgs e)
        {
            textNumber.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btnPulsa.FlatStyle = FlatStyle.Flat;
            btnPulsa.FlatAppearance.BorderSize = 0;
            btnPulsa.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btnData.FlatStyle = FlatStyle.Flat;
            btnData.FlatAppearance.BorderSize = 0;
            btnData.BackColor = ColorTranslator.FromHtml("#BBDEFA");
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            if (textNumber.Text.Length != 12)
            {
                MessageBox.Show("Maaf Nomor Harus 12 Digit!!!");
            }
            else
            {
                MessageBox.Show("Nomor Valid");
                nomorTujuan = textNumber.Text.ToString();
            }
        }

        private void btnPulsa_Click(object sender, EventArgs e)
        {
            if (nomorTujuan == "")
            {
                MessageBox.Show("Maaf Nomor Masih Kosong");
            }
            else
            {
                FormDataPulsa.Pulsa.ChoicePulsa cp = new FormDataPulsa.Pulsa.ChoicePulsa();
                cp.Show();
                this.Hide();
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            if (nomorTujuan == "")
            {
                MessageBox.Show("Maaf Nomor Masih Kosong");
            }
            else
            {
                FormDataPulsa.Data.ChoiceData cd = new FormDataPulsa.Data.ChoiceData();
                cd.Show();
                this.Hide();
            }
        }
    }
}
