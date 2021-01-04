

using DataAccessLayer;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    class BusinessSongs
    {
        private readonly SongRepository songRepository;

        public BusinessSongs()
        {
            songRepository = new SongRepository();
        }

        // Method for insert song
        public int InsertSong(Song song)
        {
            return this.songRepository.InsertSong(song);
        }
        // Method for update song info
        public int UpdateSong(Song song)
        {
            return this.songRepository.UpdateSong(song);
        }
        // Method for delete song
        public int DeleteSong(Song song)
        {
            return this.songRepository.DeleteSong(song);
        }
        // Method for get all songs
        public List<Song> GetAllSongs()
        {
            return this.songRepository.GetAllSongs();
        }
    }
}
