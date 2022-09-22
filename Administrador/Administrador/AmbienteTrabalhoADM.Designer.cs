
namespace Administrador
{
    partial class FRM_AmbienteTrabalhoADM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_ConfiguracoesADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_ConfUsuarioADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_ConfFuncionariosADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_SairADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CadastroADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CadFornecedorADM = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CadFuncionarioADM = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.StripMenu_CadastroADM,
            this.relatoriosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_ConfiguracoesADM,
            this.StripMenu_SairADM});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // StripMenu_ConfiguracoesADM
            // 
            this.StripMenu_ConfiguracoesADM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_ConfUsuarioADM,
            this.StripMenu_ConfFuncionariosADM});
            this.StripMenu_ConfiguracoesADM.Name = "StripMenu_ConfiguracoesADM";
            this.StripMenu_ConfiguracoesADM.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_ConfiguracoesADM.Text = "configurações";
            // 
            // StripMenu_ConfUsuarioADM
            // 
            this.StripMenu_ConfUsuarioADM.Name = "StripMenu_ConfUsuarioADM";
            this.StripMenu_ConfUsuarioADM.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_ConfUsuarioADM.Text = "Meu usuario";
            this.StripMenu_ConfUsuarioADM.Click += new System.EventHandler(this.StripMenu_ConfUsuarioADM_Click);
            // 
            // StripMenu_ConfFuncionariosADM
            // 
            this.StripMenu_ConfFuncionariosADM.Name = "StripMenu_ConfFuncionariosADM";
            this.StripMenu_ConfFuncionariosADM.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_ConfFuncionariosADM.Text = "Funcionarios";
            // 
            // StripMenu_SairADM
            // 
            this.StripMenu_SairADM.Name = "StripMenu_SairADM";
            this.StripMenu_SairADM.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_SairADM.Text = "Sair";
            this.StripMenu_SairADM.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // StripMenu_CadastroADM
            // 
            this.StripMenu_CadastroADM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_CadFornecedorADM,
            this.StripMenu_CadFuncionarioADM,
            this.cadastroProdutoToolStripMenuItem});
            this.StripMenu_CadastroADM.Name = "StripMenu_CadastroADM";
            this.StripMenu_CadastroADM.Size = new System.Drawing.Size(66, 20);
            this.StripMenu_CadastroADM.Text = "Cadastro";
            this.StripMenu_CadastroADM.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // StripMenu_CadFornecedorADM
            // 
            this.StripMenu_CadFornecedorADM.Name = "StripMenu_CadFornecedorADM";
            this.StripMenu_CadFornecedorADM.Size = new System.Drawing.Size(187, 22);
            this.StripMenu_CadFornecedorADM.Text = "Cadastro Fornecedor";
            this.StripMenu_CadFornecedorADM.Click += new System.EventHandler(this.CadastroFornecedorToolStripMenuItem_Click);
            // 
            // StripMenu_CadFuncionarioADM
            // 
            this.StripMenu_CadFuncionarioADM.Name = "StripMenu_CadFuncionarioADM";
            this.StripMenu_CadFuncionarioADM.Size = new System.Drawing.Size(187, 22);
            this.StripMenu_CadFuncionarioADM.Text = "Cadastro Funcionario";
            this.StripMenu_CadFuncionarioADM.Click += new System.EventHandler(this.CadastroFuncionarioToolStripMenuItem_Click);
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem.Text = "Fornecedor";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Estoque";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.localizarProdutosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // localizarProdutosToolStripMenuItem
            // 
            this.localizarProdutosToolStripMenuItem.Name = "localizarProdutosToolStripMenuItem";
            this.localizarProdutosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.localizarProdutosToolStripMenuItem.Text = "Localizar Produtos";
            // 
            // FRM_AmbienteTrabalhoADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 613);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_AmbienteTrabalhoADM";
            this.Text = "AmbienteTrabalhoADM";
            this.Load += new System.EventHandler(this.FRM_AmbienteTrabalhoADM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_SairADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CadastroADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CadFornecedorADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CadFuncionarioADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_ConfiguracoesADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_ConfUsuarioADM;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_ConfFuncionariosADM;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarProdutosToolStripMenuItem;
    }
}