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
    public partial class Register : BaseForm
    {
        public StartScreen startScreen;
        AppData appData = new AppData();
        public Home home;
        public Register()
        {
            InitializeComponent();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen sc = new StartScreen();
            sc.ShowDialog();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                nameErrorLbl.Show();
                nameErrorLbl.Text = "You must include a name";
            }
            else if (emailTb.Text == "")
            {
                nameErrorLbl.Hide();
                emailErrorLbl.Show();
                emailErrorLbl.Text = "You must include an email";
            }
            else if (passwordTb.Text == "")
            {
                emailErrorLbl.Hide();

                passwordErrorLbl.Show();
                passwordErrorLbl.Text = "You must include a password";
            }
            else if (!cPasswordTb.Text.Equals(passwordTb.Text))
            {
                passwordErrorLbl.Hide();
                cPasswordErrorLbl.Show();
                cPasswordErrorLbl.Text = "The passwords do not match";
            }
            else
            {
                cPasswordErrorLbl.Hide();
                Users user1 = new Users(nameTb.Text, Convert.ToInt32(ageUpDown.Value), emailTb.Text, passwordTb.Text);
                appData.addUser(user1);
                Authentication auth = new Authentication();
                auth.username = emailTb.Text;
                auth.password = passwordTb.Text;


                if (home == null)
                {
                    home = new Home();
                    home.FormClosed += delegate { home = null; };
                }

                home.Show();
                home.welcomeLbl.Text = "Welcome " + nameTb.Text;
                this.Hide();
            }

            
        }
    }
}
