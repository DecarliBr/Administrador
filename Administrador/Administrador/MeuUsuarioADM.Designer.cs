
namespace Administrador
{
    partial class FRM_MeuUsuarioADM
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
            this.LBL_MeuUsuarioADM = new System.Windows.Forms.Label();
            this.BTN_SalvarMeuUsuarioADM = new System.Windows.Forms.Button();
            this.LBL_UsuarioMuADM = new System.Windows.Forms.Label();
            this.LBL_SenhaMuADM = new System.Windows.Forms.Label();
            this.TXB_UsuarioMuADM = new System.Windows.Forms.TextBox();
            this.TXB_SenhaMuADM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_MeuUsuarioADM
            // 
            this.LBL_MeuUsuarioADM.AutoSize = true;
            this.LBL_MeuUsuarioADM.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.LBL_MeuUsuarioADM.Location = new System.Drawing.Point(169, 9);
            this.LBL_MeuUsuarioADM.Name = "LBL_MeuUsuarioADM";
            this.LBL_MeuUsuarioADM.Size = new System.Drawing.Size(190, 33);
            this.LBL_MeuUsuarioADM.TabIndex = 1;
            this.LBL_MeuUsuarioADM.Text = "Editar Usuario";
            // 
            // BTN_SalvarMeuUsuarioADM
            // 
            this.BTN_SalvarMeuUsuarioADM.Location = new System.Drawing.Point(414, 179);
            this.BTN_SalvarMeuUsuarioADM.Name = "BTN_SalvarMeuUsuarioADM";
            this.BTN_SalvarMeuUsuarioADM.Size = new System.Drawing.Size(108, 36);
            this.BTN_SalvarMeuUsuarioADM.TabIndex = 2;
            this.BTN_SalvarMeuUsuarioADM.Text = "Salvar";
            this.BTN_SalvarMeuUsuarioADM.UseVisualStyleBackColor = true;
            // 
            // LBL_UsuarioMuADM
            // 
            this.LBL_UsuarioMuADM.AutoSize = true;
            this.LBL_UsuarioMuADM.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LBL_UsuarioMuADM.Location = new System.Drawing.Point(103, 97);
            this.LBL_UsuarioMuADM.Name = "LBL_UsuarioMuADM";
            this.LBL_UsuarioMuADM.Size = new System.Drawing.Size(66, 21);
            this.LBL_UsuarioMuADM.TabIndex = 3;
            this.LBL_UsuarioMuADM.Text = "Usuario";
            // 
            // LBL_SenhaMuADM
            // 
            this.LBL_SenhaMuADM.AutoSize = true;
            this.LBL_SenhaMuADM.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LBL_SenhaMuADM.Location = new System.Drawing.Point(63, 133);
            this.LBL_SenhaMuADM.Name = "LBL_SenhaMuADM";
            this.LBL_SenhaMuADM.Size = new System.Drawing.Size(106, 21);
            this.LBL_SenhaMuADM.TabIndex = 4;
            this.LBL_SenhaMuADM.Text = "Nova Senha";
            // 
            // TXB_UsuarioMuADM
            // 
            this.TXB_UsuarioMuADM.Location = new System.Drawing.Point(175, 97);
            this.TXB_UsuarioMuADM.Name = "TXB_UsuarioMuADM";
            this.TXB_UsuarioMuADM.Size = new System.Drawing.Size(251, 20);
            this.TXB_UsuarioMuADM.TabIndex = 5;
            this.TXB_UsuarioMuADM.TextChanged += new System.EventHandler(this.TXB_UsuarioMuADM_TextChanged);
            // 
            // TXB_SenhaMuADM
            // 
            this.TXB_SenhaMuADM.Location = new System.Drawing.Point(175, 133);
            this.TXB_SenhaMuADM.Name = "TXB_SenhaMuADM";
            this.TXB_SenhaMuADM.Size = new System.Drawing.Size(251, 20);
            this.TXB_SenhaMuADM.TabIndex = 6;
            // 
            // FRM_MeuUsuarioADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 227);
            this.Controls.Add(this.TXB_SenhaMuADM);
            this.Controls.Add(this.TXB_UsuarioMuADM);
            this.Controls.Add(this.LBL_SenhaMuADM);
            this.Controls.Add(this.LBL_UsuarioMuADM);
            this.Controls.Add(this.BTN_SalvarMeuUsuarioADM);
            this.Controls.Add(this.LBL_MeuUsuarioADM);
            this.Name = "FRM_MeuUsuarioADM";
            this.Text = "MeuUsuarioADM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_MeuUsuarioADM;
        private System.Windows.Forms.Button BTN_SalvarMeuUsuarioADM;
        private System.Windows.Forms.Label LBL_UsuarioMuADM;
        private System.Windows.Forms.Label LBL_SenhaMuADM;
        private System.Windows.Forms.TextBox TXB_UsuarioMuADM;
        private System.Windows.Forms.TextBox TXB_SenhaMuADM;
    }
}