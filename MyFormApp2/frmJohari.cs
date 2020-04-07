using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmJohari : Form
    {
       int MAX_ALLOWED=8;
        private string[] attributesArray=new string[55]; // Declaring array of CheckBox
        private System.Windows.Forms.CheckBox[] chkArray; // Declaring array of CheckBox

        public frmJohari()
        {
            InitializeComponent();

            attributesArray[0] = "able";
            attributesArray[1] = "calm";
            attributesArray[2] = "confident";
            attributesArray[3] = "friendly";
            attributesArray[4] = "independent";
            attributesArray[5] = "knowledgeable";
            attributesArray[6] = "nervous";
            attributesArray[7] = "proud";
            attributesArray[8] = "responsive";
            attributesArray[9] = "sentimental";

            attributesArray[10] = "tense";












            CreateCheckBoxes();
            AddAllAttrib2Combo(this.cmbMeNotByMe);
            AddAllAttrib2Combo(this.cmbMeNotByYou);
        }

        private void frmJohari_Load(object sender, EventArgs e)
        {


        }

        private void CreateCheckBoxes()
        {
            int xPos = 8;
            int yPos = 16;
            int btnNum = attributesArray.Length; // number of Checkboxes to create
            AddControls(btnNum); // Create Checkboxes
            int n = 1;
            while (n < btnNum + 1)
            {
                chkArray[n].Tag = n;
                chkArray[n].Width = 72;
                chkArray[n].Height = 24;
                chkArray[n].Text = "chk_" + chkArray[n].Tag.ToString();

                // Positioning checkboxes
                if (yPos > grpControl.Height-10) // Adjust buttons in one column
                {
                    yPos = 16;
                    xPos = xPos + chkArray[n].Width + 8;
                }
                chkArray[n].Left = xPos;
                chkArray[n].Top = yPos;
                yPos = yPos + chkArray[n].Height + 10;


                grpControl.Controls.Add(chkArray[n]); // Let groupbox hold the CheckBox
                                                      // the Event of CheckChanged CheckBox
                chkArray[n].Click += new System.EventHandler(MyCheckChanged);
                n++;
            }

        }

        private void AddControls(int cNumber)
        {

            // assign number of controls 
            chkArray = new System.Windows.Forms.CheckBox[cNumber + 1];
            for (int i = 0; i < cNumber + 1; i++)
            {
                // Initialize one variable
                chkArray[i] = new System.Windows.Forms.CheckBox();
            }
        }

        private void AddAllAttrib2Combo(System.Windows.Forms.ComboBox cmb)
        {
            foreach (var item in chkArray)
            {
                cmb.Items.Add(item.Text);
            }
            
        }

        //===================== Function for Check Array ======================

        private void MyCheckChanged(object sender, EventArgs e)
        {   // cmbMeByMe.Items[index];
            string attribute = ((CheckBox)sender).Text;   //((CheckBox)sender).Tag.ToString();

            if (rdoMe.Checked)
            {
                if (((CheckBox)sender).Checked)
                {
                   

                    if (cmbMeByMe.Items.Count == MAX_ALLOWED)
                    {
                        MessageBox.Show("Maximum of " + MAX_ALLOWED + "attributes allowed.");

                    }
                    else
                    {
                        cmbMeNotByMe.Items.Remove(attribute);
                        cmbMeByMe.Items.Add(attribute);
                        (((CheckBox)sender).ForeColor) = Color.FromName("Orange");//Color.FromArgb(r, g, b);


                    }
                    

                }
                else
                {

                    cmbMeByMe.Items.Remove(attribute);
                    cmbMeNotByMe.Items.Add(attribute);
                    (((CheckBox)sender).ForeColor) = Color.FromName("Black");

                }
                lblMe.Text = cmbMeByMe.Items.Count.ToString() + " selected";
            }
            else //rdoYou
            {
               
                    if (((CheckBox)sender).Checked)
                    {


                        if (cmbMeByYou.Items.Count == MAX_ALLOWED)
                        {
                            MessageBox.Show("Maximum of " + MAX_ALLOWED + "attributes allowed.");

                        }
                        else
                        {
                            cmbMeNotByYou.Items.Remove(attribute);
                            cmbMeByYou.Items.Add(attribute);
                        (((CheckBox)sender).ForeColor) = Color.FromName("Magenta");


                    }

                    }
                    else
                    {

                        cmbMeByYou.Items.Remove(attribute);
                        cmbMeNotByYou.Items.Add(attribute);
                    (((CheckBox)sender).ForeColor) = Color.FromName("Black");

                }

                lblYou.Text = cmbMeByYou.Items.Count.ToString() + " selected";
            }

        }



        private void grpControl_Enter(object sender, EventArgs e)
        {
            //  (cmbMeByMe.Items[i].ToString()); 
            /*        // Check if attribute already there in other combo?
                       index = cmbMeNotByMe.Items.IndexOf(attribute);
                       if (index == 0) {
                           cmbMeNotByMe.Items.Remove(attribute);
                       }
            // System.Windows.Forms.MessageBox.Show("You have clicked button " +
            //                 ((System.Windows.Forms.CheckBox)sender).Tag.ToString());

            //int index;           


               */
        }

        private void cmbMeByMe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            int index;
            for (int i=0;i< cmbMeByMe.Items.Count;i++)
            {
                index = cmbMeNotByMe.Items.IndexOf(cmbMeByMe.Items[i]);
                if (index == 0)
                { //found so in ARENA
                    cmbArena.Items.Add(cmbMeByMe.Items[i]);
                }
                else
                {//Not found so in Facade 
                    cmbFacade.Items.Add(cmbMeByMe.Items[i]);
                }                
            }

            index = 0;
            for (int i = 0; i < cmbMeNotByMe.Items.Count; i++)
            {
                

                index = cmbMeByYou.Items.IndexOf(cmbMeNotByMe.Items[i]);
                if (index == 0)
                { //found so in Blind
                    cmbBlind.Items.Add(cmbMeNotByMe.Items[i]);
                }
                else
                {//Not found so in Mystery 
                    cmbMystery.Items.Add(cmbMeNotByMe.Items[i]);
                }
            }

            lblArena.Text=cmbArena.Items.Count.ToString()+ " in ARENA";
            lblFacade.Text = cmbFacade.Items.Count.ToString() + " in FACADE";
            lblBlind.Text = cmbBlind.Items.Count.ToString() + " in BLIND";
            lblMystery.Text = cmbMystery.Items.Count.ToString() + " in MYSTERY";


        }

        private void rdoMe_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in chkArray)
            {
                item.Checked = false;
                item.ForeColor = Color.FromName("Black");
            }
        }

        private void rdoYou_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in chkArray)
            {
                item.Checked = false;
                item.ForeColor = Color.FromName("Black");
            }
        }
    }
}