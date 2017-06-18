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
                ServicoDAO servicoDAO = new ServicoDAO();
                txtCodigo.Text = (servicoDAO.Max_ID()+1).ToString();
                txtCodigo.Enabled = false;
                ListarCategorias();
            }
        }

        //Cria a entidade(DTO) com as informações da visão
        private Servico GetDTO()
        {
            Servico servico = new Servico();
            servico.Codigo = int.Parse(txtCodigo.Text);
            servico.Descricao = txtServico.Text;
            servico.Categoria = cboCategoria.Text;

            return servico;
        }

        //Coloca as informações do modelo na visão
        private void SetDTO(Servico s)
        {
            txtCodigo.Text = (s.Codigo).ToString();
            txtServico.Text = s.Descricao;
            cboCategoria.Text = s.Categoria;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja CANCELAR as alterações?",
                "Cancelar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja SALVAR as alterações?",
                "Salvar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ServicoDAO servicoDAO = new ServicoDAO();
                Servico s = GetDTO();
                if (op == "novo")
                    servicoDAO.Create(s);
                if (op == "editar")
                    servicoDAO.Update(s);
                form.AtualizarDGV();
                MessageBox.Show("Registro salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
