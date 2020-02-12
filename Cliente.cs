using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControleCredito
{
    public class Cliente
    {
        //métodos para cliente(escritório)

        public void Incluir(ClienteInformation cliente)
        {

            //conexão
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //nome da stored procedure (inserir procedure no banco)
                cmd.CommandText = "insere_cliente"; // inserir aqui a stored procedure

                //parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pcod_escritorio = new SqlParameter("@cod_escritorio", System.Data.SqlDbType.Int);
                pcod_escritorio.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcod_escritorio);

                SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.NVarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pcidade = new SqlParameter("@cidade", System.Data.SqlDbType.NVarChar, 100);
                pcidade.Value = cliente.Cidade;
                cmd.Parameters.Add(pcidade);

                SqlParameter pcredito = new SqlParameter("@credito", System.Data.SqlDbType.Decimal);
                pcredito.Value = cliente.Credito;
                cmd.Parameters.Add(pcredito);

                //SqlParameter pprotocolo_er = new SqlParameter("@protocolo_er", System.Data.SqlDbType.Int);
                //pprotocolo_er.Value = cliente.ProtocoloER;
                //cmd.Parameters.Add(pprotocolo_er);

                //SqlParameter pdata = new SqlParameter("@data", System.Data.SqlDbType.DateTime);                           
                //pdata.Value = cliente.Data;
                //cmd.Parameters.Add(pdata);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.CodigoEscritorio = (Int32)cmd.Parameters["@cod_escritorio"].Value;


            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int codigo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.stringConexao;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_escritorio";

                SqlParameter pcodigo = new SqlParameter("@cod_escritorio", SqlDbType.Int);

                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                cmd.ExecuteNonQuery();

                //int resultado = cmd.ExecuteNonQuery();
                //if (resultado != 1)
                //{
                //    throw new Exception("Não foi possível excluir Escritório" + codigo);
                //}

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Listagem(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_escritorio";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", System.Data.SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable ListagemExcluir(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select_escritorio";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", System.Data.SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable ListagemRelatorio(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_escritorioRel";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", System.Data.SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable ListagemAlterar(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select_escritorio";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", System.Data.SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        public void Alterar(ClienteInformation cliente)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.stringConexao;                       
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_escritorio";

                SqlParameter pcodigo = new SqlParameter("@cod_escritorio", SqlDbType.Int);
                pcodigo.Value = cliente.CodigoEscritorio;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pcidade = new SqlParameter("@cidade", SqlDbType.NVarChar, 50);
                pcidade.Value = cliente.Cidade;
                cmd.Parameters.Add(pcidade);

                SqlParameter pcredito = new SqlParameter("@credito", SqlDbType.Decimal);
                pcredito.Value = cliente.Credito;
                cmd.Parameters.Add(pcredito);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("SQL ERRO:" + ex.Number);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
           
        }
    }

}

