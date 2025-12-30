using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMuto
{
    // Represents the splash screen displayed at the application start.
    public partial class Splash : Form
    {
        // Constructor for the Splash form.
        public Splash()
        {
            InitializeComponent(); // Initializes form components.
        }

        // Variable to track the progress of the splash screen.
        int starting = 0;

        // Event handler for the timer tick event.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the progress value by 10 each tick.
            starting += 10;
            Myprogress.Value = starting; // Update progress bar.
            Percentage.Text = "" + starting; // Display the percentage.

            // Check if the progress reaches 100%.
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 100; // Ensure progress bar is at maximum.
                timer1.Stop(); // Stop the timer.

                // Navigate to the login form.
                Login login = new Login();
                this.Hide(); // Hide the splash screen.
                login.Show(); // Show the login form.
            }
        }

        // Event handler for the form's Load event.
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Start the timer when the form loads.
        }
    }
}
