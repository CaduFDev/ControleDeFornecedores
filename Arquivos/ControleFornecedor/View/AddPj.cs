using Model.Negocio;
using Model.Table;
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
    public partial class AddPj : Form
    {
        public AddPj()
        {
            InitializeComponent();
        }
        public int FkEmp { get; set; }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            cmdFornPJ.Inserir(txtNomeFantasia.Text, txtCnpj.Text, DateTime.Now, txtTelefone.Text,FkEmp);
            MessageBox.Show("Cadastro Realizado com sucesso!");
            DashBoard dashBoard = new DashBoard();
            dashBoard.CarregarData();

        }

        private void AddPj_Load(object sender, EventArgs e)
        {

        }
    }
}
