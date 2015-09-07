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
    public partial class frmConsultaLivros : Form
    {
        public frmConsultaLivros()
        {
            InitializeComponent();
        }

        private void frmConsultaLivros_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).lIVROSToolStripMenuItem.Enabled = true;
        }
    }
}
