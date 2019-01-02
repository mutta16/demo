namespace ATDsistemleri
{
    partial class LogPaneli
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
            this.AtdSistemleriDatabaseDataSet = new ATDsistemleri.AtdSistemleriDatabaseDataSet();
            this.LoglarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoglarTableAdapter = new ATDsistemleri.AtdSistemleriDatabaseDataSetTableAdapters.LoglarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AtdSistemleriDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoglarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LoglarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ATDsistemleri.LoglarRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // AtdSistemleriDatabaseDataSet
            // 
            this.AtdSistemleriDatabaseDataSet.DataSetName = "AtdSistemleriDatabaseDataSet";
            this.AtdSistemleriDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoglarBindingSource
            // 
            this.LoglarBindingSource.DataMember = "Loglar";
            this.LoglarBindingSource.DataSource = this.AtdSistemleriDatabaseDataSet;
            // 
            // LoglarTableAdapter
            // 
            this.LoglarTableAdapter.ClearBeforeFill = true;
            // 
            // LogPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LogPaneli";
            this.Text = "LogPaneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtdSistemleriDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoglarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoglarBindingSource;
        private AtdSistemleriDatabaseDataSet AtdSistemleriDatabaseDataSet;
        private AtdSistemleriDatabaseDataSetTableAdapters.LoglarTableAdapter LoglarTableAdapter;
    }
}