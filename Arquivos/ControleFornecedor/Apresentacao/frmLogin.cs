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

namespace Apresentacao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string Cnpj;
       
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            CessaoLogin cl = new CessaoLogin();

            Cnpj = Convert.ToString(txtCnpj.Text);

            bool liberarAcesso;
            if (liberarAcesso = cl.VfLogin(Cnpj))
            {
                MessageBox.Show("Logado");
            }
            else
            {
                MessageBox.Show("Erro no Login");
            }
            
        }
    }
}
