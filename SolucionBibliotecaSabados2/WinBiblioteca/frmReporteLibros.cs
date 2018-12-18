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
    public partial class frmReporteLibros : Form
    {
        public frmReporteLibros()
        {
            InitializeComponent();
        }

        private void frmReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLibros.v_libros' table. You can move, or remove it, as needed.
            this.v_librosTableAdapter.Fill(this.dsLibros.v_libros);

            this.reportViewer1.RefreshReport();
        }
    }
}
