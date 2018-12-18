using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Editorial
    {
        Datos.Editorial objDatosEditorial = new Datos.Editorial();

        //metodos
        public void Agregar(string pDescripcion)
        {

            objDatosEditorial.Tabla = "Editoriales";
            objDatosEditorial.Agregar(pDescripcion);


        }
        public DataTable TraerTodos()
        {
            objDatosEditorial.Tabla = "Editoriales";
            return objDatosEditorial.TraerTodos();
        }
    }
}
