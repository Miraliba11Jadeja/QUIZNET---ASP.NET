using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMINATIONSYSTEM
{
    public partial class Login_Form : Form
    {
        // Connection string to your database
        private string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\.Net\\PROJECT\\EXAMINATIONSYSTEM\\ExamData.mdf;Integrated Security=True";

        public Login_Form()
        {
            InitializeComponent();
        }

        // Event handler for the label click (if needed)
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the login button click
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get username, password, and role from the form fields
            string username = user_txt.Text;
            string password = Pass_txt.Text;  // Assuming Pass_txt is the correct text box for password
            string role = LoginAs.SelectedItem?.ToString();

            // Ensure all fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                Fields_msg fm  = new Fields_msg();
                fm.Show();
                return;
            }

            // Validate user credentials
            if (ValidateUser(username, password, role))
            {
                // Create the appropriate form based on the role
                Form nextForm = null;
                switch (role)
                {
                    case "Admin":
                        nextForm = new Admin();  // Replace with the actual Admin form
                        break;
                    case "Student":
                        nextForm = new Student();  // Replace with the actual Student form
                        break;
                    case "Teacher":
                        nextForm = new Teacher();  // Replace with the actual Teacher form
                        break;
                    default:
                        MessageBox.Show("Invalid role selected.");
                        return;
                }

                // Create the Msg form and pass the nextForm
                Login_msg m = new Login_msg(nextForm);
                m.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                Invalid_msg m = new Invalid_msg();
                m.Show();
            }
        }

        // Method to validate user credentials against the database
        private bool ValidateUser(string username, string password, string role)
        {
            string query = "";

            // Construct the query based on the role
            switch (role)
            {
                case "Admin":
                    query = "SELECT COUNT(*) FROM ADMIN WHERE Username = @Username AND Password = @Password";
                    break;
                case "Student":
                    query = "SELECT COUNT(*) FROM STUDENT WHERE Username = @Username AND Password = @Password";
                    break;
                case "Teacher":
                    query = "SELECT COUNT(*) FROM TEACHER WHERE Username = @Username AND Password = @Password";
                    break;
                default:
                    MessageBox.Show("Invalid role selected.");
                    return false;
            }

            // Create the SQL connection and command
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int count = (int)cmd.ExecuteScalar();

                    // Close the connection
                    con.Close();

                    // Return true if one record was found, false otherwise
                    return count == 1;
                }
            }
        }
    }
}
