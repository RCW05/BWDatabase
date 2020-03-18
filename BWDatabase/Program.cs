using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWDatabase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmDatabase());
            }
            catch(Exception ex)
            {
                var ErrorResult = ($"A Fatal error has occured.\nPlease contact your administrator.\n{ ex.GetType().Name}");
                var Caption = "An error has occured.";
                MessageBox.Show(ErrorResult, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
