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
    public partial class frmOperators : Form
    {
        double a, b, c, w, x, y, z;
        double res,res2;
        bool ra;

        bool p, q, r, s;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnLogical_Click(object sender, EventArgs e)
        {

            LblRes.Text = "";
            LblRes.Text = LblRes.Text + "\n\n" + "NOT p is: "+ !p;
            LblRes.Text = LblRes.Text + "\n\n" + "NOT q is: "+ !q;

            LblRes.Text = LblRes.Text + "\n\n" + "p AND q is: " + (p && q);
            LblRes.Text = LblRes.Text + "\n\n" + "p OR q is: "+ (p || q);
            LblRes.Text = LblRes.Text + "\n\n" + "p XOR q is: "+( p ^ q);

            LblRes.Text = LblRes.Text + "\n\n" + "NOT p AND NOT q is: "+ (!p && !q);

            LblRes.Text = LblRes.Text + "\n\n" + "p AND q OR r is: "+ (p && q || r);
            LblRes.Text = LblRes.Text + "\n\n" + "p OR q AND r is: "+( p || q && r);

            LblRes.Text = LblRes.Text + "\n\n" + "p AND q AND r is: "+ (p && q && r);
            LblRes.Text = LblRes.Text + "\n\n" + "p OR q OR r is: "+ (p || q || r);

            LblRes.Text = LblRes.Text + "\n\n" + "p XOR q XOR r is: "+ (p ^ q ^ r);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND q XOR r is: "+ (p && q ^ r);
            LblRes.Text = LblRes.Text + "\n\n" + "p XOR q XOR r is: "+ (p ^ q ^ r);

            LblRes.Text = LblRes.Text + "\n\n" + "p AND q OR r OR s is: "+ ( p && q || r || s);
            LblRes.Text = LblRes.Text + "\n\n" + "p OR q OR r OR s is: " + ( p || q || r || s);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND q OR r OR NOT s is: " + ( p && q || r || !s);

            LblRes.Text = LblRes.Text + "\n\n" + "p AND q AND r AND s is: " + ( p && q && r && s);

            LblRes.Text = LblRes.Text + "\n\n" + "(p AND q) OR (r AND s) is: " + ( (p && q) || (r && s));
            LblRes.Text = LblRes.Text + "\n\n" + "p AND q OR r AND s is: " + ( p && q || r && s);


            LblRes.Text = LblRes.Text + "\n\n" + "p OR q AND r AND s is:" + ( p || q && r && s);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND q ^ r AND s is: " + ( p && q ^ r && s);
            LblRes.Text = LblRes.Text + "\n\n" + "NOT p AND q AND r AND s is: " + ( !p && q && r && s);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND q AND r OR s is: " + ( p && q && r || s);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND NOT q AND NOT r AND NOT s is: " + ( p && !q && !r && !s);
            LblRes.Text = LblRes.Text + "\n\n" + "NOT p AND q AND r AND s is: " + ( p && q && r && s);
            LblRes.Text = LblRes.Text + "\n\n" + "p XOR q AND r AND s is: " + ( p ^ q && r && s);
            LblRes.Text = LblRes.Text + "\n\n" + "p AND NOT q XOR r AND s is: " + ( p && !q ^ r && s);
        }

        private void BtnCompoundAssignment_Click(object sender, EventArgs e)
        {
            z = y += 2;

            txtY.Text = Convert.ToString(y);
            txtZ.Text = Convert.ToString(z);
        }

        private void BtnIncrement_Click(object sender, EventArgs e)
        {
            y = ++z + y++;

            txtY.Text = Convert.ToString(y);
            txtZ.Text = Convert.ToString(z);
        }

        private void BtnRelational_Click(object sender, EventArgs e)
        {
            LblRes.Text = "";
            ra = 5 < 6;
            LblRes.Text = LblRes.Text + "\n\n" + "ra = 5 < 6  is: " + ra;

            ra = 6 < 5;
            LblRes.Text = LblRes.Text + "\n\n" + "Now ra = 6 < 5  is: " + ra;

            ra = 67 >= 34;
            LblRes.Text = LblRes.Text + "\n\n" + "Now ra = 67 >= 34  is: " + ra;


            ra = 67 >= 34 + 38;
            LblRes.Text = LblRes.Text + "\n\n" + "Now ra = 67 >= 34 + 38  is: " + ra;

            ra = 67 % 10 >= 7;
            LblRes.Text = LblRes.Text + "\n\n" + "By 67 % 10 >= 7, we have now ra  is: " + ra;
        }

        private void BtnSolveQuad_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtP.Text);

            b = Convert.ToDouble(txtQ.Text);

            c = Convert.ToDouble(txtR.Text);


            double Disc = Math.Pow(b, 2) - 4 * a * c;
            // Formula
            res = (-b + Math.Sqrt(Disc)) / (2 * a);
            res2 = (-b - Math.Sqrt(Disc)) / (2 * a);

            LblRes.Text = "x1:\t" + Convert.ToString(res);
            LblRes.Text = LblRes.Text + "\n\n" + "x2:\t" + Convert.ToString(res2);
        }

        private void BtnPostfix_Click(object sender, EventArgs e)
        {
            //postfix
            y = x++;

            txtX.Text = Convert.ToString(x);
            txtY.Text = Convert.ToString(y);
        }

        private void BtnPrefix_Click(object sender, EventArgs e)
        {
            //prefix
            y = ++x;
            txtX.Text = Convert.ToString(x);
            txtY.Text = Convert.ToString(y);         
            

        }

        

        private void BtnSolve_Click(object sender, EventArgs e)
        {

            try
            {
                a = Convert.ToDouble(txtP.Text);

                b = Convert.ToDouble(txtQ.Text);

                c = Convert.ToDouble(txtR.Text);

                w = Convert.ToDouble(txtW.Text);

                x = Convert.ToDouble(txtX.Text);

                y = Convert.ToDouble(txtY.Text);


                res = a * c % b + w / (x - y);

            LblRes.Text= "a * c % b + w / (x - y): " + Convert.ToString(res);


                res = (z * z) + x / y;
                LblRes.Text = LblRes.Text + "\n\n" + "(z * z) + x / y:\t" + Convert.ToString(res);

                res = z * x + x / y;
                LblRes.Text = LblRes.Text + "\n\n" + "z * x + x / y:\t" + Convert.ToString(res);

                res = z % x + x * y;
                LblRes.Text = LblRes.Text + "\n\n" + "z % x + x * y:\t" + Convert.ToString(res);

                res = x - y + z * x + x / y;
                LblRes.Text = LblRes.Text + "\n\n" + "x - y + z * x + x / y:\t" + Convert.ToString(res);

                res = x - (y + z) * x + x / y;
                LblRes.Text = LblRes.Text + "\n\n" + "x - (y + z) * x + x / y:\t" + Convert.ToString(res);

                res = z % 2 * y;
                LblRes.Text = LblRes.Text + "\n\n" + "z % 2 * y:\t" + Convert.ToString(res);


            }
            catch (Exception)
            {

                throw;
            }

        }

        public frmOperators()
        {
            InitializeComponent();
        }

        private void frmOperators_Load(object sender, EventArgs e)
        {

            a = Convert.ToDouble(txtP.Text);

            b = Convert.ToDouble(txtQ.Text);

            c = Convert.ToDouble(txtR.Text);

            w = Convert.ToDouble(txtW.Text);

            x = Convert.ToDouble(txtX.Text);

            y = Convert.ToDouble(txtY.Text);

        }
    }
}
