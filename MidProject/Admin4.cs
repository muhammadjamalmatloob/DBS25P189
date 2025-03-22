using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace MidProject
{
    public partial class Admin4 : Form
    {
        public Admin4()
        {
            InitializeComponent();
            Admin4DL.LoadData();
            this.dataGridView2.DataSource = Admin4DL.items;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string item = textBox3.Text;
            if (item == null || item == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int row = Admin4DL.AddItem(item);
                if (row > 0)
                {
                    MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearForm()
        {
            textBox3.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Admin4DL.LoadData();
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = Admin4DL.items;
            dataGridView2.Refresh();

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
                int r = Admin4DL.Update(colname, newvalue, row);
                if (r > 0)
                {
                    MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Not Able to Update.", "Error" + row , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin4_Load(object sender, EventArgs e)
        {

        }
    }

}