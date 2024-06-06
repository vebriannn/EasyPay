using EASYPAY.Backend;
using EASYPAY.FormAuth;
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

namespace EASYPAY.FormTransferEasyPay
{

    public partial class Transfer : Form
    {
        string db = SignIn.db;
        string id = SignIn.id_user;
        string nomor = Dashboard.nomor;
        double saldoPengirim = Dashboard.saldo;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        MySqlConnection connection;

        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            textNumber.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textJumlah.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textPesan.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btnKonfir.FlatStyle = FlatStyle.Flat;
            btnKonfir.FlatAppearance.BorderSize = 0;
            btnKonfir.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnKonfir.ForeColor = Color.White;

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void btnKonfir_Click(object sender, EventArgs e)
        {
            if(nomor != textNumber.Text.ToString())
            {
                if(Convert.ToInt32(saldoPengirim) < Convert.ToInt32(textJumlah.Text.ToString()))
                {
                    MessageBox.Show("Maaf Saldo Tidak Mencukupi!");
                    return;
                }
                else
                {
                    checkNomor();
                }
            }
            else
            {
                MessageBox.Show("Maaf Anda Tidak Bisa Menggunakan Nomor Anda!!!");
            }
        }

        // check nomor target
        private void checkNomor()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM users WHERE nomor = '{textNumber.Text}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int saldoUsers = Convert.ToInt32(reader.GetDouble(6));
                    int totalkan = saldoUsers + Convert.ToInt32(textJumlah.Text.ToString());
                    double saldo = Convert.ToDouble(totalkan);

                    updateSaldoUsers(saldo);
                }
                else
                {
                    MessageBox.Show($"Error Nomor Tidak Terdaftar!");
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

        // update users saldo target
        private void updateSaldoUsers(double saldo)
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryInsert = $"UPDATE users SET saldo_wallet = '{saldo}' WHERE nomor = '{textNumber.Text}'";
                MySqlCommand cmd = new MySqlCommand(queryInsert, connection);
                int db = cmd.ExecuteNonQuery();
                if (db > 0)
                {
                    updatedNomorSaldo();
                }
                else
                {
                    MessageBox.Show($"Gagal Update Saldo Target");
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

        // update saldo pengirim
        private void updatedNomorSaldo()
        {
            connection = new MySqlConnection(db);

            int total = Convert.ToInt32(saldoPengirim) - Convert.ToInt32(textJumlah.Text.ToString());

            double saldoo = Convert.ToDouble(total); 

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET saldo_wallet = '{saldoo}' WHERE id = '{id}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    InsertDataPengeluaran();
                }
                else
                {
                    MessageBox.Show("Pembayaran Gagal, Ada Beberapa Kesalahan!!!");
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

        private void InsertDataPengeluaran()
        {
            DateTime year = DateTime.Now;
            string tahun = year.ToString("yyyy");

            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO detail_aktifitas(id_pengguna, saldo_keluar, tahun) VALUES('{id}', '{Convert.ToDouble(textJumlah.Text)}', '{tahun}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {

                                        Alert at = new Alert();
                    at.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan Data!!!");
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
