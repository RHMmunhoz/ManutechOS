namespace ManutechOS.VIEW
{
    partial class frmCatServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatServico));
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboRegistros = new System.Windows.Forms.GroupBox();
            this.dgvCatServicos = new System.Windows.Forms.DataGridView();
            this.gboFiltro = new System.Windows.Forms.GroupBox();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.pnBotoes.SuspendLayout();
            this.gboRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatServicos)).BeginInit();
            this.gboFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnBotoes.Controls.Add(this.btnVisualizar);
            this.pnBotoes.Controls.Add(this.btnExcluir);
            this.pnBotoes.Controls.Add(this.btnEditar);
            this.pnBotoes.Controls.Add(this.btnAdd);
            this.pnBotoes.Location = new System.Drawing.Point(12, 400);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(426, 46);
            this.pnBotoes.TabIndex = 11;
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
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gboRegistros
            // 
            this.gboRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboRegistros.Controls.Add(this.dgvCatServicos);
            this.gboRegistros.Location = new System.Drawing.Point(9, 95);
            this.gboRegistros.Name = "gboRegistros";
            this.gboRegistros.Size = new System.Drawing.Size(429, 299);
            this.gboRegistros.TabIndex = 10;
            this.gboRegistros.TabStop = false;
            this.gboRegistros.Text = "Registros";
            // 
            // dgvCatServicos
            // 
            this.dgvCatServicos.AllowUserToAddRows = false;
            this.dgvCatServicos.AllowUserToDeleteRows = false;
            this.dgvCatServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatServicos.Location = new System.Drawing.Point(3, 16);
            this.dgvCatServicos.Name = "dgvCatServicos";
            this.dgvCatServicos.ReadOnly = true;
            this.dgvCatServicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCatServicos.Size = new System.Drawing.Size(423, 280);
            this.dgvCatServicos.TabIndex = 0;
            // 
            // gboFiltro
            // 
            this.gboFiltro.Controls.Add(this.rdbCodigo);
            this.gboFiltro.Controls.Add(this.rdbCategoria);
            this.gboFiltro.Controls.Add(this.btnBuscar);
            this.gboFiltro.Controls.Add(this.txtBusca);
            this.gboFiltro.Location = new System.Drawing.Point(9, 11);
            this.gboFiltro.Name = "gboFiltro";
            this.gboFiltro.Size = new System.Drawing.Size(429, 78);
            this.gboFiltro.TabIndex = 9;
            this.gboFiltro.TabStop = false;
            this.gboFiltro.Text = "Filtro";
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(94, 13);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 4;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Checked = true;
            this.rdbCategoria.Location = new System.Drawing.Point(18, 13);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdbCategoria.TabIndex = 3;
            this.rdbCategoria.TabStop = true;
            this.rdbCategoria.Text = "Categoria";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(340, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(18, 32);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(316, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // frmCatServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 456);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.gboRegistros);
            this.Controls.Add(this.gboFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCatServico";
            this.Text = "Consulta de Categorias de Serviço";
            this.pnBotoes.ResumeLayout(false);
            this.gboRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatServicos)).EndInit();
            this.gboFiltro.ResumeLayout(false);
            this.gboFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboRegistros;
        private System.Windows.Forms.DataGridView dgvCatServicos;
        private System.Windows.Forms.GroupBox gboFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbCategoria;
    }
}