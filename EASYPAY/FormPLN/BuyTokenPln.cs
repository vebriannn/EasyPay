﻿using EASYPAY.Backend;
using EASYPAY.FormAuth;
using EASYPAY.FormHslPbyr;
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

namespace EASYPAY.FormPLN
{
    public partial class BuyTokenPln : Form
    {
        private int pilihHarga = 0;
        private string column = "";
        private string methodBayar;
        private double sisaSaldo = 0;


        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public BuyTokenPln()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            Btn50.FlatStyle = FlatStyle.Flat;
            Btn50.FlatAppearance.BorderSize = 0;
            Btn50.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            Btn150.FlatStyle = FlatStyle.Flat;
            Btn150.FlatAppearance.BorderSize = 0;
            Btn150.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            Btn300.FlatStyle = FlatStyle.Flat;
            Btn300.FlatAppearance.BorderSize = 0;
            Btn300.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            checkBoxBalance.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            BtnConfirmBuy.Visible = false;

            BtnConfirmBuy.FlatStyle = FlatStyle.Flat;
            BtnConfirmBuy.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            labelNomor.Text = CheckPln.IDMeteran;
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            pilihHarga = 52000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void Btn150_Click(object sender, EventArgs e)
        {
            pilihHarga = 152000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void Btn300_Click(object sender, EventArgs e)
        {
            pilihHarga = 250000;
            MessageBox.Show("Token Listrik Dengan Harga " + pilihHarga.ToString("N0") + " Berhasil Di Pilih");
            checkBtnBuy();
        }

        private void checkBoxBalance_CheckedChanged(object sender, EventArgs e)
        {
            methodBayar = "Wallet";
            checkBtnBuy();
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
                updatedUsers.updateSaldo(column, sisaSaldo, "pln", pilihHarga);
                this.Close();

            }
            else
            {
                MessageBox.Show($"Maaf Saldo {methodBayar} Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }

    }
}
