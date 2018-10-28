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
    
    public partial class Home : BaseForm
    {
        public Users currentUser;
        public AddShifts addShifts;
        public ViewShifts viewShifts;
        public Tips tips;
        public AddTrips addTrips;
        public Register register;
        public StartScreen startScreen;
        public UserProfile userProfile;
        public ViewTrips viewTrips;
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
            addShifts.currentUser = currentUser;
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
            viewShifts.currentUser = currentUser;
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
            tips.currentUser = currentUser;
            tips.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            welcomeLbl.Text = currentUser.getName();
            if (tips == null)
            {
                tips = new Tips();
                tips.FormClosed += delegate { tips = null; };
            }
            tipsLbl.Text = tips.tip1Lbl.Text;
        }

        private void profilePicBox_Click(object sender, EventArgs e)
        {
           
        }

        private void profileComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            { bottelPicBox.Visible = true;
                bottel2PicBox.Visible = false;
                bottel3PicBox.Visible = false;
                bottel4PicBox.Visible = false;
            }
            else if (label1.Text == "2")
            {
                bottelPicBox.Visible = false;
                bottel2PicBox.Visible = true;
                bottel3PicBox.Visible = false;
                bottel4PicBox.Visible = false;
            }
            else if (label1.Text == "3")
            {
                bottelPicBox.Visible = false;
                bottel2PicBox.Visible = false;
                bottel3PicBox.Visible = true;
                bottel4PicBox.Visible = false;
            }
            else if (label1.Text == "4")
            {
                bottelPicBox.Visible = false;
                bottel2PicBox.Visible = false;
                bottel3PicBox.Visible = false;
                bottel4PicBox.Visible =true;
            }
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
                if (userProfile == null)
                {
                    userProfile  = new UserProfile();
                    userProfile.FormClosed += delegate { tips = null; };
                }
                userProfile.Show();
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
                startScreen.currentUser = currentUser;
                startScreen.Show();
                this.Hide();
                // startScreen.Show();
                //this.Hide();
            }
        }

        private void addTripsBtn_Click(object sender, EventArgs e)
        {
            if (addTrips == null) {
                addTrips = new AddTrips();
                addTrips.FormClosed += delegate { addTrips = null; };
            }

            addTrips.currentUser = currentUser;
            addTrips.Show();
            this.Hide();
        }

        private void viewTripsBtn_Click(object sender, EventArgs e)
        {
            if (viewTrips == null) {
                viewTrips = new ViewTrips();
                viewTrips.FormClosed += delegate { viewTrips = null; };
            }

            viewTrips.Show();
        }
    }
}

