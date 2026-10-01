using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gatoTemporario
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Dashboard());
            Application.Run(new Cadastro());
            
            
            Application.Run(new Calcados());
            Application.Run(new ParEncontrado());
            Application.Run(new Registros());
            Application.Run(new RedefinirSenha());
        }
    }
}
