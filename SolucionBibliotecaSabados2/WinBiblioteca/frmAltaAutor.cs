using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class frmAltaAutor : Form
    {
        public frmAltaAutor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaAutor_Load(object sender, EventArgs e)
        {
            // llenar combo de paises
            Logica.Autor objLogicaAutor = new Logica.Autor();
            cboPaises.DataSource = objLogicaAutor.TraerPaises();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // creo objeto de entidades autor para cargar los datos 
                // y ese objeto se lo paso al metodo de logica agregar
                Entidades.Autor objEntidadesAutor = new Entidades.Autor();
                objEntidadesAutor.IdAutor = Convert.ToInt32(txtId.Text);
                objEntidadesAutor.Apellido = txtApellido.Text;
                objEntidadesAutor.Nombre = txtNombre.Text;
                objEntidadesAutor.FechaNacimiento = dtpFechaNac.Value;

                Entidades.Nacionalidad pais = new Entidades.Nacionalidad();
                Enum.TryParse(cboPaises.SelectedValue.ToString(), out pais);
                objEntidadesAutor.PaisOrigen = pais;


                // creo un objeto de logica
                // ejecuto el metodo de logica : agregar
                Logica.Autor objLogicaAutor = new Logica.Autor();
                objLogicaAutor.Agregar(objEntidadesAutor);
                MessageBox.Show("Autor agregado!!!");
            }
            catch (FormatException)
            {
                MessageBox.Show("El codigo de Autor debe ser Numerico");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            
            }
        }

    }
}
