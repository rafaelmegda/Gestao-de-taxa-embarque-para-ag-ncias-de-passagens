namespace View
{
    partial class VTaxaPesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VTaxaPesquisar));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelecionarEmpresaPesquisar = new System.Windows.Forms.ComboBox();
            this.dtPesquisarTaxa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTaxaEmbarqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimparPesquisaTaxa = new System.Windows.Forms.Button();
            this.btnPesquisarTaxa = new System.Windows.Forms.Button();
            this.menuSuperior = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.Data = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.mTaxaEmbarqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTaxaEmbarqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomarValorTotal = new System.Windows.Forms.Button();
            this.lbValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPesquisarTaxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource2)).BeginInit();
            this.menuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empresa";
            // 
            // cbSelecionarEmpresaPesquisar
            // 
            this.cbSelecionarEmpresaPesquisar.DisplayMember = "NomeEmpresa";
            this.cbSelecionarEmpresaPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelecionarEmpresaPesquisar.FormattingEnabled = true;
            this.cbSelecionarEmpresaPesquisar.Location = new System.Drawing.Point(61, 51);
            this.cbSelecionarEmpresaPesquisar.Name = "cbSelecionarEmpresaPesquisar";
            this.cbSelecionarEmpresaPesquisar.Size = new System.Drawing.Size(224, 21);
            this.cbSelecionarEmpresaPesquisar.TabIndex = 15;
            this.cbSelecionarEmpresaPesquisar.ValueMember = "ID";
            // 
            // dtPesquisarTaxa
            // 
            this.dtPesquisarTaxa.AllowUserToAddRows = false;
            this.dtPesquisarTaxa.AllowUserToDeleteRows = false;
            this.dtPesquisarTaxa.AllowUserToResizeColumns = false;
            this.dtPesquisarTaxa.AllowUserToResizeRows = false;
            this.dtPesquisarTaxa.AutoGenerateColumns = false;
            this.dtPesquisarTaxa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPesquisarTaxa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDaEmpresaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.Quantidade,
            this.valorTarifaDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.empresaIDDataGridViewTextBoxColumn});
            this.dtPesquisarTaxa.DataSource = this.mTaxaEmbarqueBindingSource2;
            this.dtPesquisarTaxa.Location = new System.Drawing.Point(0, 89);
            this.dtPesquisarTaxa.MultiSelect = false;
            this.dtPesquisarTaxa.Name = "dtPesquisarTaxa";
            this.dtPesquisarTaxa.ReadOnly = true;
            this.dtPesquisarTaxa.RowHeadersVisible = false;
            this.dtPesquisarTaxa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPesquisarTaxa.Size = new System.Drawing.Size(708, 251);
            this.dtPesquisarTaxa.TabIndex = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDaEmpresaDataGridViewTextBoxColumn
            // 
            this.nomeDaEmpresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDaEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NomeDaEmpresa";
            this.nomeDaEmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.nomeDaEmpresaDataGridViewTextBoxColumn.Name = "nomeDaEmpresaDataGridViewTextBoxColumn";
            this.nomeDaEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // valorTarifaDataGridViewTextBoxColumn
            // 
            this.valorTarifaDataGridViewTextBoxColumn.DataPropertyName = "ValorTarifa";
            this.valorTarifaDataGridViewTextBoxColumn.HeaderText = "Valor Tarifa";
            this.valorTarifaDataGridViewTextBoxColumn.Name = "valorTarifaDataGridViewTextBoxColumn";
            this.valorTarifaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaIDDataGridViewTextBoxColumn
            // 
            this.empresaIDDataGridViewTextBoxColumn.DataPropertyName = "EmpresaID";
            this.empresaIDDataGridViewTextBoxColumn.HeaderText = "EmpresaID";
            this.empresaIDDataGridViewTextBoxColumn.Name = "empresaIDDataGridViewTextBoxColumn";
            this.empresaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mTaxaEmbarqueBindingSource2
            // 
            this.mTaxaEmbarqueBindingSource2.DataSource = typeof(Model.MTaxaEmbarque);
            // 
            // btnLimparPesquisaTaxa
            // 
            this.btnLimparPesquisaTaxa.Location = new System.Drawing.Point(548, 40);
            this.btnLimparPesquisaTaxa.Name = "btnLimparPesquisaTaxa";
            this.btnLimparPesquisaTaxa.Size = new System.Drawing.Size(63, 46);
            this.btnLimparPesquisaTaxa.TabIndex = 32;
            this.btnLimparPesquisaTaxa.Text = "Limpar";
            this.btnLimparPesquisaTaxa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisaTaxa.Click += new System.EventHandler(this.btnLimparPesquisaTaxa_Click);
            // 
            // btnPesquisarTaxa
            // 
            this.btnPesquisarTaxa.Location = new System.Drawing.Point(462, 40);
            this.btnPesquisarTaxa.Name = "btnPesquisarTaxa";
            this.btnPesquisarTaxa.Size = new System.Drawing.Size(63, 46);
            this.btnPesquisarTaxa.TabIndex = 31;
            this.btnPesquisarTaxa.Text = "Pesquisar";
            this.btnPesquisarTaxa.UseVisualStyleBackColor = true;
            this.btnPesquisarTaxa.Click += new System.EventHandler(this.btnPesquisarTaxa_Click);
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(709, 25);
            this.menuSuperior.TabIndex = 35;
            this.menuSuperior.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(23, 22);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(309, 54);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 36;
            this.Data.Text = "Data";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(634, 40);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(63, 46);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(345, 51);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 40;
            // 
            // mTaxaEmbarqueBindingSource
            // 
            this.mTaxaEmbarqueBindingSource.DataSource = typeof(Model.MTaxaEmbarque);
            // 
            // mTaxaEmbarqueBindingSource1
            // 
            this.mTaxaEmbarqueBindingSource1.DataSource = typeof(Model.MTaxaEmbarque);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 42;
            // 
            // btnSomarValorTotal
            // 
            this.btnSomarValorTotal.Location = new System.Drawing.Point(351, 359);
            this.btnSomarValorTotal.Name = "btnSomarValorTotal";
            this.btnSomarValorTotal.Size = new System.Drawing.Size(240, 23);
            this.btnSomarValorTotal.TabIndex = 43;
            this.btnSomarValorTotal.Text = "Clique aqui para somar o Total das Taxas Selecionadas";
            this.btnSomarValorTotal.UseVisualStyleBackColor = true;
            this.btnSomarValorTotal.Click += new System.EventHandler(this.btnSomarValorTotal_Click_1);
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lbValorTotal.Location = new System.Drawing.Point(607, 364);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(92, 15);
            this.lbValorTotal.TabIndex = 44;
            this.lbValorTotal.Text = "Valor Total Taxas";
            // 
            // VTaxaPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 402);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.btnSomarValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.btnLimparPesquisaTaxa);
            this.Controls.Add(this.btnPesquisarTaxa);
            this.Controls.Add(this.dtPesquisarTaxa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelecionarEmpresaPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VTaxaPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar e Imprimir Taxa de Embarque";
            this.Load += new System.EventHandler(this.VTaxaPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPesquisarTaxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource2)).EndInit();
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTaxaEmbarqueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelecionarEmpresaPesquisar;
        private System.Windows.Forms.DataGridView dtPesquisarTaxa;
        private System.Windows.Forms.Button btnLimparPesquisaTaxa;
        private System.Windows.Forms.Button btnPesquisarTaxa;
        private System.Windows.Forms.ToolStrip menuSuperior;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.BindingSource mTaxaEmbarqueBindingSource;
        private System.Windows.Forms.Label Data;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.BindingSource mTaxaEmbarqueBindingSource2;
        private System.Windows.Forms.BindingSource mTaxaEmbarqueBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSomarValorTotal;
        private System.Windows.Forms.Label lbValorTotal;
    }
}