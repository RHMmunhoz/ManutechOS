using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManutechOS.MODEL;
using ManutechOS.DAO;

namespace ManutechOS
{
    public partial class frmCadServicos : Form
    {
        private string op;
        private frmServico form;

        public frmCadServicos(string opcao, Servico s, frmServico f)
        {
            op = opcao;
            form = f;
            InitializeComponent();
            txtCodigo.Text = s.Codigo.ToString();
            txtServico.Text = s.Descricao;
            cboCategoria.Text = s.Categoria;
            txtCodigo.Enabled = false;
            ListarCategorias();
            if(op == "visualizar")
            {
                gboDados.Enabled = false;
            }
        }

        public frmCadServicos(string opcao, frmServico f)
        {
            op = opcao;
            form = f;
            InitializeComponent();
            if(opcao == "novo")
            {
                ListarCategorias();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarCategorias()
        {
            List<CatServico> listaCat = new List<CatServico>();
            CatServicoDAO cat = new CatServicoDAO();
            listaCat = cat.ListAll();
            List<string> categorias = new List<string>();
            foreach (CatServico c in listaCat)
                categorias.Add(c.Categoria);
            cboCategoria.DataSource = categorias;
        }
    }
}
