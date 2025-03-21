﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmArray : Form
    {
        //Array to be filled with Random numbers
        Random rnd = new Random();
        int[] b = new int[500];

        //1D Arrays

        Int32[] iArray1 = new Int32[5];//Declaration & Definition
        Int32[] iArray2 = new Int32[5]; //Declaration and Definition 
        Int32[] iArray3 = new Int32[5] { 21, 22, 23, 24, 25 };//RECOMMENDED WAY:Declaration, Definition & Initialization
        Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 }; //Declaration, Definition & Initialization (can omit size value only if initialization)           
        Int32[] iArray5 = { 31, 32, 33, 34, 35 };//Declaration, Definition & Initialization (can omit new keyword only if initialization) 

        //2D Arrays
        int[,] iArray55 = new int[5, 5]; //Declaration and Definition of 2D array 
        int[,,] iArray345 = new int[3, 4, 5]; //Declaration and Definition of 3D array

       

        int[,] iArray32 = new int[3, 2]
                                {
                                         { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 }
                                }; //Declaration,Definition & Initialization of 2D array

               



        public frmArray()
        {
            InitializeComponent();
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
           
        }

        private void BtnDisplay1DForLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray3 using for Loop";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + 
                    Convert.ToString(iArray3[i]);

            }
            
        }

        private void BtnDisplay1DForEachLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray5 using foreach Loop";

            foreach (Int32 j in iArray5)
            {
               
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(j);

            }
        }

        private void BtnDisplay2DForLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "2D Array named iArray32 using nested for Loop";
            for (int i = 1; i < 4; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n";

                for (int j = 1; j < 3; j++)
                {
                    lblDisplay.Text = lblDisplay.Text + "    " + Convert.ToString(iArray32[i - 1, j - 1]);

                }
            }
        }


        

        private void BtnDisplayPropertiesMethods2D_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Some Methods and Properties:";
            

            lblDisplay.Text = lblDisplay.Text + "\n" + "Rank of iArray23 is:" + iArray32.Rank;   // Dimensions
            lblDisplay.Text = lblDisplay.Text + "\n" + "Length of iArray23 is:" + iArray32.Length;// Length: Total number of elements in all dimensions


            lblDisplay.Text = lblDisplay.Text + "\n" + "Number of Rows of  of iArray23 is:" + iArray32.GetLength(0);// first dimension
            lblDisplay.Text = lblDisplay.Text + "\n" + "Number of Columns of iArray23 is:" + iArray32.GetLength(1);//second dimension




        }

        private void BtnDisplayRandomList_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "Some Methods and Properties of Random Array b :";
            LstRandom.Items.Clear();
            for (int i = 0; i < b.Length; i++)
            {

                b[i] = rnd.Next(500, 1000);
                LstRandom.Items.Add(b[i]);
            }

            lblDisplay.Text = lblDisplay.Text + "\n" + "Min of Random Array b is:" + b.Min();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Max of Random Array  b is:" + b.Max();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Sum of Random Array  b is:" + b.Sum();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Average of Random Array b is:" + b.Average();

        }


        private void BtnModifyAnArray_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

            ModifyArray(iArray3); // paasing an entire array, by default it will be by ref 

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }
        }

        void ModifyArray(Int32[] MyArray)
        {
            for (Int32 i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = MyArray[i] + 10;
            }
        }
        

        private void BtnModifyAnElement_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

            ModifyElement(iArray3[2]); // by default it is passed by val

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

        }

        void ModifyElement(int AnElement)
        {
            AnElement = AnElement + 10;

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "Value of Element from inside the called method is: " + AnElement;

        }



        private void BtnModifyAnElementByRef_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

            ModifyElementByRef(ref iArray3[2]); // by default it is passed by val

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }
        }

        void ModifyElementByRef(ref int AnElement)
        {
            AnElement = AnElement + 10;

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "Value of Element from inside the called method is: " + AnElement;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Display:";
            LstRandom.Items.Clear();

            //1D Arrays

            for (int i = 0; i < iArray3.Length; i++)
            {
                iArray3[i] = 21 + i;
            }
            for (int i = 0; i < iArray4.Length; i++)
            {
                iArray3[i] = 11 + i;
            }
            for (int i = 0; i < iArray5.Length; i++)
            {
                iArray3[i] = 31 + i;
            }

           

            //2D Arrays
            int[,] iArray55 = new int[5, 5]; //Declaration and Definition of 2D array 
            int[,,] iArray345 = new int[3, 4, 5]; //Declaration and Definition of 3D array

            int[,] iArray32 = new int[3, 2]
                                    {
                                         { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 }
                                    }; //Declaration,Definition & Initialization of 2D array


            //Array to be filled with Random numbers
            Random rnd = new Random();
            int[] b = new int[500];


        }

        private void BtnQuestion02_2D_Click(object sender, EventArgs e)
        {
            int[,] d = { { 1, 2, 1 }, { 1, 2, 1 }, { 2, 0, 1 } };
            int total = 0;
            for (int j = 1; j < d.GetLength(1); j++)
            {
                
                for (int i = j; i < d.GetLength(0); i++)
                {
                    total = total + d[i, j];
                }
                lblDisplay.Text = "Answer is " + Convert.ToString(total);
            }

        }

        private void BtnDisplayPropertiesMethods1D_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Some Methods and Properties:";

            // Some methods of Array
            lblDisplay.Text = lblDisplay.Text + "\n" + "Min of iArray5 is:" + iArray5.Min();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Max of iArray5 is:" + iArray5.Max();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Sum of iArray5 is:" + iArray5.Sum();

            // Some properties of Array
            lblDisplay.Text = lblDisplay.Text + "\n" + "Rank of iArray5 is:" + iArray5.Rank;   // Dimensions
            lblDisplay.Text = lblDisplay.Text + "\n" + "Length of iArray5 is:" + iArray5.Length;// size           

        }

        private void BtnVariablesInArray_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray3 using for Loop"; 
            
            int i = 1;
            int [] a=new int[3] { i,i+1,i*7};

            for (int j = 0; j < a.Length; j++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(a[j]);
            }

            
        }

        private void BtnDoubleArrayForEach_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "1D Array named iArray3 using for Loop";
            for (Int32 i = 0; i < 5; i++)
            {
                iArray3[i] = iArray3[i] * 2;
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }
        }

        private void BtnQuestion1_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int total = 0;
            for (int i = 1; i < array.Length; i = i + 2)
                total = total + array[i];
            MessageBox.Show(total.ToString());

        }

        
    }// end frmArray
}//end namespace
