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
using View.Cache;

namespace View
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        public int idEmp { get; set; }

        public string[] iEmpresa { get; set; } = new string[4];
        public void CarregarData()
        {
            CmdFornPF cmdFornPF = new CmdFornPF();
            dgvContatosPf.DataSource = cmdFornPF.InfoFornPf(idEmp);
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            dgvContatosPj.DataSource = cmdFornPJ.InfoFornPj(idEmp);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            CarregarData();
        }

        private void dgvContatosPj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPJ_Click(object sender, EventArgs e)
        {
            AddPj addPj = new AddPj();
            addPj.FkEmp = idEmp;
            addPj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPF addPF = new AddPF();
            addPF.FkEmp = idEmp;
            addPF.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltroPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCliPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtFiltroPF_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCliPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnAddTelPJ_Click(object sender, EventArgs e)
        {
            int index = dgvContatosPj.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show("Selecione um fornecedor");
            }
            else
            {
                int FkPj = (int)dgvContatosPj.Rows[index].Cells[0].Value;
                frmTell frmTell = new frmTell();
                frmTell.FkPj = FkPj;                
                frmTell.ShowDialog();
            }
        }

        private void btnAddTelPF_Click(object sender, EventArgs e)
        {
            int index = dgvContatosPj.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show("Selecione um fornecedor");
            }
            else
            {
                int FkPf = (int)dgvContatosPj.Rows[index].Cells[0].Value;
                frmTell frmTell = new frmTell();
                frmTell.FkPf = FkPf;                
                frmTell.ShowDialog();
            }
        }

        private void btnAtz_Click(object sender, EventArgs e)
        {
            CarregarData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busca = txtFiltroPJ.Text;
            CmdFornPJ cmdFornPJ = new CmdFornPJ();            
            dgvContatosPj.DataSource = cmdFornPJ.FiltroPj(idEmp, busca);
            dgvContatosPj.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {         
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            dgvContatosPj.DataSource = cmdFornPJ.ClientePj(idEmp, Convert.ToInt32(txtCliPJ.Text));
            dgvContatosPj.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string busca = txtFiltroPF.Text;
            CmdFornPF cmdFornPF = new CmdFornPF();
            dgvContatosPf.DataSource = cmdFornPF.FiltroPf(idEmp, busca);
            dgvContatosPj.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CmdFornPF cmdFornPF = new CmdFornPF();
            dgvContatosPf.DataSource = cmdFornPF.ClientePf(idEmp, Convert.ToInt32(txtCliPF.Text));
            dgvContatosPj.Refresh();
        }
    }
}
