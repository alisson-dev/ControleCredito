namespace ControleCredito
{
    partial class frmConsultaEscritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEscritorio));
            this.dgrConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrConsulta
            // 
            this.dgrConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrConsulta.Location = new System.Drawing.Point(15, 12);
            this.dgrConsulta.Name = "dgrConsulta";
            this.dgrConsulta.Size = new System.Drawing.Size(789, 197);
            this.dgrConsulta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira o Nome do Escritório:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(517, 221);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(164, 223);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(347, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConsultaEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(832, 300);
            this.MinimumSize = new System.Drawing.Size(832, 300);
            this.Name = "frmConsultaEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaEscritorio";
            this.Load += new System.EventHandler(this.frmConsultaEscritorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgrConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button button1;
    }
}