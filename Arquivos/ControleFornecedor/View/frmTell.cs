using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Negocio;

namespace View
{
    public partial class frmTell : Form
    {
        public frmTell()
        {
            InitializeComponent();
        }
        public int FkPj { get; set; }
        
        private int fkPf;
        public int FkPf
    {
            get { return fkPf; }
            set { fkPf = value; }
        }


        private void frmTell_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CmdTelefones telefonesAdicionais = new CmdTelefones();
            telefonesAdicionais.InserirPj(Convert.ToString(txtTelefone.Text), FkPj, FkPf);
            MessageBox.Show("Telefone cadastrado com sucesso!");            
        }
    }
}
