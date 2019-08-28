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
    public partial class VTelaInicial : Form
    {
        public VTelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            VEmpresaCadastrar form = new VEmpresaCadastrar(null);
            form.ShowDialog();
        }

        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            VEmpresaPesquisar form = new VEmpresaPesquisar();
            form.ShowDialog();
        }

        private void btnInserirTaxaEmbarque_Click(object sender, EventArgs e)
        {
            VTaxaCadastrar form = new VTaxaCadastrar(null);
            form.ShowDialog();
        }

        private void btnPesquisarTaxaEmbarque_Click(object sender, EventArgs e)
        {
            VTaxaPesquisar form = new VTaxaPesquisar();
            form.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
