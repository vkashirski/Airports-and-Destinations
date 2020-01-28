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
    public partial class AddAirport : Form
    {
        public AddAirport()
        {
            InitializeComponent();
        }

        

        public bool checkValidity()
        {
            bool checkCity = true;
            bool checkName = true;
            bool checkAcronym = true;
            //city
            if (string.IsNullOrEmpty(tbCity.Text))
            {
                errorProvider1.SetError(tbCity, "Празно");
                checkCity = false;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                checkCity = true;
            }
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
            //acronym
            if (string.IsNullOrEmpty(tbAcronym.Text))
            {
                errorProvider1.SetError(tbAcronym, "Празно");
                checkAcronym = false;
            }
            else
            {
                String acr = tbAcronym.Text.ToString();
                if (acr.Length != 3)
                {
                    errorProvider1.SetError(tbAcronym, "Не се 3 букви");
                    checkAcronym = false;
                }
                else
                {
                    char[] parts = acr.ToCharArray();
                    String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char[] betabet = alphabet.ToCharArray();
                    int counter = 0;
                    foreach(char c in parts)
                    {
                       foreach(char ch in betabet)
                        {
                            if (c == ch)
                                counter++;
                        }
                    }
                    if (counter == 3)
                    {
                        errorProvider1.SetError(tbAcronym, null);
                        checkAcronym = true;
                    }
                    else
                    {
                        errorProvider1.SetError(tbAcronym, "Не се големи букви сите");
                        checkAcronym = false;
                    }
                }
            }

            if (checkCity && checkName && checkAcronym)
                return true;
            else
                return false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (checkValidity())
            {
                String city = tbCity.Text.ToString();
                String name = tbName.Text.ToString();
                String acronym = tbAcronym.Text.ToString();
                Airport a = new Airport(city, name, acronym);
                Form1.airports.Add(a);
                this.Close();
            }
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

        private void Save_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Save, "Only works with Latin Alphabet");
        }
    }
}
