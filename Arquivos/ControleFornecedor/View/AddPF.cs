using Model.Negocio;
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
    public partial class AddPF : Form
    {
        public AddPF()
        {
            InitializeComponent();
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            EmpresaLogada empresaLogada = new EmpresaLogada();
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year - 18;
            
            DateTime menorIdade = Convert.ToDateTime(dia + "/" + mes + "/" + ano);
            DateTime dataNascimento = Convert.ToDateTime(txtNascimento.Text);            

            if (empresaLogada.UF == "PR" && dataNascimento == menorIdade)
            {
                MessageBox.Show("Seu estado não permite cadastro de menores de idade!");
            }
            else
            {
                CmdFornPF cmdFornPF = new CmdFornPF();
                cmdFornPF.Inserir(txtNome.Text, txtCpf.Text, DateTime.Now, txtTelefone.Text, txtRg.Text, txtNascimento.Text, empresaLogada.ID);
                MessageBox.Show("Cadastro concluido!");
               
                DashBoard dashBoard = new DashBoard();
                dashBoard.CarregarData();
            }
            
        }
    }
}
