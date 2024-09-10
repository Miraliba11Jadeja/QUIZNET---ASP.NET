using System;
using System.Windows.Forms;

namespace EXAMINATIONSYSTEM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the HomePageForm
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePageForm());
        }
    }
}
