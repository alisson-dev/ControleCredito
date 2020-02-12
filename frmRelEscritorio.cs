using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ControleCredito
{
    public partial class frmRelEscritorio : Form
    {
        //recebo as informações do form frmRelatorio
        public frmRelEscritorio(frmRelatorio rel)
        {
            InitializeComponent();

            txtDataInicio.Text = rel.mskDataInicio.Text.ToString();
            txtDataFinal.Text = rel.mskDataFinal.Text.ToString();
            txtNome.Text = rel.txtBusca.Text;

            txtDataInicio.Enabled = false;
            txtDataFinal.Enabled = false;
            txtNome.Enabled = false;
        }     

        private void frmRelEscritorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CREDITODataRel.DADOS' table. You can move, or remove it, as needed.           
         
            //recebo as informações do frmRelatorio para gerar o report view
            string inicio = txtDataInicio.Text;
            string final = txtDataFinal.Text;
            string nome = txtNome.Text;

            this.DADOSTableAdapter.Fill(this.CREDITODataRel.DADOS, Convert.ToDateTime(inicio), Convert.ToDateTime(final),txtNome.Text);

            //recebo as variaveis para executar o select no DataSet

            this.reportViewer1.RefreshReport();
          
        }
    }
}
