namespace WinBiblioteca
{
    partial class frmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.chbEspañol = new System.Windows.Forms.CheckBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.cboAutores = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.cboEditoriales = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTituloModifica = new System.Windows.Forms.TextBox();
            this.cboAutoresModifica = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cboFiltros = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAutorBorrar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTituloBorrar = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblISBNBorrar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLibrosBorrar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 401);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Libro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45798F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chbEspañol, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboGeneros, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboAutores, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtISBN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboEditoriales, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ES ESPAÑOL ?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENERO :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "AUTOR :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "EDITORIAL :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(87, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTitulo.Location = new System.Drawing.Point(287, 62);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(293, 26);
            this.txtTitulo.TabIndex = 8;
            // 
            // chbEspañol
            // 
            this.chbEspañol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chbEspañol.AutoSize = true;
            this.chbEspañol.Location = new System.Drawing.Point(287, 116);
            this.chbEspañol.Name = "chbEspañol";
            this.chbEspañol.Size = new System.Drawing.Size(15, 14);
            this.chbEspañol.TabIndex = 9;
            this.chbEspañol.UseVisualStyleBackColor = true;
            // 
            // cboGeneros
            // 
            this.cboGeneros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(287, 159);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(193, 26);
            this.cboGeneros.TabIndex = 10;
            // 
            // cboAutores
            // 
            this.cboAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutores.FormattingEnabled = true;
            this.cboAutores.Location = new System.Drawing.Point(287, 195);
            this.cboAutores.Name = "cboAutores";
            this.cboAutores.Size = new System.Drawing.Size(193, 26);
            this.cboAutores.TabIndex = 11;
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtISBN.Location = new System.Drawing.Point(287, 10);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(193, 26);
            this.txtISBN.TabIndex = 7;
            // 
            // cboEditoriales
            // 
            this.cboEditoriales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEditoriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditoriales.FormattingEnabled = true;
            this.cboEditoriales.Location = new System.Drawing.Point(287, 240);
            this.cboEditoriales.Name = "cboEditoriales";
            this.cboEditoriales.Size = new System.Drawing.Size(193, 26);
            this.cboEditoriales.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.cboLibros);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "MODIFICAR DATOS DE UN LIBRO";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(337, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "CERRAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(275, 45);
            this.button5.TabIndex = 15;
            this.button5.Text = "CONFIRMAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0365F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.9635F));
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTituloModifica, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboAutoresModifica, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(56, 126);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(549, 144);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "AUTOR --->";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "TITULO --->";
            // 
            // txtTituloModifica
            // 
            this.txtTituloModifica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTituloModifica.Location = new System.Drawing.Point(196, 23);
            this.txtTituloModifica.Name = "txtTituloModifica";
            this.txtTituloModifica.Size = new System.Drawing.Size(317, 26);
            this.txtTituloModifica.TabIndex = 3;
            // 
            // cboAutoresModifica
            // 
            this.cboAutoresModifica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboAutoresModifica.FormattingEnabled = true;
            this.cboAutoresModifica.Location = new System.Drawing.Point(196, 97);
            this.cboAutoresModifica.Name = "cboAutoresModifica";
            this.cboAutoresModifica.Size = new System.Drawing.Size(317, 26);
            this.cboAutoresModifica.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(53, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 18);
            this.label22.TabIndex = 13;
            this.label22.Text = "SELECCIONAR LIBRO";
            // 
            // cboLibros
            // 
            this.cboLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Location = new System.Drawing.Point(199, 77);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(393, 26);
            this.cboLibros.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvListado);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(766, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(13, 28);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(724, 309);
            this.dgvListado.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnBuscar);
            this.tabPage4.Controls.Add(this.btnImprimir);
            this.tabPage4.Controls.Add(this.cboFiltros);
            this.tabPage4.Controls.Add(this.txtFiltro);
            this.tabPage4.Controls.Add(this.dgvLibros);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(766, 370);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(488, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(163, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // cboFiltros
            // 
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Items.AddRange(new object[] {
            "Titulo",
            "Genero",
            "Editorial"});
            this.cboFiltros.Location = new System.Drawing.Point(14, 21);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(121, 26);
            this.cboFiltros.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(141, 22);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(191, 26);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(14, 59);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(637, 291);
            this.dgvLibros.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.btnBorrar);
            this.tabPage5.Controls.Add(this.tableLayoutPanel2);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.cboLibrosBorrar);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(766, 370);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Borrar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "BORRAR UN LIBRO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(56, 310);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(275, 45);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "CONFIRMAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAutorBorrar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloBorrar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblISBNBorrar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(56, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 171);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "AUTOR --->";
            // 
            // lblAutorBorrar
            // 
            this.lblAutorBorrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAutorBorrar.AutoSize = true;
            this.lblAutorBorrar.Location = new System.Drawing.Point(278, 138);
            this.lblAutorBorrar.Name = "lblAutorBorrar";
            this.lblAutorBorrar.Size = new System.Drawing.Size(53, 18);
            this.lblAutorBorrar.TabIndex = 4;
            this.lblAutorBorrar.Text = "label12";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "TITULO --->";
            // 
            // lblTituloBorrar
            // 
            this.lblTituloBorrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTituloBorrar.AutoSize = true;
            this.lblTituloBorrar.Location = new System.Drawing.Point(278, 84);
            this.lblTituloBorrar.Name = "lblTituloBorrar";
            this.lblTituloBorrar.Size = new System.Drawing.Size(53, 18);
            this.lblTituloBorrar.TabIndex = 3;
            this.lblTituloBorrar.Text = "label11";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(209, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 18);
            this.label23.TabIndex = 6;
            this.label23.Text = "ISBN --->";
            // 
            // lblISBNBorrar
            // 
            this.lblISBNBorrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblISBNBorrar.AutoSize = true;
            this.lblISBNBorrar.Location = new System.Drawing.Point(278, 22);
            this.lblISBNBorrar.Name = "lblISBNBorrar";
            this.lblISBNBorrar.Size = new System.Drawing.Size(53, 18);
            this.lblISBNBorrar.TabIndex = 7;
            this.lblISBNBorrar.Text = "label24";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "SELECCIONAR LIBRO";
            // 
            // cboLibrosBorrar
            // 
            this.cboLibrosBorrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibrosBorrar.FormattingEnabled = true;
            this.cboLibrosBorrar.Location = new System.Drawing.Point(222, 63);
            this.cboLibrosBorrar.Name = "cboLibrosBorrar";
            this.cboLibrosBorrar.Size = new System.Drawing.Size(360, 26);
            this.cboLibrosBorrar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(339, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLibros";
            this.Text = "ACTUALIZACION DE LIBROS";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.CheckBox chbEspañol;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.ComboBox cboAutores;
        private System.Windows.Forms.ComboBox cboEditoriales;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTituloModifica;
        private System.Windows.Forms.ComboBox cboAutoresModifica;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboFiltros;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAutorBorrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTituloBorrar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblISBNBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLibrosBorrar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnBuscar;
    }
}