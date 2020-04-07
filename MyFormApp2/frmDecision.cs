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
    public partial class frmDecision : Form
    {
        public frmDecision()
        {
            InitializeComponent();
        }

        private void BtnIfElseifElse_Click(object sender, EventArgs e)
        {
            int first = 0, second = 0;

            try
            {
                first = Convert.ToInt32(TxtA.Text);
                second = Convert.ToInt32(TxtB.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }


            if (first == second)
            {
                MessageBox.Show("Numbers are equal");

            }

            else if (first > second)
            {
                MessageBox.Show("First number is bigger");
            }
            else
            {
                MessageBox.Show("First number is smaller");
            }
        }

        private void BtnSwitchMathCalc_Click(object sender, EventArgs e)
        {
            double a, b, res;
            int choice = 0;

            try
            {
                a = Convert.ToDouble(TxtA.Text);
                b = Convert.ToDouble(TxtB.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }

            if (RdoAdd.Checked)
                choice = 1;
            if (RdoSubtract.Checked)
                choice = 2;
            if (RdoMultiply.Checked)
                choice = 3;
            if (RdoDivide.Checked)
                choice = 4;
            if (RdoRemainder.Checked)
                choice = 5;


            switch (choice)
            {
                case 1:

                    res = a + b;
                    break;

                case 2:

                    res = a - b;
                    break;
                case 3:

                    res = a * b;
                    break;
                case 4:
                    if (b == 0)
                    {
                        MessageBox.Show("b must not be zero", "ERROR");
                        return;
                    }

                    res = a / b;
                    break;
                case 5:
                    if (b == 0)
                    {
                        MessageBox.Show("b must not be zero", "ERROR");
                        return;
                    }

                    res = a % b;
                    break;
                default:

                    MessageBox.Show("Thanks");
                    return;

            }
            MessageBox.Show("Result is " + res, "Result");
        }

        private void BtnAnimalType_Click(object sender, EventArgs e)
        {
            string animal;

            animal = CmbAnimal.Text;

            switch (animal)
            {
                case "dog":
                    MessageBox.Show("MAMMAL");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    MessageBox.Show("REPTILE");
                    break;
                default:
                    MessageBox.Show("There is no such animal!");
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
