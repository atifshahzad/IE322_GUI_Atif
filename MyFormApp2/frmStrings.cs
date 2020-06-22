using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnFormattedString_Click(object sender, EventArgs e)
        {
            Decimal pricePerOunce = 17.36m;
            String s = String.Format("The current price is {0} per ounce.", pricePerOunce);// Result: The current price is 17.36 per ounce.


            decimal temp = 20.4m;
            string s2 = String.Format("The temperature is {0}°C.", temp); // Displays 'The temperature is 20.4°C.'

            RtbStrings.Text = s + "\n" + s2;




        }

        private void BtnFormattedStrings2_Click(object sender, EventArgs e)
        {
            Decimal pricePerOunce = 17.36m;
            String s = String.Format("The current price is {0:C2} per ounce.",
                                     pricePerOunce);

            // Result if current culture is en-US:
            //      The current price is $17.36 per ounce.



            string s2 = String.Format("At {0}, the temperature is {1}°C.",
                         DateTime.Now, 20.4);

            // Output similar to: 'At 4/10/2015 9:29:41 AM, the temperature is 20.4°C.'

            RtbStrings.Text = s + "\n" + s2;
        }

        private void BtnFormattedString3_Click(object sender, EventArgs e)
        {
            string s = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
            RtbStrings.Text = s;
            // Output similar to: 'It is now 4/10/2015 at 10:04 AM'
        }

        private void BtnStringSpacing_Click(object sender, EventArgs e)
        {
            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };

            var sb = new System.Text.StringBuilder();
            sb.Append(String.Format("{0,6} {1,15}\n\n", "Year", "Population"));

            for (int index = 0; index < years.Length; index++)
                sb.Append(String.Format("{0,6} {1,15:N0}\n", years[index], population[index]));

            RtbStrings.Text = Convert.ToString(sb);
        }

        private void BtnStringLeftAllign_Click(object sender, EventArgs e)
        {
            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            String s = String.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
            for (int index = 0; index < years.Length; index++)
                s += String.Format("{0,-10} {1,-10:N0}\n",
                                   years[index], population[index]);
            RtbStrings.Text = $"{s}";
            // Result:
            //    Year       Population
            //
            //    2013       1,025,632
            //    2014       1,105,967
            //    2015       1,148,203
        }

        private void BtnStringFormatMultiple_Click(object sender, EventArgs e)
        {
            DateTime dat = new DateTime(2020, 1, 17, 9, 30, 0);
            string city = "Jeddah";
            int temp = -32;
            string output = String.Format("At {0} in {1}, the temperature was {2} degrees.",
                                          dat, city, temp);
            RtbStrings.Text = $"{output}";
            // The example displays output like the following:
            //    At 1/17/2020 9:30:00 AM in Chicago, the temperature was -16 degrees.   
        }

        private void BtnTableString_Click(object sender, EventArgs e)
        {
            // Create array of 5-tuples with population data for three U.S. cities, 1940-1950.
            Tuple<string, DateTime, int, DateTime, int>[] cities =
                { Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277,
                   new DateTime(1950, 1, 1), 1970358),
      Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995,
                   new DateTime(1950, 1, 1), 7891957),
      Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808,
                   new DateTime(1950, 1, 1), 3620962),
      Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452,
                   new DateTime(1950, 1, 1), 1849568) };

            // Display header
            var header = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}\n",
                                          "City", "Year", "Population", "Change (%)");
           
            var output = "";
            foreach (var city in cities)
            {
                output = output + "\n"+ String.Format("{0,-12}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,14:P1}",
                                       city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                                       (city.Item5 - city.Item3) / (double)city.Item3);
                
            }

            string FinalTable= header + "\n" + output;
            RtbStrings.Text = $"{FinalTable}";

            // The example displays the following output:
            //    City            Year  Population    Year  Population    Change (%)
            //  
            //    Los Angeles     1940   1,504,277    1950   1,970,358        31.0 %
            //    New York        1940   7,454,995    1950   7,891,957         5.9 %
            //    Chicago         1940   3,396,808    1950   3,620,962         6.6 %
            //    Detroit         1940   1,623,452    1950   1,849,568        13.9 %
        }

        private void BtnDigitsAfterDecimal_Click(object sender, EventArgs e)
        {
            object[] values = { 1603, 1794.68235, 15436.14 };
            string result;
            foreach (var value in values)
            {
                result = String.Format("{0,12:C2}   {0,12:E3}   {0,12:F4}   {0,12:N3}  {1,12:P2}\n",
                                       Convert.ToDouble(value), Convert.ToDouble(value) / 10000);
                RtbStrings.Text = $"{result}";
            }
        }

        private void BtnSimpleString_Click(object sender, EventArgs e)
        {

        }
    }
}