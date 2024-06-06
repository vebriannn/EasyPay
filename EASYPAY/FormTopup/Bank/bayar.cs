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

namespace EASYPAY.FormTopup.Bank
{
    public partial class bayar : Form
    {

        string db = SignIn.db;
        string id = SignIn.id_user;


        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        int saldoAgent = 0;

        MySqlConnection connection;

        public bayar()
        {
            InitializeComponent();
        }

        private void bayar_Load(object sender, EventArgs e)
        {
            btnKonfir.FlatStyle = FlatStyle.Flat;
            btnKonfir.FlatAppearance.BorderSize = 0;
            btnKonfir.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnKonfir.ForeColor = Color.White;

            textNoRek.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textSaldo.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            pictureBox1.Image = FormTopup.choiceMetode.url_images;

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void btnKonfir_Click(object sender, EventArgs e)
        {

            updateSaldo();
        }


        private void updateSaldo()
        {
            connection = new MySqlConnection(db);
            int jumlah = Convert.ToInt32(textSaldo.Text);
            DateTime tanggal = DateTime.Now;
            string nama = Dashboard.namaUsers;

            int totalSaldo = Convert.ToInt32(Dashboard.saldo) + jumlah;

            double Saldo = Convert.ToDouble(totalSaldo);

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET saldo_wallet = '{Saldo}' WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    InsertDataPengeluaran(nama, jumlah, tanggal);
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

        private void InsertDataPengeluaran(string nama, int jumlah, DateTime tanggal)
        {
            DateTime year = DateTime.Now;
            string tahun = year.ToString("yyyy");
            
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO detail_aktifitas(id_pengguna, saldo_masuk, tahun) VALUES('{id}', '{Convert.ToDouble(textSaldo.Text)}', '{tahun}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {

                    FormResi.FormTopupBank ftb = new FormResi.FormTopupBank(nama, jumlah, tanggal);
                    ftb.Show();
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
