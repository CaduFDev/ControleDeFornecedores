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
        
        public int FkEmp { get; set; }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            EmpresaLogada empresaLogada = new EmpresaLogada();
            DateTime dataNascimento = Convert.ToDateTime(txtNascimento.Text);
            int menorIdade = comparar(dataNascimento);
            if (empresaLogada.UF == "PR" && menorIdade < 6.570)
            {
                MessageBox.Show("Seu estado não permite cadastro de menores de idade!");
            }
            else
            {
                CmdFornPF cmdFornPF = new CmdFornPF();
                cmdFornPF.Inserir(txtNome.Text, txtCpf.Text, DateTime.Now, txtTelefone.Text, txtRg.Text, txtNascimento.Text,FkEmp);
                MessageBox.Show("Cadastro concluido!");
               
                DashBoard dashBoard = new DashBoard();
                dashBoard.CarregarData();
            }
            
        }
        public static int comparar (DateTime dataNascimento)
        {
            DateTime menorIdade = new DateTime(DateTime.Today.Year - 18, 1, 1);
            int resultado = (int)dataNascimento.Subtract(menorIdade).TotalDays;
            return resultado;
            
        }
       
    }
}
