using EASYPAY.FormAuth;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPAY.Backend
{
    internal class UpdatedUsers
    {
        string db = SignIn.db;
        string id = SignIn.id_user;

        MySqlConnection connection;

        public void updateSaldo(string column, Double sisaSaldo, string jenis_pembelian, int pilihHarga)
        {
            connection = new MySqlConnection(db);

            try
            {
                connection.Open();
                string queryCheck = $"UPDATE users SET {column} = '{sisaSaldo}' WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    if(jenis_pembelian == "tfbank")
                    {
                        InsertDataPembelianUsers insertDP = new InsertDataPembelianUsers();
                        insertDP.InsertRiwayatTrxAtm("Almareta", pilihHarga);
                    }
                    else
                    {
                        InsertDataPembelianUsers insertDP = new InsertDataPembelianUsers();
                        insertDP.InsertRiwayatPembelian(jenis_pembelian, pilihHarga);
                    }
                }
                else
                {
                    MessageBox.Show("Pembayaran Gagal, Ada Beberapa Kesalahan!!!");
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
