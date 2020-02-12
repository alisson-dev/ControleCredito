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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //para salvar o nome do usuario logado
        public string UsuarioLogado1
        {
            get { return UsuarioLogado; }
        }     

        public static string UsuarioLogado;
        public static string nivel;

        private bool logado = false;

        bool VerificaLogin()
        {
            bool result = false;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            try
            {
 
                SqlCommand cmd = new SqlCommand("SELECT nivel FROM usuario WHERE nome = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "';", cn);
                cn.Open();

                SqlDataReader dados = cmd.ExecuteReader();
                result = dados.HasRows;

                UsuarioLogado = txtUsuario.Text;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return result;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool result = VerificaLogin();
                                
            logado = result;

            if (result)
            {              
                if (VerificaNivel().Equals("administrador"))
                {
                    MessageBox.Show("Bem Vindo " + UsuarioLogado + "!");
                    frmMenu menu = new frmMenu(UsuarioLogado);                    

                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bem Vindo " + UsuarioLogado + "!");
                    frmMenuUsuario menuUsuario = new frmMenuUsuario(UsuarioLogado);
                    
                    this.Hide();
                    menuUsuario.ShowDialog();
                }            
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto");
                txtUsuario.Text = "";
                txtUsuario.Focus();
                txtSenha.Text = "";
            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logado)
            {
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);

            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        //Retorna 0 se não encontrar o valor nivel
        public string VerificaNivel()
        {
            string nivel;
          
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            string sql = ("SELECT nivel FROM usuario WHERE nome = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "';");
            cn.Open();

            SqlCommand cmd = new SqlCommand(sql, cn);
                      
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                return nivel = rd.GetString(0);
            }

            return null;
        }
    }

}
