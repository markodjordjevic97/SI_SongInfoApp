using DataAccessLayer.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class AdminRepository
    {
        private List<Admin> list = new List<Admin>();
        public int RegisterAdmin(Admin admin)
        {
            using (MySqlConnection connection = new MySqlConnection(Constants.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("INSERT INTO admin(name, surname, username, password) VALUES ('{0}','{1}','{2}',md5('{3}'));", admin.Name, admin.Surname, admin.Username, admin.Password);

                int result = command.ExecuteNonQuery();
                return result;
            }
        }

        //Checking if Admin Username already exists in database
        public bool IsUidAvailable(Admin admin)
        {
            using (MySqlConnection connection = new MySqlConnection(Constants.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("SELECT * FROM admin WHERE username = {0};", admin.Username);

                MySqlDataReader reader = command.ExecuteReader();
                Admin temp = new Admin();
                while (reader.Read())
                {
                    temp.Username = reader.GetString(3);
                }

                if (temp.Username == admin.Username)
                    return false;
                else
                    return true;
            }
        }
    }
}
