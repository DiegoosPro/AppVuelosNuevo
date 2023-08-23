namespace AppVuelos
{
    partial class frmRepAeropuertoPais
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
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.AeropuertoPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AeropuertoPaisTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.AeropuertoPaisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeropuertoPaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AeropuertoPaisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepAeropuertoPais.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(806, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AeropuertoPaisBindingSource
            // 
            this.AeropuertoPaisBindingSource.DataMember = "AeropuertoPais";
            this.AeropuertoPaisBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // AeropuertoPaisTableAdapter
            // 
            this.AeropuertoPaisTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepAeropuertoPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 464);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepAeropuertoPais";
            this.Text = "frmRepAeropuertoPais";
            this.Load += new System.EventHandler(this.frmRepAeropuertoPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeropuertoPaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AeropuertoPaisBindingSource;
        private bddvuelosDataSet bddvuelosDataSet;
        private bddvuelosDataSetTableAdapters.AeropuertoPaisTableAdapter AeropuertoPaisTableAdapter;
    }
}