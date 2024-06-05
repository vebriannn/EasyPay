using EASYPAY.FormAuth;
using EASYPAY.profile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPAY.Backend
{
    internal class checkEmail
    {
        string db = SignIn.db;
        string emailUser = "";
        string hasil = "gagal";

        MySqlConnection connection;

        public checkEmail(string email)
        {
            emailUser = email;
        }

        public string check()
        {
            connection = new MySqlConnection(db);
            try
            {
                connection.Open();
                string queryInsert = $"SELECT * FROM users WHERE email = '{emailUser}'";
                MySqlCommand command = new MySqlCommand(queryInsert, connection);
                int execute = command.ExecuteNonQuery();
                if (execute > 0)
                {
                    hasil = "success";
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

            return hasil;
        }
    }
}
