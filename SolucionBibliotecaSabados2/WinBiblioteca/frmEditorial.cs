using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class frmEditorial : WinBiblioteca.frmBaseParam
    {
        Logica.Editorial objLogicaEditorial = new Logica.Editorial();
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            objLogicaEditorial.Agregar(txtDescripcion.Text);
            MessageBox.Show("Alta Editorial OK");
            TraerTodos();
        }
        void TraerTodos()
        {
            dgvVista.DataSource = objLogicaEditorial.TraerTodos();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }
    }
}
