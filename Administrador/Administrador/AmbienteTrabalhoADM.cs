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

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CadastroFuncionario F = new FRM_CadastroFuncionario();
            F.MdiParent = this;
            F.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
