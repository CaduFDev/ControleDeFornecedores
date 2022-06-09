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
        public int FkPf { get; set; }

        private void frmTell_Load(object sender, EventArgs e)
        {
            CmdTelefones telefonesAdicionais = new CmdTelefones();
            telefonesAdicionais.Inserir(txtTelefone.Text,FkPj,FkPf);
            MessageBox.Show("Telefone cadastrado com sucesso!");
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
