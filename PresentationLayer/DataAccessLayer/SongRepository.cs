using DataAccessLayer.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class SongRepository
    {

        public int InsertSong(Song song)
        {
            using (MySqlConnection connection = new MySqlConnection(Constants.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("DELETE FROM songs WHERE id = {0}", song.Song_Id);

                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int UpdateSong(string columnName, string newValue, string conditionColumn, string value)
        {
            using (MySqlConnection connection = new MySqlConnection(Constants.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("UPDATE songs SET {0} = '{1}' WHERE {2} = '{4}'", columnName, newValue, conditionColumn, value);

                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int DeleteSong(Song song)
        {
            using (MySqlConnection connection = new MySqlConnection(Constants.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("DELETE FROM songs WHERE id = '{0}'", song.Song_Id);

                int result = command.ExecuteNonQuery();
                return result;
            }
        }

        public List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();

            return songs;
        }
    }
}
