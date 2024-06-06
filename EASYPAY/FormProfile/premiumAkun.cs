using EASYPAY.Backend;
using EASYPAY.FormAuth;
using EASYPAY.profile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPAY.FormProfile
{
    public partial class premiumAkun : Form
    {
        string imageLocation = "";
        string db = SignIn.db;
        string id = SignIn.id_user;
        string nama = Dashboard.namaUsers;
        string tipe_pengguna = Dashboard.tipe_pengguna;

        MySqlConnection connection;

        public premiumAkun()
        {
            InitializeComponent();
        }

        private void premiumAkun_Load(object sender, EventArgs e)
        {
            picture.BackColor = ColorTranslator.FromHtml("#F9F5FE");

            labelNama.BackColor = ColorTranslator.FromHtml("#BBDEFA");
            labelTP.BackColor = ColorTranslator.FromHtml("#BBDEFA");

            btnUpload.BackColor = ColorTranslator.FromHtml("#41A6F4");
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.ForeColor = Color.White;
            labelNama.Text = nama;
            labelTP.Text = tipe_pengguna;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    imageLocation = dialog.FileName;

                    picture.ImageLocation = imageLocation;

                    MessageBox.Show("Foto Terupload, Mohon Tunggu Sebentar Untuk Konfirmasi Premium.");
                    Thread.Sleep(3000);
                    MessageBox.Show("Foto Terkonfirmasi, Selamat Akun Anda Premium");
                    UpdatePremium();

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }


        private void UpdatePremium()
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET tipe_pengguna = 'premium' WHERE id = '{id}'";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    ViewProfil vp = new ViewProfil();
                    vp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Menyimpan Data Ke database, Mohon Ulangi Progress!!!");
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
