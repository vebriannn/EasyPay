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

namespace EASYPAY.FormAuth
{
    public partial class SignUp : Form
    {

        string db = SignIn.db;
        MySqlConnection connection;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            BtnSignUp.FlatStyle = FlatStyle.Flat;
            BtnSignUp.FlatAppearance.BorderSize = 0;
            BtnSignUp.BackColor = ColorTranslator.FromHtml("#64CFF3");
            BtnSignUp.ForeColor = ColorTranslator.FromHtml("#FFF");
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (textCreateNama.Text.ToString() == "" && textCreateEmail.Text.ToString() == "" && textCreateNomor.Text.ToString() == "" && textCreatePin.Text.ToString() == "")
            {
                MessageBox.Show("Maaf Input Tidak Boleh Kosong, Mohon Isi Semua Data Pada Kolom Input!!!");
            }
            else
            {
                if(textCreatePin.Text.ToString() == textKonfirmasiPin.Text.ToString())
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
                            ProsesCreateData(textCreateNama.Text.ToString(), textCreateEmail.Text.ToString(), textCreateNomor.Text.ToString(), textCreatePin.Text.ToString());
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
                else
                {
                    MessageBox.Show("Maaf Input Pin Dengan Konfirmasi Pin Harus Sama!!!");
                }
            }
        }

        public void ProsesCreateData(string nama, string email, string nomor, string pin)
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO users (nama, email, nomor, pin) VALUES('{nama}', '{email}', '{nomor}', '{pin}') "; ;
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

    }
}
