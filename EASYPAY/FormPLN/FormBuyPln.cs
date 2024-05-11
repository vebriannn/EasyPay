using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormPLN
{
    public partial class FormBuyPln : Form
    {

        public static int pilihHarga = 0;
        public static string nomor_pembelian;
        public static string tanggalPembelianString;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;

        string db = FormSignIn.db;
        string id = FormSignIn.id_user;

        MySqlConnection connection;

        public FormBuyPln()
        {
            InitializeComponent();
        }

        private void FormBuyPln_Load(object sender, EventArgs e)
        {
            Btn50.FlatStyle = FlatStyle.Flat;
            Btn50.FlatAppearance.BorderSize = 0;
            Btn50.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            Btn100.FlatStyle = FlatStyle.Flat;
            Btn100.FlatAppearance.BorderSize = 0;
            Btn100.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            Btn150.FlatStyle = FlatStyle.Flat;
            Btn150.FlatAppearance.BorderSize = 0;
            Btn150.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            Btn300.FlatStyle = FlatStyle.Flat;
            Btn300.FlatAppearance.BorderSize = 0;
            Btn300.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            checkBoxBalance.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            checkBoxSavings.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.Text = FormCheckPln.IDMeteran;


        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            pilihHarga = 52000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void Btn100_Click(object sender, EventArgs e)
        {
            pilihHarga = 102000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void Btn150_Click(object sender, EventArgs e)
        {
            pilihHarga = 152000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void Btn300_Click(object sender, EventArgs e)
        {
            pilihHarga = 48000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void checkBoxBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSavings.Checked == true)
            {
                checkBoxSavings.Checked = false;
            }
            methodBayar = "Wallet";
            checkBtnBuy();
        }

        private void checkBoxSavings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBalance.Checked == true)
            {
                checkBoxBalance.Checked = false;
            }
            methodBayar = "Savings";
            checkBtnBuy();
        }

        public void checkBtnBuy()
        {
            if (pilihHarga != 0 && methodBayar == "Wallet" || methodBayar == "Savings")
            {
                BtnConfirmBuy.Visible = true;
            }
            else
            {
                BtnConfirmBuy.Visible = false;
            }
        }

        private void BtnConfirmBuy_Click(object sender, EventArgs e)
        {
            checkSaldo();
        }

        private void checkSaldo()
        {
            double saldo = 0;

            if (methodBayar == "Wallet")
            {
                column = "saldo_wallet";
            }
            else if(methodBayar == "Savings")
            {
                column = "saldo_savings";
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

            if(saldo >= pilihHarga)
            {
                updateSaldo();
            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

        private void updateSaldo()
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET {column} = '{sisaSaldo}' WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if(reader > 0)
                {
                    AddDataTransaction("pln");
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
        private void AddDataTransaction(string jenis_pembelian)
        {

            connection = new MySqlConnection(db);

            DateTime tanggalPembelian = DateTime.Now;
            tanggalPembelianString = tanggalPembelian.ToString("yyyy-MM-dd HH:mm:ss");
            nomor_pembelian = generateNomorTransaksi();

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO data_transaksi (id_pengguna, nomor_pembelian, jenis_pembelian,  harga, tanggal_pembelian) VALUES ('{id}', '{nomor_pembelian}', '{jenis_pembelian}', '{pilihHarga}', '{tanggalPembelianString}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    FormResultsTrxPln frtp = new FormResultsTrxPln();
                    frtp.Show();
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

        private void GenerateToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder(20);

            // Menghasilkan string acak dengan panjang tertentu
            for (int i = 0; i < 20; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }
        }

        private string generateNomorTransaksi()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder(10);

            // Menghasilkan string acak dengan panjang tertentu
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }
    }
}
