using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class FRM_AmbienteTrabalhoADM : Form
    {
        public FRM_AmbienteTrabalhoADM()
        {
            InitializeComponent();
        }
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //chamando tela de cadastro de Fornecedor
        private void CadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CadastroFornecedorADM Fornecedor = new FRM_CadastroFornecedorADM();
            Fornecedor.MdiParent = this;
            Fornecedor.Show();
        }
        //chamando tela de cadastro de funcionario
        private void CadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CadastroFuncionario Funcionario = new FRM_CadastroFuncionario();
            Funcionario.MdiParent = this;
            Funcionario.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StripMenu_ConfUsuarioADM_Click(object sender, EventArgs e)
        {
            FRM_MeuUsuarioADM Usuario = new FRM_MeuUsuarioADM();
            Usuario.Show();
            
        }

        private void FRM_AmbienteTrabalhoADM_Load(object sender, EventArgs e)
        {

        }

    }
}
