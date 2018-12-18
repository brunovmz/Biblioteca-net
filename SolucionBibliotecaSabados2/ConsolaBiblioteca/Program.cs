using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo  4 instancias de clase autor de entidades
            Entidades.Autor objEntidadautor1 = new Entidades.Autor();
            Entidades.Autor objEntidadautor2 = new Entidades.Autor();
            Entidades.Autor objEntidadautor3 = new Entidades.Autor();
            Entidades.Autor objEntidadautor4 = new Entidades.Autor();
            
            // creo lista de clase Autor para guardar los autores cargados
            List<Entidades.Autor> listaAutores = new List<Entidades.Autor>();

            // cargo propiedades en objetos de entidades autor
            objEntidadautor1.IdAutor = 1;
            objEntidadautor1.Apellido = "Borges";
            objEntidadautor1.Nombre = "Jorge Luis";
            objEntidadautor1.FechaNacimiento = Convert.ToDateTime("01/10/1926");
            objEntidadautor1.PaisOrigen = Entidades.Nacionalidad.Argentina;

            // autor 2
            objEntidadautor2.IdAutor = 2;
            objEntidadautor2.Apellido = "Cortazar";
            objEntidadautor2.Nombre = "Julio";
            objEntidadautor2.FechaNacimiento = Convert.ToDateTime("11/10/1932");
            objEntidadautor2.PaisOrigen = Entidades.Nacionalidad.Argentina;

            // autor 3
            objEntidadautor3.IdAutor = 3;
            objEntidadautor3.Apellido = "Pigna";
            objEntidadautor3.Nombre = "Felipe";
            objEntidadautor3.FechaNacimiento = Convert.ToDateTime("11/10/1962");
            objEntidadautor3.PaisOrigen = Entidades.Nacionalidad.Argentina;

            // autor 4
            objEntidadautor4.IdAutor = 4;
            objEntidadautor4.Apellido = "Neruda";
            objEntidadautor4.Nombre = "Pablo";
            objEntidadautor4.FechaNacimiento = Convert.ToDateTime("11/10/1955");
            objEntidadautor4.PaisOrigen = Entidades.Nacionalidad.Chile;

            // agrego autores a la lista
            listaAutores.Add(objEntidadautor1);
            listaAutores.Add(objEntidadautor2);
            listaAutores.Add(objEntidadautor3);
            listaAutores.Add(objEntidadautor4);

            // muestro autores
            foreach (Entidades.Autor a in listaAutores)
            {
                Console.WriteLine(a.IdAutor + " " + a.Apellido + " " + a.Nombre + " " + a.PaisOrigen.ToString());
                
            }


            Console.ReadKey();
            

        }
    }
}
