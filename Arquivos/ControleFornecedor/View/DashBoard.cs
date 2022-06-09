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
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            dgvContatosPf.DataSource = cmdFornPF.InfoFornPf(idEmp);
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
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            cmdFornPJ.FiltroPj(idEmp, Convert.ToString(txtCliPJ.Text));
        }

        private void txtCliPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            cmdFornPJ.ClientePj(idEmp, Convert.ToInt32(txtCliPJ.Text));
        }

        private void txtFiltroPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            CmdFornPF cmdFornPF = new CmdFornPF();
            cmdFornPF.FiltroPf(idEmp, Convert.ToString(txtCliPF.Text));
        }

        private void txtCliPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            CmdFornPF cmdFornPF = new CmdFornPF();
            cmdFornPF.ClientePf(idEmp, Convert.ToInt32(txtCliPF.Text));
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
                frmTell.FkPf = 0;
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
                frmTell.FkPj = 0;
                frmTell.ShowDialog();
            }
        }
    }
}
