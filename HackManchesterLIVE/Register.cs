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
        public Register()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

            
        }
    }
}
