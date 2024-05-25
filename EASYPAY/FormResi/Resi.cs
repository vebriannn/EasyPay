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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EASYPAY.FormHslPbyr
{
    public partial class Resi : Form
    {
        string db = SignIn.db;
        string no_transaksi;
        string jenis_pembelian;

        MySqlConnection connection;

        public Resi(string nomorPembelian)
        {
            InitializeComponent();
            this.no_transaksi = nomorPembelian;
        }

        private void Resi_Load(object sender, EventArgs e)
        {
            detail.FlatStyle = FlatStyle.Flat;
            detail.FlatAppearance.BorderSize = 0;

            labelNoTrx.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelJP.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelHarga.BackColor = ColorTranslator.FromHtml("#41A6F4");
            detail.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelDate.BackColor = ColorTranslator.FromHtml("#41A6F4");
            checkTransaksi();
        }

        private void checkTransaksi()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM riwayat_transaksi WHERE nomor_pembelian = '{no_transaksi}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string saldoFormat = reader.GetDouble(4).ToString("N0");

                    labelNoTrx.Text = reader.GetString(2).ToUpper();
                    labelJP.Text = reader.GetString(3).ToUpper();
                    labelHarga.Text = "Rp. " + saldoFormat;
                    labelDate.Text = reader.GetDateTime(5).ToString();
                    jenis_pembelian = reader.GetString(3);
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

        private void detail_Click(object sender, EventArgs e)
        {
            if(jenis_pembelian == "pln")
            {
                FormResi.DetailResi.DetailPln dp = new FormResi.DetailResi.DetailPln(no_transaksi);
                dp.Show();
                this.Hide();
            }
            else if(jenis_pembelian == "pdam")
            {
                FormResi.DetailResi.DetailPdam dp = new FormResi.DetailResi.DetailPdam(no_transaksi);
                dp.Show();
                this.Hide();
            }
            else if(jenis_pembelian == "pulsa" || jenis_pembelian == "data")
            {
                FormResi.DetailResi.DetailPulsaData dp = new FormResi.DetailResi.DetailPulsaData(no_transaksi);
                dp.Show();
                this.Hide();
            }
        }
    }
}
