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

namespace EASYPAY.FormTransferBank
{
    public partial class Transfer : Form
    {
        string namaBk = choiceBank.namaBank;
        public static string norek = "";

        string db = SignIn.db;
        string id = SignIn.id_user;
        private double sisaSaldo = 0;

        MySqlConnection connection;
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            namaBank.Text = namaBk.ToString();

            namaBank.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textNomorBk.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textSaldoBk.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textPesan.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btnTranfer.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnTranfer.ForeColor = Color.White;
            btnTranfer.FlatStyle = FlatStyle.Flat;
            btnTranfer.FlatAppearance.BorderSize = 0;

        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            int totaltf = Convert.ToInt32(textSaldoBk.Text.ToString());
            norek = textNomorBk.Text.ToString();
            checkSaldo(totaltf);
        }

        private void checkSaldo(int totaltf)
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
                    totaltf += 2500;
                    int saldoo = Convert.ToInt32(saldo) - totaltf;
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

            if (saldo >= totaltf)
            {;
                detailAktifitas(totaltf);

            }
            else
            {
                MessageBox.Show($"Maaf Saldo Saldo Wallet Tidak Mencukupi, Untuk Melanjutkan Transaksi");
            }
        }


        private void detailAktifitas(int totaltf)
        {

            DateTime year = DateTime.Now;
            string tahun = year.ToString("yyyy");

            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO detail_aktifitas(id_pengguna, saldo_keluar, tahun) VALUES('{id}', '{totaltf}', '{tahun}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    UpdatedUsers updatedUsers = new UpdatedUsers();
                    updatedUsers.updateSaldo("saldo_wallet", sisaSaldo, "tfbank", totaltf);
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
