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
        
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            
            CessaoLogin cl = new CessaoLogin();
            CNPJ = Convert.ToString(txtCnpj.Text).Trim();            

            if (cl.VfLogin(CNPJ))
            {

                string[] empInfo = InfoEmpresa(CNPJ);
                MessageBox.Show($"Bem vindo! {empInfo[2].ToString()}!", "Cadastro localizado");
                this.Visible = false;                

                DashBoard dashBoard = new DashBoard();
                dashBoard.idEmp = Convert.ToInt32(empInfo[0]);
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
        
        public string[] InfoEmpresa(string cnpj)
        {
            string[] iEmpresa = new string[4];
            VrEmpresa vrEmpresa = new VrEmpresa();
            EmpresaLogada empresaLogada = new EmpresaLogada();
            iEmpresa = vrEmpresa.InfoEmpresa(CNPJ);
            empresaLogada.ID = Convert.ToInt32(iEmpresa[0]);
            empresaLogada.UF = Convert.ToString(iEmpresa[1]);
            empresaLogada.Nome = Convert.ToString(iEmpresa[2]);
            empresaLogada.CNPJ = Convert.ToString(iEmpresa[3]);
            return iEmpresa;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {           
        }
    }
}
