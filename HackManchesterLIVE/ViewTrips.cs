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
    public partial class ViewTrips : BaseForm
    {
        public Home home;
        public Users currentUser;
        public ViewTrips()
        {
            InitializeComponent();
        }

        private void ViewTrips_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }
            home.currentUser = currentUser;
            home.viewTrips = this;
            this.Hide();
            home.Show();
        }
    }
}
