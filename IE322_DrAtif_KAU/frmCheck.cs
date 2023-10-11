using System;

using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmCheck : Form
    {

        public frmCheck()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }




        private void btnShow_Click(object sender, EventArgs e)
        {

            string msg = "";
            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }



            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {

        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void GrpQuestion_Enter(object sender, EventArgs e)
        {
            /*
            Create a Windows Forms application that displays a multiple-choice question
            with four checkboxes. Users can select one or more checkboxes,
            and when they click the "Submit" button, a message box will
            display their selected options.
            */
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check the selected checkboxes and provide feedback
            string result = "Your selected options: ";
            foreach (Control ctrl in GrpQuestion.Controls)
            {
                if (ctrl is CheckBox checkBox && checkBox.Checked)
                {
                    result += checkBox.Text + ", ";
                }
            }

            if (result == "Your selected options: ")
            {
                result += "None"; // No checkboxes were selected
            }
            else
            {
                result = result.TrimEnd(',', ' '); // Remove the trailing comma and space
            }

            MessageBox.Show(result, "Your Selection");

        }
    }
}
