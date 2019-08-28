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
    public static class CTaxaEmbarque
    {
        //INSERIR --- CONCLUIR VERIFICAÇÕES
        public static void Inserir(MTaxaEmbarque item)
        {
            //REGEX PARA VALIDAR NUMEROS
            Regex validarNumero = new Regex(@"^\d+$");
            //Regex validarData = new Regex(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/((1[2-9]|[2-9][0-9])[0-9]{2})");
            //Regex validarData = new Regex(@"(\d{2}\/\d{2}\/\d{4} \d{2}:\d{2})");

            if (item == null)
            {
                throw new Exception("Taxa de Embarque esta incorreta");
            }

            if (item.EmpresaID == 0)
            {
                throw new Exception("É necessário selecionar uma empresa");
            }

            if(item.Data == "00/00/0000" || item.Data == "/  /") 
            {
                throw new Exception("A data esta incorreta");
            }

            if(item.Quantidade <= 0)
            {
                throw new Exception("Campo Quantidade não pode ser negativo ou igual a zero");
            }

            if(item.ValorTarifa <= 0)
            {
                throw new Exception("Campo Valor Tarifa não pode ser negativo ou igual a zero");
            }

            //VALIDAR DATA
            //if (validarData.IsMatch(item.Data))
            //{
            //    throw new Exception("A data esta incorreta");
            //}

            //corrigir aqui - esta invalidando tudo - alterar o regex
            //if (validarData.IsMatch(item.Data))
            //{
            //    throw new Exception("A data esta incorreta");
            //}

            try
            {
                DTaxaEmbarque.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //PESQUISAR
        public static List<MTaxaEmbarque> Pesquisar(MTaxaEmbarque item)
        {
            List<MTaxaEmbarque> retorno = null;

            if (item.id == 0)
            {
                retorno = DTaxaEmbarque.Pesquisar(item);

                //RETORNO SE NÃO HOUVER NENHUM CADASTRO
                if (retorno == null)
                {
                    throw new Exception("A Pesquisa não retornou nenhum cadastro!");
                }


            }
            return retorno;
        }

        //EXCLUIR
        public static void Excluir(MTaxaEmbarque item)
        {
            if (item.id == 0)
                throw new Exception("Nome da Empresa Inválida");

            try
            {
                DTaxaEmbarque.Excluir(item);
            }
            catch
            {
                throw;
            }
        }

        //OBTER
        public static MTaxaEmbarque Obter(MTaxaEmbarque item)
        {
            MTaxaEmbarque retorno = null;

            if (item != null)
            {
                retorno = DTaxaEmbarque.Obter(item);
            }

            return retorno;
        }

        //ATUALIZAR
        public static void Atualizar(MTaxaEmbarque item)
        {
            if (item == null)
            {
                throw new Exception("Objeto PESSOA inválido");
            }

            if (item.EmpresaID == 0)
            {
                throw new Exception("É necessário selecionar uma empresa");
            }

            if (item.Data == "00/00/0000" || item.Data == "/  /")
            {
                throw new Exception("A data esta incorreta");
            }

            if (item.Quantidade <= 0)
            {
                throw new Exception("Campo Quantidade não pode ser negativo ou igual a zero");
            }

            if (item.ValorTarifa <= 0)
            {
                throw new Exception("Campo Valor Tarifa não pode ser negativo ou igual a zero");
            }

            try
            {
                DTaxaEmbarque.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }


    }
}
