
namespace Administrador
{
    partial class AmbienteTrabalhoFuncionario
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
            this.StripMenu_SairFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_ConfiguracoesFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_ConfUsuarioFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CadastroFun = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_CadClienteFun = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.StripMenu_CadastroFun,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_SairFuncionario,
            this.StripMenu_ConfiguracoesFuncionario});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // StripMenu_SairFuncionario
            // 
            this.StripMenu_SairFuncionario.Name = "StripMenu_SairFuncionario";
            this.StripMenu_SairFuncionario.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_SairFuncionario.Text = "Sair";
            // 
            // StripMenu_ConfiguracoesFuncionario
            // 
            this.StripMenu_ConfiguracoesFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_ConfUsuarioFuncionario});
            this.StripMenu_ConfiguracoesFuncionario.Name = "StripMenu_ConfiguracoesFuncionario";
            this.StripMenu_ConfiguracoesFuncionario.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_ConfiguracoesFuncionario.Text = "configurações";
            // 
            // StripMenu_ConfUsuarioFuncionario
            // 
            this.StripMenu_ConfUsuarioFuncionario.Name = "StripMenu_ConfUsuarioFuncionario";
            this.StripMenu_ConfUsuarioFuncionario.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_ConfUsuarioFuncionario.Text = "Meu usuario";
            // 
            // StripMenu_CadastroFun
            // 
            this.StripMenu_CadastroFun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_CadClienteFun});
            this.StripMenu_CadastroFun.Name = "StripMenu_CadastroFun";
            this.StripMenu_CadastroFun.Size = new System.Drawing.Size(66, 20);
            this.StripMenu_CadastroFun.Text = "Cadastro";
            // 
            // StripMenu_CadClienteFun
            // 
            this.StripMenu_CadClienteFun.Name = "StripMenu_CadClienteFun";
            this.StripMenu_CadClienteFun.Size = new System.Drawing.Size(180, 22);
            this.StripMenu_CadClienteFun.Text = "Cadastro Cliente";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // AmbienteTrabalhoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 613);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AmbienteTrabalhoFuncionario";
            this.Text = "AmbienteTrabalhoFuncionario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_SairFuncionario;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_ConfiguracoesFuncionario;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_ConfUsuarioFuncionario;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CadastroFun;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_CadClienteFun;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}