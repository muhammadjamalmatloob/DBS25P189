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
    public partial class Admin1 : Form
    {
        string user;
        public Admin1(string username)
        {
            InitializeComponent();
            Admin1DL.LoadData(username);
            this.dataGridView1.DataSource = Admin1DL.faculties;
            user = username;
        }
        private void DataGridView2_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string newvalue = dataGridView1.Rows[row].Cells[col].Value.ToString();
            string colname = dataGridView1.Columns[col].HeaderText;
            if (string.IsNullOrEmpty(newvalue))
            {
                MessageBox.Show("Not able to assign null value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Rows[row].Cells[col].Value = "Error";
                return;
            }
            if (colname != "total_teaching_hours")
            {
                try
                {
                    int r = Admin1DL.Update(colname, newvalue, row);
                    if (r > 0)
                    {
                        MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
            else
            {
                MessageBox.Show("You can't update it because teaching hours will be decided on the basis of assigned courses", "Error" + row, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
                Admin1DL.LoadData(user);
                dataGridView1.DataSource = Admin1DL.faculties;
            }
        }

    }
}
