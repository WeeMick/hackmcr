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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            {
                if (home == null)
                {
                    home = new Home();
                    home.formClosed += delegate { home = null; };
                }
                home.Show();
                this.Hide();
            }
        }
    }
}
