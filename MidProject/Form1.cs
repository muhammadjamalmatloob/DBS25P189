using System.Threading.Tasks;
namespace MidProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        public void OpenAndClose(Form Current, Form New)
        {
            // Show the new form
            New.Show();

            // Close the current form
            Current.Hide(); 

            // Event handler to show the previous form when the new form closes.
            New.FormClosed += (s, args) =>
            {
                Current.Show();
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Admin5 dep = new Admin5();
            OpenAndClose(this, dep);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
