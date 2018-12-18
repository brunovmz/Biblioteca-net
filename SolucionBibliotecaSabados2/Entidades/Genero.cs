using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Genero
    {
        private int idGenero;

        public int IdGenero
        {
            get { return idGenero; }
            set { idGenero = value; }
        }


        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private List<Libro> libros;

        public List<Libro> Libros
        {
            get { return libros; }
            set { libros = value; }
        }


    }
}
