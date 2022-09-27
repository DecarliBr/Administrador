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
    public partial class AmbienteTrabalhoFuncionario : Form
    {
        public AmbienteTrabalhoFuncionario()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //chamando tela de cadastro de Fornecedor FUN
        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CadastroFornecedorFUN Fornecedor = new FRM_CadastroFornecedorFUN();
            Fornecedor.MdiParent= this;
            Fornecedor.Show();
        }
        //chamando tela de configuração do meu usuario
        private void StripMenu_ConfUsuarioFuncionario_Click(object sender, EventArgs e)
        {
            FRM_MeuUsuarioFUN Usuario = new FRM_MeuUsuarioFUN();
            Usuario.MdiParent = this;
            Usuario.Show();
        }
    }
}
