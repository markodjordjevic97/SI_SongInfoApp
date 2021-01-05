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
    public partial class adminlogin : UserControl
    {


        public BusinessAdmin business;
        
        

        public adminlogin()
        {
            
            business = new BusinessAdmin();

            

            InitializeComponent();
            star1.Hide();
            star2.Hide();
            panelRegistration.Hide();

        }

        private void adminlogin_Load(object sender, EventArgs e)
        {
            songinfoinput1.Hide();

           Admin a = new Admin();

             if(this.business.GetAdmin(a))
            {
                labelRegistration.Hide();
                btnRegisterNow.Hide();
            }
        }

        /*Sprecavanje unosa praznih polja*/
        private void btnSignInHaveAccount_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            
            
            if(textBoxPasswordHaveAccount.Text.Length == 0 
                || textBoxUserNameHaveAccount.Text.Length ==0
                || this.business.IsValidPassword(textBoxPasswordHaveAccount.Text) != true
                || this.business.IsValidUsername(textBoxUserNameHaveAccount.Text) != true  )
            {

                star1.Show();
                star2.Show();
                MessageBox.Show("Enter correct data!");
                

            } else
            {
                
                a.Username = textBoxUserNameHaveAccount.Text;
                a.Password = textBoxPasswordHaveAccount.Text;

                if (this.business.AuthenticateAdmin(a))
                {
                    MessageBox.Show("Successfull login!");
                    songinfoinput1.Show();
                }
                else
                {
                    MessageBox.Show("Unsuccessful login!");
                }
            }

            



        }
        /*Prikaz panela za registraciju*/
        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            panelRegistration.Show();
            star9.Hide();
            star10.Hide();
            star11.Hide();
            star12.Hide();
        }

        /*Ponovnim klikom na Sign In se vracamo nazad na logovanje*/
        private void btnSignInNoFunction_Click(object sender, EventArgs e)
        {
            panelRegistration.Hide();
        }

        /*Sprecavanje unosa praznih polja*/
        private void btnRegisterNowCreate_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            

            if (textBoxName.Text.Length == 0 
                || textBoxSurname.Text.Length == 0
                || textBoxUsername.Text.Length == 0 
                || textBoxPassword.Text.Length == 0 
                || this.business.IsValidPassword(textBoxPassword.Text) != true 
                || this.business.IsValidUsername(textBoxUsername.Text) != true) 

               
            {
                star9.Show();
                star10.Show();
                star11.Show();
                star12.Show();

                MessageBox.Show("Enter correct data!(Username: characters only, min 8 char;Password: one Uppercase, one Number, min 8 char)");

                
            }
            else
            {
                a.Name = textBoxName.Text;
                a.Surname = textBoxSurname.Text;
                a.Username = textBoxUsername.Text;
                a.Password = textBoxPassword.Text;

                if (this.business.RegisterAdmin(a) > 0)
                {

                    MessageBox.Show("Successfull registration!");
                    songinfoinput1.Show();

                }
                else
                {
                    MessageBox.Show("Unsuccessfull registration!");
                }
            }

           

           
           






        }

      
    }
}
