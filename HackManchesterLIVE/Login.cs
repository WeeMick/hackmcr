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
    public partial class Login : Form
    {

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
            startScreen.Show();
            this.Hide();

            
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (home == null) {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }

            
            home.Show();
            this.Hide();


            
        }
    }
}
