using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;// para trabajar con las clases de sql

namespace Datos
{
    public class Autor
    {
        public Autor()
        { 
            // codigo 
        }

        // metodos
        public void Agregar(Entidades.Autor pAutor)
        { 
            // declaro variable con la sentencia sql
            string strSQL = "Insert Autores(idAutor,Apellido,Nombre,FechaNacimiento,PaisOrigen)";
            strSQL += " Values(@idAutor,@Apellido,@Nombre,@Fechanacimiento,@PaisOrigen)";

            // crear objeto de la clase sqlconnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            // crear objeto de sqlcommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            // cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@idAutor", pAutor.IdAutor);
            comAlta.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            comAlta.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            comAlta.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            comAlta.Parameters.AddWithValue("@PaisOrigen", pAutor.PaisOrigen.ToString());

            try
            {
                // abro conexion
                objConexion.Open();
                // ejecuto el comando
                comAlta.ExecuteNonQuery();
            }
            catch (DivideByZeroException)
            {
                throw new Exception("Como dijo Paenza, no se puede dividir x cero");
            }
            catch (SqlException)
            {
                // se produjo un error en sql
                throw new Exception("Error en SQL");
            }
            catch (Exception)
            {
                throw new Exception("No pudo realizar el alta de Autor");
            }
            finally
            {
                // cierro conexion
                if(objConexion.State==ConnectionState.Open)
                objConexion.Close();
            }
           
        }

        
        /// <summary>
        /// Metodo : me devuelve una lista de los autores
        /// Fecha  : 19/09/2015
        /// Autor  : Curso Prog. Net Sabados
        /// </summary>
        /// <returns>un DataTable</returns>
        public DataTable TraerTodos()
        { 
            DataTable dt = new DataTable();
            try
            {
               
                string strSQL = "Select * from Autores";
                SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
                daTraer.Fill(dt);

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
            return dt;
        
        
        }

        public void Modificar(Entidades.Autor pAutor)
        { 
            // variable con el nombre del sp
            string strProc = "proc_modifica_autor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comModificar = new SqlCommand(strProc, objConexion);

            // interprete el primer argumento del command como SP
            comModificar.CommandType = CommandType.StoredProcedure;

            // parametros
            comModificar.Parameters.AddWithValue("@IdAutor", pAutor.IdAutor);
            comModificar.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            comModificar.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            comModificar.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            comModificar.Parameters.AddWithValue("@PaisOrigen", pAutor.PaisOrigen.ToString());

            objConexion.Open();
            comModificar.ExecuteNonQuery();
            objConexion.Close();

        }
    }
}
