using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_VENTAS
{
    internal static class Program
    {

        public static int vIdCategoria = 0; //variables que tomarán el valor de la clave
                                          //primaria de la tabla correspondiente
        public static int tbIdCategoria = 0;
                                           //colocar una por cada clave primaria que tengamos
        public static int vIdCliente = 0; 
        //en nuestra base de datos
        public static bool Nuevo = false; //variable usada para identificar si se trabaja con
                                          //un nuevo dato o no
        public static bool Modificar = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
