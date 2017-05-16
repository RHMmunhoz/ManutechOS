namespace ManutechOS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tscContainer = new System.Windows.Forms.ToolStripContainer();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.miCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.miSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLateral = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnEquipamentos = new System.Windows.Forms.ToolStripButton();
            this.btnServicos = new System.Windows.Forms.ToolStripButton();
            this.btnOS = new System.Windows.Forms.ToolStripButton();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rodStatus = new System.Windows.Forms.StatusStrip();
            this.tscContainer.BottomToolStripPanel.SuspendLayout();
            this.tscContainer.LeftToolStripPanel.SuspendLayout();
            this.tscContainer.TopToolStripPanel.SuspendLayout();
            this.tscContainer.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.mnuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscContainer
            // 
            // 
            // tscContainer.BottomToolStripPanel
            // 
            this.tscContainer.BottomToolStripPanel.Controls.Add(this.rodStatus);
            // 
            // tscContainer.ContentPanel
            // 
            this.tscContainer.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tscContainer.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tscContainer.ContentPanel.BackgroundImage")));
            this.tscContainer.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tscContainer.ContentPanel.Size = new System.Drawing.Size(524, 381);
            this.tscContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // tscContainer.LeftToolStripPanel
            // 
            this.tscContainer.LeftToolStripPanel.Controls.Add(this.mnuLateral);
            this.tscContainer.Location = new System.Drawing.Point(0, 0);
            this.tscContainer.Name = "tscContainer";
            this.tscContainer.Size = new System.Drawing.Size(653, 427);
            this.tscContainer.TabIndex = 0;
            this.tscContainer.Text = "toolStripContainer1";
            // 
            // tscContainer.TopToolStripPanel
            // 
            this.tscContainer.TopToolStripPanel.Controls.Add(this.mnuPrincipal);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadastros,
            this.miConsultas,
            this.miSobre});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(653, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "Menu Principal";
            // 
            // miCadastros
            // 
            this.miCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.equipamentosToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.toolStripSeparator1,
            this.usuáriosToolStripMenuItem});
            this.miCadastros.Name = "miCadastros";
            this.miCadastros.Size = new System.Drawing.Size(71, 20);
            this.miCadastros.Text = "Cadastros";
            // 
            // miSobre
            // 
            this.miSobre.Name = "miSobre";
            this.miSobre.Size = new System.Drawing.Size(49, 20);
            this.miSobre.Text = "Sobre";
            // 
            // mnuLateral
            // 
            this.mnuLateral.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuLateral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuLateral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnEquipamentos,
            this.btnServicos,
            this.btnOS});
            this.mnuLateral.Location = new System.Drawing.Point(0, 3);
            this.mnuLateral.Name = "mnuLateral";
            this.mnuLateral.Size = new System.Drawing.Size(129, 218);
            this.mnuLateral.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(127, 51);
            this.btnClientes.Text = "Clientes (F2)";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.Image")));
            this.btnEquipamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEquipamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(127, 51);
            this.btnEquipamentos.Text = "Equipamentos (F3)";
            this.btnEquipamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnServicos
            // 
            this.btnServicos.Image = ((System.Drawing.Image)(resources.GetObject("btnServicos.Image")));
            this.btnServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(127, 51);
            this.btnServicos.Text = "Serviços (F4)";
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnOS
            // 
            this.btnOS.Image = ((System.Drawing.Image)(resources.GetObject("btnOS.Image")));
            this.btnOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(127, 51);
            this.btnOS.Text = "Ordem de Serviço (F5)";
            this.btnOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOS.ToolTipText = "O.S (F)";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // miConsultas
            // 
            this.miConsultas.Name = "miConsultas";
            this.miConsultas.Size = new System.Drawing.Size(71, 20);
            this.miConsultas.Text = "Consultas";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // rodStatus
            // 
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.rodStatus.Location = new System.Drawing.Point(0, 0);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(653, 22);
            this.rodStatus.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.tscContainer);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutech O.S - Gestão de Ordem de Serviços";
            this.tscContainer.BottomToolStripPanel.ResumeLayout(false);
            this.tscContainer.BottomToolStripPanel.PerformLayout();
            this.tscContainer.LeftToolStripPanel.ResumeLayout(false);
            this.tscContainer.LeftToolStripPanel.PerformLayout();
            this.tscContainer.TopToolStripPanel.ResumeLayout(false);
            this.tscContainer.TopToolStripPanel.PerformLayout();
            this.tscContainer.ResumeLayout(false);
            this.tscContainer.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.mnuLateral.ResumeLayout(false);
            this.mnuLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscContainer;
        private System.Windows.Forms.ToolStrip mnuLateral;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem miCadastros;
        private System.Windows.Forms.ToolStripMenuItem miSobre;
        private System.Windows.Forms.ToolStripButton btnEquipamentos;
        private System.Windows.Forms.ToolStripButton btnServicos;
        private System.Windows.Forms.ToolStripButton btnOS;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miConsultas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip rodStatus;
    }
}

