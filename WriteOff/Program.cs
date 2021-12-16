using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteOff
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProjectSingelton.db = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings[ProjectSingelton.ConnectionString].ConnectionString);
            Application.Run(new FormEmployeer());
        }
    }
}
