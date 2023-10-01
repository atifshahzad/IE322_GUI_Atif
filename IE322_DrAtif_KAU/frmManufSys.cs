using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmManufSys : Form
    {

        Random RndST = new Random();
        int MyTimeScale = 10; // Max 1000
        long PartsArrived = 0;
        long PartsDelivered = 0;
        long PartsInCombo = 0;

        public frmManufSys()
        {
            InitializeComponent();

            //Default Values

            TmrArrival.Enabled = false;
            TmrCNC01.Enabled = false;

            BtnStop.Enabled = false;
            BtnPause.Enabled = false;

            TrkTBA.Value = 2;
            TrkMinST.Value = 1;
            TrkMaxST.Value = TrkMinST.Value + 2;

            TmrArrival.Interval = TrkTBA.Value * MyTimeScale;
            TmrCNC01.Interval = 999999;// six digit

            RdoStatusCNC01.Checked = false; // Machine is IDLE


        }

        private void frmManufSys_Load(object sender, EventArgs e)
        {

        }

        private void TrkTBA_Scroll(object sender, EventArgs e)
        {

        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            BtnSimulate.Enabled = !BtnSimulate.Enabled; // Toggle
            BtnPause.Enabled = !BtnPause.Enabled;
            BtnStop.Enabled = !BtnStop.Enabled;

            TmrArrival.Start(); // Arrival of Parts Started
            TmrCNC01.Start(); // Arrival of Parts Started
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStop.Enabled = !BtnStop.Enabled;
            BtnSimulate.Enabled = !BtnSimulate.Enabled;

            TmrArrival.Stop();
            TmrCNC01.Stop();

            CmbWaitingArea01.Items.Clear();
            PartsArrived = 0;
            PartsDelivered = 0;
            PartsInCombo = 0;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void TmrArrival_Tick(object sender, EventArgs e)
        {
            //TmrArrival.Interval = Convert.ToInt32( TrkTBA.Value) * MyTimeScale;
            TmrArrival.Interval = TrkTBA.Value * MyTimeScale;
            int ServiceTimeAtCNC01 = RndST.Next(TrkMinST.Value, TrkMaxST.Value);

            if (RdoStatusCNC01.Checked == false)
            {
                RdoStatusCNC01.Checked = true;
                TmrCNC01.Interval = ServiceTimeAtCNC01 * MyTimeScale;
            }
            else
            {
                CmbWaitingArea01.Items.Add(ServiceTimeAtCNC01);
            }

            //Update Status
            TxTPartsArrived.Text = Convert.ToString(PartsArrived++);//
            TxTPartsInCombo.Text = Convert.ToString(CmbWaitingArea01.Items.Count);
            //TxTPartsDelivered.Text = Convert.ToString(CmbWaitingArea01.Items.Count);

            //DateTime localDate = DateTime.Now;
            //MessageBox.Show(localDate.ToShortTimeString());
        }

        private void PicCNC01_Click(object sender, EventArgs e)
        {

        }

        private void TmrCNC01_Tick(object sender, EventArgs e)
        { // This event triggers when Machine gets free

            TxTPartsDelivered.Text = Convert.ToString(PartsDelivered++);//
            RdoStatusCNC01.Checked = false;

            // Check if Machine is Free, Parts will be removed from Combo, But if Combo is Empty , Nothing happens

            if (RdoStatusCNC01.Checked == false)
            {// Machine is IDLE
                if (CmbWaitingArea01.Items.Count > 0)
                {// Parts waiting in Combo

                    CmbWaitingArea01.SelectedIndex = 0; // Select the First part (FIFO)
                    TmrCNC01.Interval = Convert.ToInt32(CmbWaitingArea01.Text) * MyTimeScale; // Set Service Time for this part


                    CmbWaitingArea01.Items.RemoveAt(0); // Remove it from Combo
                    RdoStatusCNC01.Checked = true;     // Make Machine BUSY

                }
                else
                {// Nothing in Combo
                    TmrCNC01.Interval = 999999 * MyTimeScale; // Make it Infinite Until Part Arrives


                }
            }
            else
            { // Machine was Busy, 


            }
            //Update Status
            TxTPartsInCombo.Text = Convert.ToString(CmbWaitingArea01.Items.Count);

        }

        private void TrkMinST_Scroll(object sender, EventArgs e)
        {
            if (TrkMinST.Value > TrkMaxST.Value)
            {
                TrkMinST.Value = TrkMaxST.Value;
            }
        }

        private void TrkMaxST_Scroll(object sender, EventArgs e)
        {
            if (TrkMinST.Value > TrkMaxST.Value)
            {
                TrkMaxST.Value = TrkMinST.Value;
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            BtnPause.Enabled = !BtnPause.Enabled;
            BtnSimulate.Enabled = !BtnSimulate.Enabled;
            BtnStop.Enabled = !BtnStop.Enabled;

            TmrArrival.Stop();
            TmrCNC01.Stop();
        }

        private void PnlStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RdoStatusCNC01_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoStatusCNC01.Checked)
                PnlStatus.BackColor = Color.Red;
            else
            {
                PnlStatus.BackColor = Color.Green;
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(Possibly Copyrighted) Image Source: http://www.orsemachine.com/WebImages/2016083117424106025.png");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
