using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); // Get username from the textbox
            string password = textBox2.Text.Trim(); // Get password from the textbox

            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query to check if the user exists in the database
            string query = $"SELECT username,password_hash,value as Role FROM users join lookup ON role_id = lookup_id WHERE username = '{username}' AND password_hash = '{HashPassword(password)}'";

            try
            {
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    if (reader.HasRows) // If user exists
                    {
                        reader.Read();
                        string role = reader["Role"].ToString(); // Get user role

                        // Open the appropriate form based on the user's role
                        switch (role)
                        {
                            case "Department Head":
                                MessageBox.Show("Login successful! Opening Department Head Dashboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                // Open Department Head Form
                                new DepHead().Show();

                                break;
                            case "Faculty":
                                MessageBox.Show("Login successful! Opening Faculty Member Dashboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                // Open Faculty Member Form
                                new FacultyProfile().Show();
                                break;
                            case "Admin":
                                MessageBox.Show("Login successful! Opening Administrative Staff Dashboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                // Open Administrative Staff Form
                                new AdminProfile().Show();
                                break;
                            default:
                                MessageBox.Show("Invalid role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = HashPassword(password);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Close button
        private void Closebtn_Click1(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        // Event handler for the Forgot Password button
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Helper method to hash the password (for security)
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
    

