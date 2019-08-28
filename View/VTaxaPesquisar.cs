using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class VTaxaPesquisar : Form
    {
        public VTaxaPesquisar()
        {
            InitializeComponent();
        }

        //LOAD DA TELA
        private void VTaxaPesquisar_Load(object sender, EventArgs e)
        {
            //PREENCHER COMBOBOX COM O NOME DA EMPRESA
            MEmpresa item = new MEmpresa();
            item.NomeEmpresa = "";
            List<MEmpresa> lista = CEmpresa.Pesquisar(item);

            if (lista == null)
                lista = new List<MEmpresa>();

            item.NomeEmpresa = "[SELECIONE PARA PESQUISAR]";
            lista.Insert(0, item);

            cbSelecionarEmpresaPesquisar.DataSource = lista;

        }

        //CARREGAR VALOR TOTAL DAS COLUNAS
        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (dtPesquisarTaxa.Rows.Count > 0)
            {
                try
                {
                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in dtPesquisarTaxa.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells["valorTotalDataGridViewTextBoxColumn"].Value);
                    }
                    lbValorTotal.Text = Convert.ToString(valorTotal);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Feche o sistema e realize a pesquisa novamente para calcular o valor das taxas");
                }
            }
        }

        private void btnSomarValorTotal_Click_1(object sender, EventArgs e)
        {
            txtValorTotal_Leave(sender, e);
            
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTÃO PESQUISAR
        private void btnPesquisarTaxa_Click(object sender, EventArgs e)
        {
            lbValorTotal.Text = string.Empty;
            MTaxaEmbarque taxa = new MTaxaEmbarque();

            taxa.EmpresaID = int.Parse(cbSelecionarEmpresaPesquisar.SelectedValue.ToString());
            taxa.Data = txtData.Text;


            dtPesquisarTaxa.DataSource = null;

            try
            {
                dtPesquisarTaxa.DataSource = CTaxaEmbarque.Pesquisar(taxa);
            }
            catch 
            {
                MessageBox.Show("Não foi encontrados dados de acordo com a pesquisa realizada",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTÃO INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VTaxaCadastrar(null);
            form.ShowDialog();

            btnPesquisarTaxa_Click(null, null);
        }

        //BOTÃO LIMPAR
        private void btnLimparPesquisaTaxa_Click(object sender, EventArgs e)
        {
            lbValorTotal.Text = string.Empty;
            MTaxaEmbarque taxa = new MTaxaEmbarque();

            cbSelecionarEmpresaPesquisar.SelectedIndex = 0;
            txtData.Text = ("");
            dtPesquisarTaxa.DataSource = null;

        }

        //BOTÃO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtPesquisarTaxa.SelectedRows != null &&
               dtPesquisarTaxa.SelectedRows.Count > 0)
            {
                MTaxaEmbarque taxa = new MTaxaEmbarque();

                taxa.id = int.Parse(dtPesquisarTaxa.SelectedRows[0].
                    Cells["idDataGridViewTextBoxColumn"].Value.ToString());

                Form v = new VTaxaCadastrar(taxa);
                v.ShowDialog();

                btnPesquisarTaxa_Click(null, null);
            }
        }

        //BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtPesquisarTaxa.SelectedRows != null &&
                dtPesquisarTaxa.SelectedRows.Count > 0)
            {
                DialogResult excluirTaxa = MessageBox.Show("Deseja Excluir esta Empresa?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (excluirTaxa == DialogResult.Yes)
                {
                    MTaxaEmbarque taxa = (MTaxaEmbarque)dtPesquisarTaxa.SelectedRows[0].
                        DataBoundItem;

                    bool sucesso = false;

                    try
                    {
                        CTaxaEmbarque.Excluir(taxa);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Empresa já possui taxa de Embarque, cadastrada, sera necessário exclui-las",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Taxa de Embarque Excluida com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<MTaxaEmbarque> lista = (List<MTaxaEmbarque>)dtPesquisarTaxa.DataSource;
                        lista.Remove(taxa);

                        dtPesquisarTaxa.DataSource = null;
                        dtPesquisarTaxa.DataSource = lista;
                    }
                }
            }
        }

        //BOTÃO IMPRIMIR
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int width = 0;
            int height = 0;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);


            try
            {
                //COLUNAS PARA USAR NA IMPRESSÃO
                #region Draw Column 1 
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 100, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                e.Graphics.DrawString(dtPesquisarTaxa.Columns[1].HeaderText, dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(100, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);
                #endregion

                #region Draw column 2 

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100 + dtPesquisarTaxa.Columns[0].Width, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 100 + dtPesquisarTaxa.Columns[0].Width, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                e.Graphics.DrawString(dtPesquisarTaxa.Columns[2].HeaderText, dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(100 + dtPesquisarTaxa.Columns[0].Width, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);
                #endregion

                #region Draw Column 3 

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(300, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 300, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                e.Graphics.DrawString(dtPesquisarTaxa.Columns[3].HeaderText, dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(300, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);
                #endregion

                #region Draw Column 4 

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(400, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 400, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                e.Graphics.DrawString(dtPesquisarTaxa.Columns[4].HeaderText, dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(400, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);
                #endregion

                #region Draw Column 5 

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(500, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height));
                e.Graphics.DrawRectangle(Pens.Black, 500, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                e.Graphics.DrawString(dtPesquisarTaxa.Columns[5].HeaderText, dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(500, 100, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);
                #endregion

                width = 100 + dtPesquisarTaxa.Columns[0].Width;
                height = 100;

                //CONTAGEM DAS LINHAS PARA INSERIR NO RELATÓRIO
                while (i < dtPesquisarTaxa.Rows.Count)
                {
                    if (height > e.MarginBounds.Height)
                    {
                        height = 100;
                        width = 100;
                        e.HasMorePages = true;
                        return;
                    }

                    height += dtPesquisarTaxa.Rows[i].Height;
                    e.Graphics.DrawRectangle(Pens.Black, 100, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                    e.Graphics.DrawString(dtPesquisarTaxa.Rows[i].Cells[1].FormattedValue.ToString(), dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(100, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);

                    e.Graphics.DrawRectangle(Pens.Black, 100 + dtPesquisarTaxa.Columns[0].Width, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                    e.Graphics.DrawString(dtPesquisarTaxa.Rows[i].Cells[2].Value.ToString(), dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(100 + dtPesquisarTaxa.Columns[0].Width, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);

                    e.Graphics.DrawRectangle(Pens.Black, 300, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                    e.Graphics.DrawString(dtPesquisarTaxa.Rows[i].Cells[3].FormattedValue.ToString(), dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(300, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);

                    e.Graphics.DrawRectangle(Pens.Black, 400, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                    e.Graphics.DrawString(dtPesquisarTaxa.Rows[i].Cells[4].FormattedValue.ToString(), dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(400, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);

                    e.Graphics.DrawRectangle(Pens.Black, 500, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height);
                    e.Graphics.DrawString(dtPesquisarTaxa.Rows[i].Cells[5].FormattedValue.ToString(), dtPesquisarTaxa.Font, Brushes.Black, new RectangleF(500, height, dtPesquisarTaxa.Columns[0].Width, dtPesquisarTaxa.Rows[0].Height), str);

                    width += dtPesquisarTaxa.Columns[0].Width;
                    i++;
                }

            }
            catch
            {
                MessageBox.Show("Não existe dados para ser impresso!",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //FECHA O PREVIEW DE IMPRESSÃO AUTOMATICAMENTE
                printPreviewDialog1.Close();
            }

        }

    }
}
