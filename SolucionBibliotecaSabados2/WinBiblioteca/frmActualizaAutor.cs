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
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor()
        {
            InitializeComponent();
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {
            
            TraerPaises();
            TraerAutores();
            this.dgvAutores.SelectionChanged += new System.EventHandler(this.dgvAutores_SelectionChanged);

        }
        void TraerAutores()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            dgvAutores.DataSource = objLogicaAutor.TraerTodos();

        }
        void TraerPaises()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            cboPaises.DataSource = objLogicaAutor.TraerPaises();
          
        }

        private void dgvAutores_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dgv.SelectedRows[0];
                if (fila != null)
                {
                    txtId.Text = fila.Cells[0].Value.ToString();
                    txtApellido.Text = fila.Cells[1].Value.ToString();
                    txtNombre.Text = fila.Cells[2].Value.ToString();
                    dtpFechaNac.Value = Convert.ToDateTime(fila.Cells[3].Value.ToString());
                    cboPaises.SelectedItem= fila.Cells[4].Value.ToString();

                }
            }
        }

    }
}
    

