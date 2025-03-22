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
    public partial class Admin10 : Form
    {
        public Admin10()
        {
            InitializeComponent();
            Admin10DL.LoadData();
            dataGridView2.DataSource = Admin10DL.semesters;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string term = comboBox2.SelectedItem?.ToString();
            string year = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(term) || string.IsNullOrEmpty(year))

            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int row = Admin10DL.AddSemester(new Admin10BL(term, Convert.ToInt32(year)));
                if (row > 0)
                {
                    MessageBox.Show("Semester added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add smester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int r = Admin10DL.Update(colname, newvalue, row);
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
        public void ClearForm()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }
        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            Admin10DL.LoadData();
            dataGridView2.DataSource = Admin10DL.semesters;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
