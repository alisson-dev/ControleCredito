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
    public partial class frmDebito : Form
    {
        public frmDebito()
        {
            InitializeComponent();

        }

        //passando parametro para outro form
        public frmDebito(string nome, string saldo, string codigo, string protocoloER)
        {
            InitializeComponent();

            txtNome.Text = nome;
            txtCredito.Text = saldo;
            txtCodigo.Text = codigo;
            //txtProtocoloER.Text = protocoloER;
        }

        private void frmDebito_Load(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
            txtCodigo.Enabled = false;
            txtCredito.Enabled = false;
            txtCreditoAtualizado.Enabled = false;
            txtValorDebito.Enabled = false;

            btnSalvar.Enabled = false;
            btnObservacao.Enabled = false;

            DateTime data = DateTime.Now;
            lblData.Text = data.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public decimal valor;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtValorDebito.Text) <= 0)
            {
                MessageBox.Show("Insira um valor acima de zero!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorDebito.Focus();
            }
            else if (Convert.ToDecimal(txtValorDebito.Text) > 0)
            {
                valor = Convert.ToDecimal(txtCredito.Text) - Convert.ToDecimal(txtValorDebito.Text);
                txtCreditoAtualizado.Text = Convert.ToString(valor);
                btnObservacao.Enabled = true;
            }      

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.stringConexao;

                string sql = "UPDATE escritorio SET credito = @credito WHERE cod_escritorio=@cod_escritorio";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@cod_escritorio", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@credito", txtCreditoAtualizado.Text);

                cn.Open();
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Dados salvos com sucesso!");
                this.Close();
            }
        }

        public ClienteInformation ObterCliente(string nome)
        {

            ClienteInformation cliente = new ClienteInformation();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            string sql = "SELECT * FROM escritorio WHERE nome=@nome";

            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);

            cn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                try
                {
                    cliente.CodigoEscritorio = Convert.ToInt32(leitor["cod_escritorio"].ToString());
                    cliente.Nome = leitor["nome"].ToString();
                    cliente.Cidade = leitor["cidade"].ToString();
                    cliente.Saldo = Convert.ToDecimal(leitor["credito"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }

            cn.Close();

            return cliente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                ClienteInformation cliente = ObterCliente(txtNome.SelectedText.ToString());

                txtCodigo.Text = cliente.CodigoEscritorio.ToString();
                txtCidade.Text = cliente.Cidade.ToString();
                txtNome.Text = cliente.Nome.ToString();
                txtCredito.Text = cliente.Saldo.ToString();

                txtValorDebito.Enabled = true;
                ValidaCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void ValidaCampos()
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome não pode ser vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtNome.Text != string.Empty)
            {
                txtNome.Enabled = false;
            }

        }

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.stringConexao;

                string sql = @" INSERT INTO dados (observacao, usuario, cod_escritorio, nome_escritorio, cidade, valor_debito, credito_Atualizado, data_hora) values(@observacao, @usuario, @codigo, @nome, @cidade, @valDebito, @creditoAtualizado, @data_hora)";

                SqlCommand cmd = new SqlCommand(sql, cn);

                txtValorDebito.Text = txtValorDebito.Text.Replace(",", ".");
                txtCreditoAtualizado.Text = txtCreditoAtualizado.Text.Replace(",", ".");

                frmLogin login = new frmLogin();

                cmd.Parameters.AddWithValue("@observacao", txtObs.Text);
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@valDebito", txtValorDebito.Text);
                cmd.Parameters.AddWithValue("@creditoAtualizado", txtCreditoAtualizado.Text);
                cmd.Parameters.AddWithValue("@data_hora",Convert.ToDateTime(lblData.Text));
                cmd.Parameters.AddWithValue("@usuario", login.UsuarioLogado1);

                cn.Open();
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Dados salvos com sucesso, Pressione salvar para concluir!");
                btnSalvar.Enabled = true;
            }
        }

        private void txtCredito_Leave(object sender, EventArgs e)
        {
            txtCredito.Text = Convert.ToDouble(txtCredito.Text).ToString("C");
        }

       
        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtCredito.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
    }

}
