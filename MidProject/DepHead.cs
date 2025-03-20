using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MidProject
{
    public partial class DepHead : Form
    {
        // Store the logged-in username
        private string loggedInUsername;

        public DepHead(string username)
        {
            InitializeComponent();
            loggedInUsername = username; // Store the username passed from the login form
            LoadProfileData(); // Load profile data when the form is initialized
        }

        // Method to load profile data from the database
        private void LoadProfileData()
        {
            try
            {
                // Query to fetch user details based on the logged-in username
                string query = $"SELECT u.username, u.email, l.value AS role FROM users u JOIN lookup l ON u.role_id = l.lookup_id WHERE u.username = '{loggedInUsername}' ";

                MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
                            if (reader.Read()) // If user data is found
                            {
                                // Display the user's details in the form
                                label6.Text = "Email: " + reader["email"].ToString(); // Email
                                label7.Text = "Username: " + reader["username"].ToString(); // Username
                                label3.Text = "Role: " + reader["role"].ToString(); // Role
                            }
                            else
                            {
                                MessageBox.Show("User data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Logout button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            new Login().Show(); // Open the login form
        }

        // Event handler for the Close button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        // Event handler for the Assign Courses button
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead1().Show();
        }

        // Event handler for the Assign Final Year Project Supervision button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead2().Show();
        }

        // Event handler for the Assign Classrooms and Labs button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead3().Show();
        }

        // Event handler for the Faculty Requests button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead4().Show();
        }

        // Event handler for the Track Admin Roles button
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead5().Show();
        }

        // Event handler for the Profile button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepHead(loggedInUsername).Show();
        }
    }
}