using ATMuto.classes;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMuto
{
    // Represents the login screen for the application.
    public partial class Login : Form
    {
        // Constructor for the Login form.
        public Login()
        {
            InitializeComponent(); // Initializes form components.
        }

        // Event handler for the exit button click.
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application.
        }

        // Event handler for the sign-up button click.
        private void signUp_Click(object sender, EventArgs e)
        {
            account acc = new account(); // Create a new account form instance.
            acc.Show(); // Show the account creation form.
            this.Hide(); // Hide the current form.
        }

        // Static variable to hold the logged-in account number.
        public static string AccNumber;

        // SQL connection to interact with the database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Event handler for the login button click.
        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open(); // Open the database connection.

                // SQL query to check if the account number and PIN match an entry in the database.
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='" + AccNumTb.Text + "' and PIN = " + PinTb.Text + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt); // Fill the data table with the query result.

                // Check if a matching account exists.
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccNumber = AccNumTb.Text; // Set the logged-in account number.
                    HOME home = new HOME(); // Create a new HOME form instance.
                    home.Show(); // Show the HOME form.
                    this.Hide(); // Hide the login form.
                }
                else
                {
                    // Display an error message if login fails.
                    MessageBox.Show("Wrong Account Number Or Pin Code");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the login process.
                MessageBox.Show($"Error during login: {ex.Message}");
            }
            finally
            {
                Con.Close(); // Ensure the database connection is closed.
            }
        }
    }
}