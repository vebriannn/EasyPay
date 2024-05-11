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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EASYPAY
{
    public partial class FormSignUp : Form
    {

        string db = FormSignIn.db;
        MySqlConnection connection;

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            BtnLinkSignIn.FlatStyle = FlatStyle.Flat;
            BtnLinkSignIn.FlatAppearance.BorderSize = 0;
            BtnLinkSignIn.ForeColor = ColorTranslator.FromHtml("#64CFF3");

            BtnSignUp.FlatStyle = FlatStyle.Flat;
            BtnSignUp.FlatAppearance.BorderSize = 0;
            BtnSignUp.BackColor = ColorTranslator.FromHtml("#64CFF3");
            BtnSignUp.ForeColor = ColorTranslator.FromHtml("#FFF");
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (textCreateNama.Text.ToString() == "" && textCreateNomor.Text.ToString() == "" && textCreatePin.Text.ToString() == "")
            {
                MessageBox.Show("Maaf Input Tidak Boleh Kosong");
            }
            else
            {
                connection = new MySqlConnection(db);

                try
                {
                    connection.Open();
                    string queryCheck = $"SELECT * FROM users WHERE nomor = '{textCreateNomor.Text.ToString()}'";
                    MySqlCommand command = new MySqlCommand(queryCheck, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Maaf Nomor Sudah Terdaftar, Gunakan Nomor Baru Untuk Mendaftar");
                    }
                    else
                    {
                        ProsesCreateData(textCreateNama.Text.ToString(), textCreateNomor.Text.ToString(), textCreatePin.Text.ToString());
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


        public void ProsesCreateData(string nama, string nomor, string pin)
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO users (nama, nomor, pin, tipe_pengguna) VALUES('{nama}', '{nomor}', '{pin}', 'free') "; ;
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int execute = command.ExecuteNonQuery();
                if (execute > 0)
                {
                    MessageBox.Show("Akun Berhasil Di Buat!");
                }
                else
                {
                    MessageBox.Show("Akun Gagal Di Buat!");
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

        private void BtnLinkSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn si = new FormSignIn();
            si.Show();
            this.Hide();
        }
    }
}
