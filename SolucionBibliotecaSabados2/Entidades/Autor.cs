using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Nacionalidad
    { 
        Argentina,
        Chile,
        Uruguay,
        España,
        Colombia,
        Peru
    }
    public class Autor
    {
        // propiedades
        private int idAutor;

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private Nacionalidad paisOrigen;

        public Nacionalidad PaisOrigen
        {
            get { return paisOrigen; }
            set { paisOrigen = value; }
        }


        private List<Libro> libros;

        public List<Libro> Libros
        {
            get { return libros; }
            set { libros = value; }
        }
    }
}
