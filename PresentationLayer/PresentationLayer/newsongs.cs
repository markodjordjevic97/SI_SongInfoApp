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
            SongsItems();
        }

        private void SongsItems()
        {
            // primer pesme
            string Title = "Tisina";
            string Genre = "Ex-yu";
            string Performer = "Bajaga";
            double Rating = 8.5;
            var listLength = this.blSong.GetAllSongs().ToArray().Length;
            SongCard[] listSongs = new SongCard[20];
            for (int i = 0; i < 20; i++)
            {
                // Song info
                listSongs[i] = new SongCard();
                listSongs[i].Title = Title;
                listSongs[i].Genre = Genre;
                listSongs[i].Performer = Performer;
                listSongs[i].Rating = Rating;

                // Add to flow panel
                if(flowListSongs.Controls.Count < 0)
                {
                    flowListSongs.Controls.Clear();
                }
                else
                    flowListSongs.Controls.Add(listSongs[i]);
            }
        }
    }
}
