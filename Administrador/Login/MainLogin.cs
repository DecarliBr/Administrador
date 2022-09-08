using System;
using System.Windows.Forms;

namespace Administrador
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }
        ConexaoSqlClass conexao = new ConexaoSqlClass();
        private void FRM_Login_Load(object sender, EventArgs e)
        {
        }
        private void BTN_EntrarLogin_Click(object sender, EventArgs e)
        {
            if (TXB_UsuarioLogin.Text == "" || TXB_SenhaLogin.Text == "")
            {
                MessageBox.Show("Verificar se campos usuario e senha não se encontram vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    // abrindo conexao com banco
                    conexao.ConexaoOpen();
                    //retornando validação do banco caso verdadeiro ou falso
                    bool response = conexao.Command(TXB_UsuarioLogin.Text, TXB_SenhaLogin.Text);
                    if (response)
                    {
                        FRM_AmbienteTrabalhoADM AT = new FRM_AmbienteTrabalhoADM();
                        AT.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXB_UsuarioLogin.Clear();
                        TXB_SenhaLogin.Clear();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }
    }
}
