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
    public partial class Home : Form
    {
        public AddShifts addShifts = new AddShifts();
        public ViewShifts viewShifts;
        public Tips tips;
        public Home()
        {
            InitializeComponent();
        }

        private void addShifsBtn_Click(object sender, EventArgs e)
        {
            if (addShifts == null)
            {
                addShifts = new AddShifts();
                addShifts.FormClosed += delegate { addShifts = null; };
            }
            addShifts.Show();
            this.Hide();
        }

        private void viewShiftsBtn_Click(object sender, EventArgs e)
        {
            if (viewShifts == null)
            {
                viewShifts = new ViewShifts();
                viewShifts.FormClosed += delegate { viewShifts = null; };
            }
            viewShifts.Show();
            this.Hide();
        }

        private void todaysTipsBtn_Click(object sender, EventArgs e)
        {
            if (tips == null)
            {
                tips = new Tips();
                tips.FormClosed += delegate { tips = null; };
            }
            tips.Show();
            this.Hide();
        }
    }
}
