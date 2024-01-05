using CScourseUdemy.OperadoresAritmeticos; // Importando carpeta de proyecto
using CScourseUdemy.OperadoresRelacionales;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new OpRel()); // Se cambia Form1 a el otro prycto
        }
    }
}