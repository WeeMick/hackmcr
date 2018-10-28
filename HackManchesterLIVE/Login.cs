using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackManchesterLIVE
{
    public partial class Login : BaseForm
    {
        public Users currentUser;
        public Home home;
        public StartScreen startScreen;
        public Login()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startScreen == null) {
                    startScreen = new StartScreen();
                startScreen.FormClosed += delegate { startScreen = null; };
            }

            startScreen.currentUser = currentUser;
            startScreen.Show();
            this.Hide();

            
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTb.Text))
            {
                emailErrLbl.Show();
                passwordErrorLbl.Hide();
                emailErrLbl.Text = "You must enter an email address";
            }
            else if (String.IsNullOrEmpty(passwordTb.Text))
            {
                emailErrLbl.Hide();
                passwordErrorLbl.Show();
                passwordErrorLbl.Text = "You must enter a password";
            }
            else if (currentUser == null)
            {
                passwordErrorLbl.Text = "You are not registered on the system";
            }
            else if (currentUser.getEmail().Equals(emailTb.Text) && currentUser.getPassword().Equals(passwordTb.Text))

            {

                if (home == null)
                {
                    home = new Home();
                    home.FormClosed += delegate { home = null; };
                }

                home.currentUser = currentUser;
                home.Show();
                this.Hide();
            }
        
            else
            {
                passwordErrorLbl.Text = "Incorrect password entered";
            }


            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
