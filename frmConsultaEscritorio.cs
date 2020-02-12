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
using System.IO; //A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using PdfSharp;
using PdfSharp.Fonts;



namespace ControleCredito
{
    public partial class frmConsultaEscritorio : Form
    {
        public frmConsultaEscritorio()
        {
            InitializeComponent();
        }    

        private void frmConsultaEscritorio_Load(object sender, EventArgs e)
        {
            
        }


        DataTable tabela = new DataTable();

        public ClienteInformation ObterCliente(string nome)
        {
            ClienteInformation cliente = new ClienteInformation();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            string sql = "SELECT * FROM observacao WHERE nome_escritorio = @nome";
            //string sql = "SELECT * FROM observacao WHERE nome_escritorio= @nome";
            


            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@nome", txtConsulta.Text);

            cn.Open();

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
         
            da.Fill(tabela);


             //dgrConsulta.DataSource = tabela;

            return  cliente;
            
        }       

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            tabela.Rows.Clear();

            Cliente cli = new Cliente();
            dgrConsulta.DataSource = cli.Listagem(txtConsulta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
