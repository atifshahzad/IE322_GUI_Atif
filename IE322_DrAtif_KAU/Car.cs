using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    class Car
    {
        public int speed = 0;           //field
        public String Color = "Red";    //field

        public void Start()// A method
        {
            MessageBox.Show("Car has been started");
            speed = speed + 5;

        }
        public void Stop()// A method
        {
            speed = 0;
            MessageBox.Show("Car has been stopped");

        }

        public void Accelerate(int increase)// A method with input parameter
        {
            speed = speed + increase;
            MessageBox.Show("Car has been accelerated by " + increase +" to reach at " + speed + " km/h");
        }

        public void Deccelerate(int decrease)// A method with input parameter
        {
            speed = speed - decrease;
            MessageBox.Show("Car has been deccelerated by " + decrease);

        }
    } // end class Car

}
