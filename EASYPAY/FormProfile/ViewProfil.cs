﻿using EASYPAY.FormAuth;
using EASYPAY.FormProfile;
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

namespace EASYPAY.profile
{
    public partial class ViewProfil : Form
    {
        string db = SignIn.db;
        string id = SignIn.id_user;

        public static string namaUser;
        public static string GenderUser;
        public static string nomorUser;
        public static string pinUser;
        string tipeUsers;

        MySqlConnection connection;

        public ViewProfil()
        {
            InitializeComponent();
        }

        private void ViewProfil_Load(object sender, EventArgs e)
        {
            GetDataDB();
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelprofile.BackColor = Color.Transparent;
            labelprofile.ForeColor = ColorTranslator.FromHtml("#1F94F3");
            labelDashboard.BackColor = Color.Transparent;
            labelEwallet.BackColor = Color.Transparent;

            labelNama.Text = namaUser;
            labelTP.Text = tipeUsers;
            


            label1.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label2.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label3.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label4.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label5.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            btnUpgrade.FlatStyle = FlatStyle.Flat;
            btnUpgrade.FlatAppearance.BorderSize = 0;
            btnUpgrade.BackColor = ColorTranslator.FromHtml("#41A6F4");

            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.BackColor = ColorTranslator.FromHtml("#41A6F4");

            if (label5.Text.ToString() == "premium")
            {
                btnUpgrade.Text = "Premium";
                btnUpgrade.Enabled = false;
            }
            else
            {
                btnUpgrade.Text = "Upgrade";
            }
        }

        private void GetDataDB()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM users WHERE id = '{id}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // labelNama.Text = reader.GetString(1);
                    label1.Text = reader.GetString(1);
                    label2.Text = reader.GetString(2);
                    label3.Text = reader.GetString(3);
                    label4.Text = reader.GetString(4);
                    label5.Text = reader.GetString(5);

                    namaUser = reader.GetString(1);
                    GenderUser = reader.GetString(2);
                    nomorUser = reader.GetString(3);
                    tipeUsers = reader.GetString(5);
                    pinUser = reader.GetString(4);

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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
            this.Hide();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            premiumAkun pa = new premiumAkun();
            pa.Show();
            this.Hide();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void labelEwallet_Click(object sender, EventArgs e)
        {
            FormWallet.walletView wv = new FormWallet.walletView();
            wv.Show();
            this.Hide();
        }
    }
}
