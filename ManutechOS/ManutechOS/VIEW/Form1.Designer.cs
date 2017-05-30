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
            this.rodStatus = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuLateral = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnEquipamentos = new System.Windows.Forms.ToolStripButton();
            this.btnServicos = new System.Windows.Forms.ToolStripButton();
            this.btnOS = new System.Windows.Forms.ToolStripButton();
            this.btnTecnico = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.miCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEquipamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miServico = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewServico = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.miConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissãoDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCatServico = new System.Windows.Forms.ToolStripButton();
            this.tscContainer.BottomToolStripPanel.SuspendLayout();
            this.tscContainer.LeftToolStripPanel.SuspendLayout();
            this.tscContainer.TopToolStripPanel.SuspendLayout();
            this.tscContainer.SuspendLayout();
            this.rodStatus.SuspendLayout();
            this.mnuLateral.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
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
            this.tscContainer.LeftToolStripPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // rodStatus
            // 
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.rodStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser});
            this.rodStatus.Location = new System.Drawing.Point(0, 0);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(653, 22);
            this.rodStatus.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(93, 17);
            this.lblUser.Text = "Usuário Logado:";
            // 
            // mnuLateral
            // 
            this.mnuLateral.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuLateral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuLateral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnEquipamentos,
            this.btnServicos,
            this.btnOS,
            this.btnTecnico,
            this.toolStripSeparator2,
            this.btnCatServico});
            this.mnuLateral.Location = new System.Drawing.Point(0, 3);
            this.mnuLateral.Name = "mnuLateral";
            this.mnuLateral.Size = new System.Drawing.Size(129, 351);
            this.mnuLateral.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(127, 51);
            this.btnClientes.Text = "Clientes (F2)";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
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
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnServicos.Image = ((System.Drawing.Image)(resources.GetObject("btnServicos.Image")));
            this.btnServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(127, 51);
            this.btnServicos.Text = "Serviços (F4)";
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
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
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // btnTecnico
            // 
            this.btnTecnico.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTecnico.Image = ((System.Drawing.Image)(resources.GetObject("btnTecnico.Image")));
            this.btnTecnico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTecnico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTecnico.Name = "btnTecnico";
            this.btnTecnico.Size = new System.Drawing.Size(127, 51);
            this.btnTecnico.Text = "Técnico (F6)";
            this.btnTecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTecnico.Click += new System.EventHandler(this.btnTecnico_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadastros,
            this.miConsultas,
            this.relatóriosToolStripMenuItem,
            this.emissãoDeDocumentosToolStripMenuItem,
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
            this.miClientes,
            this.miEquipamentos,
            this.miServico,
            this.toolStripSeparator1,
            this.miUsuario});
            this.miCadastros.Name = "miCadastros";
            this.miCadastros.Size = new System.Drawing.Size(71, 20);
            this.miCadastros.Text = "Cadastros";
            // 
            // miClientes
            // 
            this.miClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem});
            this.miClientes.Name = "miClientes";
            this.miClientes.Size = new System.Drawing.Size(150, 22);
            this.miClientes.Text = "Clientes";
            this.miClientes.Click += new System.EventHandler(this.miClientes_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente...";
            // 
            // miEquipamentos
            // 
            this.miEquipamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEquipamentoToolStripMenuItem});
            this.miEquipamentos.Name = "miEquipamentos";
            this.miEquipamentos.Size = new System.Drawing.Size(150, 22);
            this.miEquipamentos.Text = "Equipamentos";
            this.miEquipamentos.Click += new System.EventHandler(this.miEquipamentos_Click);
            // 
            // novoEquipamentoToolStripMenuItem
            // 
            this.novoEquipamentoToolStripMenuItem.Name = "novoEquipamentoToolStripMenuItem";
            this.novoEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.novoEquipamentoToolStripMenuItem.Text = "Novo Equipamento...";
            // 
            // miServico
            // 
            this.miServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewServico,
            this.miNewCategoria});
            this.miServico.Name = "miServico";
            this.miServico.Size = new System.Drawing.Size(150, 22);
            this.miServico.Text = "Serviços";
            this.miServico.Click += new System.EventHandler(this.miServico_Click);
            // 
            // miNewServico
            // 
            this.miNewServico.Name = "miNewServico";
            this.miNewServico.Size = new System.Drawing.Size(156, 22);
            this.miNewServico.Text = "Novo Serviço...";
            // 
            // miNewCategoria
            // 
            this.miNewCategoria.Name = "miNewCategoria";
            this.miNewCategoria.Size = new System.Drawing.Size(156, 22);
            this.miNewCategoria.Text = "Nova Categoria";
            this.miNewCategoria.Click += new System.EventHandler(this.miNewCategoria_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // miUsuario
            // 
            this.miUsuario.Name = "miUsuario";
            this.miUsuario.Size = new System.Drawing.Size(150, 22);
            this.miUsuario.Text = "Usuários";
            // 
            // miConsultas
            // 
            this.miConsultas.Name = "miConsultas";
            this.miConsultas.Size = new System.Drawing.Size(71, 20);
            this.miConsultas.Text = "Consultas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // emissãoDeDocumentosToolStripMenuItem
            // 
            this.emissãoDeDocumentosToolStripMenuItem.Name = "emissãoDeDocumentosToolStripMenuItem";
            this.emissãoDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.emissãoDeDocumentosToolStripMenuItem.Text = "Emissão de Documentos";
            // 
            // miSobre
            // 
            this.miSobre.Name = "miSobre";
            this.miSobre.Size = new System.Drawing.Size(49, 20);
            this.miSobre.Text = "Sobre";
            this.miSobre.Click += new System.EventHandler(this.miSobre_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // btnCatServico
            // 
            this.btnCatServico.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCatServico.Image = ((System.Drawing.Image)(resources.GetObject("btnCatServico.Image")));
            this.btnCatServico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCatServico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCatServico.Name = "btnCatServico";
            this.btnCatServico.Size = new System.Drawing.Size(127, 51);
            this.btnCatServico.Text = "Categorias de Serviço";
            this.btnCatServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCatServico.Click += new System.EventHandler(this.btnCatServico_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.tscContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutech O.S - Gestão de Ordem de Serviços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tscContainer.BottomToolStripPanel.ResumeLayout(false);
            this.tscContainer.BottomToolStripPanel.PerformLayout();
            this.tscContainer.LeftToolStripPanel.ResumeLayout(false);
            this.tscContainer.LeftToolStripPanel.PerformLayout();
            this.tscContainer.TopToolStripPanel.ResumeLayout(false);
            this.tscContainer.TopToolStripPanel.PerformLayout();
            this.tscContainer.ResumeLayout(false);
            this.tscContainer.PerformLayout();
            this.rodStatus.ResumeLayout(false);
            this.rodStatus.PerformLayout();
            this.mnuLateral.ResumeLayout(false);
            this.mnuLateral.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem miClientes;
        private System.Windows.Forms.ToolStripMenuItem miEquipamentos;
        private System.Windows.Forms.ToolStripMenuItem miServico;
        private System.Windows.Forms.ToolStripMenuItem miConsultas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miUsuario;
        private System.Windows.Forms.StatusStrip rodStatus;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewServico;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripButton btnTecnico;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emissãoDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewCategoria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCatServico;
    }
}

