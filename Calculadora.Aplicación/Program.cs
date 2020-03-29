using System;
using System.Windows.Forms;

namespace Calculadora.Aplicación
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pantalla());
        }
    }
}
