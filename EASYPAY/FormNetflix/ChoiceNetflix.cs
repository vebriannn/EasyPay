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

namespace EASYPAY.FormNetflix
{
    public partial class ChoiceNetflix : Form
    {
        public static string produk = "";
        private int pilihHarga = 0;
        private double sisaSaldo = 0;


        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public ChoiceNetflix()
        {
            InitializeComponent();
        }

        private void ChoiceNetflix_Load(object sender, EventArgs e)
        {
            btn30.FlatStyle = FlatStyle.Flat;
            btn30.FlatAppearance.BorderSize = 0;
            btn30.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn55.FlatStyle = FlatStyle.Flat;
            btn55.FlatAppearance.BorderSize = 0;
            btn55.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn70.FlatStyle = FlatStyle.Flat;
            btn70.FlatAppearance.BorderSize = 0;
            btn70.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn85.FlatStyle = FlatStyle.Flat;
            btn85.FlatAppearance.BorderSize = 0;
            btn85.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn110.FlatStyle = FlatStyle.Flat;
            btn110.FlatAppearance.BorderSize = 0;
            btn110.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn125.FlatStyle = FlatStyle.Flat;
            btn125.FlatAppearance.BorderSize = 0;
            btn125.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");
        }

        public void checkBtnBuy()
        {
            if (pilihHarga != 0)
            {
                BtnConfirmBuy.Visible = true;
            }
            else
            {
                BtnConfirmBuy.Visible = false;
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            pilihHarga = 30000;
            produk = "Premium 1 Bulan";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            pilihHarga = 55000;
            produk = "Premium 3 Bulan";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn70_Click(object sender, EventArgs e)
        {
            pilihHarga = 70000;
            produk = "Premium 5 Bulan";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn85_Click(object sender, EventArgs e)
        {
            pilihHarga = 85000;
            produk = "Premium 6 Bulan";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            pilihHarga = 110000;
            produk = "Premium 8 Bulan";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn125_Click(object sender, EventArgs e)
        {
            pilihHarga = 125000;
            produk = "Premium 1 Tahun";
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void BtnConfirmBuy_Click(object sender, EventArgs e)
        {
            checkSaldo();
        }

        private void checkSaldo()
        {
            double saldo = 0;

            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"SELECT saldo_wallet FROM users WHERE id = '{id}'";
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
                updatedUsers.updateSaldo("saldo_wallet", sisaSaldo, "netflix", pilihHarga);
                this.Hide();

            }
            else
            {
                MessageBox.Show($"Maaf Saldo Saldo Wallet Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

    }

}
