using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ExamenSegundoParcial
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // get the singleton instance
            Singleton instance = Singleton.Instance;
            instance = Singleton.GetInstance();
            instance.createDB();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
            
            dynamic DB;
        }
    }
}
