using EASYPAY.FormAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY
{
    public partial class OnBoarding : Form
    {
        public OnBoarding()
        {
            InitializeComponent();
        }

        private void onboarding_Load(object sender, EventArgs e)
        {
            // BackColor
            label1.BackColor = ColorTranslator.FromHtml("#64CFF3");
            BtnLinkSignIn.BackColor = ColorTranslator.FromHtml("#64CFF3");
            BtnLinkSignUp.BackColor = ColorTranslator.FromHtml("#64CFF3");

            // hilangkan outline button
            BtnLinkSignIn.FlatStyle = FlatStyle.Flat;
            BtnLinkSignIn.FlatAppearance.BorderSize = 0;
            BtnLinkSignUp.FlatStyle = FlatStyle.Flat;
            BtnLinkSignUp.FlatAppearance.BorderSize = 0;
        }

        private void BtnLinkSignIn_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
            this.Hide();
        }

        private void BtnLinkSignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }
    }
}
