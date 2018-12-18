namespace WinBiblioteca
{
    partial class frmReporteLibros
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.v_librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLibros = new WinBiblioteca.dsLibros();
            this.v_librosTableAdapter = new WinBiblioteca.dsLibrosTableAdapters.v_librosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.v_librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.v_librosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinBiblioteca.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(617, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // v_librosBindingSource
            // 
            this.v_librosBindingSource.DataMember = "v_libros";
            this.v_librosBindingSource.DataSource = this.dsLibros;
            // 
            // dsLibros
            // 
            this.dsLibros.DataSetName = "dsLibros";
            this.dsLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_librosTableAdapter
            // 
            this.v_librosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 435);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteLibros";
            this.Text = "frmReporteLibros";
            this.Load += new System.EventHandler(this.frmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_librosBindingSource;
        private dsLibros dsLibros;
        private dsLibrosTableAdapters.v_librosTableAdapter v_librosTableAdapter;
    }
}