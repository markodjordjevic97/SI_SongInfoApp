using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        

      

      

        private readonly BusinessAdmin businessAdmin;
        

        public Form1()
        {
            InitializeComponent();
            businessAdmin = new BusinessAdmin();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newsongs1.Show();
            adminlogin1.Hide();
            songinfoinput1.Hide();

            btnEditSongs.Hide();
           
        }

        

        private void btnNewSongs_Click(object sender, EventArgs e)
        {
            newsongs1.Show();
            adminlogin1.Hide();
            songinfoinput1.Hide();

        }
        private void btnGenres_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminlogin al = new adminlogin();
            newsongs1.Hide();
            adminlogin1.Show();
            songinfoinput1.Hide();
            
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
        private void btnEditSongs_Click(object sender, EventArgs e)
        {
            
            newsongs1.Hide();
            adminlogin1.Hide();
            songinfoinput1.Show();
            btnEditSongs.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 70)
            {

                panelMenu.Width = 190;
                logo.Show();
                btnHamburger.Location = new Point(140, 12);
                btnNewSongs.Text = "New Songs";
                btnGenres.Text = "Genres";
                btnAdmin.Text = "Admin";
                btnContact.Text = "Contact";
                btnHelp.Text = "Help";
                btnEditSongs.Text = "EditSongs";
                btnExit.Text = "Exit";


            }
            else
            {
                panelMenu.Width = 70;
                logo.Hide();
                btnHamburger.Location = new Point(10, 12);
                btnNewSongs.Text = " ";               
                btnGenres.Text = " ";
                btnAdmin.Text = " ";
                btnContact.Text = " ";
                btnHelp.Text = " ";
                btnEditSongs.Text = " ";
                btnExit.Text = " ";
                
            }
        }

     
    }
}
