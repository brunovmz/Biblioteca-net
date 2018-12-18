namespace WinBiblioteca
{
    partial class frmNovedades
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
            this.dgvNovedades = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNovedades
            // 
            this.dgvNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Comprar});
            this.dgvNovedades.Location = new System.Drawing.Point(13, 25);
            this.dgvNovedades.Name = "dgvNovedades";
            this.dgvNovedades.Size = new System.Drawing.Size(451, 257);
            this.dgvNovedades.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 300;
            // 
            // Comprar
            // 
            this.Comprar.HeaderText = "Comprar";
            this.Comprar.Name = "Comprar";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(13, 303);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 28);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // frmNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 360);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dgvNovedades);
            this.Name = "frmNovedades";
            this.Text = "LISTADO DE NOVEDADES";
            this.Load += new System.EventHandler(this.frmNovedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNovedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Comprar;
        private System.Windows.Forms.Button btnComprar;
    }
}