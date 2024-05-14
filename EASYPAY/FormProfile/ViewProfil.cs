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

namespace EASYPAY.profile
{
    public partial class ViewProfil : Form
    {
        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public ViewProfil()
        {
            InitializeComponent();
        }

        private void ViewProfil_Load(object sender, EventArgs e)
        {
            GetDataDB();
            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelEmail.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label1.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label2.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label3.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label4.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            label5.BackColor = ColorTranslator.FromHtml("#BBDEFA");
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
                    labelNama.Text = reader.GetString(1);
                    label1.Text = reader.GetString(1);
                    if (reader.IsDBNull(2) || string.IsNullOrEmpty(reader.GetString(2)))
                    {
                        labelEmail.Text = "Tidak ada email";
                        label2.Text = "Tidak ada email";
                    }
                    else
                    {
                        labelEmail.Text = reader.GetString(2);
                        label2.Text = reader.GetString(2);
                    }
                    label3.Text = reader.GetString(3);
                    label4.Text = reader.GetString(4);
                    label5.Text = reader.GetString(5);

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
