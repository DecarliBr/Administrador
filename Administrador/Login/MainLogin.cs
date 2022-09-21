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
        public void BTN_EntrarLogin_Click(object sender, EventArgs e)
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
                    string arg1 = $"Select Email, senha from Usuarios where Email = ('{TXB_UsuarioLogin}') and senha = ('{TXB_SenhaLogin.Text}')";

                    bool response = conexao.Command(arg1);

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

        public void TXB_UsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
        public String LoginUser()
        {
            String LoginUser = TXB_UsuarioLogin.Text;
            return LoginUser;
        }
    }
}
