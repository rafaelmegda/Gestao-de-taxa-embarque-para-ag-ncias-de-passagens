
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DEmpresa
    {
        //INSERIR
        public static void Inserir(MEmpresa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!!");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                "INSERT INTO TBEmpresa(NomeEmpresa) " +
                "VALUES(@NomeEmpresa)";

            SqlParameter param = new SqlParameter("@NomeEmpresa", SqlDbType.VarChar);
            param.Value = item.NomeEmpresa;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Empresa Já Cadastrada!");
            }
            finally
            {
                conexao.Close();
            }
        }

        //PESQUISAR
        public static List<MEmpresa> Pesquisar(MEmpresa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!!");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT id, NomeEmpresa FROM TBEmpresa WHERE 1 = 1 ";

            if (item.NomeEmpresa.Trim() != "")
            {
                comando.CommandText += " AND NomeEmpresa LIKE @NomeEmpresa ";

                SqlParameter param = new SqlParameter("@NomeEmpresa", SqlDbType.VarChar);
                param.Value = "%" + item.NomeEmpresa + "%";
                comando.Parameters.Add(param);
            }

            if (item.id != 0)
            {
                comando.CommandText += " AND id = @id ";

                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Value = item.id;
                comando.Parameters.Add(param);
            }

            SqlDataReader reader = comando.ExecuteReader();

            List<MEmpresa> retorno = null;

            while (reader.Read())
            {
                if (retorno == null)
                    retorno = new List<MEmpresa>();

                MEmpresa empresa = new MEmpresa();
                empresa.id = int.Parse(reader["id"].ToString());
                empresa.NomeEmpresa = reader["NomeEmpresa"].ToString();

                retorno.Add(empresa);
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //EXCLUIR 
        public static void Excluir(MEmpresa item)
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!!");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM TBEmpresa where NomeEmpresa = @NomeEmpresa";

            SqlParameter param = new SqlParameter("@NomeEmpresa", SqlDbType.VarChar);
            param.Value = item.NomeEmpresa;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        //OBTER 
        public static MEmpresa Obter(MEmpresa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!!");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = " SELECT id, NomeEmpresa FROM TBEmpresa " +
                " WHERE NomeEmpresa = @NomeEmpresa ";

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = item.id;
            comando.Parameters.Add(param);

            param = new SqlParameter("@NomeEmpresa", SqlDbType.VarChar);
            param.Value = item.NomeEmpresa;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            MEmpresa retorno = null;

            if (reader.Read())
            {
                retorno = new MEmpresa();

                retorno.id = int.Parse(reader["id"].ToString());
                retorno.NomeEmpresa = reader["NomeEmpresa"].ToString();

            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //ATUALIZAR 
        public static void Atualizar(MEmpresa item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!!");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "UPDATE TBEmpresa SET NomeEmpresa = @NomeEmpresa " +
                " WHERE id = @id";

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = item.id;
            comando.Parameters.Add(param);

            param = new SqlParameter("@NomeEmpresa", SqlDbType.VarChar);
            param.Value = item.NomeEmpresa;
            comando.Parameters.Add(param);
                       

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("O comando não pode ser executado");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
