using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE322_App_KAU.FSM
{
    class FiniteStateMachine
    {
        public enum States { Start, Standby, On };
        public States State { get; set; }

        public enum Events { PlugIn, TurnOn, TurnOff, RemovePower };

        private Action[,] fsm;

        public FiniteStateMachine()
        {
            this.fsm = new Action[3, 4] { 
                //PlugIn,       TurnOn,                 TurnOff,            RemovePower
                {this.PowerOn,  this.DoNothing,                   this.DoNothing,               this.DoNothing},              //start
                {this.DoNothing,          this.StandbyWhenOff,    this.DoNothing,               this.PowerOff},     //standby
                {this.DoNothing,          this.DoNothing,                   this.StandbyWhenOn, this.PowerOff} };   //on
        }
        public void ProcessEvent(Events theEvent)
        {
            this.fsm[(int)this.State, (int)theEvent].Invoke();
        }

        private void PowerOn() { this.State = States.Standby; }
        private void PowerOff() { this.State = States.Start; }
        private void StandbyWhenOn() { this.State = States.Standby; }
        private void StandbyWhenOff() { this.State = States.On; }

        private void DoNothing() { return; }
    }
}
