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
    public partial class frmCadastroGenero : Form
    {
        public frmCadastroGenero()
        {
            InitializeComponent();
        }

        private void frmCadastroGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).lIVROToolStripMenuItem.Enabled = true;
        }
    }
}
