using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ControleCredito
{
    public class Usuario
    {
        public void Incluir(UsuarioInformation usuario)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //nome da estored procedure
                cmd.CommandText = "insere_usuario";
                //parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                pcodigo.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.NVarChar, 12);
                pnome.Value = usuario.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter psenha = new SqlParameter("@senha", System.Data.SqlDbType.NVarChar, 12);
                psenha.Value = usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pnivel = new SqlParameter("@nivel", System.Data.SqlDbType.NVarChar, 15);
                pnivel.Value = usuario.Nivel;
                cmd.Parameters.Add(pnivel);

                cn.Open();
                cmd.ExecuteNonQuery();

                usuario.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable SelecionaUsuario(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_Usuario";
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

        public void ExcluiUsuario(int codigo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.stringConexao;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_usuario";

                SqlParameter pcodigo = new SqlParameter("@cod_login", SqlDbType.Int);

                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                cmd.ExecuteNonQuery();

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

        public void AlteraUsuario(UsuarioInformation usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_usuario";

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 12);
                pnome.Value = usuario.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter psenha = new SqlParameter("@senha", SqlDbType.NVarChar, 12);
                psenha.Value = usuario.Senha;
                cmd.Parameters.Add(psenha);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO:" + ex.Number);
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
    }
}
