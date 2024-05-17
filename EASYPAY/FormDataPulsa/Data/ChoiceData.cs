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

namespace EASYPAY.FormDataPulsa.Data
{


    public partial class ChoiceData : Form
    {

        private int pilihHarga = 0;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;


        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public ChoiceData()
        {
            InitializeComponent();
        }

        private void ChoiceData_Load(object sender, EventArgs e)
        {
            btn225.FlatStyle = FlatStyle.Flat;
            btn225.FlatAppearance.BorderSize = 0;
            btn225.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn100.FlatStyle = FlatStyle.Flat;
            btn100.FlatAppearance.BorderSize = 0;
            btn100.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn145.FlatStyle = FlatStyle.Flat;
            btn145.FlatAppearance.BorderSize = 0;
            btn145.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn33.FlatStyle = FlatStyle.Flat;
            btn33.FlatAppearance.BorderSize = 0;
            btn33.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn44.FlatStyle = FlatStyle.Flat;
            btn44.FlatAppearance.BorderSize = 0;
            btn44.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btn20.FlatStyle = FlatStyle.Flat;
            btn20.FlatAppearance.BorderSize = 0;
            btn20.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            checkBoxBalance.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            checkBoxSavings.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");
        }

        private void btn225_Click(object sender, EventArgs e)
        {
            pilihHarga = 225000;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            pilihHarga = 100000;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn145_Click(object sender, EventArgs e)
        {
            pilihHarga = 14500;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            pilihHarga = 33000;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            pilihHarga = 44000;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            pilihHarga = 20000;
            MessageBox.Show("Paket Data Dengan Harga " + pilihHarga + " Berhasil Di Pilih");
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

        private void BtnConfirmBuy_Click(object sender, EventArgs e)
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
                updatedUsers.updateSaldo(column, sisaSaldo, "data", pilihHarga);

            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

    }
}
