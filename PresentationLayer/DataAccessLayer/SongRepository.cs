using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class SongRepository
    {

        public int InsertSong(Song song)
        {
            return 2;
        }
        public int UpdateSong(Song song)
        {
            return 2;
        }
        public int DeleteSong(Song song)
        {
            return 2;
        }
        public List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();

            return songs;
        }
    }
}
