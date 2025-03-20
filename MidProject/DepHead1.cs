using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MidProject
{
    public partial class DepHead1 : Form
    {
        public DepHead1()
        {
            InitializeComponent();
            // Attach event handlers
            this.button10.Click += new EventHandler(button10_Click);
            this.Load += new EventHandler(DepHead1_Load);
        }

        // Event handler for the "Assign" button click
        private void button10_Click(object sender, EventArgs e)
        {
            string courseName = textBox3.Text;
            string courseType = textBox2.Text;
            string facultyMember = textBox1.Text;
            string semester = comboBox3.SelectedItem?.ToString();
            string year = comboBox4.SelectedItem?.ToString();

            // Validate input fields
            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseType) ||
                string.IsNullOrEmpty(facultyMember) || string.IsNullOrEmpty(semester) ||
                string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Insert data into the database
                string query = $"INSERT INTO faculty_courses (faculty_id, course_id, semester_id) " +
                               $"VALUES ((SELECT faculty_id FROM faculty WHERE name = {facultyMember}), " +
                               $"(SELECT course_id FROM courses WHERE course_name = {courseName}), " +
                               $"(SELECT semester_id FROM semesters WHERE term = @semester AND year = {Convert.ToInt32(year)}))";

                int rowsAffected = DatabaseHelper.Instance.Update(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to assign course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear the form fields
        private void ClearForm()
        {
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        // Event handler for form load
        private void DepHead1_Load(object sender, EventArgs e)
        {
            LoadSemesters();
            LoadYears();
        }

        // Method to load semesters into the combo box
        private void LoadSemesters()
        {
            try
            {
                string query = "SELECT DISTINCT term FROM semesters";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["term"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading semesters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load years into the combo box
        private void LoadYears()
        {
            try
            {
                string query = "SELECT DISTINCT year FROM semesters";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader["year"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading years: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}