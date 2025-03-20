using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MidProject
{
    public partial class AdminProfile : Form
    {
        public string loggedInusername;
        public AdminProfile(string username)
        {
            loggedInusername = username;
            InitializeComponent();
            LoadProfileData();
        }
        private void LoadProfileData()
        {
            try
            {
                // Query to fetch user details based on the logged-in username
                string query = $"SELECT u.username, u.email, l.value AS role FROM users u JOIN lookup l ON u.role_id = l.lookup_id WHERE u.username = '{loggedInusername}' ";

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

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin1(loggedInusername).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin2().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin3().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin4().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin5().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin6().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin7().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin8().Show();
        }
    }
}
