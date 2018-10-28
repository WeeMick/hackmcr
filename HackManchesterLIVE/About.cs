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
    public partial class About: BaseForm
    {
        public StartScreen startScreen;

        public About()
        {
            InitializeComponent();
        }

        private void aboutLbl_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (startScreen == null)
            {
                startScreen = new StartScreen();
                startScreen.FormClosed += delegate { startScreen = null; };
            }

            
            startScreen.Show();
            this.Hide();
            
        }
    }
}
