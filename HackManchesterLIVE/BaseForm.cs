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
    public partial class BaseForm : Form
    {
        public DateTime dusk;
        public TimeSpan dawn;

        public BaseForm()
        {
            InitializeComponent();

            dusk = new DateTime().Add(new TimeSpan(19, 15, 26));
            dawn = new TimeSpan(06, 15, 26);

        }

        private void BaseForm_Paint(object sender, PaintEventArgs e)
        {

            if (checkTime(dusk.ToString("HH:mm")))
                {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Silver, 90f);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            else
            {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.White, 90f);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private DateTime toTime(String time)
        {

            DateTime date = DateTime.Parse(time, System.Globalization.CultureInfo.CurrentCulture);
            return date;
        }
        private String getTimeString()
        {
            String timeNow = DateTime.Now.ToString("h:mm");
            return timeNow;
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

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
