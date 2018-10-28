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
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#000000");
            System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml("#203A43");
            System.Drawing.Color col3 = System.Drawing.ColorTranslator.FromHtml("#7AA1D2");
            System.Drawing.Color col4 = System.Drawing.ColorTranslator.FromHtml("#3f4c6b");
            

            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(this.ClientRectangle, col, col2, 60F);

            ColorBlend cblend = new ColorBlend(4);
            cblend.Colors = new Color[4] { col, col2, col3, col4 };
            cblend.Positions = new float[4] { 0f, 0.75F, 0.85f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);


            /** if (checkTime(dusk.ToString("HH:mm")))
                 {
                 LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Silver, 90f);
                 e.Graphics.FillRectangle(brush, this.ClientRectangle);
             }
             else
             {
                 LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.White, 90f);
                 e.Graphics.FillRectangle(brush, this.ClientRectangle);
             }**/
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
