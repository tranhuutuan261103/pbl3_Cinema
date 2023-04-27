using pbl3_Cinema.View;
using pbl3_Cinema.View.AdminView.ManageProduct;
using pbl3_Cinema.View.AdminView.ManageStaff;
using pbl3_Cinema.View.CustomerView.BuyProduct;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        
    }
}
