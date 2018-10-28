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
    public partial class AddTrips : BaseForm
    {
        public Home home;
        public Users currentUser;
        public AddTrips()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void AddTrips_Load(object sender, EventArgs e)
        {
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (home == null) {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }
            home.Show();
            home.currentUser = currentUser;
            this.Hide();
        }

        private void AddTripBtn_Click(object sender, EventArgs e)
        {
            currentUser.destination = destTb.Text;
            
            currentUser.DepartureDate = depDateTb.Text;
            currentUser.DepartureTime = DepTimeTb.Text;
            currentUser.ArrivalDate = arrDateTb.Text;
            currentUser.ArrivalTime = arrTimeTb.Text;

            if (eastOrWest(currentUser.destination).Equals("east"))
            {
                currentUser.setType("East");
            }
            else if (eastOrWest(currentUser.destination).Equals("west"))
            {
                currentUser.setType("West");
            }
            else
            {
                currentUser.setType("Regular");
            }



            MessageBox.Show("Trip Added!");
            destTb.Clear();
            depDateTb.Clear();
            DepTimeTb.Clear();
            arrDateTb.Clear();
            arrTimeTb.Clear();

            }

        public String eastOrWest(String destination)
        {
            String direction;
            if (destination.Equals("Hong Kong") || destination.Equals("Rome") || destination.Equals("Dubai")
                || destination.Equals("Istanbul") || destination.Equals("Tokyo") || destination.Equals("Beijing")
                || destination.Equals("Munich") || destination.Equals("Moscow") || destination.Equals("Astana"))
            {

                direction = "east";
                
            }
            else if (destination.Equals("New York") || destination.Equals("Mexico City") || destination.Equals("Toronto")
                || destination.Equals("Los Angeles") || destination.Equals("Florida") || destination.Equals("Washington")
                || destination.Equals("San Francisco"))
            {
                direction = "west";

            }
            else
            {
                direction = "fail";
            }

            return direction;
        }

        }
    }

