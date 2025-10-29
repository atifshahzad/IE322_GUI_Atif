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
using System.CodeDom.Compiler;


namespace IE322_App_KAU
{
    public partial class frmStopWatch : Form
    {
        // Create a new Stopwatch instance
        Stopwatch Mystopwatch = new Stopwatch();

        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Start measuring time
            Mystopwatch.Start();

                    // Code block whose execution time you want to measure
                    for (int i = 0; i < 100000000; i++)
                    {
                        // Perform some operation
                        int result = i * 2;
                    }

            // Stop measuring time
            Mystopwatch.Stop();
            

            // Get the elapsed time
            TimeSpan elapsed = Mystopwatch.Elapsed;
            
           // Print the elapsed time in various formats                       
            

            LblDisplay.Text = String.Format(
                $"Execution Time for 10 million iterations:\n" +
               elapsed.TotalMilliseconds + " ms\n" +
               elapsed.Ticks + " ticks\n" +
               elapsed.Seconds + " and " + elapsed.Milliseconds + " milliseconds\n" +
            $"");
            Mystopwatch.Reset();


            // You can also use Stopwatch.StartNew() for a more concise way to start
            Stopwatch conciseStopwatch = Stopwatch.StartNew();

            // Another code block to measure
            System.Threading.Thread.Sleep(50); // Simulate some work

            conciseStopwatch.Stop();

            LblDisplay.Text = String.Format(
                $"{LblDisplay.Text} \n" +
                $"Concise Execution Time:{conciseStopwatch.ElapsedMilliseconds} ms\n"
                );

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
