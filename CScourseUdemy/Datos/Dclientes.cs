using System;
using System.Data.SqlClient;
using System.Data;


public class Dclientes
{

    public InsertarClientes()
    {
        try
        {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("InsertarClientes", CONEXIONMAESTRA.conectar);
            cmd.CommandType
        }
        catch (Exception)
        {

            throw;
        }
    }

}
