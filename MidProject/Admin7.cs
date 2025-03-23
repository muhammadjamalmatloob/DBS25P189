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
    public partial class Admin7 : Form
    {
        public Admin7()
        {
            InitializeComponent();
            Admin7DL.LoadData();
            dataGridView1.DataSource = Admin7DL.frequests;
            AddButton();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    DataGridViewButtonColumn clickedButtonColumn = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                    if (clickedButtonColumn.HeaderText == "Fullfill Request")
                    {
                        Admin7DL.UpdateStatus(e.RowIndex);
                        MessageBox.Show("Request Fulfilled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                Reload();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddButton()
        {
            DataGridViewButtonColumn FulfillButtonColumn = new DataGridViewButtonColumn();
            FulfillButtonColumn.HeaderText = "Fullfill Request";
            FulfillButtonColumn.Text = "Fulfill";
            FulfillButtonColumn.UseColumnTextForButtonValue = true;
            FulfillButtonColumn.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dataGridView1.Columns.Add(FulfillButtonColumn);
        }
        private void Reload()
        {
            dataGridView1.DataSource = null;
            Admin7DL.LoadData();
            dataGridView1.DataSource = Admin7DL.frequests;
        }
    }
}
