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
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioInformation usuario = new UsuarioInformation();

                if (txtNome.Text != "" && txtSenha.Text != "" && cbxNivel.Text != "")
                {
                    usuario.Nome = txtNome.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Nivel = cbxNivel.Text;
                    //usuario.Senha = Convert.ToInt32(txtSenha.Text);
                    ValidaCampos();

                    Usuario objUsuario = new Usuario();
                    objUsuario.Incluir(usuario);

                    MessageBox.Show("Usuário Salvo com Sucesso!");

                    this.Close();
                }
                else
                    MessageBox.Show("Preencha os campos corretamente!");
            }
            catch(SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("ERRO: " + ex.Message );
            }
           
        }

        public void ValidaCampos()
        {

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome não pode ser vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }           
            else if (txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                txtNome.Clear();
                txtSenha.Clear();

                txtNome.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(sender, e);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(sender, e);
            }
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
