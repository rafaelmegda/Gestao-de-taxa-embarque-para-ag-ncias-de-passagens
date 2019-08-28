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
    public partial class VEmpresaEditar : Form
    {
        MEmpresa atual = null;
        internal bool Atualizou = false;

        public VEmpresaEditar(MEmpresa item)
        {
            InitializeComponent();
            atual = item;
        }

        //FUNÇÃO EDITAR
        private void VEmpresaEditar_Load(object sender, EventArgs e)
        {
            atual = CEmpresa.Obter(atual);

            if (atual != null)
            {
                txtNomeEditarEmpresa.Text = atual.NomeEmpresa;
               }
            else
            {
                Close();
            }
        }

        //Botão Salvar
        private void btnSalvarEditarEmpresa_Click(object sender, EventArgs e)
        {
            atual.NomeEmpresa = txtNomeEditarEmpresa.Text;
            
            bool sucesso = false;

            try
            {
                CEmpresa.Atualizar(atual);
                sucesso = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            if (sucesso)
            {
                MessageBox.Show("Empresa atualizada com sucesso!");
                Atualizou = true;
                Close();
            }
        }
    }
}
