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
    public partial class frmAlteraUsuario : Form
    {
        public frmAlteraUsuario()
        {
            InitializeComponent();
        }

        private void frmAlteraUsuario_Load(object sender, EventArgs e)
        {
            txtCodUsuario.Enabled = false;
            txtNomeUsuario.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT cod_login, nome FROM usuario WHERE nome = @nome";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;
           
            SqlCommand cmd = new SqlCommand(sql, cn);

            SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.NVarChar, 100);
            pnome.Value = txtBuscar.Text;
            cmd.Parameters.Add(pnome);

            cn.Open();    
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read()) //Verifica se conseguiu trazer informações
            {
                txtCodUsuario.Text = rd["cod_login"].ToString();
                txtNomeUsuario.Text = rd["nome"].ToString();        
            }
        }      

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtConfirmaSenha.Text == "")
            {
                MessageBox.Show("Os campos SENHA e CONFIRMA SENHA devem ser preenchidos!");
            }
            else if (txtCodUsuario.Text == "")
            {
                MessageBox.Show("Um Usuário deve ser selecionado para alteração!");
            }
            else if(txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("Informe as senhas iguais em ambos os campos! ");
            }
            else
                try
                {
                    UsuarioInformation usuario = new UsuarioInformation();

                    usuario.Nome = txtNomeUsuario.Text;
                    usuario.Senha = txtSenha.Text;

                    Usuario us = new Usuario();
                    us.AlteraUsuario(usuario);
            
                    MessageBox.Show("Senha atualizada com sucesso!");
                    LimpaCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        public void LimpaCampos()
        {
            txtBuscar.Text = "";
            txtCodUsuario.Text = "";
            txtConfirmaSenha.Text = "";
            txtNomeUsuario.Text = "";
            txtSenha.Text = "";

            txtBuscar.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
