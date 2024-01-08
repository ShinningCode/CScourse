using CScourseUdemy.OperadoresAritmeticos; // Importando carpeta de proyecto
using CScourseUdemy.OperadoresRelacionales;
using CScourseUdemy.Operadores_Logicos;
using CScourseUdemy.Ejercicios;
namespace CScourseUdemy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu()); // Se cambia Form1 a el otro prycto
        }
    }
}