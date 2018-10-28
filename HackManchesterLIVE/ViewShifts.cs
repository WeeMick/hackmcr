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
        public ViewShifts()
        {
            InitializeComponent();
        }

        private void ViewShifts_Load(object sender, EventArgs e)
        {
            addShifts = new AddShifts();
            startTimeLbl.Visible = false;
            finishTimeLbl.Visible = false;
            startDateLbl.Visible = false;
            finishDateLbl.Visible = false;
            editShiftBtn.Visible = false;
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void shiftInfoLbl_Click(object sender, EventArgs e)
        {
            startTimeLbl.Visible = true;
            finishTimeLbl.Visible = true;
            startDateLbl.Visible = true;
            finishDateLbl.Visible = true;
            editShiftBtn.Visible = true;
        }

        private void editShiftBtn_Click(object sender, EventArgs e)
        {
            if (startTimeLbl.Enabled == true)
            {
                startTimeLbl.Text = "mod";
            }
            else if (finishTimeLbl.Enabled == true) {
                
            }
        }
    }
}