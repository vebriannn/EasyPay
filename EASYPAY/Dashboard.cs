using EASYPAY.FormAir;
using EASYPAY.FormAuth;
using EASYPAY.FormDataPulsa;
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
        string db = SignIn.db;
        string id = SignIn.id_user;
        double saldo;

        MySqlConnection connection;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelEmail.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelSaldo.BackColor = ColorTranslator.FromHtml("#63B4F6");
            pictureDashboard.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            labelEmail.ForeColor = ColorTranslator.FromHtml("#625E5E");

            DashboardDB();
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
                    if (reader.IsDBNull(2) || string.IsNullOrEmpty(reader.GetString(2)))
                    {
                        labelEmail.Text = "Tidak ada email";
                    }
                    else
                    {
                        labelEmail.Text = reader.GetString(2);
                    }

                    // convert digit 
                    saldo = reader.GetDouble(6);
                    string saldoFormat = saldo.ToString("N0");

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

        private void pictureListrik_Click(object sender, EventArgs e)
        {
            CheckPln cp = new CheckPln();
            cp.Show();
            this.Hide();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormDataPulsa.CheckNomor cn = new FormDataPulsa.CheckNomor();
            cn.Show();
            this.Hide();

        }
    }
}
