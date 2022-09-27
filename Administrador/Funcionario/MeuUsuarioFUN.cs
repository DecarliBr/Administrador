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
    public partial class FRM_MeuUsuarioFUN : Form
    {
        public FRM_MeuUsuarioFUN()
        {
            InitializeComponent();
        }

        private void TXB_UsuarioMuADM_TextChanged(object sender, EventArgs e)
        {
            FRM_Login user = new FRM_Login();

        }
    }
}
