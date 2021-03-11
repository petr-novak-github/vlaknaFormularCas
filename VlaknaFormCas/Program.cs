using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VlaknaFormCas.implementace;


namespace VlaknaFormCas
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
            
            Hodiny hodiny1 = new Hodiny();
            Thread vlakno = new Thread(hodiny1.Smycka);
            vlakno.Start();
            frmOvladaciPanel f1 = new frmOvladaciPanel(hodiny1);
            Application.Run(f1);
            vlakno.Abort();
                      

        }
    }
}
