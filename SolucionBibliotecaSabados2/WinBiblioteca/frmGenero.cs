using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class frmGenero : WinBiblioteca.frmBaseParam
    { 
        Logica.Genero objLogicaGenero = new Logica.Genero();
        
        public frmGenero()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            objLogicaGenero.Agregar(txtDescripcion.Text);
            MessageBox.Show("Alta OK");
            TraerTodos();

        }
        void TraerTodos()
        {
            dgvVista.DataSource = objLogicaGenero.TraerTodos();  
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }
    }
}
