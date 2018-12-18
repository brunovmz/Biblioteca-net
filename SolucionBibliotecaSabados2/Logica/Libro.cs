using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Libro
    { 
        Datos.Libro objDatosLibro = new Datos.Libro();
        public void Agregar(Entidades.Libro pLibro)
        {
           
            objDatosLibro.Agregar(pLibro);
        }
        public DataTable TraerTodos()
        {
            return objDatosLibro.TraerTodos();
        }
        public Entidades.Libro traerUno(string pISBN)
        {
            return objDatosLibro.traerUno(pISBN);
        }
        public void Modificar(Entidades.Libro pLibro)
        {
            objDatosLibro.Modificar(pLibro);
        }
        public void Borrar(string pISBN)
        {
            objDatosLibro.Borrar(pISBN);
        }
        public DataTable Buscar(string pfiltro)
        {
            return objDatosLibro.Buscar(pfiltro);
        }
        public DataTable Buscar(string pCampo, string pFiltro)
        {
            return objDatosLibro.Buscar(pCampo, pFiltro);
        }
        public List<Entidades.Libro> TraerNovedades()
        {
            return objDatosLibro.TraerNovedades();
        }
        public void Comprar(List<string> pArchivo)
        {
            objDatosLibro.Comprar(pArchivo);
        }
    }
}
