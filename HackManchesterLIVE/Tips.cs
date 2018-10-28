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
            Boolean ct6 = checkTime(tip6timeLbl.Text);
            Boolean ct5 = checkTime(tip5timeLbl.Text);
            Boolean ct4 = checkTime(tip4timeLbl.Text);
            Boolean ct3 = checkTime(tip3timeLbl.Text);
            Boolean ct2 = checkTime(tip2timeLbl.Text);
            Boolean ct1 = checkTime(tip1timeLbl.Text);
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

                tip1Lbl.Hide();
                tip1timeLbl.Hide();
                tip2Lbl.Hide();
                tip2timeLbl.Hide();
                tip3Lbl.Hide();
                tip3timeLbl.Hide();
                tip4Lbl.Hide();
                tip4timeLbl.Hide();
                tip5Lbl.Hide();
                tip5timeLbl.Hide();
                tip6Lbl.Hide();
                tip6timeLbl.Hide();
            }

            if (i == 5)
            {
                tip1Lbl.Text = tip6Lbl.Text;
                tip1timeLbl.Text = tip6timeLbl.Text;
                tip1Lbl.Show();
                tip1timeLbl.Show();
            }
            else if (i == 4)
            {
                tip1Lbl.Text = tip6Lbl.Text;
                tip1timeLbl.Text = tip6timeLbl.Text;
                tip2Lbl.Text = tip5Lbl.Text;
                tip2timeLbl.Text = tip5timeLbl.Text;
                tip1Lbl.Show();
                tip2Lbl.Show();
                tip1timeLbl.Show();
                tip2timeLbl.Show();
            }
            else if (i == 3)
            {
                tip1Lbl.Text = tip4Lbl.Text;
                tip1timeLbl.Text = tip4timeLbl.Text;
                tip2Lbl.Text = tip5Lbl.Text;
                tip2timeLbl.Text = tip5timeLbl.Text;
                tip3Lbl.Text = tip6Lbl.Text;
                tip3timeLbl.Text = tip6timeLbl.Text;
                tip1Lbl.Show();
                tip2Lbl.Show();
                tip3Lbl.Show();
                tip1timeLbl.Show();
                tip2timeLbl.Show();
                tip3timeLbl.Show();
            }

            else if (i == 2)
            {
                tip1Lbl.Text = tip3Lbl.Text;
                tip1timeLbl.Text = tip3timeLbl.Text;
                tip2Lbl.Text = tip4Lbl.Text;
                tip2timeLbl.Text = tip4timeLbl.Text;
                tip3Lbl.Text = tip5Lbl.Text;
                tip3timeLbl.Text = tip5timeLbl.Text;
                tip4Lbl.Text = tip6Lbl.Text;
                tip4timeLbl.Text = tip6timeLbl.Text;
                tip1Lbl.Show();
                tip2Lbl.Show();
                tip3Lbl.Show();
                tip4Lbl.Show();
                tip1timeLbl.Show();
                tip2timeLbl.Show();
                tip3timeLbl.Show();
                tip4timeLbl.Show();
            }

            else if (i == 1)
            {
                tip1Lbl.Text = tip2Lbl.Text;
                tip1timeLbl.Text = tip2timeLbl.Text;
                tip2Lbl.Text = tip3Lbl.Text;
                tip2timeLbl.Text = tip3timeLbl.Text;
                tip3Lbl.Text = tip4Lbl.Text;
                tip3timeLbl.Text = tip4timeLbl.Text;
                tip4Lbl.Text = tip5Lbl.Text;
                tip4timeLbl.Text = tip5timeLbl.Text;
                tip5Lbl.Text = tip6Lbl.Text;
                tip5timeLbl.Text = tip6timeLbl.Text;
                tip1Lbl.Show();
                tip2Lbl.Show();
                tip2Lbl.Show();
                tip2Lbl.Show();
                tip3Lbl.Show();
                tip4Lbl.Show();
                tip5Lbl.Show();
                tip1timeLbl.Show();
                tip1timeLbl.Show();
                tip2timeLbl.Show();
                tip3timeLbl.Show();
                tip4timeLbl.Show();
                tip5timeLbl.Show();
            }
            else
            {

            }
        }

        //checks tips and changes
        public void checkTips()
        {
            int timeCheck = checkAllTips();
            changeTips(timeCheck);
            home.tipsLbl.Text = tip1Lbl.Text + " " + tip1timeLbl.Text;
        }
    }
}