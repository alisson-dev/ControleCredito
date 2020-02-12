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
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {
            txtCodEscritorio.Enabled = false;          
            //AtualizaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            dgvAlteraEscritorio.DataSource = cli.ListagemAlterar(txtBuscar.Text);

            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            Cliente cli = new Cliente();
            dgvAlteraEscritorio.DataSource = cli.ListagemExcluir(txtBuscar.Text);

            try
            {
                txtCodEscritorio.Text = dgvAlteraEscritorio[0, dgvAlteraEscritorio.CurrentRow.Index].Value.ToString();
                txtNomeEscritorio.Text = dgvAlteraEscritorio[1, dgvAlteraEscritorio.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvAlteraEscritorio[2, dgvAlteraEscritorio.CurrentRow.Index].Value.ToString();
                txtCredito.Text = dgvAlteraEscritorio[3, dgvAlteraEscritorio.CurrentRow.Index].Value.ToString();

                if (txtBuscar.Text == "")
                {
                    txtCodEscritorio.Text = "";
                    txtNomeEscritorio.Text = "";
                    txtCidade.Text = "";
                    txtCredito.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           if(txtCodEscritorio.Text == "")
            {
                MessageBox.Show("Um escritório deve ser selecionado para alteração!");
            }
           else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();

                    cliente.CodigoEscritorio = Convert.ToInt32(txtCodEscritorio.Text);
                    cliente.Nome = txtNomeEscritorio.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Credito = Convert.ToDecimal(txtCredito.Text);

                    Cliente cli = new Cliente();
                    cli.Alterar(cliente);
                    MessageBox.Show("Escritório atualizado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            AtualizaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAlteraEscritorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = dgvAlteraEscritorio.Rows[e.RowIndex];
            EnviaDados(row);
        }

        public void EnviaDados(DataGridViewRow row)
        {
            txtCodEscritorio.Text = row.Cells["cod_escritorio"].Value.ToString();
            txtNomeEscritorio.Text = row.Cells["nome"].Value.ToString();
            txtCidade.Text = row.Cells["cidade"].Value.ToString();
            txtCredito.Text = row.Cells["credito"].Value.ToString();
        }
    }   
}
