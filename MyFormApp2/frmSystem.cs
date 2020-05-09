using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Newtonsoft.Json;

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
            string json = JsonConvert.SerializeObject(myInfo,Formatting.Indented);
            
            LblInfo.Text=json;
        }
    }
}
