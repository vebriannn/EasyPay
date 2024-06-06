using EASYPAY.FormAuth;
using EASYPAY.FormHslPbyr;
using EASYPAY.profile;
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

        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

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
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelprofile.BackColor = Color.Transparent;
            labelDashboard.BackColor = Color.Transparent;
            labelEwallet.BackColor = Color.Transparent;
            labelEwallet.ForeColor = ColorTranslator.FromHtml("#1F94F3");

            labelSaldo.Text = "Rp. " + saldo;

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
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
                while (reader.Read())
                {
                    newRow[0] = reader.GetString(2);
                    newRow[1] = reader.GetString(3);
                    newRow[2] = reader.GetDouble(4).ToString("N0");
                    newRow[3] = reader.GetDateTime(5).ToString();
                    historyDG.Rows.Add(newRow);
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

        private void labelDashboard_Click(object sender, EventArgs e)
        {
           Dashboard dn = new Dashboard();
            dn.Show();
            this.Hide();
        }

        private void labelprofile_Click(object sender, EventArgs e)
        {
            ViewProfil vp = new ViewProfil();
            vp.Show();
            this.Hide();
        }
    }
}
