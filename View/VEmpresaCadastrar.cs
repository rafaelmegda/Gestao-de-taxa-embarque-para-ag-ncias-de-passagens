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
    public partial class VEmpresaCadastrar : Form
    {
        MEmpresa atual = null;

        public VEmpresaCadastrar(MEmpresa item)
        {
            InitializeComponent();
            item = CEmpresa.Obter(item);
            atual = item;
        }

        //BOTÃO SALVAR
        private void btnSalvarEmpresa_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (dadosValidos)
            {
                MEmpresa empresa = new MEmpresa();

                empresa.NomeEmpresa = txtNomeEmpresa.Text.Trim();

                try
                {
                    if (atual != null)
                    {
                        empresa.id = atual.id;
                        CEmpresa.Atualizar(empresa);
                        MessageBox.Show("Campo alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CEmpresa.Inserir(empresa);
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

        private void btnSairEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LOAD OK
        private void VEmpresaCadastrar_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar Empresa";
            }
            else
            {
                this.Text = "Inserir Nova Empresa";
            }
        }
    }
}
