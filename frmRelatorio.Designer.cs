namespace ControleCredito
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.DADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGeraRelatorio = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lvResultado = new System.Windows.Forms.ListView();

            this.txtBusca = new System.Windows.Forms.TextBox();
            this.mskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.mskDataFinal = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DADOSBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodo De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escritório:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(600, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGeraRelatorio
            // 
            this.btnGeraRelatorio.Location = new System.Drawing.Point(463, 235);
            this.btnGeraRelatorio.Name = "btnGeraRelatorio";
            this.btnGeraRelatorio.Size = new System.Drawing.Size(131, 23);
            this.btnGeraRelatorio.TabIndex = 5;
            this.btnGeraRelatorio.Text = "Gerar Relatório";
            this.btnGeraRelatorio.UseVisualStyleBackColor = true;
            this.btnGeraRelatorio.Click += new System.EventHandler(this.btnGeraRelatorio_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(600, 235);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lvResultado
            // 
            this.lvResultado.Location = new System.Drawing.Point(12, 41);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(663, 188);
            this.lvResultado.TabIndex = 11;
            this.lvResultado.UseCompatibleStateImageBehavior = false;
            this.lvResultado.View = System.Windows.Forms.View.Details;
            // 
            // CREDITODataSet
            // 
     
            // 
            // DADOSTableAdapter
            // 

            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(379, 14);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(215, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // mskDataInicio
            // 
            this.mskDataInicio.Location = new System.Drawing.Point(80, 14);
            this.mskDataInicio.Mask = "00/00/0000";
            this.mskDataInicio.Name = "mskDataInicio";
            this.mskDataInicio.Size = new System.Drawing.Size(100, 20);
            this.mskDataInicio.TabIndex = 1;
            this.mskDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataFinal
            // 
            this.mskDataFinal.Location = new System.Drawing.Point(215, 14);
            this.mskDataFinal.Mask = "00/00/0000";
            this.mskDataFinal.Name = "mskDataFinal";
            this.mskDataFinal.Size = new System.Drawing.Size(100, 20);
            this.mskDataFinal.TabIndex = 2;
            this.mskDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 263);
            this.ControlBox = false;
            this.Controls.Add(this.mskDataFinal);
            this.Controls.Add(this.mskDataInicio);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGeraRelatorio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(705, 302);
            this.MinimumSize = new System.Drawing.Size(705, 302);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DADOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGeraRelatorio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListView lvResultado;
        private System.Windows.Forms.BindingSource DADOSBindingSource;
        public System.Windows.Forms.TextBox txtBusca;
        public System.Windows.Forms.MaskedTextBox mskDataInicio;
        public System.Windows.Forms.MaskedTextBox mskDataFinal;
    }
}