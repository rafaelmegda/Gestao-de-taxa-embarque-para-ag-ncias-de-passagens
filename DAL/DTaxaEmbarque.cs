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
    public static class DTaxaEmbarque
    {
        //INSERIR
        public static void Inserir(MTaxaEmbarque item)
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
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!! conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO TBTaxaDeEmbarque (Data, " +
                "Quantidade, ValorTarifa, ValorTotal, CODEmpresaID) VALUES(@Data, " +
                "@Quantidade, @ValorTarifa, @ValorTotal, @CODEmpresaID)";

            SqlParameter param = new SqlParameter("@Data", SqlDbType.VarChar);
            param.Value = item.Data;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Quantidade", SqlDbType.Int);
            param.Value = item.Quantidade;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ValorTarifa", SqlDbType.Decimal);
            param.Value = item.ValorTarifa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ValorTotal", SqlDbType.Decimal);
            param.Value = item.ValorTotal;
            comando.Parameters.Add(param);

            param = new SqlParameter("@CODEmpresaID", SqlDbType.Int);
            param.Value = item.EmpresaID;
            comando.Parameters.Add(param);


            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Erro no Cadastro no Banco de Dados!");
            }
            finally
            {
                conexao.Close();
            }
        }

        //PESQUISAR
        public static List<MTaxaEmbarque> Pesquisar(MTaxaEmbarque item)
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
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!! conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = " SELECT TE.id, TE.Data, " +
                " TE.Quantidade, TE.ValorTarifa, EM.NomeEmpresa, TE.ValorTotal, TE.CODEmpresaID FROM " +
                "TBTaxaDeEmbarque AS TE JOIN TBEmpresa AS EM ON TE.CODEmpresaID = EM.id WHERE 1 = 1 ";

            if (item.EmpresaID != 0)
            {
                comando.CommandText += " AND TE.CODEmpresaID = @CODEmpresaID ";

                SqlParameter param = new SqlParameter("@CODEmpresaID", SqlDbType.Int);
                param.Value = item.EmpresaID;
                comando.Parameters.Add(param);
            }

            if (item.Data != "  /  /") //melhorar esta pesquisa aqui posteriormente
            {
                comando.CommandText += " AND TE.Data = @Data ";

                SqlParameter param = new SqlParameter("@Data", SqlDbType.VarChar);
                param.Value = item.Data;
                comando.Parameters.Add(param);
            }


            SqlDataReader reader = comando.ExecuteReader();

            List<MTaxaEmbarque> retorno = null;

            while (reader.Read())
            {
                if (retorno == null)
                    retorno = new List<MTaxaEmbarque>();

                MTaxaEmbarque empresa = new MTaxaEmbarque();
                empresa.id = int.Parse(reader["id"].ToString());
                empresa.Data = reader["data"].ToString();
                empresa.Quantidade = int.Parse(reader["Quantidade"].ToString());
                empresa.ValorTarifa = Decimal.Parse(reader["ValorTarifa"].ToString());
                empresa.ValorTotal = Decimal.Parse(reader["ValorTotal"].ToString());
                empresa.NomeDaEmpresa = reader["NomeEmpresa"].ToString();
                empresa.EmpresaID = int.Parse(reader["CODEmpresaID"].ToString());

                retorno.Add(empresa);
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }

        //EXCLUIR 
        public static void Excluir(MTaxaEmbarque item)
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
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!! conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM TBTaxaDeEmbarque where id = @id";

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = item.id;
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
        public static MTaxaEmbarque Obter(MTaxaEmbarque item)
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
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!! conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = " SELECT id, Data, Quantidade, " +
                "ValorTarifa, ValorTotal, CODEmpresaID " +
                "FROM TBTaxaDeEmbarque WHERE id = @id";

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = item.id;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            MTaxaEmbarque retorno = null;

            if (reader.Read())
            {
                retorno = new MTaxaEmbarque();

                retorno.id = int.Parse(reader["id"].ToString());
                retorno.Data = reader["data"].ToString();
                retorno.Quantidade = int.Parse(reader["Quantidade"].ToString());
                retorno.ValorTarifa = Decimal.Parse(reader["ValorTarifa"].ToString());
                retorno.ValorTotal = Decimal.Parse(reader["ValorTotal"].ToString());

                retorno.EmpresaID = int.Parse(reader["CODEmpresaID"].ToString());
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }


        //ATUALIZAR 
        public static void Atualizar(MTaxaEmbarque item)
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
                throw new Exception("O banco de dados não esta conectado, para utilizar o sistema primeiro inicie o gerenciador de Banco de Dados!! conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "UPDATE TBTaxaDeEmbarque SET data = @data, " +
                "Quantidade = @Quantidade, ValorTarifa = @ValorTarifa, " +
                "ValorTotal = @ValorTotal, CODEmpresaID = @CODEmpresaID " +
                " WHERE id = @id ";

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = item.id;
            comando.Parameters.Add(param);

            param = new SqlParameter("@data", SqlDbType.VarChar);
            param.Value = item.Data;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Quantidade", SqlDbType.Int);
            param.Value = item.Quantidade;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ValorTarifa", SqlDbType.Decimal);
            param.Value = item.ValorTarifa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ValorTotal", SqlDbType.Decimal);
            param.Value = item.ValorTotal;
            comando.Parameters.Add(param);

            param = new SqlParameter("@CODEmpresaID", SqlDbType.Int);
            param.Value = item.EmpresaID;
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
