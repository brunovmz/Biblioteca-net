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
    public partial class frmLibros : Form
    {
        Logica.Genero objLogicaGenero = new Logica.Genero();
        Logica.Editorial objLogicaEditorial = new Logica.Editorial();
        Logica.Autor objLogicaAutor = new Logica.Autor();
        Logica.Libro objLogicaLibro = new Logica.Libro();
        DataView dtLibros = new DataView();

        public frmLibros()
        {
            InitializeComponent();
        }
        // llena combo autores para modificar
        void LlenarComboAutoresModifica()
        {
            // llenar Autores
            cboAutoresModifica.DataSource = objLogicaAutor.TraerTodos();
            cboAutoresModifica.ValueMember = "idAutor";
            cboAutoresModifica.DisplayMember = "Apellido";
        }
        void LlenarCombos()
        { 
            // llenar generos
            cboGeneros.DataSource = objLogicaGenero.TraerTodos();
            cboGeneros.ValueMember = "IdGenero";
            cboGeneros.DisplayMember = "Descripcion";

            // llenar Editoriales
            cboEditoriales.DataSource = objLogicaEditorial.TraerTodos();
            cboEditoriales.ValueMember = "idEditorial";
            cboEditoriales.DisplayMember = "Descripcion";

            // llenar Autores
            cboAutores.DataSource = objLogicaAutor.TraerTodos();
            cboAutores.ValueMember = "idAutor";
            cboAutores.DisplayMember = "Apellido";

        
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            dtLibros = objLogicaLibro.TraerTodos().DefaultView;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            objEntidadLibro.Isbn = txtISBN.Text;
            objEntidadLibro.Titulo = txtTitulo.Text;

            // objeto autor
            Entidades.Autor a = new Entidades.Autor();
            a.IdAutor = Convert.ToInt32(cboAutores.SelectedValue);
            objEntidadLibro.Autor = a;

            // objeto genero
            Entidades.Genero g = new Entidades.Genero();
            g.IdGenero = Convert.ToInt32(cboGeneros.SelectedValue);
            objEntidadLibro.Genero = g;

            // objeto editorial
            Entidades.Editorial ed = new Entidades.Editorial();
            ed.IdEditorial = Convert.ToInt32(cboEditoriales.SelectedValue);
            objEntidadLibro.Editorial = ed;
            objEntidadLibro.EsEspañol= chbEspañol.Checked;

            Logica.Libro objLogicaLibro = new Logica.Libro();
            objLogicaLibro.Agregar(objEntidadLibro);
            MessageBox.Show("Libro agregado exitosamente!!");

            
        }

        void CargarLibros()
        {
            dgvListado.DataSource = objLogicaLibro.TraerTodos();
        }
        void CargarComboLibros()
        {
            cboLibros.DataSource = objLogicaLibro.TraerTodos();
            cboLibros.ValueMember = "Isbn";
            cboLibros.DisplayMember = "Titulo";
            this.cboLibros.SelectedIndexChanged += new System.EventHandler(this.cboLibros_SelectedIndexChanged);


        }
        void CargarComboLibrosBorrar()
        {
            cboLibrosBorrar.DataSource = objLogicaLibro.TraerTodos();
            cboLibrosBorrar.ValueMember = "Isbn";
            cboLibrosBorrar.DisplayMember = "Titulo";
            this.cboLibrosBorrar.SelectedIndexChanged += new System.EventHandler(this.cboLibrosBorrar_SelectedIndexChanged);


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    CargarComboLibros();
                    LlenarComboAutoresModifica();
                    break;
                case 2:
                    CargarLibros();
                    break;
                case 4:
                    CargarComboLibrosBorrar();
                    break;
                default:
                    break;
            }

            
        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerLibro(cboLibros.SelectedValue.ToString());
        }
        void TraerLibro(string pIsbn)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            objEntidadLibro = objLogicaLibro.traerUno(pIsbn);
            txtTituloModifica.Text = objEntidadLibro.Titulo;
            cboAutoresModifica.SelectedValue = objEntidadLibro.Autor.IdAutor;

        }

        void TraerLibroBorrar(string pIsbn)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            objEntidadLibro = objLogicaLibro.traerUno(pIsbn);
            lblTituloBorrar.Text = objEntidadLibro.Titulo;
            lblISBNBorrar.Text = cboLibrosBorrar.SelectedValue.ToString();
            lblAutorBorrar.Text = objEntidadLibro.Autor.IdAutor.ToString();

        }


        private void button5_Click(object sender, EventArgs e)
        {
            // confirma los cambios
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            
            // creo un objeto de entidad.autor
            Entidades.Autor objEntidadAutor = new Entidades.Autor();
            objEntidadAutor.IdAutor = Convert.ToInt32(cboAutoresModifica.SelectedValue);

            // cargo las propiedades de objentidadLibro
            objEntidadLibro.Isbn = cboLibros.SelectedValue.ToString();
            objEntidadLibro.Titulo = txtTituloModifica.Text;
            objEntidadLibro.Autor = objEntidadAutor;

            objLogicaLibro.Modificar(objEntidadLibro);

            MessageBox.Show("Libro Modificado!");

        }

        private void cboLibrosBorrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerLibroBorrar(cboLibrosBorrar.SelectedValue.ToString());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string strISBN = cboLibrosBorrar.SelectedValue.ToString();
            objLogicaLibro.Borrar(strISBN);
            MessageBox.Show("Libro Borrado exitosamente!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLibros.DataSource = objLogicaLibro.Buscar(cboFiltros.SelectedItem.ToString(),txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dtLibros.RowFilter = cboFiltros.SelectedItem.ToString()+" like '" + txtFiltro.Text + "%'";
            dgvLibros.DataSource = dtLibros;
        }
    }
}
