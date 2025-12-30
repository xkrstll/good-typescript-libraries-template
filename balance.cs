using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMuto
{
    // Represents the balance form in the ATMuto application.
    public partial class balance : Form
    {
        // Constructor for the balance form.
        public balance()
        {
            InitializeComponent(); // Initializes form components.
        }

        // Event handler for clicking label6 (likely a "Home" label).
        private void back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME(); // Navigate to the HOME form.
            this.Hide(); // Hide the current form.
            home.Show(); // Show the HOME form.
        }

        // SQL connection to the database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Retrieves the balance from the database and displays it.
        private void getbalance()
        {
            Con.Open(); // Open the SQL connection.

            // SQL query to retrieve the balance for the current account number.
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + AccNumbertbl.Text + "'", Con);

            DataTable dt = new DataTable(); // Create a DataTable to hold the query result.
            sda.Fill(dt); // Fill the DataTable with query results.

            // Display the balance in pesos.
            Balancetbl.Text = dt.Rows[0][0].ToString() + " pesos";
        }

        // Event handler for the form's Load event.
        private void balance_Load(object sender, EventArgs e)
        {
            AccNumbertbl.Text = HOME.AccNumber; // Retrieve the account number from the HOME form.
            getbalance(); // Fetch and display the balance.
        }

        // Event handler for clicking exit (likely an "Exit" label).
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application.
        }
    }
}
