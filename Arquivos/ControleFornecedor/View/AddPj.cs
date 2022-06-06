﻿using Model.Negocio;
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CmdFornPJ cmdFornPJ = new CmdFornPJ();
            EmpresaLogada empresaLogada = new EmpresaLogada();
            cmdFornPJ.Inserir(txtNomeFantasia.Text, txtCnpj.Text, DateTime.Now, txtTelefone.Text, empresaLogada.ID);
            MessageBox.Show("Cadastro Realizado com sucesso!");
            DashBoard dashBoard = new DashBoard();
            dashBoard.CarregarData();

        }
    }
}
