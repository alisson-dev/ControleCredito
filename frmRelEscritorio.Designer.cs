namespace ControleCredito
{
    partial class frmRelEscritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelEscritorio));
            this.DADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CREDITODataRel = new ControleCredito.CREDITODataRel();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DADOSTableAdapter = new ControleCredito.CREDITODataRelTableAdapters.DADOSTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITODataRel)).BeginInit();
            this.SuspendLayout();
            // 
            // DADOSBindingSource
            // 
            this.DADOSBindingSource.DataMember = "DADOS";
            this.DADOSBindingSource.DataSource = this.CREDITODataRel;
            // 
            // CREDITODataRel
            // 
            this.CREDITODataRel.DataSetName = "CREDITODataRel";
            this.CREDITODataRel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(79, 12);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicio.TabIndex = 1;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(214, 12);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(99, 20);
            this.txtDataFinal.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(379, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodo De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escritório:";
            // 
            // DADOSTableAdapter
            // 
            this.DADOSTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DADOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleCredito.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(687, 336);
            this.reportViewer1.TabIndex = 3;
            // 
            // frmRelEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 376);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(705, 415);
            this.MinimumSize = new System.Drawing.Size(705, 302);
            this.Name = "frmRelEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelEscritorio";
            this.Load += new System.EventHandler(this.frmRelEscritorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITODataRel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource DADOSBindingSource;
        private CREDITODataRel CREDITODataRel;
        private CREDITODataRelTableAdapters.DADOSTableAdapter DADOSTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}