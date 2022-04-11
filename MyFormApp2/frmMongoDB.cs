using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmMongoDB : Form
    {
        public frmMongoDB()
        {
            InitializeComponent();
        }

        private void frmMongoDB_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

            MongoClient dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            var dbList = dbClient.ListDatabases().ToList();


            LblDispaly.Text = "The list of databases on this server is: ";
            foreach (var db in dbList)
            {
                LblDispaly.Text = LblDispaly.Text + "\n" + db;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
