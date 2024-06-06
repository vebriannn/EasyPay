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

namespace EASYPAY.FormDataPulsa.Pulsa
{
    public partial class ChoicePulsa : Form
    {
        public static string produk = "";
        private int pilihHarga = 0;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;


        string db = SignIn.db;
        string id = SignIn.id_user;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        MySqlConnection connection;

        public ChoicePulsa()
        {
            InitializeComponent();
        }

        private void ChoicePulsa_Load(object sender, EventArgs e)
        {
            btn50.FlatStyle = FlatStyle.Flat;
            btn50.FlatAppearance.BorderSize = 0;
            btn50.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn100.FlatStyle = FlatStyle.Flat;
            btn100.FlatAppearance.BorderSize = 0;
            btn100.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn150.FlatStyle = FlatStyle.Flat;
            btn150.FlatAppearance.BorderSize = 0;
            btn150.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn200.FlatStyle = FlatStyle.Flat;
            btn200.FlatAppearance.BorderSize = 0;
            btn200.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn250.FlatStyle = FlatStyle.Flat;
            btn250.FlatAppearance.BorderSize = 0;
            btn250.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn300.FlatStyle = FlatStyle.Flat;
            btn300.FlatAppearance.BorderSize = 0;
            btn300.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            checkBoxBalance.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            pilihHarga = 52000;
            produk = "Paket 50,000 30 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            pilihHarga = 102000;
            produk = "Paket 100,000 120 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn150_Click(object sender, EventArgs e)
        {
            pilihHarga = 152000;
            produk = "Paket 150,000 150 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            pilihHarga = 202000;
            produk = "Paket 200,000 200 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();

        }

        private void btn250_Click(object sender, EventArgs e)
        {
            pilihHarga = 252000;
            produk = "Paket 250,000 200 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            pilihHarga = 305000;
            produk = "Paket 300,000 300 Hari";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void checkBoxBalance_CheckedChanged(object sender, EventArgs e)
        {
            methodBayar = "Wallet";
            checkBtnBuy();
        }

        private void BtnConfirmBuy_Click_1(object sender, EventArgs e)
        {
            checkSaldo();
        }

        public void checkBtnBuy()
        {
            if (pilihHarga != 0 && methodBayar == "Wallet")
            {
                BtnConfirmBuy.Visible = true;
            }
            else
            {
                BtnConfirmBuy.Visible = false;
            }
        }

        private void checkSaldo()
        {
            double saldo = 0;

            if (methodBayar == "Wallet")
            {
                column = "saldo_wallet";
            }
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"SELECT {column} FROM users WHERE id = '{id}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    saldo = reader.GetDouble(0);
                    int saldoo = Convert.ToInt32(saldo) - pilihHarga;
                    sisaSaldo = Convert.ToDouble(saldoo);
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

            if (saldo >= pilihHarga)
            {
                UpdatedUsers updatedUsers = new UpdatedUsers();
                updatedUsers.updateSaldo(column, sisaSaldo, "pulsa", pilihHarga);
                this.Hide();

            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

    }
}
