namespace ControleCredito
{
    partial class frmMenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUsuario));
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buscaEscritórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosEscritórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.dadosEscritórioToolStripMenuItem,
            this.buscaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuário: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // buscaEscritórioToolStripMenuItem
            // 
            this.buscaEscritórioToolStripMenuItem.Name = "buscaEscritórioToolStripMenuItem";
            this.buscaEscritórioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.buscaEscritórioToolStripMenuItem.Text = "Busca Escritório";
            this.buscaEscritórioToolStripMenuItem.Click += new System.EventHandler(this.buscaEscritórioToolStripMenuItem_Click);
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaEscritórioToolStripMenuItem});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.buscaToolStripMenuItem.Text = "Histórico Escritório";
            this.buscaToolStripMenuItem.Click += new System.EventHandler(this.buscaToolStripMenuItem_Click);
            // 
            // dadosEscritórioToolStripMenuItem
            // 
            this.dadosEscritórioToolStripMenuItem.Name = "dadosEscritórioToolStripMenuItem";
            this.dadosEscritórioToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.dadosEscritórioToolStripMenuItem.Text = "Escritório";
            // 
            // frmMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 733);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1042, 772);
            this.MinimumSize = new System.Drawing.Size(964, 640);
            this.Name = "frmMenuUsuario";
            this.Text = "frmMenuUsuario";
            this.Load += new System.EventHandler(this.frmMenuUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem buscaEscritórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosEscritórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
    }
}