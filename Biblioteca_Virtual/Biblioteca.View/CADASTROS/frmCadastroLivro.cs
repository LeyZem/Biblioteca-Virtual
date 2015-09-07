using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class frmCadastroLivro : Form
    {
        public frmCadastroLivro()
        {
            InitializeComponent();
        }

        private void frmCadastroLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).lIVROToolStripMenuItem.Enabled = true;

        }
    }
}
