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
    public partial class ChoiceWater : Form
    {

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        public ChoiceWater()
        {
            InitializeComponent();
        }

        private void ChoiceWater_Load(object sender, EventArgs e)
        {


            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckWater cW = new CheckWater();
            cW.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckWater cW = new CheckWater();
            cW.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckWater cW = new CheckWater();
            cW.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckWater cW = new CheckWater();
            cW.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckWater cW = new CheckWater();
            cW.Show();
            this.Hide();
        }
    }
}
