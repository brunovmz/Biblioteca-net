﻿using System;
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
    public partial class frmVistaAutores : Form
    {
        public frmVistaAutores()
        {
            InitializeComponent();
        }

        void TraerAutores()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            dgvAutores.DataSource = objLogicaAutor.TraerTodos();

        
        }

        private void frmVistaAutores_Load(object sender, EventArgs e)
        {
            TraerAutores();
        }
    }
}
