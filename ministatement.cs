using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMuto
{
    // Represents the ministatement form in the ATMuto application.
    public partial class ministatement : Form
    {
        // Constructor for the ministatement form.
        public ministatement()
        {
            InitializeComponent(); // Initializes form components.
        }

        // SQL connection to the database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Stores the account number of the logged-in user.
        string Acc = Login.AccNumber;

        // Populates the DataGridView with transaction history.
        private void Populate()
        {
            try
            {
                Con.Open(); // Open the SQL connection.

                // Query to fetch both outgoing and incoming transactions for the account.
                string query = "SELECT AccNum AS [Account Number], Type AS [Transaction Type], Amount AS [Amount], TDate AS [Date], RecipientAccNum AS [Recipient Account] " +
                               "FROM TransactionTbl " +
                               "WHERE AccNum = @AccNum OR RecipientAccNum = @AccNum " +
                               "ORDER BY TDate DESC";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc); // Parameterized query to prevent SQL injection.

                // Fetch the data into a DataSet.
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                // Bind the data to the DataGridView.
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MinistatementTb.DataSource = ds.Tables[0];
                }
                else
                {
                    // Notify the user if no transactions are found.
                    MessageBox.Show("No transactions found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle and display any errors.
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close(); // Ensure the SQL connection is closed.
            }
        }

        // Event handler for the form's Load event.
        private void ministatement_Load(object sender, EventArgs e)
        {
            Populate(); // Populate the transaction history on form load.
        }

        // Event handler for the "Log Out" button click.
        private void logOut_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application.
        }

        // Event handler for the "Back" button click.
        private void back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME(); // Navigate to the HOME form.
            home.Show();
            this.Hide(); // Hide the current form.
        }
    }
}

