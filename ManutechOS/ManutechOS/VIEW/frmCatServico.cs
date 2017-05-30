using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManutechOS.DAO;
using ManutechOS.MODEL;

namespace ManutechOS.VIEW
{
    public partial class frmCatServico : Form
    {
        public frmCatServico()
        {
            InitializeComponent();
            CatServicoDAO catServicoDAO = new CatServicoDAO();
            List<CatServico> lista = catServicoDAO.ListAll();
            dgvCatServicos.DataSource = lista;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadCatServico formCategoria = new frmCadCatServico("novo");
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadCatServico formCategoria = new frmCadCatServico("editar");
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }
    }
}
