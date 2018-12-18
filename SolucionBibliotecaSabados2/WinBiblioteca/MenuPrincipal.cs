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
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmAltaAutor objAutor = new frmAltaAutor();

            // configuramos que sea hijo del mdi menuprincipal
            objAutor.MdiParent = this;
            
            // que se abra en el centro de la pantalla
            objAutor.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objAutor.Show();

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmVistaAutores objAutor = new frmVistaAutores();

            // configuramos que sea hijo del mdi menuprincipal
            objAutor.MdiParent = this;

            // que se abra en el centro de la pantalla
            objAutor.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objAutor.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmActualizaAutor objAutor = new frmActualizaAutor();

            // configuramos que sea hijo del mdi menuprincipal
            objAutor.MdiParent = this;

            // que se abra en el centro de la pantalla
            objAutor.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objAutor.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmGenero objMostrar = new frmGenero();

            // configuramos que sea hijo del mdi menuprincipal
            objMostrar.MdiParent = this;

            // que se abra en el centro de la pantalla
            objMostrar.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objMostrar.Show();
        }

        private void actualizacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmEditorial objMostrar = new frmEditorial();

            // configuramos que sea hijo del mdi menuprincipal
            objMostrar.MdiParent = this;

            // que se abra en el centro de la pantalla
            objMostrar.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objMostrar.Show();
        }

        private void actualizacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmLibros objMostrar = new frmLibros();

            // configuramos que sea hijo del mdi menuprincipal
            objMostrar.MdiParent = this;

            // que se abra en el centro de la pantalla
            objMostrar.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objMostrar.Show();
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmNovedades objMostrar = new frmNovedades();

            // configuramos que sea hijo del mdi menuprincipal
            objMostrar.MdiParent = this;

            // que se abra en el centro de la pantalla
            objMostrar.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objMostrar.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO DE LA CLASE DEL FORM A MOSTRAR
            frmReporteLibros objMostrar = new frmReporteLibros();

            // configuramos que sea hijo del mdi menuprincipal
            objMostrar.MdiParent = this;

            // que se abra en el centro de la pantalla
            objMostrar.StartPosition = FormStartPosition.CenterScreen;

            // mostrar el form
            objMostrar.Show();
        }
    }
}
