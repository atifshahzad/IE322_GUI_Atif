using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {

        }

        private void BtnClickEvents_Click(object sender, EventArgs e)
        {
            BtnClickEvents.Text = "MouseClick Event occurred";
        }

        private void BtnClickEvents_MouseEnter(object sender, EventArgs e)
        {
            BtnClickEvents.Text = "MouseEnter Event occurred";
            BtnClickEvents.BackColor = Color.GreenYellow;

        }

        private void BtnClickEvents_MouseHover(object sender, EventArgs e)
        {
            BtnClickEvents.Text = "MouseHover Event occurred";
            BtnClickEvents.BackColor = Color.Beige;
        }

        private void BtnClickEvents_MouseDown(object sender, MouseEventArgs e)
        {
            BtnClickEvents.Text = "MouseDown Event occurred";
        }

        private void BtnClickEvents_MouseUp(object sender, MouseEventArgs e)
        {
            BtnClickEvents.Text = "MouseUp Event occurred";
        }

        private void ChkDrag_CheckedChanged(object sender, EventArgs e)
        {
            ControlExtension.Draggable(BtnDrag, ChkDrag.Checked);
            ControlExtension.Draggable(ChkDrag, ChkDrag.Checked);
            ControlExtension.Draggable(LblDrag, ChkDrag.Checked);

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            BtnDrag.Left = 18;
            BtnDrag.Top = 29;

            ChkDrag.Left = 153;
            ChkDrag.Top = 33;

            LblDrag.Left = 6;
            LblDrag.Top = 213;

            BtnClickEvents.Text = "Click Me";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
