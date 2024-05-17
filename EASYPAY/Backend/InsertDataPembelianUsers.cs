using EASYPAY.FormAuth;
using EASYPAY.FormHslPbyr;
using EASYPAY.FormPLN;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPAY.Backend
{
    internal class InsertDataPembelianUsers
    {

        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public void InsertRiwayatPembelian(string jenis_pembelian, int pilihHarga)
        {

            connection = new MySqlConnection(db);

            DateTime tanggalPembelian = DateTime.Now;
            string tanggalPembelianString = tanggalPembelian.ToString("yyyy-MM-dd HH:mm:ss");
            string nomor_pembelian = generateNomorTransaksi();

            try
            {
                connection.Open();
                string queryCheck = $"INSERT INTO riwayat_transaksi (id_pengguna, nomor_pembelian, jenis_pembelian,  harga, tanggal_pembelian) VALUES ('{id}', '{nomor_pembelian}', '{jenis_pembelian}', '{pilihHarga}', '{tanggalPembelianString}')";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    Resi frtp = new Resi(nomor_pembelian);
                    frtp.Show();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan Data!!!");
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

        private string generateNomorTransaksi()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder(10);

            // Menghasilkan string acak dengan panjang tertentu
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }
    }
}
