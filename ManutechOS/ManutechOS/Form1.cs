using System;
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

        private void miSobre_Click(object sender, EventArgs e)
        {
            frmSobre formSobre = new frmSobre();
            formSobre.BringToFront();
            formSobre.ShowDialog();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS f = (frmOS)Application.OpenForms["frmOS"];
            if (f != null)
                f.BringToFront();
            else
            {
                frmOS formOS = new frmOS();
                formOS.TopLevel = false;
                tscContainer.ContentPanel.Controls.Add(formOS);
                formOS.BringToFront();
                formOS.Show();
            }
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            frmTecnico f = (frmTecnico)Application.OpenForms["frmTecnico"];
            if (f != null)
                f.BringToFront();
            else
            {
                frmTecnico formTecnico = new frmTecnico();
                formTecnico.TopLevel = false;
                tscContainer.ContentPanel.Controls.Add(formTecnico);
                formTecnico.BringToFront();
                formTecnico.Show();
            }
        }

        private void miEquipamentos_Click(object sender, EventArgs e)
        {
            btnEquipamentos_Click(btnEquipamentos, e);
        }

        private void miServico_Click(object sender, EventArgs e)
        {
            btnServicos_Click(btnServicos, e);
        }

        private void miClientes_Click(object sender, EventArgs e)
        {
            btnClientes_Click(btnClientes, e);
        }
    }
}
