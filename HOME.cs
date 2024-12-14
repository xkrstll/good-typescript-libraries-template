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
    // Represents the home screen with options for different banking operations.
    public partial class HOME : Form
    {
        // Constructor for the HOME form.
        public HOME()
        {
            InitializeComponent(); // Initializes form components.
        }

        // Event handler for the transfer button click.
        private void transfer_Click(object sender, EventArgs e)
        {
            transfer withdraw = new transfer(); // Create a new transfer form instance.
            this.Hide(); // Hide the current form.
            withdraw.Show(); // Show the transfer form.
        }

        // Event handler for the mini statement button click.
        private void miniState_Click(object sender, EventArgs e)
        {
            ministatement mini = new ministatement(); // Create a new ministatement form instance.
            this.Hide(); // Hide the current form.
            mini.Show(); // Show the ministatement form.
        }

        // Event handler for the balance button click.
        private void balance_Click(object sender, EventArgs e)
        {
            balance bal = new balance(); // Create a new balance form instance.
            this.Hide(); // Hide the current form.
            bal.Show(); // Show the balance form.
        }

        // Event handler for the change PIN button click.
        private void changepin_Click(object sender, EventArgs e)
        {
            changepin changepin = new changepin(); // Create a new changepin form instance.
            this.Hide(); // Hide the current form.
            changepin.Show(); // Show the change PIN form.
        }

        // Event handler for the exit button click.
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application.
        }

        // Event handler for the back to login button click.
        private void backToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(); // Create a new login form instance.
            login.Show(); // Show the login form.
            this.Hide(); // Hide the current form.
        }

        // Static variable to hold the account number.
        public static String AccNumber;

        // Event handler for the form's Load event.
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumtbl.Text = "Account Number: " + Login.AccNumber; // Display the account number.
            AccNumber = Login.AccNumber; // Assign the account number to the static variable.
        }
    }
}
