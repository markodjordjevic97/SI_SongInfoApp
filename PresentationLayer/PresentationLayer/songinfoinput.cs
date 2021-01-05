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
using BusinessLayer;

namespace PresentationLayer
{
    public partial class songinfoinput : UserControl
    {
        public BusinessSongs business;
        public songinfoinput()
        {
            this.business = new BusinessSongs();
            InitializeComponent();
            star3.Hide();
            star4.Hide();
            star5.Hide();
            star6.Hide();
            star7.Hide();
            star8.Hide();
            star11.Show();
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

        //Popunjavanje list boxa pesama za admina
        private void FillList()
        {
            listBoxSongsForAdmin.Items.Clear();
            List<Song> list = this.business.GetAllSongs();
            foreach (var item in list)
            {
                listBoxSongsForAdmin.Items.Add(item.ToString());
            }
        }

        /*Sprecavanje unosa praznih polja*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Song s = new Song();

            if(textBoxGenre.Text.Length == 0 || textBoxTitle.Text.Length == 0 || textBoxInputDate.Text.Length == 0||
                textBoxPerfName.Text.Length == 0 || textBoxPerfSurname.Text.Length == 0 || textBoxURLYoutube.Text.Length==0
                || pictureBoxSong.Image == null)
            {
                star3.Show();
                star4.Show();
                star5.Show();
                star6.Show();
                star7.Show();
                star8.Show();
                star11.Show();
                MessageBox.Show("Niste uneli sve podatke!");
            }
            else
            {
                s.Title = textBoxTitle.Text;
                s.Genre = textBoxGenre.Text;
                s.Youtube_Url = textBoxURLYoutube.Text;
                // s.Picture_Url 
                s.Created_At = Convert.ToDateTime(textBoxInputDate.Text);
                s.Performer.Name = textBoxPerfName.Text;
                s.Performer.Surname = textBoxPerfSurname.Text;

            }

            if(this.business.InsertSong(s) > 0)
            {
                MessageBox.Show("Successfull input of song!");
                FillList();
            }
            else
            {
                MessageBox.Show("Unsuccessfull input of song!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Song s = new Song();

            int Id = Convert.ToInt32(listBoxSongsForAdmin.SelectedItem.ToString().Split(' ')[0]);

            

           /* if(this.business.UpdateSong(s.Title, textBoxTitle.Text, s.Song_Id, Id) > 0)
            {
                MessageBox.Show("Successful update!");
                FillList();
                  
            }else
            {
                MessageBox.Show("Unsuccessfull update!");
            }*/
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Song s = new Song();

            s.Song_Id = Convert.ToInt32(listBoxSongsForAdmin.SelectedItem.ToString().Split(' ')[0]);

            if(this.business.DeleteSong(s) > 0)
            {
                MessageBox.Show("Successfull delete!");
                FillList();
            }else
            {
                MessageBox.Show("Unsuccessfull delete!");
            }
        }
    }
}
