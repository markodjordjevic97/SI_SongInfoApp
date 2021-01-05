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
            
            // Posle kad budu bile pesme u bazi
            var listLength = this.blSong.GetAllSongs().Count;
            var Songs = this.blSong.GetAllSongs();
            SongCard[] listSongs = new SongCard[listLength];

            for (int i = 0; i < listLength; i++)
            {
                // Song info
                listSongs[i] = new SongCard();
                listSongs[i].Icon = Resources.music; 
                listSongs[i].IconRating = Resources.star;
                listSongs[i].IconYoutube = Resources.youtube;
                listSongs[i].IconBackground = Color.FromArgb(44, 62, 80);
                listSongs[i].PROBAYOUTUBE = Songs[i].Youtube_Url;
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

        private void textBoxSearch_OnValueChanged(object sender, EventArgs e)
        {

        }
        /* List<Song> list = this.business.GetAllSongs();

   foreach (Song item in list)
   {
       listBoxSongsForAdmin.Items.Add(item.ToString());
   } */
    }
}
