﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutechOS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente f = (frmCliente)Application.OpenForms["frmCliente"];
            if (f != null)
                f.BringToFront();
            else
            {
                frmCliente formCliente = new frmCliente();
                formCliente.TopLevel = false;
                tscContainer.ContentPanel.Controls.Add(formCliente);
                formCliente.BringToFront();
                formCliente.Show();
            }
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            frmEquipamento f = (frmEquipamento)Application.OpenForms["frmEquipamento"];
            if (f != null)
                f.BringToFront();
            else
            {
                frmEquipamento formEquipamento = new frmEquipamento();
                formEquipamento.TopLevel = false;
                tscContainer.ContentPanel.Controls.Add(formEquipamento);
                formEquipamento.BringToFront();
                formEquipamento.Show();
            }
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmServico f = (frmServico)Application.OpenForms["frmServico"];
            if (f != null)
                f.BringToFront();
            else
            {
                frmServico formServico = new frmServico();
                formServico.TopLevel = false;
                tscContainer.ContentPanel.Controls.Add(formServico);
                formServico.BringToFront();
                formServico.Show();
            }
        }
    }
}
