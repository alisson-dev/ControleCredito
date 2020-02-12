using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //desabilitar botão fechar

namespace ControleCredito
{
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string usuario)
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = usuario;

        }

        //desabilitar botão fechar do form
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //Desabilita o botão Fechar (X)
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, MenuItemCount - 1, MF_BYPOSITION);

            //frmLogin frmLg = new frmLogin();
            // frmLg.ShowDialog();

        }

        private void cadastroEscriórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // desta forma o form será aberto apenas uma vez.
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadEscritorio)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmCadEscritorio frmEscritorio = new frmCadEscritorio();
                frmEscritorio.MdiParent = this;
                frmEscritorio.Show();
            }
        }

        private void débitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCredito)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmCredito frmCred = new frmCredito();
                frmCred.MdiParent = this;
                frmCred.Show();
            }
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadUsuario)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmCadUsuario frmUsuario = new frmCadUsuario();
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            }
        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsultaEscritorio)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmConsultaEscritorio frmConsulta = new frmConsultaEscritorio();
                frmConsulta.MdiParent = this;
                frmConsulta.Show();
            }
        }

        private void escritórioDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmDebito)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmDebito frmDeb = new frmDebito();
                frmDeb.MdiParent = this;
                frmDeb.Show();
            }

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmRelatorio)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmRelatorio frmExclui = new frmRelatorio();
                frmExclui.MdiParent = this;
                frmExclui.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmAlterar)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmAlterar frmExclui = new frmAlterar();
                frmExclui.MdiParent = this;
                frmExclui.Show();
            }
        }

        private void excluirEscritórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmExcluiEscritorio)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmExcluiEscritorio frmExclui = new frmExcluiEscritorio();
                frmExclui.MdiParent = this;
                frmExclui.Show();
            }
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmUsuario)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmUsuario frmExclui = new frmUsuario();
                frmExclui.MdiParent = this;
                frmExclui.Show();
            }
        }

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmAlteraUsuario)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmAlteraUsuario frmExclui = new frmAlteraUsuario();
                frmExclui.MdiParent = this;
                frmExclui.Show();
            }
        }      

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmBuscaEscritorio)
                {
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                frmBuscaEscritorio frmBusca = new frmBuscaEscritorio();
                frmBusca.MdiParent = this;
                frmBusca.Show();
            }
        }
    }

}
