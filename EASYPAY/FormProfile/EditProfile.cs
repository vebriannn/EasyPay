using EASYPAY.FormAuth;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EASYPAY.FormProfile
{
    public partial class EditProfile : Form
    {

        string db = SignIn.db;
        string user_id = SignIn.id_user;

        string columnNama = "";
        string columnNomor = "";

        string namaUser = ViewProfil.namaUser;
        string GenderUser = ViewProfil.GenderUser;
        string nomorUser = ViewProfil.nomorUser;
        string pinUser = ViewProfil.pinUser;

        string tipe_pengguna = Dashboard.tipe_pengguna;

        MySqlConnection connection;

        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            btnGanti.FlatStyle = FlatStyle.Flat;
            btnGanti.FlatAppearance.BorderSize = 0;
            btnGanti.BackColor = ColorTranslator.FromHtml("#41A6F4");

            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.BackColor = ColorTranslator.FromHtml("#41A6F4");
            textNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textGender.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textPin.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            textNama.Text = namaUser;
            textGender.Text = GenderUser;
            textNomor.Text = nomorUser;
            textPin.Text = pinUser;

            labelNama.Text = namaUser;
            labelTP.Text = tipe_pengguna;

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ViewProfil vp = new ViewProfil();
            vp.Show();
            this.Hide();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            if(textNama.Text.ToString() != "" && textNomor.Text.ToString() != "" && textPin.Text.ToString() != "")
            {
                if(namaUser != textNama.Text.ToString())
                {
                    columnNama = $"nama = '{textNama.Text.ToString()}',";
                }
                else if (nomorUser != textNomor.Text.ToString())
                {
                    columnNomor = $"nomor = '{textNomor.Text.ToString()}',";
                }

                checkDataNomor();
            }
            else
            {
                MessageBox.Show("Maaf Input Tidak Boleh Kosong, Mohon Isi Semua Data Pada Kolom Input!!!");
            }
        }

        private void checkDataNomor()
        {
            if (nomorUser != textNomor.Text.ToString()) {
                connection = new MySqlConnection(db);
                try
                {
                    connection.Open();
                    string queryCheck = $"SELECT COUNT(*) FROM users WHERE nomor = '{textNomor.Text.ToString()}'";
                    MySqlCommand command = new MySqlCommand(queryCheck, connection);
                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Maaf, Nomor Sudah Di Pakai Akun Lain!!!");
                        return;
                    }
                    else
                    {
                        GantiDataDiri();
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
            else
            {
                GantiDataDiri();
            }
        }


        private void GantiDataDiri()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();  
                string queryInsert = $"UPDATE users SET {columnNama} {columnNomor} pin = '{textPin.Text.ToString()}' WHERE id = '{user_id}'";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int ex = command.ExecuteNonQuery();
                if (ex > 0)
                {
                    MessageBox.Show("Akun Berhasil Di Ubah");

                    ViewProfil vp = new ViewProfil();
                    vp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Akun Gagal Di Buat!");
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
