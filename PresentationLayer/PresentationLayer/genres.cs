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
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class genres : UserControl
    {
      
        public BusinessSongs business;
        public EventHandler btnEvent;

        public genres()
        {
            this.business = new BusinessSongs();
            InitializeComponent();

       
        }

        private void genres_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            var genre = b.Text;

            newsongs newSongPanel = new newsongs();
            newSongPanel.SelectedGenre = genre;
        }
    }
}
