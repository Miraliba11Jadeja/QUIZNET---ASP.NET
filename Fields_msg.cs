namespace EXAMINATIONSYSTEM
{
    public partial class Fields_msg : Form
    {
        // Constructor
        public Fields_msg()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Show the login form again
            Login_Form l = new Login_Form();
            l.Show();

            // Close the current Invalid_msg form
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
