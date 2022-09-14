
namespace Administrador
{
    partial class FRM_Login
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
            this.LBL_ApresentaçãoLogin = new System.Windows.Forms.Label();
            this.LBL_UsuarioLogin = new System.Windows.Forms.Label();
            this.LBL_SenhaLogin = new System.Windows.Forms.Label();
            this.TXB_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.TXB_SenhaLogin = new System.Windows.Forms.TextBox();
            this.BTN_EntrarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_ApresentaçãoLogin
            // 
            this.LBL_ApresentaçãoLogin.AutoSize = true;
            this.LBL_ApresentaçãoLogin.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ApresentaçãoLogin.Location = new System.Drawing.Point(98, 9);
            this.LBL_ApresentaçãoLogin.Name = "LBL_ApresentaçãoLogin";
            this.LBL_ApresentaçãoLogin.Size = new System.Drawing.Size(272, 58);
            this.LBL_ApresentaçãoLogin.TabIndex = 0;
            this.LBL_ApresentaçãoLogin.Text = "Bem vindo";
            // 
            // LBL_UsuarioLogin
            // 
            this.LBL_UsuarioLogin.AutoSize = true;
            this.LBL_UsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UsuarioLogin.Location = new System.Drawing.Point(8, 215);
            this.LBL_UsuarioLogin.Name = "LBL_UsuarioLogin";
            this.LBL_UsuarioLogin.Size = new System.Drawing.Size(75, 22);
            this.LBL_UsuarioLogin.TabIndex = 1;
            this.LBL_UsuarioLogin.Text = "Usuario";
            // 
            // LBL_SenhaLogin
            // 
            this.LBL_SenhaLogin.AutoSize = true;
            this.LBL_SenhaLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LBL_SenhaLogin.Location = new System.Drawing.Point(15, 271);
            this.LBL_SenhaLogin.Name = "LBL_SenhaLogin";
            this.LBL_SenhaLogin.Size = new System.Drawing.Size(68, 22);
            this.LBL_SenhaLogin.TabIndex = 2;
            this.LBL_SenhaLogin.Text = "Senha";
            // 
            // TXB_UsuarioLogin
            // 
            this.TXB_UsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.TXB_UsuarioLogin.Location = new System.Drawing.Point(89, 206);
            this.TXB_UsuarioLogin.Name = "TXB_UsuarioLogin";
            this.TXB_UsuarioLogin.Size = new System.Drawing.Size(344, 31);
            this.TXB_UsuarioLogin.TabIndex = 3;
            this.TXB_UsuarioLogin.TextChanged += new System.EventHandler(this.TXB_UsuarioLogin_TextChanged);
            // 
            // TXB_SenhaLogin
            // 
            this.TXB_SenhaLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.TXB_SenhaLogin.Location = new System.Drawing.Point(89, 262);
            this.TXB_SenhaLogin.Name = "TXB_SenhaLogin";
            this.TXB_SenhaLogin.Size = new System.Drawing.Size(344, 31);
            this.TXB_SenhaLogin.TabIndex = 4;
            // 
            // BTN_EntrarLogin
            // 
            this.BTN_EntrarLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BTN_EntrarLogin.Location = new System.Drawing.Point(358, 327);
            this.BTN_EntrarLogin.Name = "BTN_EntrarLogin";
            this.BTN_EntrarLogin.Size = new System.Drawing.Size(75, 33);
            this.BTN_EntrarLogin.TabIndex = 5;
            this.BTN_EntrarLogin.Text = "Entrar";
            this.BTN_EntrarLogin.UseVisualStyleBackColor = true;
            this.BTN_EntrarLogin.Click += new System.EventHandler(this.BTN_EntrarLogin_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.BTN_EntrarLogin);
            this.Controls.Add(this.TXB_SenhaLogin);
            this.Controls.Add(this.TXB_UsuarioLogin);
            this.Controls.Add(this.LBL_SenhaLogin);
            this.Controls.Add(this.LBL_UsuarioLogin);
            this.Controls.Add(this.LBL_ApresentaçãoLogin);
            this.Name = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ApresentaçãoLogin;
        private System.Windows.Forms.Label LBL_UsuarioLogin;
        private System.Windows.Forms.Label LBL_SenhaLogin;
        private System.Windows.Forms.TextBox TXB_UsuarioLogin;
        private System.Windows.Forms.TextBox TXB_SenhaLogin;
        private System.Windows.Forms.Button BTN_EntrarLogin;
    }
}

