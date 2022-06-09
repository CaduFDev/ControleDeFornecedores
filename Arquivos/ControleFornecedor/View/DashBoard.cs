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
            VrEmpresa vrEmpresa = new VrEmpresa();
            dgvContatosPf.DataSource = vrEmpresa.InfoFornPf(idEmp);
            dgvContatosPj.DataSource = vrEmpresa.InfoFornPj(idEmp);
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
    }
}
