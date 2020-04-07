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
    public partial class frmTimer : Form
    {
        int second = 0;// 
        Random rnd = new Random();

        public frmTimer()
            
        {
            InitializeComponent();
            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {

            prgTry.Value = 0;
            tmrTry.Start();                 //Option 1

            //btnStartTimer.Enabled = false;  //Option 2   
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            tmrTry.Interval = 2000; // 2 sec
            TmrShowMsg.Interval = 1000; // 1 Sec

            BtnTimerShowMsgStop.Enabled = false;
        }

        private void prgTry_Click(object sender, EventArgs e)
        {

        }

        private void tmrTry_Tick(object sender, EventArgs e)
        {
            second = second + tmrTry.Interval / 1000;//in seconds
            prgTry.Value += tmrTry.Interval / 100;// 100 is tmrTry.Max

           
            if (second >= 10)
            {
                tmrTry.Stop();
                MessageBox.Show("Exiting from Timer 1....");
                btnStartTimer.Enabled = true;
                second = 0;
            }
        }

        private void BtnTimerShowMsgStart_Click(object sender, EventArgs e)
        {
            TmrShowMsg.Start();
            BtnTimerShowMsgStart.Enabled = !BtnTimerShowMsgStart.Enabled;
            BtnTimerShowMsgStop.Enabled = !BtnTimerShowMsgStop.Enabled;

        }

        private void TmrShowMsg_Tick(object sender, EventArgs e)
        {
            RdoTry.Checked = !(RdoTry.Checked);
            

        }
           
        private void BtnTimerShowMsgStop_Click(object sender, EventArgs e)
        {
            TmrShowMsg.Stop();
            BtnTimerShowMsgStop.Enabled = !BtnTimerShowMsgStop.Enabled;
            BtnTimerShowMsgStart.Enabled = !BtnTimerShowMsgStart.Enabled;
        }

        private void BtnToggleTimer3_Click(object sender, EventArgs e)
        {
            Timer3.Enabled = !Timer3.Enabled;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            
            BtnToggleTimer3.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            TxtForTimer4.Text = Convert.ToString(rnd.Next(0, 50000));
        }

        private void TrkTBA_Scroll(object sender, EventArgs e)
        {
            Timer4.Interval = TrkTBA.Value * 200;
        }

        private void BtnStartTimer4_Click(object sender, EventArgs e)
        {
            Timer4.Enabled = !Timer4.Enabled;
        }
    }
}
