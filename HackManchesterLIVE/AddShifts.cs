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
            TimeSpan timeSpan = new TimeSpan(2, 14, 5);

            startTimeTb.Text = timeSpan.ToString();
            if (startTimeTb.Enabled == false)
            {
                startTimeTb.Text = startTimeTb.ToString();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void finishTimeTb_Enter(object sender, EventArgs e)
        {
            finishTimeTb.Text = "";
            TimeSpan timeSpan = new TimeSpan(2, 10, 5);

            finishTimeTb.Text = timeSpan.ToString();
            if (finishTimeTb.Enabled == false)
            {
                finishTimeTb.Text = startTimeTb.ToString();
            }
        }

        private void startDateTb_Enter(object sender, EventArgs e)
        {
            startDateTb.Text = "";
            DateTime currentDate = DateTime.Now;
            startDateTb.Text = currentDate.ToString();
            if (startDateTb.Enabled == false)
            {
                startDateTb.Text = currentDate.ToString();
            }
        }

        private void finishDateTb_Enter(object sender, EventArgs e)
        {
            finishDateTb.Text = "";
            DateTime currentDate = DateTime.Now;
            finishDateTb.Text = currentDate.ToString();
            if (finishDateTb.Enabled == false)
            {
                finishDateTb.Text = currentDate.ToString();
            }
        }

        private void addShiftLbl_Click(object sender, EventArgs e)
        {
            //adds and stores the shift information
        }
    }
}
