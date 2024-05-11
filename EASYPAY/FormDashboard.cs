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
    public partial class FormDashboard : Form
    {

        string db = FormSignIn.db;
        string id = FormSignIn.id_user;
        double saldo;

        MySqlConnection connection;


        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FormCheckPln trxPln = new FormCheckPln();
            trxPln.Show();
            this.Hide();
        }
    }
}
