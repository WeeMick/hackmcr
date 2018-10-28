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
            //startTimeLbl.Visible = false;
            //finishTimeLbl.Visible = false;
            //startDateLbl.Visible = false;
            //finishDateLbl.Visible = false;
            //editShiftBtn.Visible = false;
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

        private void shiftInfoLbl_Click(object sender, EventArgs e)
        {
        //    startTimeLbl.Visible = true;
        //    finishTimeLbl.Visible = true;
        //    startDateLbl.Visible = true;
        //    finishDateLbl.Visible = true;
        //    editShiftBtn.Visible = true;
        //    countdownLbl.Visible = true;
        }

        private void editShiftBtn_Click(object sender, EventArgs e)
        {
            startTimeLbl.Text = "Start Time: " + addShifts.startTimeTb.Text;
            finishTimeLbl.Text = "Finish Time: ";
            startDateLbl.Text = "Start Date: ";
            finishDateLbl.Text = "Finish Date: ";
            //displayInfoLbl.Text = "Start Time: " +
            //                        "\nFinish Time: " +
            //                        "\nStart Date: " +
            //                        "\nFinish Date: " ;
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
