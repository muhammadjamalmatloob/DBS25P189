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
    public partial class Faculty1 : Form
    {
        public static string loggedInusername; 
        public Faculty1(string username)
        {
            InitializeComponent();
            loggedInusername = username;
            dataGridView1.DataSource = Faculty1DL.assigned_courses;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                Faculty1DL.LoadData(loggedInusername);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

    }
}
