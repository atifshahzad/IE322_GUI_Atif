using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    class Car
    {
        public int speed = 0;
        public String Color = "Red";

        public void Start()
        {
            MessageBox.Show("Car has been started");
            speed = speed + 5;

        }
        public void Stop()
        {
            speed = 0;
            MessageBox.Show("Car has been stopped");

        }

        public void Accelerate(int increase)
        {
            speed = speed + increase;
            MessageBox.Show("Car has been accelerated by " + increase);

        }

        public void Deccelerate(int decrease)
        {
            speed = speed - decrease;
            MessageBox.Show("Car has been deccelerated by " + decrease);

        }
    } // end class Car

}
