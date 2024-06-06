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

namespace EASYPAY.FormResi.DetailResi
{
    public partial class DetailNetflix : Form
    {
        string db = SignIn.db;

        string nomor;

        MySqlConnection connection;
        public DetailNetflix(string no_transaksi)
        {
            InitializeComponent();
            nomor = no_transaksi;
        }

        private void DetailNetflix_Load(object sender, EventArgs e)
        {
            DetailCheck();
            labelNoTrx.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelKP.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelP.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelHarga.BackColor = ColorTranslator.FromHtml("#41A6F4");
            labelTgl.BackColor = ColorTranslator.FromHtml("#41A6F4");
        }

        private void DetailCheck()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM riwayat_transaksi INNER JOIN detail_netflix ON riwayat_transaksi.nomor_pembelian = '{nomor}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelNoTrx.Text = reader.GetString(2);
                    labelKP.Text = reader.GetString(3).ToUpper();
                    labelP.Text = reader.GetString(8);
                    labelHarga.Text = "Rp. " + reader.GetDouble(4).ToString("N0");
                    labelTgl.Text = reader.GetDateTime(5).ToString();
                }
                else
                {
                    MessageBox.Show($"Error Data Detail Tidak Ada");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
