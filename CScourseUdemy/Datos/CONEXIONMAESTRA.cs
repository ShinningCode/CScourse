using System;

public class CONEXIONMAESTRA
{   //-----------------------------------NOMBRE DE DISPOSITIVO (VER EN MICROSOFT SQL)--------BASE DE DATOS------------------ACTIVADO
	public static string conexion = @"Data source=DESKTOP-D6JQ9NG\SQLEXPRESS; Initial Catalog=BASECURSO; Itegrated Security=true";
	public static SqlConnection conectar = new SqlConnection(conexion);

	public static void abrir()
	{
		if(conectar.State == ConnectionState.Closed)
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
    public Class1()
	{
	}
}
