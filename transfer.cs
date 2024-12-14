using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMuto
{
    // Represents the transfer form in the ATMuto application.
    public partial class transfer : Form
    {
        // Constructor for the transfer form.
        public transfer()
        {
            InitializeComponent(); // Initializes form components.
        }

        // SQL connection to the database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Stores the account number of the logged-in user.
        string Acc = Login.AccNumber;

        // Logs a transaction into the TransactionTbl.
        private void addtransaction(string accNumber, string type, decimal amount, string recipientAcc = null)
        {
            try
            {
                // SQL query to insert a transaction record.
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate, RecipientAccNum) VALUES (@AccNum, @Type, @Amount, @TDate, @RecipientAccNum)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@AccNum", accNumber);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@RecipientAccNum", recipientAcc ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging transaction: {ex.Message}");
            }
        }

        // Current balance of the logged-in user.
        int bal;

        // New balance after a transaction.
        int newbalance;

        // Handles the "Transfer" button click event.
        private void trans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amount.Text) || string.IsNullOrWhiteSpace(accountNumberTo.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            if (Convert.ToDecimal(amount.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
                return;
            }

            if (Convert.ToDecimal(amount.Text) > bal)
            {
                MessageBox.Show("Insufficient Balance");
                return;
            }

            if (!IsRecipientAccountValid(accountNumberTo.Text))
            {
                MessageBox.Show("Recipient account does not exist");
                return;
            }

            newbalance = bal - Convert.ToInt32(amount.Text);
            decimal transferAmount = Convert.ToDecimal(amount.Text);

            try
            {
                Con.Open();

                // Update sender's balance.
                string query = "UPDATE AccountTbl SET Balance = @newbalance WHERE Accnum = @senderAcc";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@newbalance", newbalance);
                    cmd.Parameters.AddWithValue("@senderAcc", Acc);
                    cmd.ExecuteNonQuery();
                }

                // Update recipient's balance.
                string query2 = "UPDATE AccountTbl SET Balance = Balance + @transferAmount WHERE Accnum = @recipientAcc";
                using (SqlCommand cmd2 = new SqlCommand(query2, Con))
                {
                    cmd2.Parameters.AddWithValue("@transferAmount", transferAmount);
                    cmd2.Parameters.AddWithValue("@recipientAcc", accountNumberTo.Text);
                    cmd2.ExecuteNonQuery();
                }

                // Log the transactions.
                addtransaction(Acc, "Transfer", -transferAmount, accountNumberTo.Text); // Log for the sender.
                addtransaction(accountNumberTo.Text, "Transfer", transferAmount, Acc); // Log for the recipient.

                MessageBox.Show("Transfer Successful");
                HOME home = new HOME();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during transfer: {ex.Message}");
            }
            finally
            {
                Con.Close();
            }
        }

        // Retrieves the current balance of the logged-in user.
        private void getbalance()
        {
            Con.Open();
            string query = "SELECT Balance FROM AccountTbl WHERE AccNum = @AccNum";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                balancetbl.Text = dt.Rows[0][0].ToString() + " pesos balance ";
                bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            Con.Close();
        }

        // Validates if the recipient account exists in the database.
        private bool IsRecipientAccountValid(string recipientAcc)
        {
            try
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM AccountTbl WHERE AccNum = @RecipientAcc";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@RecipientAcc", recipientAcc);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating recipient account: {ex.Message}");
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

        // Event handler for the form's Load event.
        private void transfer_Load(object sender, EventArgs e)
        {
            getbalance(); // Fetch and display the current balance on form load.
        }

        // Event handler for the "Back" button click event.
        private void back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME(); // Navigate to the HOME form.
            home.Show();
            this.Hide(); // Hide the current form.
        }
    }
}
