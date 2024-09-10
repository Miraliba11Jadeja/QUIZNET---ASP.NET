using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EXAMINATIONSYSTEM
{
    public partial class Adding : Form
    {
        private string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\.Net\\PROJECT\\EXAMINATIONSYSTEM\\ExamData.mdf;Integrated Security=True";

        public Adding()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [dbo].[TEACHER] (Name, Username, Password) VALUES (@Name, @Username, @Password)";

            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adding parameters with values from text boxes
                        cmd.Parameters.AddWithValue("@Name", name.Text);
                        cmd.Parameters.AddWithValue("@Username", user.Text);
                        cmd.Parameters.AddWithValue("@Password", pass.Text);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optional: Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the error message
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
