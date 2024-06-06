using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormTransferEasyPay
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.ForeColor = ColorTranslator.FromHtml("#41A6F4");
            btnBack.BackColor = Color.White;
        }
    }
}
