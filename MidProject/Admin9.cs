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
    public partial class Admin9 : Form
    {
        public Admin9()
        {
            InitializeComponent();
            Admin9DL.LoadData();
            dataGridView2.DataSource = Admin9DL.rooms;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string capacity = textBox2.Text;
            string type = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(capacity) || string.IsNullOrEmpty(type))

            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int row = Admin9DL.AddRoom(new Admin9BL(name,type,Convert.ToInt32(capacity)));
                if (row > 0)
                {
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int r = Admin9DL.Update(colname, newvalue, row);
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
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            Admin9DL.LoadData();
            dataGridView2.DataSource = Admin9DL.rooms;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
