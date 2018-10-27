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
    public partial class AddShifts : Form
    {
        public AddShifts()
        {
            InitializeComponent();
        }

        private void AddShifts_Load(object sender, EventArgs e)
        {
            startTimeTb.Focus();
        }

        private void startTimeTb_Enter(object sender, EventArgs e)
        {
            startTimeTb.Text = "";
        }

        private void finishTimeTb_Enter(object sender, EventArgs e)
        {
            finishTimeTb.Text = "";
        }

        private void startDateTb_Enter(object sender, EventArgs e)
        {
            startDateTb.Text = "";
        }

        private void finishDateTb_Enter(object sender, EventArgs e)
        {
            finishDateTb.Text = "";
        }
    }
}
