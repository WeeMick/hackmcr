using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackManchesterLIVE
{
    public partial class Tips : Form
    {
        public Home home;
        public Users currentUser;
        public Tips()
        {
            InitializeComponent();
        }


        //***********************STYLING***********************************//
        private void Tips_paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#2c3e50");
            System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml("#306B96");
            System.Drawing.Color col3 = System.Drawing.ColorTranslator.FromHtml("#3498db");
            this.ForeColor = Color.White;
            homeBtn.ForeColor = Color.Black;
            tomorrowBtn.ForeColor = Color.Black;

            System.Drawing.Color col4 = System.Drawing.ColorTranslator.FromHtml("#3498db");
            // System.Drawing.Color col5 = System.Drawing.ColorTranslator.FromHtml("#2c3e50");
            if (DateTime.Now.TimeOfDay < toTime("06:00").TimeOfDay)
            {
                col = System.Drawing.ColorTranslator.FromHtml("#000000");
                col2 = System.Drawing.ColorTranslator.FromHtml("#203A43");
                col3 = System.Drawing.ColorTranslator.FromHtml("#7AA1D2");
                col4 = System.Drawing.ColorTranslator.FromHtml("#3f4c6b");
            }

            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(this.ClientRectangle, col, col2, 60F);

            ColorBlend cblend = new ColorBlend(4);
            cblend.Colors = new Color[4] { col, col2, col3, col4 };
            cblend.Positions = new float[4] { 0f, 0.75F, 0.85f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);

            //LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, col, col2, 90F);
            //e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        //********************************ACTIONS****************************//
        private void homeBtn_Click(object sender, EventArgs e)
        {
            home.tipsLbl.Text = tip1Lbl.Text + " " + tip1timeLbl.Text;
            home.Show();

            this.Hide();
        }

        private void Tips_Load(object sender, EventArgs e)
        {
            //sets current Time on page (Should update regularly - need to find code)
            currentTimeLbl.Text = "16:00";
                
                //getTimeString();
            checkTips();
            checkUserTypeTips();


        }




        //**********TIME AND TIPS CHANGES****************************//


        //Method to get current time as a string
        private String getTimeString()
        {
            String timeNow = DateTime.Now.ToString("h:mm");
            return timeNow;
        }

        //method to change a String to a dateTime object for use in comparisons
        private DateTime toTime(String time)
        {

            DateTime date = DateTime.Parse(time, System.Globalization.CultureInfo.CurrentCulture);
            return date;
        }


        private Boolean checkTime(String time)
        {
            DateTime t1 = toTime(time);
            DateTime ctl1 = toTime(currentTimeLbl.Text);

            if (t1.TimeOfDay < (ctl1.TimeOfDay))
            {
                return true; //returns true if time has passed
            }
            else
            {
                return false;
            }

        }

        //Checks times of tips to see if time has passed (if expired)


        private int checkAllTips()
        {
            Boolean ct8 = checkTime(tip8timeLbl.Text);
            Boolean ct7 = checkTime(tip7timeLbl.Text);
            Boolean ct6 = checkTime(tip6timeLbl.Text);
            Boolean ct5 = checkTime(tip5timeLbl.Text);
            Boolean ct4 = checkTime(tip4timeLbl.Text);
            Boolean ct3 = checkTime(tip3timeLbl.Text);
            Boolean ct2 = checkTime(tip2timeLbl.Text);
            Boolean ct1 = checkTime(tip1timeLbl.Text);
            if (ct8 == true)
            {
                return 8;
            }
            if (ct7 == true)
            {
                return 7;
            }
            if (ct6 == true)
            {
                return 6;
            }
            if (ct5 == true)
            {
                return 5;
            }
            else if (ct4 == true)
            {
                return 4;
            }
            else if (ct3 == true)
            {
                return 3;
            }
            else if (ct2 == true)
            {
                return 2;
            }
            else if (ct1 == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }



        }

        private void changeTips(int i)
        {
            if (i > 0)
            {

                tip1Lbl.ForeColor = Color.White;
                tip1timeLbl.ForeColor = Color.White;
                tip2Lbl.ForeColor = Color.White;
                tip2timeLbl.ForeColor = Color.White;
                tip3Lbl.ForeColor = Color.White;
                tip3timeLbl.ForeColor = Color.White;
                tip4Lbl.ForeColor = Color.White;
                tip4timeLbl.ForeColor = Color.White;
                tip5Lbl.ForeColor = Color.White;
                tip5timeLbl.ForeColor = Color.White;
                tip6Lbl.ForeColor = Color.White;
                tip6timeLbl.ForeColor = Color.White;
                tip7Lbl.ForeColor = Color.White;
                tip7timeLbl.ForeColor = Color.White;
                tip8Lbl.ForeColor = Color.White;
                tip8timeLbl.ForeColor = Color.White;

            }

            if (i == 7)
            {
                tip8Lbl.ForeColor = Color.White;
                tip8timeLbl.ForeColor = Color.White;
            }
            if (i == 6)
            {
                tip8Lbl.ForeColor = Color.White;
                tip8timeLbl.ForeColor = Color.White;
                tip7Lbl.ForeColor = Color.White;
                tip7timeLbl.ForeColor = Color.White;
            }
            if (i == 5)
            {
                tip6Lbl.ForeColor = Color.White;
                tip6timeLbl.ForeColor = Color.White;
            }

            else if (i == 4)
            {
                tip5Lbl.ForeColor = Color.White;
                tip5timeLbl.ForeColor = Color.White;
            }
            else if (i == 3)
            {
                tip4Lbl.ForeColor = Color.White;
                tip4timeLbl.ForeColor = Color.White;
            }

            else if (i == 2)
            {
                tip3Lbl.ForeColor = Color.White;
                tip3timeLbl.ForeColor = Color.White;
            }

            else if (i == 1)
            {
                tip2Lbl.ForeColor = Color.White;
                tip2timeLbl.ForeColor = Color.White;
            }
            else
            {
                tip1Lbl.ForeColor = Color.White;
                tip1timeLbl.ForeColor = Color.White;
            }
        }

        //checks tips and changes
        public void checkTips()
        {
            int timeCheck = checkAllTips();
            changeTips(timeCheck);
            home.tipsLbl.Text = tip1Lbl.Text + " " + tip1timeLbl.Text;
        }


        int clickCounterAlarm1 = 0;

        private void alarm1Btn_Click(object sender, EventArgs e)
        {
            clickCounterAlarm1++;
            if (clickCounterAlarm1 % 2 == 0)
            {
                alarm1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.alarmGreen));

            }
            else {
                alarm1Btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.alaremRed));
            }
        }

        //*****************************TIPS CATAGORISATION*******************//

        
        public void checkUserTypeTips() {
            String userType = currentUser.getType();
            if (userType.Equals("ShiftWorker"))
            {
                tip1Lbl.Text = "Wake Before it's dark";
                tip1timeLbl.Text = "16:00";
                tip2Lbl.Text = "Large Meal to start day";
                tip2timeLbl.Text = "17:00";
                tip3Lbl.Text = "Get Lots of Light - It's getting dark";
                tip3timeLbl.Text = "18:00";
                tip4Lbl.Text = "Keep Under Bright Light";
                tip4timeLbl.Text = "19:00";
                tip5Lbl.Text = "Have a snack";
                tip5timeLbl.Text = "00:00";
                tip6Lbl.Text = "Dim the Lights";
                tip6timeLbl.Text = "05:00";
                tip7Lbl.Text = "Stay in dark (wear sunglasses)";
                tip7timeLbl.Text = "07:00";
                tip8Lbl.Text = "Sleep in dark (Thick curtains or wear a mask)";
                tip8timeLbl.Text = "09:00";
            }
            else if (userType.Equals("East"))
            {
                tip1Lbl.Text = "Wake up Early";
                tip2Lbl.Text = "See sunrise";
                tip3Lbl.Text = "Early Breakfast (large)";
                tip4Lbl.Text = "Early Lunch";
                tip5Lbl.Text = "Exercise Early Afternoon";
                tip6Lbl.Text = "Early Dinner";
                tip7Lbl.Text = "Dim the lights";
                tip8Lbl.Text = "Sleep Early";

            }
            else if (userType.Equals("West"))
            {
                tip1Lbl.Text = "Sleep In late";
                tip2Lbl.Text = "Eat late breakfast";
                tip3Lbl.Text = "Stay hydrated";
                tip4Lbl.Text = "Late lunch";
                tip5Lbl.Text = "See the sunset";
                tip6Lbl.Text = "Exercise Late";
                tip7Lbl.Text = "Bright lights";
                tip8Lbl.Text = "Sleep late";
            }
            else  
            {
                tip1Lbl.Text = "Wake-up";
                tip1timeLbl.Text = "07:00";
                tip2Lbl.Text = "See sunrise";
                tip2timeLbl.Text = "08:00";
                tip3Lbl.Text = "Have a large Breakfast";
                tip3timeLbl.Text = "08:30";
                tip4Lbl.Text = "Have a light lunch";
                tip4timeLbl.Text = "12:00";
                tip5Lbl.Text = "Exercise Early Afternoon";
                tip5timeLbl.Text = "16:00";
                tip6Lbl.Text = "No more screentime";
                tip6timeLbl.Text = "18:34";
                tip7Lbl.Text = "Dim the lights";
                tip7timeLbl.Text = "19:00";
                tip8Lbl.Text = "Sleep";
                tip8timeLbl.Text = "23:00";
            }

            }
        }
    }
