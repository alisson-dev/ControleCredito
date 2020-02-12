using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCredito
{
    public partial class frmExcluiEscritorio : Form
    {
        public frmExcluiEscritorio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExcluiEscritorio_Load(object sender, EventArgs e)
        {
            txtCodEscritorio.Enabled = false;
            txtNomeEscritorio.Enabled = false;
            txtCidade.Enabled = false;
            txtCredito.Enabled = false;

            //AtualizaGrid();
            txtBuscar.Focus();
        }

        public void AtualizaGrid()
        {
            Cliente cli = new Cliente();
            dgvExcluiEscritorio.DataSource = cli.ListagemExcluir(txtBuscar.Text);

            try
            {
                txtCodEscritorio.Text = dgvExcluiEscritorio[0, dgvExcluiEscritorio.CurrentRow.Index].Value.ToString();
                txtNomeEscritorio.Text = dgvExcluiEscritorio[1, dgvExcluiEscritorio.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvExcluiEscritorio[2, dgvExcluiEscritorio.CurrentRow.Index].Value.ToString();
                txtCredito.Text = dgvExcluiEscritorio[3, dgvExcluiEscritorio.CurrentRow.Index].Value.ToString();

                if (txtBuscar.Text == "")
                {
                    txtCodEscritorio.Text = "";
                    txtNomeEscritorio.Text = "";
                    txtCidade.Text = "";
                    txtCredito.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodEscritorio.Text.Length == 0)
            {
                MessageBox.Show("Um escritório deve ser selecionado antes da exclusão");
            }

            if (Convert.ToDecimal(txtCredito.Text) > 0)
            {
                MessageBox.Show("Impossível excluir escritório com saldo positivo");
            }
           else
                try
                {
                    int codigo = Convert.ToInt32(txtCodEscritorio.Text);
                    Cliente cli = new Cliente();
                    cli.Excluir(codigo);
                    MessageBox.Show("O Escritório foi excluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }       
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            dgvExcluiEscritorio.DataSource = cli.ListagemExcluir(txtBuscar.Text);

            AtualizaGrid();

        }


        private void dgvExcluiEscritorio_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pega a linha onde foi originado o evento
            var row = dgvExcluiEscritorio.Rows[e.RowIndex];

            //passa para um método responsável por preencher todos os textboxes  
            EnviaDados(row);
        }

        //Método que atualiza os txtbox com os dados do grid
        public void EnviaDados(DataGridViewRow row)
        {
            txtCodEscritorio.Text = row.Cells["cod_escritorio"].Value.ToString();
            txtNomeEscritorio.Text = row.Cells["nome"].Value.ToString();
            txtCidade.Text = row.Cells["cidade"].Value.ToString();
            txtCredito.Text = row.Cells["credito"].Value.ToString();
        }    
    }
}
