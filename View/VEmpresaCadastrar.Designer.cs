namespace View
{
    partial class VEmpresaCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VEmpresaCadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.btnSalvarEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(92, 33);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(260, 20);
            this.txtNomeEmpresa.TabIndex = 0;
            // 
            // btnSalvarEmpresa
            // 
            this.btnSalvarEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarEmpresa.BackgroundImage")));
            this.btnSalvarEmpresa.Location = new System.Drawing.Point(297, 84);
            this.btnSalvarEmpresa.Name = "btnSalvarEmpresa";
            this.btnSalvarEmpresa.Size = new System.Drawing.Size(54, 52);
            this.btnSalvarEmpresa.TabIndex = 2;
            this.btnSalvarEmpresa.UseVisualStyleBackColor = true;
            this.btnSalvarEmpresa.Click += new System.EventHandler(this.btnSalvarEmpresa_Click);
            // 
            // VEmpresaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 171);
            this.Controls.Add(this.btnSalvarEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 210);
            this.Name = "VEmpresaCadastrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empresas";
            this.Load += new System.EventHandler(this.VEmpresaCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Button btnSalvarEmpresa;
    }
}