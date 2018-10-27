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
    public partial class Tips : Form
    {
        public Home home;
        public Tips()
        {
            InitializeComponent();
        }

        private void Tips_Load(object sender, EventArgs e)
        {
            home.tipsLbl.Text = tip1Lbl.Text + " " + tip1timeLbl.Text;
            DateTime now = DateTime.Now;
            

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            {
                if (home == null)
                {
                    home = new Home();
                    home.FormClosed += delegate { home = null; };
                }
                home.Show();
                this.Hide();
            }
        }

        public String timeToString(DateTime time) {
            String stringTime = time.ToString("hh:mm");
            return stringTime;
        }

    }
}
