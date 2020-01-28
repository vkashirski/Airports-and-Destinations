using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form1 : Form
    {
        public static List<Airport> airports = new List<Airport>();
        public static int index = -1;
        public Form1()
        {
            InitializeComponent();
            Destination d1 = new Destination("Vienna", 1500, 300);
            Destination d2 = new Destination("Skopje", 134, 60);
            Destination d3 = new Destination("Gronningen", 1300, 660);
            Destination d4 = new Destination("Amsterdam", 300, 990);
            Destination d5 = new Destination("Cape may", 8000, 1200);
            Destination d6 = new Destination("Rome", 1000, 200);
            Airport a1 = new Airport("Skopje", "Aleksandar veliki", "SKP");
            a1.addDestination(d1);
            a1.addDestination(d2);
            a1.addDestination(d3);
            Airport a2 = new Airport("Barcelona", "El Prat", "BAR");
            a2.addDestination(d2);
            a2.addDestination(d4);
            a2.addDestination(d5);
            a2.addDestination(d6);
            Airport a3 = new Airport("Vienna", "Viena IA", "VIE");
            a3.addDestination(d1);
            a3.addDestination(d3);
            Airport a4 = new Airport("Istanbul", "Ataturk", "IST");
            a4.addDestination(d1);
            a4.addDestination(d2);
            a4.addDestination(d3);
            a4.addDestination(d4);
            a4.addDestination(d5);
            a4.addDestination(d6);
            airports.Add(a1);
            airports.Add(a2);
            airports.Add(a3);
            airports.Add(a4);
            refresh();

        }
        public void refresh()
        {
            lbAirports.Items.Clear();
            foreach (Airport a in airports)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(a.acronym);
                sb.Append(" - ");
                sb.Append(a.name);
                sb.Append(" - ");
                sb.Append(a.city);
                lbAirports.Items.Add(sb.ToString());
            }
            lbDestinations.Items.Clear();
        }


        private void btAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            addAirport.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            refresh();
        }

        private void btDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                int ind = lbAirports.SelectedIndex;
                DialogResult result = MessageBox.Show("Delete " + lbAirports.SelectedItem.ToString() + "?", "Deleting ",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
                if (result == DialogResult.Yes)
                {
                    airports.RemoveAt(ind);
                    refresh();
                            
                }
            }
            else
                MessageBox.Show("You have not selected an airport.");
        }

        private void btAddDestination_Click(object sender, EventArgs e)
        {
            
            if (lbAirports.SelectedIndex != -1)
            {
                index = lbAirports.SelectedIndex;
                AddDestination addDestination = new AddDestination();
                addDestination.Show();
            }
            else
                MessageBox.Show("Select an airport.");
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDestinations.Items.Clear();
            int ind = lbAirports.SelectedIndex;
            if (airports.ElementAt(ind).destinations != null)
            {
                //list destinations
                foreach (Destination d in airports.ElementAt(ind).destinations)
                { 
                    StringBuilder sb = new StringBuilder();
                    sb.Append(d.name + " ");
                    sb.Append(d.distance + "km ");
                    sb.Append(d.price + " EUR");
                    lbDestinations.Items.Add(sb.ToString());
                }
                //most expensive
                int max = 0;
                double avg = 0;
                int destinationCounter = 0;
                String finale = "";
                foreach (Destination d in airports.ElementAt(ind).destinations)
                {
                    if(d.price > max)
                    {
                        max = d.price;
                        StringBuilder sb = new StringBuilder();
                        sb.Append(d.name + " ");
                        sb.Append(d.distance + "km ");
                        sb.Append(d.price + " EUR");
                        finale = sb.ToString();
                    }
                    avg += d.distance;
                    destinationCounter++;
                }
                tbMostExpensiveDestination.Text = finale;
                //average
                avg /= destinationCounter;
                tbAverageDistanceDestinations.Text = avg.ToString();
            }
            else
                lbDestinations.Items.Add("No destinations added to this airport");

        }
    }
}
