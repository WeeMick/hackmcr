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
        public Login()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen sc = new StartScreen();
            sc.ShowDialog();
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
