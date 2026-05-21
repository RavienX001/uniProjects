using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identityDataRetrivalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genarateButton_Click(object sender, EventArgs e)
        {
            string NICtext = nicNumber.Text;

            string gender = "";
            int year = 0;
            string month = "";
            int date = 0;

            //validate the (NIC format  NICtext[2] != 4 && NICtext[2] != 9)--> Invalid NIC number if the third digit is 4 or 9 

            if ((NICtext.Count(char.IsDigit) == 9) && NICtext[2] != 4 && NICtext[2] != 9 && (NICtext.EndsWith("V")) || (NICtext.EndsWith("X"))
                || (NICtext.Count(char.IsDigit) == 12))
            {
                //check wether old id or new id or invalid 
                if (NICtext.Length == 10)
                {
                    year = 1900 + int.Parse(NICtext.Substring(0, 2));
                    date = int.Parse(NICtext.Substring(2, 3));
                }
                else if (NICtext.Length == 12)
                {
                    year = int.Parse(NICtext.Substring(0, 4));
                    date = int.Parse(NICtext.Substring(4, 3));
                }
                else
                {
                    MessageBox.Show("Invalid NIC");
                }

                //gender
                if (date > 500) { gender = "Female"; date = date - 500; }
                else { gender = "Male"; }


                //birthDate
                DateTime birthdate = new DateTime(year, 1, 1).AddDays(date - 1);

                //display results
                yearShow.Text = year.ToString();
                GenderShow.Text = gender.ToString();
                monthShow.Text = birthdate.ToString("MMM");
                dateShow.Text = birthdate.ToString("dd");
            }

        }

    }
}

