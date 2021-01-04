using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class songinfoinput : UserControl
    {
        public songinfoinput()
        {
            InitializeComponent();
            star3.Hide();
            star4.Hide();
            star5.Hide();
            star6.Hide();
            star7.Hide();
            star8.Hide();
        }

        /*Unos slike*/
        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Select Image";
            opf.Filter = "Image File (*.jpg; *.jpeg *.bmp *.png) | *.jpg; *.jpeg *.bmp *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(opf.FileName);
                pictureBoxSong.Image = image;
            }
        }
        /*Brisanje slike*/
        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            pictureBoxSong.CancelAsync();
            pictureBoxSong.Image.Dispose();
            pictureBoxSong.Image = null;
        }

        /*Sprecavanje unosa praznih polja*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if(textBoxGenre.Text.Length == 0 || textBoxTitle.Text.Length == 0 || textBoxInputDate.Text.Length == 0||
                textBoxPerfName.Text.Length == 0 || textBoxPerfSurname.Text.Length == 0 || pictureBoxSong.Image == null)
            {
                star3.Show();
                star4.Show();
                star5.Show();
                star6.Show();
                star7.Show();
                star8.Show();
                MessageBox.Show("Niste uneli sve podatke!");
            }
            else
            {
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
