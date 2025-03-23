using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MidProject
{
    
    public partial class Faculty2 : Form
    {
        public static string loggedInusername;
        public Faculty2(string username)
        {
            InitializeComponent();
            loggedInusername = username;
            dataGridView1.DataSource = Faculty2DL.assigned_projects;
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
