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
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
            
        }

        public frmMenuUsuario(string usuario)
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = usuario;

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

        private void buscaEscritórioToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenuUsuario_Load(object sender, EventArgs e)
        {
            //Desabilita o botão Fechar (X)
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, MenuItemCount - 1, MF_BYPOSITION);

            

            //frmLogin frmLg = new frmLogin();
            // frmLg.ShowDialog();
        }

        //desabilitar botão fechar do form
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        
    }
}
