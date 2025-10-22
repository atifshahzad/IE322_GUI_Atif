using System;
using System.Text;

namespace IE322_App_KAU
{
    class BasicInfo
    {

        public string OsVersion { get; set; }
        public bool Os64 { get; set; }
        public string PcName { get; set; }
        public int NumberOfCpus { get; set; }
        public string WindowsFolder { get; set; }
        public string[] LogicalDrives { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Windows version: {0}\n", OsVersion);
            output.AppendFormat("64 Bit operating system? : {0}\n",
               Os64 ? "Yes" : "No");
            output.AppendFormat("PC Name : {0}\n", PcName);
            output.AppendFormat("Number of CPUS : {0}\n", NumberOfCpus);
            output.AppendFormat("Windows folder : {0}\n", WindowsFolder);
            output.AppendFormat("Logical Drives Available : {0}\n",
                  String.Join(", ", LogicalDrives)
               .Replace("\\", String.Empty));
            return output.ToString();
        }


    }


}
