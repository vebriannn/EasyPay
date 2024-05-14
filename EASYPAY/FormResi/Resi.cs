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

        MySqlConnection connection;

        public Resi(string nomorPembelian)
        {
            InitializeComponent();
            this.no_transaksi = nomorPembelian;
        }

        private void Resi_Load(object sender, EventArgs e)
        {
            labelNoTrx.BackColor = ColorTranslator.FromHtml("#41A6F4");
;           labelJP.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelHarga.BackColor = ColorTranslator.FromHtml("#41A6F4");
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

                    labelNoTrx.Text = reader.GetString(2);
                    labelJP.Text = reader.GetString(3).ToUpper();
                    labelHarga.Text = "Rp. " + saldoFormat;
                    labelDate.Text = reader.GetDateTime(5).ToString();
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
    }
}
