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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EASYPAY
{
    public partial class FormSignIn : Form
    {
        // field untuk menyambungkan database
        public static string db = "SERVER=localhost;DATABASE=ewallet;UID=root;PASSWORD=";
        public static string id_user;

        MySqlConnection connection;

        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            BtnLinkSignUp.FlatStyle = FlatStyle.Flat;
            BtnLinkSignUp.FlatAppearance.BorderSize = 0;
            BtnLinkSignUp.ForeColor = ColorTranslator.FromHtml("#64CFF3");

            BtnSignIn.FlatStyle = FlatStyle.Flat;
            BtnSignIn.FlatAppearance.BorderSize = 0;
            BtnSignIn.BackColor = ColorTranslator.FromHtml("#64CFF3");
            BtnSignIn.ForeColor = ColorTranslator.FromHtml("#FFF");
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (textNomor.Text.ToString() != "" && textPin.Text.ToString() != "")
            {
                checkDataLogin(textNomor.Text.ToString(), textPin.Text.ToString());
            }
            else
            {
                MessageBox.Show($"Maaf Inputan Tidak Boleh Kosong");
            }
        }

        public void checkDataLogin(string nomor, string pin)
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM users WHERE nomor = '{nomor}' AND pin = '{pin}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id_user = reader.GetInt32(0).ToString();

                    // instance ke form selanjutnya
                    FormDashboard dh = new FormDashboard();
                    dh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Error Users Tidak Terdaftar!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Mysql: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
