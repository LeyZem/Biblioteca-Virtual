using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Model;
using Biblioteca.Controller;
using System.Data.Entity.Validation;


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
            cmbPais.DataSource = ListaPais.ListaPaises();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ALUNO oAluno = new ALUNO();

            oAluno.NOME = txtNome.Text;
            oAluno.SOBRENOME = txtSobreNome.Text;
            oAluno.NASC = dtpNasc.Value.ToString();
            oAluno.CPF = txtCPF.Text;
            oAluno.ENDERECO = txtEnd.Text;
            oAluno.BAIRRO = txtBairro.Text;
            oAluno.CIDADE = txtCidade.Text;
            oAluno.UF = cmbUF.SelectedItem.ToString();
            oAluno.PAIS = cmbPais.SelectedItem.ToString();
            oAluno.CEP = txtCEP.Text;
            oAluno.TEL_RES = txtTelRes.Text;
            oAluno.TEL_CEL = txtTelCel.Text;
            oAluno.EMAIL = txtEmail.Text;

            try
            {
                AlunoWS.Cadastrar(oAluno);
                MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
