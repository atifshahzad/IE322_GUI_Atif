using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IE322_App_KAU.FSM;

namespace IE322_App_KAU
{
    public partial class frmFSM : Form
    {
        public frmFSM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            MessageBox.Show("Current State = " + p.CurrentState);
            MessageBox.Show("Command.Begin: Current State = " + p.MoveNext(Command.Begin));
            MessageBox.Show("Command.Pause: Current State = " + p.MoveNext(Command.Pause));
            MessageBox.Show("Command.End: Current State = " + p.MoveNext(Command.End));
            MessageBox.Show("Command.Exit: Current State = " + p.MoveNext(Command.Exit));
            
        }

        private void BtnPlugIn_Click(object sender, EventArgs e)
        {
            var fsm = new FiniteStateMachine();
           // Console.WriteLine(fsm.State);
            fsm.ProcessEvent(FiniteStateMachine.Events.PlugIn);
           //MessageBox.Show(fsm.State);
            fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
           // MessageBox.Show(fsm.State);
            fsm.ProcessEvent(FiniteStateMachine.Events.TurnOff);
           // MessageBox.Show(fsm.State);
            fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
            //MessageBox.Show(fsm.State);
            fsm.ProcessEvent(FiniteStateMachine.Events.RemovePower);
           // Console.WriteLine(fsm.State);
            //Console.ReadKey();
        }
    }
}
