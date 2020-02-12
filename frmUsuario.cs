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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtCodUsuario.Enabled = false;
            txtNomeUsuario.Enabled = false;

        }    

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            dgvExcluiUsuario.DataSource = usuario.SelecionaUsuario(txtBuscar.Text);
         
        }


        private void dgvExcluiUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega a linha onde foi originado o evento
            var row = dgvExcluiUsuario.Rows[e.RowIndex];

            //passa para um método responsável por preencher todos os textboxes  
            EnviaDados(row);
        }

        //Método que atualiza os txtbox com os dados do grid
        public void EnviaDados(DataGridViewRow row)
        {
            txtCodUsuario.Text = row.Cells["cod_login"].Value.ToString();
            txtNomeUsuario.Text = row.Cells["nome"].Value.ToString();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtCodUsuario.Text.Length == 0)
            {
                MessageBox.Show("Um usuário deve ser selecionado");
            }
            else
            {
                try
                {
                    int codigo = Convert.ToInt32(txtCodUsuario.Text);

                    Usuario usuario = new Usuario();
                    usuario.ExcluiUsuario(codigo);
                   
                    MessageBox.Show("Usuário excluido com sucesso!");
                  

                    txtCodUsuario.Clear();
                    txtNomeUsuario.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void AtualizaGrid()
        {
            Usuario usuario = new Usuario();
            dgvExcluiUsuario.DataSource = usuario.SelecionaUsuario(txtBuscar.Text);

            try
            {
                txtCodUsuario.Text = dgvExcluiUsuario[0, dgvExcluiUsuario.CurrentRow.Index].Value.ToString();
                txtNomeUsuario.Text = dgvExcluiUsuario[1, dgvExcluiUsuario.CurrentRow.Index].Value.ToString();

                if (txtBuscar.Text == "")
                {
                    txtCodUsuario.Text = "";
                    txtNomeUsuario.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
