using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer.Properties;
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class newsongs : UserControl
    {

       
        private readonly BusinessSongs blSong;
        public newsongs()
        {
            InitializeComponent();
            blSong = new BusinessSongs();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            FillList();
            SongsItems();
        }

       
        private void SongsItems()
        {

            // Mora jovan da mi prosledi static polje od njegov event
            var Songs = this.blSong.GetAllSongs();
            var listLength = this.blSong.GetAllSongs().Count;
            

            SongCard[] listSongs = new SongCard[listLength];
           
            for (int i = 0; i < listLength; i++)
            {
                // Song info
                listSongs[i] = new SongCard();
                listSongs[i].Icon = Resources.music; 
                listSongs[i].IconRating = Resources.star;
                listSongs[i].IconYoutube = Resources.youtube;
                listSongs[i].IconBackground = Color.FromArgb(44, 62, 80);
                listSongs[i].Youtube_hyperlink = Songs[i].Youtube_Url;
                listSongs[i].Title = Songs[i].Title;
                listSongs[i].Genre = Songs[i].Genre;
                listSongs[i].Performer = Songs[i].Performer.Name + Songs[i].Performer.Surname;
                listSongs[i].Rating = Songs[i].Jim_Rating;

                // Add to flow panel
               flowListSongs.Controls.Add(listSongs[i]);
            }
        }
        private void FillList()
        {
            flowListSongs.Controls.Clear();
           
        }

        //Search bar, sort buttons
        private void textBoxSearch_OnValueChanged(object sender, EventArgs e)
        {
            //Upit za search?
            string searchValue = textBoxSearch.Text;


        }

        private void btnAZSort_Click(object sender, EventArgs e)
        {

            List<Song> listAZSort = this.blSong.GetSongByName();

            if (listAZSort.Count != 0)
            {
                FillList();
                SongsItems();
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }

        private void btnRatingSort_Click(object sender, EventArgs e)
        {

            List<Song> listRatingSort = this.blSong.GetSongByRating();

            if (listRatingSort.Count != 0)
            {
                FillList();
                SongsItems();
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }

        }

        private void btnDateSort_Click(object sender, EventArgs e)
        {

            List<Song> listDateSort = this.blSong.GetSongByDate();

            if (listDateSort.Count != 0)
            {
                FillList();
                SongsItems();
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }


    }
}
