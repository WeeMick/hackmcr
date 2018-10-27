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
    public partial class Register : Form
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
            else
            {
                nameErrorLbl.Hide();
            }

            if (emailTb.Text == "")
            {
                emailErrorLbl.Show();
                emailErrorLbl.Text = "You must include an email";
            }
            else
            {
                emailErrorLbl.Hide();
            }

            if (passwordTb.Text == "")
            {
                passwordErrorLbl.Show();
                passwordErrorLbl.Text = "You must include a password";
            }
            else
            {
                passwordErrorLbl.Hide();
            }

            if (!cPasswordTb.Text.Equals(passwordTb.Text))
            {
                cPasswordErrorLbl.Show();
                cPasswordErrorLbl.Text = "The passwords do not match";
            }
            else
            {
                cPasswordErrorLbl.Hide();
            }
            
            appData.addUser(new Users(nameTb.Text, Convert.ToInt32(ageUpDown.Value), emailTb.Text, passwordTb.Text));

            if (home == null) {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }

            home.Show();
            home.welcomeLbl.Text = "Welcome " + nameTb.Text;
            this.Hide();
        }
    }
}
