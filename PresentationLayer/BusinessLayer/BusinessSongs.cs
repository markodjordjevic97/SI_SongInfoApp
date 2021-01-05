

using DataAccessLayer;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BusinessSongs
    {
        private readonly SongRepository songRepository;

        public BusinessSongs()
        {
            songRepository = new SongRepository();
        }

        // Method for insert song
        public bool InsertSong(Performer performer,Admin admin, Song song)
        {
            if (this.songRepository.InsertSong(performer, admin, song) > 0)
                return true;
            return false;
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
