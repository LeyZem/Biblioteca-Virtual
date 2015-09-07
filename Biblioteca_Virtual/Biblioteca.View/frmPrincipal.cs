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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aLUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aLUNOSToolStripMenuItem.Enabled = false;
            frmConsultaAlunos frm = new frmConsultaAlunos();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void aUTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aUTORESToolStripMenuItem.Enabled = false;
            frmConsultaAutores frm = new frmConsultaAutores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eDITORASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eDITORASToolStripMenuItem.Enabled = false;
            frmConsultaEditoras frm = new frmConsultaEditoras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gÊNEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gÊNEROSToolStripMenuItem.Enabled = false;
            frmConsultaGeneros frm = new frmConsultaGeneros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lIVROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lIVROSToolStripMenuItem.Enabled = false;
            frmConsultaLivros frm = new frmConsultaLivros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aLUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aLUNOToolStripMenuItem.Enabled = false;
            frmCadastroAluno frm = new frmCadastroAluno();
            frm.MdiParent = this;
            frm.Show();

        }

        private void aUTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aUTORToolStripMenuItem.Enabled = false;
            frmCadastroAutor frm = new frmCadastroAutor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eDITORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eDITORAToolStripMenuItem.Enabled = false;
            frmCadastroEditora frm = new frmCadastroEditora();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gENEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gENEROToolStripMenuItem.Enabled = false;
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lIVROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lIVROToolStripMenuItem.Enabled = false;
            frmCadastroLivro frm = new frmCadastroLivro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
