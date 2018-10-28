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
    public partial class AddTrips : BaseForm
    {
        public Home home;
        public Users currentUser;
        public AddTrips()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void AddTrips_Load(object sender, EventArgs e)
        {
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (home == null) {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }
            home.Show();
            home.currentUser = currentUser;
            this.Hide();
        }
    }
}
