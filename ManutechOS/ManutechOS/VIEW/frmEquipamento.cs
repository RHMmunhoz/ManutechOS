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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadEquipamento formCadEquipamento = new frmCadEquipamento();
            //formCadEquipamento.TopLevel = false;
            //Adiciona o Form dentro do Container Principal
            //Parent.Controls.Add(formCadEquipamento);
            //formCadEquipamento.Parent = Parent;
            //Coloca o Form a frente dos outros
            formCadEquipamento.BringToFront();
            formCadEquipamento.ShowDialog();
        }
    }
}
