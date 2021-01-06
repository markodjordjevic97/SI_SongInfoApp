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
        public genres()
        {
            this.business = new BusinessSongs();
            InitializeComponent();
        }

        private void genres_Load(object sender, EventArgs e)
        {
           
        }

      
        public void btnPop_Click(object sender, EventArgs e)
        {
 
           
        }
        
        public static void btnFolk_Click(object sender, EventArgs e)
        {
            
        }

        public static void btnRock_Click(object sender, EventArgs e)
        {
           
        }

        public static void btnMotivation_Click(object sender, EventArgs e)
        {
            
        }

        public static void btnJazz_Click(object sender, EventArgs e)
        {
          
        }

        public static void btnChill_Click(object sender, EventArgs e)
        {
            
        }
    }
}
