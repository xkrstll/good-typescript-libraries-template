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
using ATMuto.classes;
using Google.Cloud.Firestore;
using System.Net.NetworkInformation;

namespace ATMuto
{
    // Main namespace containing the ATMuto application.
    public partial class account : Form
    {
        // Constructor for the account form.
        public account()
        {
            InitializeComponent(); // Initializes form components.
        }

        // SQL connection to the database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krist\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        // Event handler for the 'ok' button click.
        private void ok_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database; // Reference to Firestore database.

            // Check if the user already exists.
            if (CheckIfUserAlreadyExit())
            {
                MessageBox.Show("User Already Exist");
                return;
            }

            var data = GetWriteData(); // Retrieve data to write to Firestore.
            DocumentReference docRef = db.Collection("UserData").Document(data.AccName);
            docRef.SetAsync(data); // Asynchronously write data to Firestore.
            MessageBox.Show("Success");

            int bal = 0; // Initial account balance.

            // Validate user input fields.
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || LastnameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || occupationTb.Text == "" || pinTb.Text == "")
            {
                MessageBox.Show("Missing Information"); // Notify user of missing information.
            }
            else
            {
                try
                {
                    Con.Open(); // Open the SQL connection.

                    // SQL query to insert user data into accountTbl.
                    string query = "insert into accountTbl values('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + dobDate.Value.Date + "','" + LastnameTb.Text + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + educationTb.SelectedItem.ToString() + "','" + occupationTb.Text + "','" + pinTb.Text + "','" + bal + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery(); // Execute the query.

                    MessageBox.Show("Account Created Successfully"); // Notify user of success.

                    Con.Close(); // Close the SQL connection.

                    // Navigate to the login form.
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message); // Display exception message.
                }
            }
        }

        // Method to retrieve and prepare user data for writing.
        private UserData GetWriteData()
        {
            string AccName = AccNameTb.Text.Trim(); // Account name.
            string Lastname = LastnameTb.Text.Trim(); // Last name.
            string AccNum = AccNumTb.Text.Trim(); // Account number.
            string Address = AddressTb.Text.Trim(); // Address.
            int zip = Convert.ToInt32(zipCode.Text); // Zip code.
            string pin = Security.Encrypt(pinTb.Text); // Encrypted PIN.
            string education = educationTb.Text.Trim(); // Education level.
            string occupation = occupationTb.Text.Trim(); // Occupation.
            string Phone = PhoneTb.Text.Trim(); // Phone number.
            string dob = dobDate.Text.Trim(); // Date of birth.

            // Return a new UserData object populated with input values.
            return new UserData()
            {
                AccName = AccName,
                Lastname = Lastname,
                AccNum = AccNum,
                Address = Address,
                zip = zip,
                pin = pin,
                education = education,
                occupation = occupation,
                Phone = Phone,
                dob = dob,
            };
        }

        // Method to check if a user already exists in the database.
        private bool CheckIfUserAlreadyExit()
        {
            string AccNum = AccNumTb.Text.Trim(); // Account number.
            string pin = pinTb.Text; // PIN.

            var db = FirestoreHelper.Database; // Reference to Firestore database.
            DocumentReference docRef = db.Collection("UserData").Document(AccNum);

            // Retrieve user data from Firestore.
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            MessageBox.Show("Success");

            // Return true if data exists, false otherwise.
            if (data != null)
            {
                return true;
            }
            return false;
        }

        // Event handler for the 'back' button click.
        private void back_click(object sender, EventArgs e)
        {
            Login login = new Login(); // Navigate to the login form.
            login.Show();
            this.Hide();
        }

        // Event handler for the 'exit' button click.
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application.
        }
    }
}
