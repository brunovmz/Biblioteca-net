using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        Datos.Autor objDatosAutor = new Datos.Autor();

        /// <summary>
        /// devuelve una lista de string con los paises
        /// de la enum Paises
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> TraerPaises()
        {
            List<string> paises = new List<string>();
            foreach (Entidades.Nacionalidad 
                pais in Enum.GetValues(typeof(Entidades.Nacionalidad)))
            {
                paises.Add(pais.ToString());
            }
            return paises;
        
        }
        public void Agregar(Entidades.Autor pAutor)
        {
            try
            {
                //TODO VALIDAR QUE NO EXISTA EL ID DE AUTOR

                if(pAutor.FechaNacimiento.Year.Equals(1976))
                {
                    // disparo una excepcion personalizada
                    throw new Exception("Año NO permitido");
                }


                // creo objeto de datos.autor
                objDatosAutor.Agregar(pAutor);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           

        
        }
        public DataTable TraerTodos()
        {
            return objDatosAutor.TraerTodos();
        }
        public void Modificar(Entidades.Autor pAutor)
        {
            objDatosAutor.Modificar(pAutor);
        }
    }
}
