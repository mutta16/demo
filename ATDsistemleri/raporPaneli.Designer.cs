namespace ATDsistemleri
{
    partial class uyeRaporPaneli
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
            this.PersonelTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AtdSistemleriDatabaseDataSet = new ATDsistemleri.AtdSistemleriDatabaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelTablosuTableAdapter = new ATDsistemleri.AtdSistemleriDatabaseDataSetTableAdapters.PersonelTablosuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtdSistemleriDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelTablosuBindingSource
            // 
            this.PersonelTablosuBindingSource.DataMember = "PersonelTablosu";
            this.PersonelTablosuBindingSource.DataSource = this.AtdSistemleriDatabaseDataSet;
            // 
            // AtdSistemleriDatabaseDataSet
            // 
            this.AtdSistemleriDatabaseDataSet.DataSetName = "AtdSistemleriDatabaseDataSet";
            this.AtdSistemleriDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 59;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonelTablosuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ATDsistemleri.uyeraporu2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1021, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelTablosuTableAdapter
            // 
            this.PersonelTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // uyeRaporPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "uyeRaporPaneli";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.raporPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtdSistemleriDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonelTablosuBindingSource;
        private AtdSistemleriDatabaseDataSet AtdSistemleriDatabaseDataSet;
        private AtdSistemleriDatabaseDataSetTableAdapters.PersonelTablosuTableAdapter PersonelTablosuTableAdapter;
    }
}