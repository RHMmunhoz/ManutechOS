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

namespace ManutechOS.VIEW
{
    public partial class frmCadCatServico : Form
    {
        private string op;
        private frmCatServico form;

        public frmCadCatServico(string opcao, CatServico c, frmCatServico f)
        {
            op = opcao;
            form = f;
            InitializeComponent();
            txtCodigo.Text = c.Codigo.ToString();
            txtCategoria.Text = c.Categoria;
            txtCodigo.Enabled = false;
            if (op == "visualizar")
            {
                txtCategoria.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        public frmCadCatServico(string opcao, frmCatServico f)
        {
            op = opcao;
            form = f;
            InitializeComponent();
            if(op == "novo")
            {
                CatServicoDAO catServicoDAO = new CatServicoDAO();
                txtCodigo.Text = (catServicoDAO.Max_ID() + 1).ToString();
                txtCodigo.Enabled = false;
            }
        }

        //Cria a entidade(DTO) com as informações da visão
        private CatServico GetDTO()
        {
            CatServico catServico = new CatServico();
            catServico.Codigo = int.Parse(txtCodigo.Text);
            catServico.Categoria = txtCategoria.Text;

            return catServico;
        }

        //Coloca as informações do modelo na visão
        private void SetDTO(CatServico c)
        {
            txtCodigo.Text = (c.Codigo).ToString();
            txtCategoria.Text = c.Categoria;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CatServicoDAO catServicoDAO = new CatServicoDAO();
            CatServico c = GetDTO();
            if(op  == "novo")
                catServicoDAO.Create(c);
            if (op == "editar")
                catServicoDAO.Update(c);
            form.AtualizarDGV();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
