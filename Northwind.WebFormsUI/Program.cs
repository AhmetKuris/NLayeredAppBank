using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new BankUI_LoginScreen());
                    
            }
            catch (Exception ex)
            {
                //Write ex.Message to a file
                using (StreamWriter outfile = new StreamWriter(@".\error.txt"))
                {
                    outfile.Write(ex.Message.ToString());
                }
            }


           
        }
    }
}
