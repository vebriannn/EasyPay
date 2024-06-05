using EASYPAY.FormAir;
using EASYPAY.FormAuth;
using EASYPAY.FormHslPbyr;
using EASYPAY.FormNetflix;
using EASYPAY.FormPLN;
using EASYPAY.FormTransferBank;
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
        string nama = Dashboard.namaUsers;
        string meteranPln = CheckPln.IDMeteran;
        string meteranPdam = CheckWater.IDMeteran;
        string nomorHp = FormDataPulsa.CheckNomor.nomorTujuan;
        string norek = FormTransferBank.Transfer.norek;

        string produk = "";


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
                string queryInsert = $"INSERT INTO riwayat_transaksi (id_pengguna, nomor_pembelian, jenis_pembelian,  harga, tanggal_pembelian) VALUES ('{id}', '{nomor_pembelian}', '{jenis_pembelian}', '{pilihHarga}', '{tanggalPembelianString}')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {

                    if(jenis_pembelian == "pln")
                    {
                        InsertDetailPembelianPLN(nomor_pembelian);
                    }
                    else if (jenis_pembelian == "pdam")
                    {
                        InsertDetailPembelianPdam(nomor_pembelian);
                    }
                    else if (jenis_pembelian == "pulsa" || jenis_pembelian == "data")
                    {
                        InsertDetailPembelianPulsaData(nomor_pembelian, jenis_pembelian);
                    }
                    else if (jenis_pembelian == "netflix")
                    {
                        InsertDetailPembelianNetflix(nomor_pembelian, jenis_pembelian);
                    }
                    else
                    {
                        Resi frtp = new Resi(nomor_pembelian);
                        frtp.Show();
                    }
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

        public void InsertRiwayatTrxAtm(string nama, int totaltf)
        {
            connection = new MySqlConnection(db);
            string kode_transfer = generateNomorTransaksi();

            string tokenListrik = GenerateTokenListrik();

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO riwayat_transfer(id_pengguna, kode_transfer, nama, bank_tujuan, no_rek, total_transfer, fee_admin) VALUES ('{id}','{kode_transfer}', '{nama}', '{choiceBank.namaBank}', '{norek}', '{totaltf}', '2500')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    FormResi.ResiTF rtf = new FormResi.ResiTF(nama, totaltf, DateTime.Now, "2500");
                    rtf.Show();
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

        private void InsertDetailPembelianPLN(string nomor_pembelian)
        {
            connection = new MySqlConnection(db);

            string tokenListrik = GenerateTokenListrik();

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO detail_pln(nomor_pembelian, nama, meteran_id, kwh, token_listrik) VALUES ('{nomor_pembelian}', '{nama}', {meteranPln},'36', '{tokenListrik}')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
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

        private void InsertDetailPembelianPdam(string nomor_pembelian)
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO detail_pdam(nomor_pembelian, nama, meteran_id) VALUES ('{nomor_pembelian}', '{nama}', '{meteranPdam}')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
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

        private void InsertDetailPembelianPulsaData(string nomor_pembelian, string jenis_pembelian)
        {
            if (jenis_pembelian == "data")
            {
                produk = FormDataPulsa.Data.ChoiceData.produk;
            }
            else
            {
                produk = FormDataPulsa.Pulsa.ChoicePulsa.produk;
            }
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO detail_pulsa_data(nomor_pembelian, kategori_produk, nomor, produk, status) VALUES ('{nomor_pembelian}', '{jenis_pembelian}', '{nomorHp}','{produk}', 'Berhasil')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
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

        private void InsertDetailPembelianNetflix(string nomor_pembelian, string jenis_pembelian)
        {
            connection = new MySqlConnection(db);

            produk = ChoiceNetflix.produk;
            try
            {
                connection.Open();
                string queryInsert = $"INSERT INTO detail_netflix(nomor_pembelian, produk) VALUES ('{nomor_pembelian}', '{produk}')";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
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

        private string GenerateTokenListrik()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder(20);

            // Menghasilkan string acak dengan panjang tertentu
            for (int i = 0; i < 20; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }

    }
}
