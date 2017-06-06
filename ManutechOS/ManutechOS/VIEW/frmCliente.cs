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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadCliente formCadCliente = new frmCadCliente();
            //formCadCliente.TopLevel = false;
            //Adiciona o Form dentro do Container Principal
            //Parent.Controls.Add(formCadCliente);
            //formCadCliente.Parent = Parent;
            //Coloca o Form a frente dos outros
            formCadCliente.BringToFront();
            formCadCliente.ShowDialog();
        }
    }
}
