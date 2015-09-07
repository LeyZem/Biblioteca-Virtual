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
    public partial class frmCadastroAutor : Form
    {
        public frmCadastroAutor()
        {
            InitializeComponent();
        }

        private void frmCadastroAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aUTORToolStripMenuItem.Enabled = true;

        }
    }
}
