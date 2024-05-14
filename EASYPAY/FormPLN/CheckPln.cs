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
    public partial class CheckPln : Form
    {
        public static string IDMeteran;
        public CheckPln()
        {
            InitializeComponent();
        }

        private void CheckPln_Load(object sender, EventArgs e)
        {
            textCheckNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnCheckReg.FlatStyle = FlatStyle.Flat;
            BtnCheckReg.FlatAppearance.BorderSize = 0;

            BtnCheckReg.BackColor = ColorTranslator.FromHtml("#41A6F4");
            BtnCheckReg.ForeColor = ColorTranslator.FromHtml("#FFF");
        }

        private void BtnCheckReg_Click(object sender, EventArgs e)
        {
            if (textCheckNomor.Text.ToString().Length < 11 && textCheckNomor.Text.ToString().Length > 12)
            {
                MessageBox.Show("ID Meteran Harus 11 Digit!!");
            }
            else
            {
                MessageBox.Show("ID Meteran Valid!");
                IDMeteran = textCheckNomor.Text.ToString();
                BuyTokenPln fbp = new BuyTokenPln();
                fbp.Show();
                this.Hide();
            }
        }
    }
}
