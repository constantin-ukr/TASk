using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        internal static DataT3Service.T3InterfaceClient client;
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
                client = new DataT3Service.T3InterfaceClient();
                client.IsRun();
                Application.Run(new frmMain()); 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Сервер додатку незапущений. Зверніться до адміністратора сервера, або перевірте налаштування.");
                Application.ExitThread();
            }                       
        }
    }
}
