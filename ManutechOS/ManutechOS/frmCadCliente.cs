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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipo_TextChanged(object sender, EventArgs e)
        {
            if(cboTipo.Text == "Pessoa Física")
            {
                gboDados.Enabled = true;
                gboDados.Visible = true;
                gboDadosEmpresa.Enabled = false;
                gboDadosEmpresa.Visible = false;
            }
            else
            {
                gboDados.Enabled = false;
                gboDados.Visible = false;
                gboDadosEmpresa.Enabled = true;
                gboDadosEmpresa.Visible = true;
            }
        }
    }
}
