using EASYPAY.Backend;
using EASYPAY.FormAuth;
using EASYPAY.FormHslPbyr;
using EASYPAY.FormPLN;
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

namespace EASYPAY.FormAir
{
    public partial class BuyWater : Form
    {
        private int pilihHarga = 0;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public BuyWater()
        {
            InitializeComponent();
        }

        private void BuyWater_Load(object sender, EventArgs e)
        {
            Btn50.FlatStyle = FlatStyle.Flat;
            Btn50.FlatAppearance.BorderSize = 0;
            Btn50.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            checkBoxBalance.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.Text = CheckWater.IDMeteran;

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            pilihHarga = 52000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void checkBtnBuy()
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

        private void BtnConfirmBuy_Click(object sender, EventArgs e)
        {
            checkSaldo();
        }

        private void checkSaldo()
        {
            double saldo = 0;
            connection = new MySqlConnection(db);

            if (methodBayar == "Wallet")
            {
                column = "saldo_wallet";
            }

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
                updatedUsers.updateSaldo(column, sisaSaldo, "pdam", pilihHarga);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

        private void checkBoxBalance_CheckedChanged(object sender, EventArgs e)
        {
            methodBayar = "Wallet";
            checkBtnBuy();
        }
    }
}
