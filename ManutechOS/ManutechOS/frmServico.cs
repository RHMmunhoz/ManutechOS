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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadServicos formCadServico = new frmCadServicos();
            formCadServico.TopLevel = false;
            //Adiciona o Form dentro do Container Principal
            Parent.Controls.Add(formCadServico);
            formCadServico.Parent = Parent;
            //Coloca o Form a frente dos outros
            formCadServico.BringToFront();
            formCadServico.Show();
        }
    }
}
