using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMuto
{
    public partial class changepin : Form
    {
        // Constructor for the changepin form
        public changepin()
        {
            InitializeComponent();
        }

        // Establish a connection to the SQL database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Store the account number of the logged-in user
        string Acc = Login.AccNumber;

        // Event handler for the 'Change' button click
        private void change_Click(object sender, EventArgs e)
        {
            // Check if either of the PIN fields are empty
            if (Pin1.Text == "" || Pin2.Text == "")
            {
                MessageBox.Show("Enter and Confirm the New Pin");
            }
            // Check if the entered PINs do not match
            else if (Pin1.Text != Pin2.Text)
            {
                MessageBox.Show("The entered PINs do not match. Please try again.");
            }
            else
            {
                // Try to update the PIN in the database
                try
                {
                    Con.Open(); // Open the database connection

                    // Update query to change the PIN for the logged-in account
                    string query = "update AccountTbl set PIN=" + Pin1.Text + " where Accnum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Notify the user that the PIN was changed successfully
                    MessageBox.Show("PIN changed successfully!");

                    Con.Close(); // Close the database connection

                    // Navigate to the login form
                    Login home = new Login();
                    home.Show();
                    this.Hide(); // Hide the current form
                }
                catch (Exception ex)
                {
                    // Display any errors that occur during the process
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Event handler for the 'Back' button click
        private void back_Click(object sender, EventArgs e)
        {
            // Navigate back to the HOME form
            HOME home = new HOME();
            home.Show();
            this.Hide(); // Hide the current form
        }

        // Event handler for the 'Exit' button click
        private void exit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}