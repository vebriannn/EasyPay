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
        private int pilihHarga = 0;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;


        string db = SignIn.db;
        string id = SignIn.id_user;

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
            checkBoxSavings.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            pilihHarga = 52000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            pilihHarga = 102000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn150_Click(object sender, EventArgs e)
        {
            pilihHarga = 152000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            pilihHarga = 202000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();

        }

        private void btn250_Click(object sender, EventArgs e)
        {
            pilihHarga = 252000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            pilihHarga = 305000;
            MessageBox.Show("Pulsa Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
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

        private void checkBoxBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSavings.Checked == true)
            {
                checkBoxSavings.Checked = false;
            }
            methodBayar = "Wallet";
            checkBtnBuy();
        }

        private void BtnConfirmBuy_Click_1(object sender, EventArgs e)
        {
            checkSaldo();
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

        private void checkSaldo()
        {
            double saldo = 0;

            if (methodBayar == "Wallet")
            {
                column = "saldo_wallet";
            }
            else if (methodBayar == "Savings")
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

            if (saldo >= pilihHarga)
            {
                UpdatedUsers updatedUsers = new UpdatedUsers();
                updatedUsers.updateSaldo(column, sisaSaldo, "pulsa", pilihHarga);

            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

    }
}
