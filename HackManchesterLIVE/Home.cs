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
    public partial class Home : Form
    {
        public AddShifts addShifts;
        public ViewShifts viewShifts;
        public Tips tips;
        public Register register;
        public StartScreen startScreen;
        public Home()
        {
            InitializeComponent();
            profileComBox.Visible = false;
            //profileComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            profilePicBox.Visible = true;
        }

        private void addShifsBtn_Click(object sender, EventArgs e)
        {
            if (addShifts == null)
            {
                addShifts = new AddShifts();
                addShifts.FormClosed += delegate { addShifts = null; };
            }
            addShifts.Show();
            this.Hide();
        }

        private void viewShiftsBtn_Click(object sender, EventArgs e)
        {
            if (viewShifts == null)
            {
                viewShifts = new ViewShifts();
                viewShifts.FormClosed += delegate { viewShifts = null; };
            }
            viewShifts.Show();
            this.Hide();
        }

        private void todaysTipsBtn_Click(object sender, EventArgs e)
        {
            if (tips == null)
            {
                tips = new Tips();
                tips.FormClosed += delegate { tips = null; };
            }
            tips.home = this;
            tips.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void profilePicBox_Click(object sender, EventArgs e)
        {
           
        }

        private void profileComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void profilePicBox_Click_1(object sender, EventArgs e)
        {
            profileComBox.Visible = true;
        }

        private void profileComBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            profileComBox.Visible = false;
            if (profileComBox.SelectedItem.ToString() == "Manage Account")
            {
                if (register == null)
                {
                    register = new Register();
                    register.FormClosed += delegate { tips = null; };
                }
                register.Show();
                this.Hide();
                //register.Show();
                //this.Hide();
            }
            else if (profileComBox.SelectedItem.ToString() == "Logout")
            {
                if (startScreen == null)
                {
                    startScreen = new StartScreen();
                    startScreen.FormClosed += delegate { tips = null; };
                }
                startScreen.Show();
                this.Hide();
                // startScreen.Show();
                //this.Hide();
            }
        }
    }
}

