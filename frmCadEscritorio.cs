using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace ControleCredito
{
    public partial class frmCadEscritorio : Form
    {
        public frmCadEscritorio()
        {
            InitializeComponent();

        }

        ClienteInformation cliente = new ClienteInformation();
  
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                  
                cliente.Nome = txtNome.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Credito = Convert.ToDecimal(txtCredito.Text);
                ValidaCampos();

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERROR: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ValidaCampos()
        {
            //else if (Convert.ToDecimal(txtCredito.Text) < 0)
            //{
            //    MessageBox.Show("Valor não pode ser negativo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCidade.BackColor = Color.Red;

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo escritório não pode ser vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Campo Cidade não pode ser vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
            }
            else if (Convert.ToDecimal(txtCredito.Text) <= 0)
            {
                MessageBox.Show("Insira um valor acima de zero!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCredito.Focus();
            }
            else if (txtNome.Text != string.Empty && txtCidade.Text != string.Empty && Convert.ToDecimal(txtCredito.Text) > 0)
            {
                Cliente objCli = new Cliente();
                objCli.Incluir(cliente);

                MessageBox.Show("Cadastro Realizado com Sucesso!");
                txtNome.Clear();
                txtCredito.Clear();
                txtCidade.Clear();
                txtNome.Focus();
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCadastrar_Click(sender, e);
            }
        }
   
        private void txtCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar_Click(sender, e);
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar_Click(sender, e);
            }
        }       
    }
}
