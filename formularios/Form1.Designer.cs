namespace BancoVelhaCredi
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeLogado = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBoxAcesso = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toollogin = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJuridicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolcadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJuridicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolgestãoAdministrativa = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcesso)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelNomeLogado);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.pictureBoxAcesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 36);
            this.panel1.TabIndex = 0;
            // 
            // labelNomeLogado
            // 
            this.labelNomeLogado.AutoSize = true;
            this.labelNomeLogado.Location = new System.Drawing.Point(38, 19);
            this.labelNomeLogado.Name = "labelNomeLogado";
            this.labelNomeLogado.Size = new System.Drawing.Size(76, 13);
            this.labelNomeLogado.TabIndex = 1;
            this.labelNomeLogado.Text = "Faça seu login";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(39, 3);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuário";
            // 
            // pictureBoxAcesso
            // 
            this.pictureBoxAcesso.Image = global::BancoVelhaCredi.Properties.Resources.logout;
            this.pictureBoxAcesso.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxAcesso.Name = "pictureBoxAcesso";
            this.pictureBoxAcesso.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxAcesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcesso.TabIndex = 0;
            this.pictureBoxAcesso.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toollogin,
            this.toolcadastro,
            this.toolgestãoAdministrativa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toollogin
            // 
            this.toollogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaJuridicaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.toolStripMenuItem3,
            this.fecharToolStripMenuItem});
            this.toollogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toollogin.Name = "toollogin";
            this.toollogin.Size = new System.Drawing.Size(49, 20);
            this.toollogin.Text = "Login";
            // 
            // pessoaJuridicaToolStripMenuItem
            // 
            this.pessoaJuridicaToolStripMenuItem.Name = "pessoaJuridicaToolStripMenuItem";
            this.pessoaJuridicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoaJuridicaToolStripMenuItem.Text = "Entrar na Conta";
            this.pessoaJuridicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaJuridicaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair da Conta";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // toolcadastro
            // 
            this.toolcadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFísicaToolStripMenuItem,
            this.pessoaJuridicaToolStripMenuItem1});
            this.toolcadastro.Name = "toolcadastro";
            this.toolcadastro.Size = new System.Drawing.Size(66, 20);
            this.toolcadastro.Text = "Cadastro";
            // 
            // pessoaFísicaToolStripMenuItem
            // 
            this.pessoaFísicaToolStripMenuItem.Name = "pessoaFísicaToolStripMenuItem";
            this.pessoaFísicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pessoaFísicaToolStripMenuItem.Text = "Pessoa Física";
            this.pessoaFísicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaFísicaToolStripMenuItem_Click);
            // 
            // pessoaJuridicaToolStripMenuItem1
            // 
            this.pessoaJuridicaToolStripMenuItem1.Name = "pessoaJuridicaToolStripMenuItem1";
            this.pessoaJuridicaToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.pessoaJuridicaToolStripMenuItem1.Text = "Pessoa Juridica";
            // 
            // toolgestãoAdministrativa
            // 
            this.toolgestãoAdministrativa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeClientesToolStripMenuItem});
            this.toolgestãoAdministrativa.Name = "toolgestãoAdministrativa";
            this.toolgestãoAdministrativa.Size = new System.Drawing.Size(135, 20);
            this.toolgestãoAdministrativa.Text = "Gestão Administrativa";
            // 
            // gerenciamentoDeClientesToolStripMenuItem
            // 
            this.gerenciamentoDeClientesToolStripMenuItem.Name = "gerenciamentoDeClientesToolStripMenuItem";
            this.gerenciamentoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gerenciamentoDeClientesToolStripMenuItem.Text = "Gerenciamento de Clientes";
            this.gerenciamentoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeClientesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BancoVelhaCredi.Properties.Resources.fundo_preto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1026, 402);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VELHACREDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcesso)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toollogin;
        private System.Windows.Forms.ToolStripMenuItem pessoaJuridicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolcadastro;
        private System.Windows.Forms.ToolStripMenuItem pessoaFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaJuridicaToolStripMenuItem1;
        public System.Windows.Forms.PictureBox pictureBoxAcesso;
        public System.Windows.Forms.Label labelNomeLogado;
        public System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolgestãoAdministrativa;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeClientesToolStripMenuItem;
    }
}

