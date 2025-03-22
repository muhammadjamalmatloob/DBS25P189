using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cms;

namespace MidProject
{
    public partial class Admin5 : Form
    {
        public Admin5()
        {
            InitializeComponent();
            Admin5DL.LoadData();
            dataGridView2.DataSource = Admin5DL.courses;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string course_name = textBox3.Text;
            string course_type = comboBox1.SelectedItem?.ToString();
            string credit_hours = textBox2.Text;
            int contact_hours = course_type == "Lab" ? Convert.ToInt32(credit_hours) * 3 : Convert.ToInt32(credit_hours);

            if (string.IsNullOrEmpty(course_name) || string.IsNullOrEmpty(course_type)
                || string.IsNullOrEmpty(credit_hours))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int row = Admin5DL.AddCourse(new Admin5BL(course_name,course_type,Convert.ToInt32(credit_hours),contact_hours));
                if (row > 0)
                {
                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearForm()
        {
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }
        private void DataGridView2_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string newvalue = dataGridView2.Rows[row].Cells[col].Value.ToString();
            string colname = dataGridView2.Columns[col].HeaderText;
            if (string.IsNullOrEmpty(newvalue))
            {
                MessageBox.Show("Not able to assign null value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView2.Rows[row].Cells[col].Value = "Error";
                return;
            }
            try
            {
                int r = Admin5DL.Update(colname, newvalue, row);
                if (r > 0)
                {
                    MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Not Able to Update.", "Error" + row, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            Admin5DL.LoadData();
            dataGridView2.DataSource = Admin5DL.courses;
        }
    }
}
