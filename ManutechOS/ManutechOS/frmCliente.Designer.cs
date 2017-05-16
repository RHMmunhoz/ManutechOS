namespace ManutechOS
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.gboFiltro = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gboRegistros = new System.Windows.Forms.GroupBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gboFiltro.SuspendLayout();
            this.gboRegistros.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gboFiltro
            // 
            this.gboFiltro.Controls.Add(this.rdbJuridica);
            this.gboFiltro.Controls.Add(this.rdbFisica);
            this.gboFiltro.Controls.Add(this.lblPessoa);
            this.gboFiltro.Controls.Add(this.btnBuscar);
            this.gboFiltro.Controls.Add(this.txtBusca);
            this.gboFiltro.Controls.Add(this.lblNome);
            this.gboFiltro.Location = new System.Drawing.Point(12, 4);
            this.gboFiltro.Name = "gboFiltro";
            this.gboFiltro.Size = new System.Drawing.Size(613, 78);
            this.gboFiltro.TabIndex = 0;
            this.gboFiltro.TabStop = false;
            this.gboFiltro.Text = "Filtro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(18, 32);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(499, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(523, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gboRegistros
            // 
            this.gboRegistros.Controls.Add(this.dgvClientes);
            this.gboRegistros.Location = new System.Drawing.Point(12, 88);
            this.gboRegistros.Name = "gboRegistros";
            this.gboRegistros.Size = new System.Drawing.Size(613, 299);
            this.gboRegistros.TabIndex = 1;
            this.gboRegistros.TabStop = false;
            this.gboRegistros.Text = "Registros";
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btnVisualizar);
            this.pnBotoes.Controls.Add(this.btnExcluir);
            this.pnBotoes.Controls.Add(this.btnEditar);
            this.pnBotoes.Controls.Add(this.btnAdd);
            this.pnBotoes.Location = new System.Drawing.Point(105, 393);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(426, 46);
            this.pnBotoes.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(13, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Novo";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(115, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(217, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 40);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(322, 3);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(91, 40);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(15, 59);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(45, 13);
            this.lblPessoa.TabIndex = 3;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Checked = true;
            this.rdbFisica.Location = new System.Drawing.Point(66, 57);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(54, 17);
            this.rdbFisica.TabIndex = 4;
            this.rdbFisica.TabStop = true;
            this.rdbFisica.Text = "Física";
            this.rdbFisica.UseVisualStyleBackColor = true;
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Location = new System.Drawing.Point(126, 57);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdbJuridica.TabIndex = 5;
            this.rdbJuridica.Text = "Jurídica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 16);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(607, 280);
            this.dgvClientes.TabIndex = 0;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 439);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.gboRegistros);
            this.Controls.Add(this.gboFiltro);
            this.Name = "frmCliente";
            this.Text = "Consulta de Clientes";
            this.gboFiltro.ResumeLayout(false);
            this.gboFiltro.PerformLayout();
            this.gboRegistros.ResumeLayout(false);
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gboRegistros;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}