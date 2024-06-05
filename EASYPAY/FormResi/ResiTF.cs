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
    public partial class ResiTF : Form
    {
        string nama;
        double totaltf;
        DateTime date;
        string Fee;
        public ResiTF(string nama, int totaltf, DateTime Date, string fee)
        {
            InitializeComponent();
            this.nama = nama;
            this.totaltf = totaltf;
            this.date = Date;
            this.Fee = fee;
        }

        private void ResiTF_Load(object sender, EventArgs e)
        {
            labelSend.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelAmount.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelDate.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelFee.BackColor = ColorTranslator.FromHtml("#41A6F4");

            labelSend.Text = nama;
            labelAmount.Text = "RP." + totaltf.ToString("N0");
            labelDate.Text = date.ToString();
            labelFee.Text = "Rp." + Fee.ToString();
      
        }

    }
}
