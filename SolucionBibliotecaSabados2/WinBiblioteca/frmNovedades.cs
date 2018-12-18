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
    public partial class frmNovedades : Form
    {
        public frmNovedades()
        {
            InitializeComponent();
            dgvNovedades.AutoGenerateColumns = false;
        
        }

        private void frmNovedades_Load(object sender, EventArgs e)
        {
            Logica.Libro objLogicaLibro = new Logica.Libro();
            dgvNovedades.DataSource = objLogicaLibro.TraerNovedades();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            List<string> nov = new List<string>();

            foreach (DataGridViewRow row in dgvNovedades.Rows)
            {

                if (Convert.ToBoolean(row.Cells["Comprar"].Value).Equals(true))
                {
                    nov.Add(row.Cells[0].Value.ToString());
                }

            }
            Logica.Libro logLibro = new Logica.Libro();
            logLibro.Comprar(nov);

            MessageBox.Show("datos enviados!");
        }
    }
}
