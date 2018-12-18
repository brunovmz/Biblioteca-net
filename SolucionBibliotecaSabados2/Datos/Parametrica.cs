using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Parametrica
    {
        public string Tabla;

        public void Agregar(string pDescripcion)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            string strProc = "proc_alta";
            SqlCommand comAlta = new SqlCommand(strProc, objConexion);
            comAlta.CommandType = System.Data.CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@Tabla", Tabla);
            comAlta.Parameters.AddWithValue("@Descripcion", pDescripcion);
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();
        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from " + Tabla;
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraer.Fill(dt);
            return dt;
        
        }
    }
}
