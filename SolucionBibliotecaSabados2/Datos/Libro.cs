using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Datos
{
    public class Libro
    {
        public void Agregar(Entidades.Libro pLibro)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAgregar = new SqlCommand("proc_alta_libro", objConexion);
            comAgregar.CommandType = System.Data.CommandType.StoredProcedure;
            comAgregar.Parameters.AddWithValue("@ISBN", pLibro.Isbn);
            comAgregar.Parameters.AddWithValue("@Titulo", pLibro.Titulo);
            comAgregar.Parameters.AddWithValue("@esEspañol", pLibro.EsEspañol);
            comAgregar.Parameters.AddWithValue("@Genero", pLibro.Genero.IdGenero);
            comAgregar.Parameters.AddWithValue("@Autor", pLibro.Autor.IdAutor);
            comAgregar.Parameters.AddWithValue("@Editorial", pLibro.Editorial.IdEditorial);
            objConexion.Open();
            comAgregar.ExecuteNonQuery();
            objConexion.Close();

        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from v_Libros";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraer.Fill(dt);
            return dt;
        
        }
        public Entidades.Libro traerUno(string pISBN)
        {
            Entidades.Libro objLibro = new Entidades.Libro();
            string strSQL = "select Titulo,Autor from Libros where ISBN=" + pISBN;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraer = new SqlCommand(strSQL, objConexion);
            SqlDataReader drLibro;
            objConexion.Open();
            drLibro = comTraer.ExecuteReader();
            drLibro.Read();
            objLibro.Isbn = pISBN;
            Entidades.Autor objAutor = new Entidades.Autor();
            objAutor.IdAutor = Convert.ToInt32(drLibro["Autor"]);

            objLibro.Autor = objAutor;
            objLibro.Titulo = drLibro["Titulo"].ToString();

            objConexion.Close();
            return objLibro;

        }
        public void Modificar(Entidades.Libro pLibro)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comModificar = new SqlCommand("proc_modi_libro", objConexion);
            comModificar.CommandType = System.Data.CommandType.StoredProcedure;
            comModificar.Parameters.AddWithValue("@ISBN", pLibro.Isbn);
            comModificar.Parameters.AddWithValue("@Titulo", pLibro.Titulo);
            comModificar.Parameters.AddWithValue("@Autor", pLibro.Autor.IdAutor);
            objConexion.Open();
            comModificar.ExecuteNonQuery();
            objConexion.Close();
        }
        public void Borrar(string pISBN)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comBorrar = new SqlCommand("Delete Libros where isbn='"+pISBN+"'", objConexion);
            objConexion.Open();
            comBorrar.ExecuteNonQuery();
            objConexion.Close();

        }

        public DataTable Buscar(string pfiltro)
        {
            DataTable dt = new DataTable();
            string strSentencia = "Select * from v_libros where titulo like '%" + pfiltro + "%'";
            SqlDataAdapter daBuscar = new SqlDataAdapter(strSentencia, Conexion.strConexion);
            daBuscar.Fill(dt);
            return dt;
        
        }
        public DataTable Buscar(string pCampo, string pFiltro)
        {
            DataTable dt = new DataTable();
            string strProc = "proc_buscar"; // nombre del stored procedure
            SqlDataAdapter daBuscar = new SqlDataAdapter(strProc, Conexion.strConexion);
            daBuscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            daBuscar.SelectCommand.Parameters.AddWithValue("@Campo", pCampo);
            daBuscar.SelectCommand.Parameters.AddWithValue("@Filtro", pFiltro);
            daBuscar.Fill(dt);
            return dt;
        
        }

        public List<Entidades.Libro> TraerNovedades()
        {
            List<Entidades.Libro> Novedades = new List<Entidades.Libro>();
            string linea;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Novedades.txt");

            while ((linea = file.ReadLine()) != null)
            {
                Entidades.Libro l = new Entidades.Libro();
                l.Titulo = linea;
                Novedades.Add(l);
            }

            file.Close();
            return Novedades;
        }
        // grabar compras.
        public void Comprar(List<string> pArchivo)
        {
            StreamWriter file = new StreamWriter(@"C:\compras.txt");

            foreach (string item in pArchivo)
            {
                file.WriteLine(item);
            }


            file.Close();
        }
    }
}
