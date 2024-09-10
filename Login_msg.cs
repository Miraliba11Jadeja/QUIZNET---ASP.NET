using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMINATIONSYSTEM
{
    public partial class Login_msg : Form
    {
        private Form nextForm;

        // Constructor to accept and store the next form
        public Login_msg(Form nextForm)
        {
            InitializeComponent();
            this.nextForm = nextForm;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the next form
            this.Hide();
            nextForm.Show();
        }
    }
}
