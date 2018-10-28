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
    public partial class ViewShifts : BaseForm
    {
        public AddShifts addShifts;
        public Users currentUser;
        public Home mainPage;
        public ViewShifts()
        {
            InitializeComponent();
        }

        private void ViewShifts_Load(object sender, EventArgs e)
        {
            addShifts = new AddShifts();
          



            countdownLbl.Visible = false;
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            if (mainPage == null) {
                mainPage = new Home();
                mainPage.FormClosed += delegate { mainPage = null; };
            }

            mainPage.currentUser = currentUser;
            mainPage.Show();
            this.Hide();
        }

        private void removeShiftBtn_Click(object sender, EventArgs e)
        {
            startDateLbl.Text = "Start Date: " + "";
            startTimeLbl.Text = "Start Time: " + "";
            finishDateLbl.Text = "Finish Date: " + "";
            finishTimeLbl.Text = "Finish Time: " + "";               
        }
    }
}
