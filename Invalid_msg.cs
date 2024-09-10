namespace EXAMINATIONSYSTEM
{
    public partial class Invalid_msg : Form
    {
        // Constructor
        public Invalid_msg()
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
    }
}
