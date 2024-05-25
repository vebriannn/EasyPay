using EASYPAY.FormPLN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormAir
{
    public partial class CheckWater : Form
    {
        public static string IDMeteran;
        public CheckWater()
        {
            InitializeComponent();
        }

        private void CheckWater_Load(object sender, EventArgs e)
        {
            textCheckNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnCheckReg.FlatStyle = FlatStyle.Flat;
            BtnCheckReg.FlatAppearance.BorderSize = 0;

            BtnCheckReg.BackColor = ColorTranslator.FromHtml("#41A6F4");
            BtnCheckReg.ForeColor = ColorTranslator.FromHtml("#FFF");
        }

        private void BtnCheckReg_Click(object sender, EventArgs e)
        {
            if (textCheckNomor.Text.ToString().Length != 11)
            {
                MessageBox.Show("ID Meteran Harus 11 Digit!!");
            }
            else
            {
                MessageBox.Show("ID Meteran Valid");
                IDMeteran = textCheckNomor.Text.ToString();
                BuyWater bw = new BuyWater();
                bw.Show();
                this.Hide();
            }
        }
    }
}
