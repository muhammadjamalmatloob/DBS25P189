using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProject
{
    public partial class Admin8 : Form
    {
        public Admin8()
        {
            InitializeComponent();
            Admin8DL.LoadData();
            Admin8DL.LoadData();
            dataGridView1.DataSource = Admin8DL.faculty_schedule;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string room_type = comboBox1.SelectedItem?.ToString();
            string room_name = textBox1.Text;
            string facultyMember = textBox3.Text;
            string start = comboBox3.SelectedItem?.ToString();
            string end = comboBox4.SelectedItem?.ToString();
            string day = comboBox2.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(room_type) || string.IsNullOrEmpty(room_name) ||
                string.IsNullOrEmpty(facultyMember) || string.IsNullOrEmpty(start) ||
                string.IsNullOrEmpty(day) || string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                int r = Admin8DL.AddFacultySchedule(new Admin8BL(facultyMember, room_name, room_type,day,start,end));

                if (r > 0)
                {
                    MessageBox.Show("Schedule assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to assign schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            textBox3.Clear();
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            string room_type = comboBox1.SelectedItem?.ToString();
            string room_name = textBox1.Text;
            string facultyMember = textBox3.Text;
            string start = comboBox3.SelectedItem?.ToString();
            string end = comboBox4.SelectedItem?.ToString();
            string day = comboBox2.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(room_type) || string.IsNullOrEmpty(room_name) ||
                string.IsNullOrEmpty(facultyMember) || string.IsNullOrEmpty(start) ||
                string.IsNullOrEmpty(day) || string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                int r = Admin8DL.DeleteFacultySchedule(new Admin8BL(facultyMember, room_name, room_type, day, start, end));

                if (r > 0)
                {
                    MessageBox.Show("Schedule unassigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to unassign schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Admin8DL.LoadData();
            dataGridView1.DataSource = Admin8DL.faculty_schedule;
        }
    }
}
