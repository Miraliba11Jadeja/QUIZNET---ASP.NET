using System;
using System.Windows.Forms;

namespace EXAMINATIONSYSTEM
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            guna2Panel3.Width += 20;

            
            if (guna2Panel3.Width >= 588) 
            {
                
                timer1.Stop();

                
                Login_Form frm = new Login_Form();
                frm.Show();
                this.Hide();
            }
        }
    }
}
