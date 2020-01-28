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
    public partial class AddDestination : Form
    {
        public static int index;
        public AddDestination()
        {
            InitializeComponent();
            index = Form1.index;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel?", "Canceling...",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bool checkName = true;
            bool checkDistance = true;
            bool checkPrice = true;
            //name
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorProvider1.SetError(tbName, "Празно");
                checkName = false;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                checkName = true;
            }
            //distance
            if(nDistance.Value == 0)
            {
                errorProvider1.SetError(nDistance, "0");
                checkDistance = false;
            }
            else
            {
                errorProvider1.SetError(nDistance, null);
                checkDistance = true;
            }
            //price
            if (nPrice.Value == 0)
            {
                errorProvider1.SetError(nPrice, "0");
                checkPrice = false;
            }
            else
            {
                errorProvider1.SetError(nPrice, null);
                checkPrice = true;
            }

            if (checkName && checkDistance && checkPrice)
            {
                String name = tbName.Text.ToString();
                int distance = Int32.Parse(nDistance.Value.ToString());
                int price = Int32.Parse(nPrice.Value.ToString());
                Destination d = new Destination(name, distance, price);
                Form1.airports.ElementAt(index).addDestination(d);
                this.Close();
            }
        }
    }
}
