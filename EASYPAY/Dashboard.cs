using EASYPAY.FormAir;
using EASYPAY.FormAuth;
using EASYPAY.FormDataPulsa;
using EASYPAY.FormNetflix;
using EASYPAY.FormPLN;
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

namespace EASYPAY
{
    public partial class Dashboard : Form
    {
        public static string namaUsers;
        public static string saldoFormat;
        string db = SignIn.db;
        string id = SignIn.id_user;
        public static double saldo;
        public static string nomor;
        public static string tipe_pengguna;

        MySqlConnection connection;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelSaldo.BackColor = ColorTranslator.FromHtml("#63B4F6");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelprofile.BackColor = Color.Transparent;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.ForeColor = ColorTranslator.FromHtml("#1F94F3");
            labelEwallet.BackColor = Color.Transparent;

            labelPln.BackColor = Color.Transparent;
            labelAir.BackColor = Color.Transparent;
            labelNetflix.BackColor = Color.Transparent;
            labelPulsaData.BackColor = Color.Transparent;
            labelTfBank.BackColor = Color.Transparent;
            labelIsiSaldo.BackColor = Color.Transparent;
            labelPayment.BackColor = Color.Transparent;

            DashboardDB();
            checkAktifitasKeuangan();
        }


        private void DashboardDB()
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
                    labelNama.Text = reader.GetString(1);
                    namaUsers = reader.GetString(1);
                    // if (reader.IsDBNull(2) || string.IsNullOrEmpty(reader.GetString(2)))
                    // {
                    //     labelEmail.Text = "Tidak ada email";
                    // }
                    // else
                    // {
                    //     labelEmail.Text = reader.GetString(2);
                    // }

                    // convert digit 

                    saldo = reader.GetDouble(6);
                    nomor = reader.GetString(3);
                    saldoFormat = saldo.ToString("N0");
                    tipe_pengguna = reader.GetString(5);

                    labelTP.Text = tipe_pengguna;

                    labelSaldo.Text = "Rp. " + saldoFormat;
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


        private void checkAktifitasKeuangan()
        {
            aktifitasDG.Rows.Clear();
            string[] newRow = { "", "" };

            DateTime year = DateTime.Now;
            string tahun = year.ToString("yyyy");


            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM detail_aktifitas WHERE id_pengguna = '{id}' AND tahun = '{tahun}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newRow[0] = !reader.IsDBNull(2) ? reader.GetDouble(2).ToString("N0") : "";
                    newRow[1] = !reader.IsDBNull(3) ? reader.GetDouble(3).ToString("N0") : "";
                    aktifitasDG.Rows.Add(newRow);
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

        private void label3_Click(object sender, EventArgs e)
        {
            ViewProfil vp = new ViewProfil();
            vp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChoiceWater choice = new ChoiceWater();
            choice.Show();
            this.Hide();
        }



        private void label4_Click(object sender, EventArgs e)
        {
            FormWallet.walletView wallet = new FormWallet.walletView();
            wallet.Show();
            this.Hide();
        }


        private void labelPln_Click(object sender, EventArgs e)
        {
            CheckPln cp = new CheckPln();
            cp.Show();
            this.Hide();
        }

        private void labelAir_Click(object sender, EventArgs e)
        {
            ChoiceWater choice = new ChoiceWater();
            choice.Show();
            this.Hide();
        }

        private void labelNetflix_Click(object sender, EventArgs e)
        {
            ChoiceNetflix cn = new ChoiceNetflix();
            cn.Show();
            this.Hide();
        }

        private void labelPulsaData_Click(object sender, EventArgs e)
        {
            FormDataPulsa.CheckNomor cn = new FormDataPulsa.CheckNomor();
            cn.Show();
            this.Hide();
        }

        private void labelTfBank_Click(object sender, EventArgs e)
        {
            FormTransferBank.choiceBank cb = new FormTransferBank.choiceBank();
            cb.Show();
            this.Hide();
        }

        private void labelIsiSaldo_Click(object sender, EventArgs e)
        {
            FormTopup.choiceMetode cm = new FormTopup.choiceMetode();
            cm.Show();
            this.Hide();
        }

        private void labelPayment_Click(object sender, EventArgs e)
        {
            FormTransferEasyPay.Transfer tf = new FormTransferEasyPay.Transfer();
            tf.Show();
            this.Hide();
        }

        private void labelprofile_Click(object sender, EventArgs e)
        {
            ViewProfil vp = new ViewProfil();
            vp.Show();
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
