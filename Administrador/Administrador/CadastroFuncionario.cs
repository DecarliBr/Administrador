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
    public partial class FRM_CadastroFuncionario : Form
    {

        SqlConnection conexao = new SqlConnection(@"Data Source = DESKTOP-6F20152\SQLEXPRESS; integrated Security = SSPI; Initial Catalog = Administrador");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public FRM_CadastroFuncionario()
        {   
            InitializeComponent();
        }

        private void FRM_CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void LBL_FoneCad_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SalvarCad_Click(object sender, EventArgs e)
        {
            if (TXB_NomeCad.Text == "" || TXB_NumeroCad.Text == "" || TXB_FoneCad.Text == "" || TXB_EnderecoCad.Text == ""
                || TXB_EmailCad.Text == "" || TXB_CpfCad.Text == "" || TXB_CidadeCad.Text == "" || TXB_CepCad.Text == ""
                || TXB_BairroCad.Text == "")
            {
                MessageBox.Show("Campo obrigatorio vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = $"insert into Cadastro_Funcionario (Nome, CPF, Endereço, Numero, Bairro, Complemento, Cidade" +
                        $",Estado, Cep, Fone, Email, ADM) values ('{TXB_NomeCad.Text}','{TXB_CpfCad.Text}','{TXB_EnderecoCad.Text}','{TXB_NumeroCad.Text}'" +
                        $",'{TXB_BairroCad.Text}','{TXB_ComplementoCad.Text}','{TXB_CidadeCad.Text}','{CBOX_EstadoCad.Text}','{TXB_CepCad.Text}'" +
                        $",'{TXB_FoneCad.Text}','{TXB_EmailCad.Text}','{CHB_ADMorUser.Checked}')";

                    comando.Connection = conexao;
                    dr = comando.ExecuteReader();
                    MessageBox.Show("Funcionario cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    dr.Close();
                }
            }
        }
    }
}