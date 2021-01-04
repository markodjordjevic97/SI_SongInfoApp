using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SongCard : UserControl
    {
        public SongCard()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _title;
        private string _genre;
        private string _performer;
        private double _rating;

        #region Properties

        [Category("Custom props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; lblIcon.Image = value; }
        }

        [Category("Custom props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom props")]
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; lblGenre.Text = value; }
        }

        [Category("Custom props")]
        public string Performer
        {
            get { return _performer; }
            set { _performer = value; lblPerformer.Text = value; }
        }

        [Category("Custom props")]
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; lblRating.Text = value.ToString(); }
        }

        #endregion
    }
}
