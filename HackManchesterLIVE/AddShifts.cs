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
    public partial class AddShifts : BaseForm
    {
        public string passingData;
        public AddShifts()
        {
            InitializeComponent();
        }

        private void AddShifts_Load(object sender, EventArgs e)
        {
            startTimeTb.Focus();
            infoLbl.Visible = false;
        }

        private void startTimeTb_Enter(object sender, EventArgs e)
        {
            startTimeTb.Text = "";
            TimeSpan timeSpan = new TimeSpan(22, 14, 5);

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
            TimeSpan timeSpan = new TimeSpan(6, 10, 5);
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
            startDateTb.Text = currentDate.ToString("dd/MM/yyyy");
            if (startDateTb.Enabled == false)
            {
                startDateTb.Text = currentDate.ToString();
            }
        }

        private void finishDateTb_Enter(object sender, EventArgs e)
        {
            finishDateTb.Text = "";
            DateTime currentDate = new DateTime();
            finishDateTb.Text = currentDate.ToString("20/11/2019");
            if (finishDateTb.Enabled == false)
            {
                finishDateTb.Text = currentDate.ToString();
            }
        }

        private void addShiftBtn_Click(object sender, EventArgs e)
        {
            //Shifts shifts = new Shifts(startTimeTb.Text, finishTimeTb.Text, startDateTb.Text, finishDateTb.Text);
            ViewShifts vs = new ViewShifts();
            vs.startTimeLbl.Text += "    " + startTimeTb.Text;
            vs.finishTimeLbl.Text += "     " + finishTimeTb.Text;
            vs.startDateLbl.Text += " " + startDateTb.Text;
            vs.finishDateLbl.Text += " " + finishDateTb.Text;
            //vs.Show();

            infoLbl.Visible = true;
            infoLbl.Text = "Start Time: " + startTimeTb.Text + "\nFinish Time: " + finishTimeTb.Text +
                "\nStandard Date: " + startDateTb.Text + "\nFinishing Date: " + finishDateTb.Text;
        }
    }
}