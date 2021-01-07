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

            newsongs1.Hide();
        }

        private void genres_Load(object sender, EventArgs e)
        {
            newsongs1.Hide();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            newsongs1.Show();

        }

        private void btnFolk_Click_1(object sender, EventArgs e)
        {
            newsongs1.Show();
        }

        private void btnRock_Click_1(object sender, EventArgs e)
        {
            newsongs1.Show();
        }

        private void btnMotivation_Click_1(object sender, EventArgs e)
        {
            newsongs1.Show();
        }

        private void btnJazz_Click_1(object sender, EventArgs e)
        {
            newsongs1.Show();
        }

        private void btnChill_Click_1(object sender, EventArgs e)
        {
            newsongs1.Show();
        }
    }
}
