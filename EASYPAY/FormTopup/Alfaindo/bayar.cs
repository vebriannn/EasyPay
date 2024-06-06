using EASYPAY.Backend;
using EASYPAY.FormAuth;
using EASYPAY.FormTransferBank;
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

namespace EASYPAY.FormTopup.Alfaindo
{
    public partial class bayar : Form
    {

        string db = SignIn.db;
        string id = SignIn.id_user;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        int saldoAgent = 0;

        MySqlConnection connection;

        public bayar(int saldoAgn)
        {
            InitializeComponent();

            saldoAgent = saldoAgn;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {


            DateTime year = DateTime.Now;
            string tahun = year.ToString("yyyy");

            double saldoo = Convert.ToDouble(saldoAgent);

            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO detail_aktifitas(id_pengguna, saldo_masuk, tahun) VALUES('{id}', '{saldoo}', '{tahun}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    updateSaldo();
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

        public void updateSaldo()
        {

            connection = new MySqlConnection(db);

            int totalSaldo = Convert.ToInt32(Dashboard.saldo) + saldoAgent;

            double Saldo = Convert.ToDouble(totalSaldo);

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET saldo_wallet = '{Saldo}' WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    MessageBox.Show("Tunggu Beberapa Saat, Saldo Anda Akan Terkirim!!!");
                    Thread.Sleep(1000);
                    MessageBox.Show("Saldo Anda Sudah Terkirim!");
                    Thread.Sleep(1000);
                    Dashboard db = new Dashboard();
                    db.Show();
                    this.Hide();
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

        private void bayar_Load(object sender, EventArgs e)
        {
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;

            btnBayar.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.ForeColor = Color.White;
        }
    }

}

