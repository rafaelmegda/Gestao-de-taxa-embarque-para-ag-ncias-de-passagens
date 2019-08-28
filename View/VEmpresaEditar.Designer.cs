namespace View
{
    partial class VEmpresaEditar
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
            this.btnSairEditarEmpresa = new System.Windows.Forms.Button();
            this.btnSalvarEditarEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEditarEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSairEditarEmpresa
            // 
            this.btnSairEditarEmpresa.Location = new System.Drawing.Point(417, 143);
            this.btnSairEditarEmpresa.Name = "btnSairEditarEmpresa";
            this.btnSairEditarEmpresa.Size = new System.Drawing.Size(54, 42);
            this.btnSairEditarEmpresa.TabIndex = 9;
            this.btnSairEditarEmpresa.Text = "Sair";
            this.btnSairEditarEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEditarEmpresa
            // 
            this.btnSalvarEditarEmpresa.Location = new System.Drawing.Point(357, 143);
            this.btnSalvarEditarEmpresa.Name = "btnSalvarEditarEmpresa";
            this.btnSalvarEditarEmpresa.Size = new System.Drawing.Size(54, 42);
            this.btnSalvarEditarEmpresa.TabIndex = 8;
            this.btnSalvarEditarEmpresa.Text = "Salvar";
            this.btnSalvarEditarEmpresa.UseVisualStyleBackColor = true;
            this.btnSalvarEditarEmpresa.Click += new System.EventHandler(this.btnSalvarEditarEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastro de Empresa";
            // 
            // txtNomeEditarEmpresa
            // 
            this.txtNomeEditarEmpresa.Location = new System.Drawing.Point(91, 67);
            this.txtNomeEditarEmpresa.Name = "txtNomeEditarEmpresa";
            this.txtNomeEditarEmpresa.Size = new System.Drawing.Size(380, 20);
            this.txtNomeEditarEmpresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empresa";
            // 
            // VEmpresaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 207);
            this.Controls.Add(this.btnSairEditarEmpresa);
            this.Controls.Add(this.btnSalvarEditarEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeEditarEmpresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VEmpresaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.VEmpresaEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairEditarEmpresa;
        private System.Windows.Forms.Button btnSalvarEditarEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEditarEmpresa;
        private System.Windows.Forms.Label label1;
    }
}