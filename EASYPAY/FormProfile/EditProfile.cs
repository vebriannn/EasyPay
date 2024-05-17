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

        string namaUser = ViewProfil.namaUser;
        string emailUser = ViewProfil.emailUser;
        string nomorUser = ViewProfil.nomorUser;
        string pinUser = ViewProfil.pinUser;

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
            textEmail.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textNomor.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            textPin.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            textNama.Text = namaUser;
            textEmail.Text = emailUser;
            textNomor.Text = nomorUser;
            textPin.Text = pinUser;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Akan Di Arahkan Ke Dashboard");
            Dashboard dd = new Dashboard();
            dd.Show();
            this.Hide();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            if(textNama.Text.ToString() != "" && textEmail.Text.ToString() != "" && textNomor.Text.ToString() != "" && textPin.Text.ToString() != "")
            {
                GantiDataDiri();
            }
            else
            {
                MessageBox.Show("Maaf Input Tidak Boleh Kosong, Mohon Isi Semua Data Pada Kolom Input!!!");
            }
        }


        private void GantiDataDiri()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryInsert = $"UPDATE users SET nama = '{textNama.Text.ToString()}', email = '{textEmail.Text.ToString()}', nomor = '{textNomor.Text.ToString()}', pin = '{textPin.Text.ToString()}' WHERE id = '{user_id}'";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int execute = command.ExecuteNonQuery();
                if (execute > 0)
                {
                    DialogResult result = MessageBox.Show("Akun Berhasil Di Ubah, Apakah Anda Ingin Kembali Ke Menu Dashboard?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Dashboard dd = new Dashboard();
                        dd.Show();
                        this.Hide();
                    }
                    else if (result == DialogResult.No)
                    {
                        ViewProfil vp = new ViewProfil();
                        vp.Show();
                        this.Hide();
                    }
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

        private void checkData()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryCheck = $"SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if(emailUser != reader.GetString(2))
                    {
                        MessageBox.Show("Maaf Anda Harus Pakai Email Lain, Email Tersebut Sudah Di Pakai Akun Lain...");
                        if (nomorUser != reader.GetString(3))
                        {
                            MessageBox.Show("Maaf Anda Harus Pakai Nomor Lain, Nomor Tersebut Sudah Di Pakai Akun Lain...");
                        }
                        else
                        {
                            GantiDataDiri();
                        }
                    }
                    else
                    {
                        GantiDataDiri();
                    }
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
