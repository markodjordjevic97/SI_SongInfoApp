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
    public partial class adminlogin : UserControl
    {
       


        public adminlogin()
        {
            
           
            InitializeComponent();
            star1.Hide();
            star2.Hide();
            panelRegistration.Hide();
           
            

        }

        /*Sprecavanje unosa praznih polja*/
        private void btnSignInHaveAccount_Click(object sender, EventArgs e)
        {
            
            
            if(textBoxPasswordHaveAccount.Text.Length == 0 || textBoxUserNameHaveAccount.Text.Length ==0)
            {
                star1.Show();
                star2.Show();
                MessageBox.Show("Unesite podatke!");
                
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
            if(textBoxName.Text.Length == 0 || textBoxSurname.Text.Length == 0 
                || textBoxUsername.Text.Length ==0 || textBoxPassword.Text.Length == 0)
            {
                star9.Show();
                star10.Show();
                star11.Show();
                star12.Show();
                MessageBox.Show("Unesite podatke!");
            }
        }
    }
}
