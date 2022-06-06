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
using View.Cache;

namespace View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string CNPJ { get; set; }
        string[] iEmpresa = new string[3];
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            
            CessaoLogin cl = new CessaoLogin();
            CNPJ = Convert.ToString(txtCnpj.Text).Trim();            
            if (cl.VfLogin(CNPJ))
            {
                EmpresaLogada empresaLogada = new EmpresaLogada();
                VrEmpresa vrEmpresa = new VrEmpresa();
                
                /*Obter o ID da empresa*/
                iEmpresa = vrEmpresa.InfoEmpresa(CNPJ);
                empresaLogada.ID = Convert.ToInt32(iEmpresa[0]);
                empresaLogada.UF = Convert.ToString(iEmpresa[1]);
                empresaLogada.Nome = Convert.ToString(iEmpresa[2]);
                empresaLogada.CNPJ = Convert.ToString(iEmpresa[3]);

                MessageBox.Show($"Bem vindo! {empresaLogada.Nome}!", "Cadastro localizado");
                this.Visible = false;                

                DashBoard dashBoard = new DashBoard();
                dashBoard.ShowDialog();

            }
            else
            {
                DialogResult resultadoCadastro = MessageBox.Show("Deseja Cadastrar-se?", "Não localizazdo",  MessageBoxButtons.YesNo);
                if (resultadoCadastro == DialogResult.Yes)
                {
                    txtCnpj.Clear();
                    frmCadEmpresa FrmCadEmpresa = new frmCadEmpresa();
                    this.Visible = false;
                    FrmCadEmpresa.ShowDialog();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {           
        }
    }
}
