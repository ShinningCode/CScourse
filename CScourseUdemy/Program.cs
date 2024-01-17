//using CScourseUdemy.OperadoresAritmeticos; // Importando carpeta de proyecto
//using CScourseUdemy.OperadoresRelacionales;
//using CScourseUdemy.Operadores_Logicos;
//using CScourseUdemy.Ejercicios; //Para utilizar el proyecto Ejercicios
//using CScourseUdemy.Condicionales;
//using CScourseUdemy.Listas;
using CScourseUdemy.Presentacion.Crud;
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
            Application.Run(new frmCrud()); // Se cambia Form1 a el otro prycto
        }
    }
}