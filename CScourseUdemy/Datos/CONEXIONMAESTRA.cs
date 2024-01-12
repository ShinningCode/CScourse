using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CScourseUdemy.Datos
{
    public class CONEXIONMAESTRA
    {                              //----------NOMBRE DE DISPOSITIVO------------NOMBRE BASE DE DATOS
        public static string CONEXION = @"Data Source=DESKTOP-D6JQ9NG\SQLEXPRESS; Initial Catalog=BASECURSO; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(CONEXION);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
    }
}
