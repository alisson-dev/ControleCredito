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
using Microsoft.Reporting.WinForms;

namespace ControleCredito
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void btnGeraRelatorio_Click(object sender, EventArgs e)
        {
            //estou recebendo informações do frmRelatorio e passando para frmRelEscritorio
            if (mskDataInicio.Text != "" && mskDataFinal.Text != "" && txtBusca.Text != "")
            {
                frmRelEscritorio frmRel = new frmRelEscritorio(this);
                frmRel.Show();
            }
            else
                MessageBox.Show("Preencha os campos corretamente!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            try
            {
                lvResultado.Columns.Clear();
                lvResultado.Items.Clear();

                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT nome_escritorio, cidade, valor_debito, valor_credito, credito_atualizado, data_hora from dados WHERE data_hora BETWEEN @dataInicial and @dataFinal and nome_escritorio = @nome", cn);

                //verifica se os masktextbox estão vazios ou não
                if (mskDataInicio.MaskCompleted && mskDataFinal.MaskCompleted && txtBusca.Text != "")
                {
                    //string inicio = Convert.ToDateTime(mskDataInicio.Text).ToString("yyyy/MM/dd");
                   // string final = Convert.ToDateTime(mskDataFinal.Text).ToString("yyyy/MM/dd");

                    cmd.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(mskDataInicio.Text).ToString("yyyy/MM/dd"));
                    cmd.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(mskDataFinal.Text).ToString("yyyy/MM/dd"));
                    cmd.Parameters.AddWithValue("@nome", txtBusca.Text);

                    //populando listView
                    SqlDataReader dr = cmd.ExecuteReader();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        ColumnHeader ch = new ColumnHeader();
                        ch.Text = dr.GetName(i);
                        lvResultado.Columns.Add(ch);
                    }

                    ListViewItem item;

                    while (dr.Read())
                    {
                        item = new ListViewItem();
                        item.Text = dr.GetValue(0).ToString();

                        for (int i = 1; i < dr.FieldCount; i++)
                        {
                            item.SubItems.Add(dr.GetValue(i).ToString());
                        }
                        lvResultado.Items.Add(item);
                    }

                    dr.Close();
                }
                else
                    MessageBox.Show("Preencha os campos corretamente!");
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL ERRO: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
