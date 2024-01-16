using System.Data;
using System.Data.SqlClient;

namespace CScourseUdemy.Datos
{
    public class CONEXIONMAESTRA
    {
        // Connection string with Data Source, Initial Catalog, and Integrated Security settings
        public static string CONEXION = @"Data Source=DESKTOP-D6JQ9NG\SQLEXPRESS; Initial Catalog=BASECURSO; Integrated Security=true";

        // SqlConnection object for database connection
        public static SqlConnection conectar = new SqlConnection(CONEXION);

        // Method to open the database connection
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        // Method to close the database connection
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
