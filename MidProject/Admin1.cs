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
        public Admin1(string username)
        {
            InitializeComponent();
            Admin1DL.LoadData(username);
            this.dataGridView1.DataSource = Admin1DL.faculties;
        }


    }
}
