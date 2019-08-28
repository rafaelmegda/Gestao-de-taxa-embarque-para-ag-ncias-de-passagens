using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class VTaxaCadastrar : Form
    {
        MTaxaEmbarque atual = null;

        public VTaxaCadastrar(MTaxaEmbarque item)
        {
            InitializeComponent();
            item = CTaxaEmbarque.Obter(item);
            atual = item;
        }

        //BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (dadosValidos)
            {
                MTaxaEmbarque taxa = new MTaxaEmbarque();

                taxa.EmpresaID = int.Parse(cbSelecionarEmpresa.SelectedValue.ToString());
                taxa.Data = txtData.Text.Trim();
                try
                {
                    taxa.Quantidade = int.Parse(txtQuantidade.Text.Trim());
                    taxa.ValorTarifa = Decimal.Parse(txtValorTarifa.Text.Trim());
                    taxa.ValorTotal = Decimal.Parse(txtValorTotal.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Existem campos obrigatórios sem preenchimento!");
                }
                
                

                try
                {
                    if (atual != null)
                    {
                        taxa.id = atual.id;
                        CTaxaEmbarque.Atualizar(taxa);
                        MessageBox.Show("Campo alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CTaxaEmbarque.Inserir(taxa);
                        MessageBox.Show("Campo salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        //LOAD TELA
        private void VTaxaCadastrar_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar Taxa de Embarque";
            }
            else
            {
                this.Text = "Inserir Taxa de Embarque";
            }

            //PREENCHER COMBOBOX COM O NOME DA EMPRESA
            MEmpresa item = new MEmpresa();
            item.NomeEmpresa = "";
            List<MEmpresa> lista = CEmpresa.Pesquisar(item);

            if (lista == null)
                lista = new List<MEmpresa>();

            item.NomeEmpresa = "[Escolha uma Empresa]";
            lista.Insert(0, item);

            cbSelecionarEmpresa.DataSource = lista;

            try
            {
                if (atual != null)
                {
                    cbSelecionarEmpresa.SelectedValue = atual.EmpresaID.Value;
                    txtData.Text = atual.Data.ToString();
                    txtQuantidade.Text = atual.Quantidade.ToString();
                    txtValorTarifa.Text = atual.ValorTarifa.ToString();
                    txtValorTotal.Text = atual.ValorTotal.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //SOMAR O TEXTBOX VALOR TOTAL AUTOMATICAMENTE
        void Soma()
        {
            decimal valor1 = 0, valor2 = 0, resultado = 0;

            if (txtQuantidade.Text != "")
            {
                valor1 = decimal.Parse(txtQuantidade.Text);
                try
                {
                    valor2 = decimal.Parse(txtValorTarifa.Text);
                }
                catch
                {
                    MessageBox.Show("O campo valor não pode estar em Branco, preencha o valor com virgula!");
                }

                resultado = (valor1 * valor2);
            }

            txtValorTotal.Text = resultado.ToString();
        }

        private void txtValorTarifa_Leave(object sender, EventArgs e)
        {
            Soma();
        }


        //FUNÇÃO PARA CAPTURAR O DIGITO EM EXECUÇÃO E ACEITAR APENAS NUMEROS E BACKSPACE
        private void validarCampoNumerico(KeyPressEventArgs e)
        {
            //PERMITE APENAS NUMEROS E O BACKSPACE
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //VALIDAR O CAMPO QUANTIDADE
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoNumerico(e);
        }

        //FUNÇÃO PARA CAPTURAR O DIGITO EM EXECUÇÃO E ACEITAR APENAS NUMEROS E VIRGULA
        private void validarCampoNumericoComVirgula(KeyPressEventArgs e)
        {
            //PERMITE APENAS NUMEROS, BACKSPACE E VRIGULA
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        //ACEITAR APENAS NUMERO NO CAMPO QUANTIDADE
        private void txtValorTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoNumericoComVirgula(e);
        }


    }
}
