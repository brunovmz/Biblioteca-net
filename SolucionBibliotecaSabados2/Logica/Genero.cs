using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Genero
    {
       Datos.Genero objDatosGenero = new Datos.Genero();

       //metodos
       public void Agregar(string pDescripcion)
       {
           
           objDatosGenero.Tabla = "Generos";
           objDatosGenero.Agregar(pDescripcion);

       
       }

       public DataTable TraerTodos()
       {
           objDatosGenero.Tabla = "Generos";
           return objDatosGenero.TraerTodos();
       }
    }
}
