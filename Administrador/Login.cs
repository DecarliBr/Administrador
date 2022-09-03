using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administrador
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source = DESKTOP-O28HAT6; integrated Security = SSPI; Initial Catalog = Administrador");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

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
                    conexao.Open();
                    comando.CommandText = $"Select Email, senha from Usuarios where Email = ('{TXB_UsuarioLogin.Text}') and senha = ('{TXB_SenhaLogin.Text}')";
                    comando.Connection = conexao;
                    dr = comando.ExecuteReader();

                    if (dr.HasRows)
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
