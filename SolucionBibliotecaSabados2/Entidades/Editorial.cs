using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Editorial
    {
        private int idEditorial;


        public int IdEditorial
        {
            get { return idEditorial; }
            set { idEditorial = value; }
        }

        private string descripcion;

        public string Descricpion
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
