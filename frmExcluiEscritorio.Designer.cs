namespace ControleCredito
{
    partial class frmExcluiEscritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluiEscritorio));
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNomeEscritorio = new System.Windows.Forms.TextBox();
            this.txtCodEscritorio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvExcluiEscritorio = new System.Windows.Forms.DataGridView();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluiEscritorio)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.txtCredito);
            this.gpbDados.Controls.Add(this.txtCidade);
            this.gpbDados.Controls.Add(this.txtNomeEscritorio);
            this.gpbDados.Controls.Add(this.txtCodEscritorio);
            this.gpbDados.Location = new System.Drawing.Point(12, 12);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(475, 172);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Escritório";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crédito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Escritório:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código Escritório: ";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(104, 133);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 20);
            this.txtCredito.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(104, 100);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(165, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtNomeEscritorio
            // 
            this.txtNomeEscritorio.Location = new System.Drawing.Point(104, 67);
            this.txtNomeEscritorio.Name = "txtNomeEscritorio";
            this.txtNomeEscritorio.Size = new System.Drawing.Size(352, 20);
            this.txtNomeEscritorio.TabIndex = 1;
            // 
            // txtCodEscritorio
            // 
            this.txtCodEscritorio.Location = new System.Drawing.Point(104, 34);
            this.txtCodEscritorio.Name = "txtCodEscritorio";
            this.txtCodEscritorio.Size = new System.Drawing.Size(72, 20);
            this.txtCodEscritorio.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(299, 459);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(371, 459);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(432, 459);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(159, 461);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(134, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Informe o nome do Escritório:";
            // 
            // dgvExcluiEscritorio
            // 
            this.dgvExcluiEscritorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluiEscritorio.Location = new System.Drawing.Point(12, 201);
            this.dgvExcluiEscritorio.Name = "dgvExcluiEscritorio";
            this.dgvExcluiEscritorio.Size = new System.Drawing.Size(475, 252);
            this.dgvExcluiEscritorio.TabIndex = 6;
            this.dgvExcluiEscritorio.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExcluiEscritorio_CellMouseDoubleClick);
            // 
            // frmExcluiEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 495);
            this.ControlBox = false;
            this.Controls.Add(this.dgvExcluiEscritorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gpbDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmExcluiEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExcluiEscritorio";
            this.Load += new System.EventHandler(this.frmExcluiEscritorio_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluiEscritorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNomeEscritorio;
        private System.Windows.Forms.TextBox txtCodEscritorio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvExcluiEscritorio;
    }
}