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
    public partial class StartScreen : Form
    {

        public Register register;
        public Login login;
        public StartScreen()
        
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login == null)
            {

                login = new Login();
                login.FormClosed += delegate { login = null; };
            }
            login.startScreen = this;
            login.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            

            if (register == null)
            {
                register = new Register();
                register.FormClosed += delegate { register = null; };
                
            }
            register.startScreen = this;
            register.Show();
            this.Hide();
        }
    }
}
