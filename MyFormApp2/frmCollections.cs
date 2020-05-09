using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections; // Required for this 

namespace IE322_App_KAU
{
    public partial class frmCollections : Form
    {
        ArrayList myList;
        Stack myStack;
        Queue myQueue;
        Hashtable myHasht;

        public frmCollections()
        {
            InitializeComponent();
        }

        private void frmCollections_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateArrayList_Click(object sender, EventArgs e)
        {
            myList = new ArrayList(5); // capacity of 5 is optional, default is 4
            LstDisplay.Items.Clear();
                     

            LblCount.Text    = "Count: "    + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();

            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }

           

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myList.Remove("IE323");

            LblCount.Text = "Count: " + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();

            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }

        }

        private void BtnRemoveAt_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myList.RemoveAt(2);

            LblCount.Text = "Count: " + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();

            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }

        }

        private void BtnRemoveRange_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myList.RemoveRange(1, 3); //

            LblCount.Text = "Count: " + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();


            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            myList.Add("IE255");
            myList.Add("IE256");
            myList.Add("IE321");
            myList.Add("IE322");
            myList.Add("IE323");
            myList.Add("IE422");


            LblCount.Text = "Count: " + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();

            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnTrimToSize_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myList.TrimToSize();

            LblCount.Text = "Count: " + myList.Count.ToString();
            LblCapacity.Text = "Capacity: " + myList.Capacity.ToString();

            foreach (object item in myList)
            {
                LstDisplay.Items.Add(item);
            }


        }

        private void BtnCreateStack_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myStack = new Stack(5); // capacity of 5 is optional, default is 4
           



            LblCount.Text = "Count: " + myStack.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myStack)
            {
                LstDisplay.Items.Add(item); 
            }
        }

        private void BtnPushClick(object sender, EventArgs e)
        {
            myStack.Push("IE255");
            myStack.Push("IE256");
            myStack.Push("IE321");
            myStack.Push("IE322");
            myStack.Push("IE323");
            myStack.Push("IE422");
           

            LblCount.Text = "Count: " + myStack.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myStack)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            myStack.Pop();

            LblCount.Text = "Count: " + myStack.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myStack)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myStack.Peek().ToString());
        }

        private void BtnCreateQueue_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myQueue = new Queue(5);  // capacity of 5 is optional, default is 4

            LblCount.Text = "Count: " + myQueue.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myQueue)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnEnqueueClick(object sender, EventArgs e)
        {
            myQueue.Enqueue("IE255");
            myQueue.Enqueue("IE256");
            myQueue.Enqueue("IE321");
            myQueue.Enqueue("IE322");
            myQueue.Enqueue("IE323");
            myQueue.Enqueue("IE422");


            LblCount.Text = "Count: " + myQueue.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myQueue)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnDequeue_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myQueue.Dequeue();
            
            LblCount.Text = "Count: " + myQueue.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (object item in myQueue)
            {
                LstDisplay.Items.Add(item);
            }
        }

        private void BtnCreateHashTable_Click(object sender, EventArgs e)
        {
            myHasht = new Hashtable();
        }

        private void BtnAddHash_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myHasht.Add("IE255","Eco"); // Key value pair where key must be unique
            myHasht.Add("IE256","EM");
            myHasht.Add("IE321","Comp");
            myHasht.Add("IE322","C#");
            myHasht.Add("IE323","DB");
            myHasht.Add("IE422","Sim");


            LblCount.Text = "Count: " + myHasht.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (DictionaryEntry item in myHasht)
            {
                LstDisplay.Items.Add(item.Key + " : " + item.Value );
            }
        }

        private void BtnRemoveHash_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            myHasht.Remove("IE321");


            LblCount.Text = "Count: " + myHasht.Count.ToString();
            LblCapacity.Text = "Capacity:  NA";

            foreach (DictionaryEntry item in myHasht)
            {
                LstDisplay.Items.Add(item.Key + " : " + item.Value);
            }
        }
    }
}
