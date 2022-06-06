using Model.Negocio;
using Model.VrFi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtUf.MaxLength = 2;
            txtNmF.MaxLength = 100;
            txtCnpj.SelectionLength = 14;

            CmdEmpresa cmdEmpresa = new CmdEmpresa();
            cmdEmpresa.Inserir(txtUf.Text, txtNmF.Text, txtCnpj.Text);
            VrEmpresa vr = new VrEmpresa();
            if (vr.UfEmpresa(txtUf.Text))
            {
                MessageBox.Show("Pelo motivo de voce ser do estado do PARANÁ - PR \n " +
                                "voce terá algumas restrições na hora do cadastro!");
            }
            DialogResult resultado = MessageBox.Show("Cadastrado com sucesso \n Deseja efetuar o login?", "Cadastro", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Visible = true;
            }
        }
    }
}
