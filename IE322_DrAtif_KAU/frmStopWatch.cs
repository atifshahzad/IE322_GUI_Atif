using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace IE322_App_KAU
{
    public partial class frmStopWatch : Form
    {
        // Create a new Stopwatch instance
        Stopwatch stopwatch = new Stopwatch();

        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // Start measuring time
            stopwatch.Start();

            // Code block whose execution time you want to measure
            for (int i = 0; i < 1000000; i++)
            {
                // Perform some operation
                int result = i * 2;
            }

            // Stop measuring time
            stopwatch.Stop();

            // Get the elapsed time
            TimeSpan elapsed = stopwatch.Elapsed;
            /*
                        // Print the elapsed time in various formats
                        Console.WriteLine($"Execution Time: {elapsed.TotalMilliseconds} ms");
                        Console.WriteLine($"Execution Time: {elapsed.Ticks} ticks");
                        Console.WriteLine($"Execution Time: {elapsed.Seconds} seconds and {elapsed.Milliseconds} milliseconds");
                       */

            // You can also use Stopwatch.StartNew() for a more concise way to start
            Stopwatch conciseStopwatch = Stopwatch.StartNew();

            // Another code block to measure
            System.Threading.Thread.Sleep(50); // Simulate some work

            conciseStopwatch.Stop();
            //Console.WriteLine($"Concise Execution Time: {conciseStopwatch.ElapsedMilliseconds} ms");


        }
    }
}
