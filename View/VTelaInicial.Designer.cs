namespace View
{
    partial class VTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VTelaInicial));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisarEmpresa = new System.Windows.Forms.Button();
            this.btnPesquisarTaxaEmbarque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Location = new System.Drawing.Point(121, 200);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 40);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "FECHAR PROGRAMA";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(12, 26);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(86, 44);
            this.btnPesquisarEmpresa.TabIndex = 3;
            this.btnPesquisarEmpresa.Text = "EMPRESAS";
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = false;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // btnPesquisarTaxaEmbarque
            // 
            this.btnPesquisarTaxaEmbarque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarTaxaEmbarque.Location = new System.Drawing.Point(121, 26);
            this.btnPesquisarTaxaEmbarque.Name = "btnPesquisarTaxaEmbarque";
            this.btnPesquisarTaxaEmbarque.Size = new System.Drawing.Size(86, 44);
            this.btnPesquisarTaxaEmbarque.TabIndex = 4;
            this.btnPesquisarTaxaEmbarque.Text = "TAXA DE EMBARQUE";
            this.btnPesquisarTaxaEmbarque.UseVisualStyleBackColor = false;
            this.btnPesquisarTaxaEmbarque.Click += new System.EventHandler(this.btnPesquisarTaxaEmbarque_Click);
            // 
            // VTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(223, 252);
            this.Controls.Add(this.btnPesquisarTaxaEmbarque);
            this.Controls.Add(this.btnPesquisarEmpresa);
            this.Controls.Add(this.btnFechar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO TAXAS EMBARQUE";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisarEmpresa;
        private System.Windows.Forms.Button btnPesquisarTaxaEmbarque;
    }
}