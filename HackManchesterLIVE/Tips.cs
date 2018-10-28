﻿using System;
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
        public Tips()
        {
            InitializeComponent();
        }

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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            home.tipsLbl.Text = tip1Lbl.Text + " " + tip1timeLbl.Text;
            home.Show();

            this.Hide();
        }

        private void Tips_Load(object sender, EventArgs e)
        {
            //sets current Time on page (Should update regularly - need to find code)
            currentTimeLbl.Text = getTimeString();
            checkTips();


        }




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

            if (t1.TimeOfDay < (DateTime.Now.TimeOfDay))
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

                tip1Lbl.ForeColor = Color.Red;
                tip1timeLbl.ForeColor = Color.Red;
                tip2Lbl.ForeColor = Color.Red;
                tip2timeLbl.ForeColor = Color.Red;
                tip3Lbl.ForeColor = Color.Red;
                tip3timeLbl.ForeColor = Color.Red;
                tip4Lbl.ForeColor = Color.Red;
                tip4timeLbl.ForeColor = Color.Red;
                tip5Lbl.ForeColor = Color.Red;
                tip5timeLbl.ForeColor = Color.Red;
                tip6Lbl.ForeColor = Color.Red;
                tip6timeLbl.ForeColor = Color.Red;
                tip7Lbl.ForeColor = Color.Red;
                tip7timeLbl.ForeColor = Color.Red;
                tip8Lbl.ForeColor = Color.Red;
                tip8timeLbl.ForeColor = Color.Red;

            }

            if (i >= 7)
            {
                tip8Lbl.ForeColor = Color.White;
                tip8timeLbl.ForeColor = Color.White;
            }
            if (i >= 6)
            {
                tip7Lbl.ForeColor = Color.White;
                tip7timeLbl.ForeColor = Color.White;
            }
            if (i >= 5)
            {
                tip6Lbl.ForeColor = Color.White;
                tip6timeLbl.ForeColor = Color.White;
            }

            else if (i >= 4)
            {
                tip5Lbl.ForeColor = Color.White;
                tip5timeLbl.ForeColor = Color.White;
            }
            else if (i >= 3)
            {
                tip4Lbl.ForeColor = Color.White;
                tip4timeLbl.ForeColor = Color.White;
            }

            else if (i >= 2)
            {
                tip3Lbl.ForeColor = Color.White;
                tip3timeLbl.ForeColor = Color.White;
            }

            else if (i >= 1)
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
    }
}