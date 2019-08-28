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
    public partial class VEmpresaPesquisar : Form
    {
        public VEmpresaPesquisar()
        {
            InitializeComponent();
        }

        //BOTÃO PESQUISAR
        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            MEmpresa empresa = new MEmpresa();
            empresa.NomeEmpresa = txtEmpresaPesquisar.Text.Trim();

            dataGridView1.DataSource = null;

            try
            {
                dataGridView1.DataSource = CEmpresa.Pesquisar(empresa);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //BOTÃO LIMPAR
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            MEmpresa empresa = new MEmpresa();

            txtEmpresaPesquisar.Text = ("");
            dataGridView1.DataSource = null;
        }


        //BOTÃO INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VEmpresaCadastrar(null);
            form.ShowDialog();

            btnPesquisarEmpresa_Click(null, null);
        }

        //BOTÃO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null &&
                dataGridView1.SelectedRows.Count > 0)
            {
                MEmpresa empresa = new MEmpresa();

                empresa.NomeEmpresa = dataGridView1.SelectedRows[0].
                    Cells["nomeEmpresaDataGridViewTextBoxColumn"].Value.ToString();

                Form v = new VEmpresaCadastrar(empresa);
                v.ShowDialog();

                btnPesquisarEmpresa_Click(null, null);

            }
        }

        //BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null &&
                dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult excluirEmpresa = MessageBox.Show("Deseja Excluir esta Empresa?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (excluirEmpresa == DialogResult.Yes)
                {
                    MEmpresa empresa = (MEmpresa)dataGridView1.SelectedRows[0].
                        DataBoundItem;

                    bool sucesso = false;

                    try
                    {
                        CEmpresa.Excluir(empresa);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Empresa já possui taxa de Embarque, cadastrada, sera necessário exclui-las",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Empresa Excluida com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<MEmpresa> lista = (List<MEmpresa>)dataGridView1.DataSource;
                        lista.Remove(empresa);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lista;
                    }
                }
            }
        }
    }
}
