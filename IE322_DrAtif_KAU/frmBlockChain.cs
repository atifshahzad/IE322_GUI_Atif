using IE322_App_KAU.BlockChainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmBlockChain : Form
    {
        /*
        Genesis Block: The first block, which is created manually and doesn't have a previous hash.
        New Blocks: Each subsequent block records a stage in the product's journey.
        Hashing: Each block's hash is generated using the block's data and the previous block's hash, creating a secure link between blocks.
        Validation: The IsChainValid method checks if the blockchain has been tampered with by verifying the hashes.
        */
       
        Blockchain coffeeBlockchain = new Blockchain();

        public frmBlockChain()
        {
            InitializeComponent();
        }

        private void BtnCreateBC_Click(object sender, EventArgs e)
        {

            

            coffeeBlockchain.AddBlock(new Block(1, DateTime.Now, "Coffee beans harvested", coffeeBlockchain.GetLatestBlock().Hash));
            coffeeBlockchain.AddBlock(new Block(2, DateTime.Now, "Coffee beans processed", coffeeBlockchain.GetLatestBlock().Hash));
            coffeeBlockchain.AddBlock(new Block(3, DateTime.Now, "Coffee packed", coffeeBlockchain.GetLatestBlock().Hash));
            coffeeBlockchain.AddBlock(new Block(4, DateTime.Now, "Coffee shipped to store", coffeeBlockchain.GetLatestBlock().Hash));


            LstDispBC.Items.Add("Blockchain Created: ");

        }

        private void BtnValidateBC_Click(object sender, EventArgs e)
        {
            LstDispBC.Items.Add("Blockchain valid: " + coffeeBlockchain.IsChainValid());
        }

        private void BtnDisplayBC_Click(object sender, EventArgs e)
        {

            LstDispBC.Items.Clear();
            foreach (Block block in coffeeBlockchain.Chain)
            {
                LstDispBC.Items.Add($"Block {block.Index} - Data: {block.Data} - Hash: {block.Hash} - Previous Hash: {block.PreviousHash}");
                              
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmBlockChain_Load(object sender, EventArgs e)
        {

        }
    }
}
