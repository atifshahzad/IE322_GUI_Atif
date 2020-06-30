using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmSystem : Form
    {


        public frmSystem()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {

        }

        private void BtnSystemInfo_Click(object sender, EventArgs e)
        {
            BasicInfo myInfo = new BasicInfo
            {
                OsVersion = Environment.OSVersion.ToString(),
                Os64 = Environment.Is64BitOperatingSystem,
                PcName = Environment.MachineName,
                NumberOfCpus = Environment.ProcessorCount,
                WindowsFolder = Environment.SystemDirectory,
                LogicalDrives = Environment.GetLogicalDrives()
            };
            string json = JsonConvert.SerializeObject(myInfo, Formatting.Indented);

            LblInfo.Text = json;
        }
    }
}
