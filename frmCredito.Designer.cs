namespace ControleCredito
{
    partial class frmCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredito));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFechar = new System.Windows.Forms.Button();
            this.txtCreditoAtual = new System.Windows.Forms.TextBox();
            this.txtValCredito = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(266, 347);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFechar
            // 
            this.txtFechar.Location = new System.Drawing.Point(327, 347);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(55, 23);
            this.txtFechar.TabIndex = 10;
            this.txtFechar.Text = "Fechar";
            this.txtFechar.UseVisualStyleBackColor = true;
            this.txtFechar.Click += new System.EventHandler(this.txtFechar_Click);
            // 
            // txtCreditoAtual
            // 
            this.txtCreditoAtual.Location = new System.Drawing.Point(306, 137);
            this.txtCreditoAtual.Name = "txtCreditoAtual";
            this.txtCreditoAtual.Size = new System.Drawing.Size(72, 20);
            this.txtCreditoAtual.TabIndex = 27;
            // 
            // txtValCredito
            // 
            this.txtValCredito.Location = new System.Drawing.Point(90, 137);
            this.txtValCredito.Name = "txtValCredito";
            this.txtValCredito.Size = new System.Drawing.Size(100, 20);
            this.txtValCredito.TabIndex = 4;
            this.txtValCredito.Text = "0";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Crédito Atualizado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor Crédito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(205, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(55, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Location = new System.Drawing.Point(14, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 167);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 19);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(356, 142);
            this.txtObs.TabIndex = 5;
            this.txtObs.Text = "Protocolo ER: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(58, 72);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(121, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cidade:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(59, 20);
            this.txtCodigo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(289, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Crédito:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar Obs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(266, 10);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 41;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(306, 110);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(72, 20);
            this.txtCredito.TabIndex = 38;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 379);
            this.ControlBox = false;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.txtCreditoAtual);
            this.Controls.Add(this.txtValCredito);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(406, 418);
            this.MinimumSize = new System.Drawing.Size(406, 418);
            this.Name = "frmCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCredito";
            this.Load += new System.EventHandler(this.frmCredito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button txtFechar;
        private System.Windows.Forms.TextBox txtCreditoAtual;
        private System.Windows.Forms.TextBox txtValCredito;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtCredito;
    }
}