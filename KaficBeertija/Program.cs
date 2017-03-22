using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaficBeertija.Logic;

namespace KaficBeertija
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProvjeraBaze provjeraBaze = new ProvjeraBaze();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            provjeraBaze.Provjera();
            if (StaticVarijable.bazaPrazna)
            {
                Application.Run(new frmRegistration());
            }
            else
                Application.Run(new frmLogin());

            //Application.Run(new frmMain());

        }

    }
 }

