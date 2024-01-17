using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
public class Dclientes
{

    public void InsertarClientes(Lclientes parametros)
    {
        try
        {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("InsertarClientes", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
            cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
            cmd.Parameters.AddWithValue("@Edad", parametros.Edad);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Registrado");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message); // o StackTrace
        }
        finally
        {
            CONEXIONMAESTRA.cerrar();
        }
    }

}
