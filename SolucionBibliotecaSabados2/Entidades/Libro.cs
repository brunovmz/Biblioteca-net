using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private bool esEspañol;

        public bool EsEspañol
        {
            get { return esEspañol; }
            set { esEspañol = value; }
        }

        private Genero genero;

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private Editorial editorial;

        public Editorial Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        private Autor autor;

        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }


    }
}
