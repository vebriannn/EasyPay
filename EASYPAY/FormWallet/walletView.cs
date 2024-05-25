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

namespace EASYPAY.FormWallet
{
    public partial class walletView : Form
    {

        string id = SignIn.id_user;
        string db = SignIn.db;
        string saldo = Dashboard.saldoFormat;

        MySqlConnection connection;

        public walletView()
        {
            InitializeComponent();
        }

        private void walletView_Load(object sender, EventArgs e)
        {
            historyDG.ReadOnly = true;
            checkDataGrid();

            labelSaldo.BackColor = ColorTranslator.FromHtml("#63B4F6");

            labelSaldo.Text = "Rp. " + saldo;
        }

        private void checkDataGrid()
        {
            historyDG.Rows.Clear();
            string[] newRow = { "", "", "", "" };

            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM riwayat_transaksi WHERE id_pengguna = '{id}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        newRow[0] = reader.GetString(2);
                        newRow[1] = reader.GetString(3);
                        newRow[2] = reader.GetDouble(4).ToString();
                        newRow[3] = reader.GetDateTime(5).ToString();
                        historyDG.Rows.Add(newRow);
                    }
                }
                else
                {
                    MessageBox.Show($"Maaf Data Tidak Ada!!!");
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

        private void historyDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Ingin Check History Transaksi?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Resi resi = new Resi(historyDG.CurrentRow.Cells[0].Value.ToString());
                resi.Show();
                this.Hide();
            }
        }
    }
}
