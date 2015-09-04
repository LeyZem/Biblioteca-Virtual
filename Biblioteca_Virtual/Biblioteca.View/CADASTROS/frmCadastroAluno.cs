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
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aLUNOToolStripMenuItem.Enabled = true;

        }

        private void LimpaCampos()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtSobreNome.Text = "";
            txtTelCel.Text = "";
            txtTelRes.Text = "";
            txt_ID.Text = "";
            txt_Nome.Text = "";
            cmbUF.SelectedItem = null;
            dtpNasc.Value = System.DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
