using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    public static class CEmpresa 
    {
        //INSERIR
        public static void Inserir(MEmpresa item)
        {
            if (item == null)
            {
                throw new Exception("Empresa digitada esta inválida");
            }

            //NÃO SALVAR CAMPO EM BRANCO OU COM MAIS DE 50 CHARS
            if (item.NomeEmpresa.Trim() == "" || item.NomeEmpresa.Length > 50)
            {
                throw new Exception("O Nome da empresa não pode esta vazia ou conter mais de 50 caracteres");
            }

            //NÃO PERMITIR SALVAR SOMENTE NUMEROS
            Regex validarNumero = new Regex (@"^\d+$");
            if (validarNumero.IsMatch(item.NomeEmpresa))
            {
                throw new Exception("Nome da Empresa não pode conter somente numeros");
            }

            try
            {
                DEmpresa.Inserir(item);
            }
            catch
            {
                throw;
            }
        }


        //PESQUISAR
        public static List<MEmpresa> Pesquisar(MEmpresa item)
        {
            List<MEmpresa> retorno = null;

            if (item.NomeEmpresa != null && item.NomeEmpresa.Length <= 50)
            {
                retorno = DEmpresa.Pesquisar(item);

                //RETORNO SE NÃO HOUVER NENHUM CADASTRO
                if (retorno == null)
                {
                    throw new Exception("A Pesquisa não retornou nenhum cadastro!");
                }
            }

            return retorno;
        }

        //EXCLUIR
        public static void Excluir(MEmpresa item)
        {
            if (item.NomeEmpresa.Trim() == "")
                throw new Exception("Nome da Empresa Inválida");

            try
            {
                DEmpresa.Excluir(item);
            }
            catch
            {
                throw;
            }
        }

        //OBTER
        public static MEmpresa Obter(MEmpresa item)
        {
            MEmpresa retorno = null;

            if (item != null)
            {
                retorno = DEmpresa.Obter(item);
            }

            return retorno;
        }

        //ATUALIZAR
        public static void Atualizar(MEmpresa item)
        {
            if (item == null)
            {
                throw new Exception("Empresa digitada esta inválida");
            }

            //NÃO SALVAR CAMPO EM BRANCO OU COM MAIS DE 50 CHARS
            if (item.NomeEmpresa.Trim() == "" || item.NomeEmpresa.Length > 50)
            {
                throw new Exception("O Nome da empresa não pode esta vazia ou conter mais de 50 caracteres");
            }

            //NÃO SALVAR NUMEROS
            Regex validarNumero = new Regex(@"^\d+$");
            if (validarNumero.IsMatch(item.NomeEmpresa))
            {
                throw new Exception("Nome da Empresa não pode conter somente numeros");
            }

            try
            {
                DEmpresa.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
