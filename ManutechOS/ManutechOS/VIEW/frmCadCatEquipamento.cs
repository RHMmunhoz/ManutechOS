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
    public partial class frmCadCatEquipamento : Form
    {
        private string op;
        private frmCatEquipamento form;

        public frmCadCatEquipamento(string opcao, CatEquipamento c, frmCatEquipamento f)
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

        public frmCadCatEquipamento(string opcao, frmCatEquipamento f)
        {
            op = opcao;
            form = f;
            InitializeComponent();
            if (op == "novo")
            {
                CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
                txtCodigo.Text = (catEquipamentoDAO.Max_ID() + 1).ToString();
                txtCodigo.Enabled = false;
            }
        }

        //Cria a entidade(DTO) com as informações da visão
        private CatEquipamento GetDTO()
        {
            CatEquipamento catEquipamento = new CatEquipamento();
            catEquipamento.Codigo = int.Parse(txtCodigo.Text);
            catEquipamento.Categoria = txtCategoria.Text;

            return catEquipamento;
        }

        //Coloca as informações do modelo na visão
        private void SetDTO(CatEquipamento c)
        {
            txtCodigo.Text = (c.Codigo).ToString();
            txtCategoria.Text = c.Categoria;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja SALVAR as alterações?",
                "Salvar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
                CatEquipamento c = GetDTO();
                if (op == "novo")
                    catEquipamentoDAO.Create(c);
                if (op == "editar")
                    catEquipamentoDAO.Update(c);
                form.AtualizarDGV();
                MessageBox.Show("Registro salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja CANCELAR as alterações?",
                "Cancelar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
