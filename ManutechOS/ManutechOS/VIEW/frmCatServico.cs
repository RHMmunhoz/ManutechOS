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
        private List<CatServico> lista = null;

        public frmCatServico()
        {
            InitializeComponent();
            AtualizarDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadCatServico formCategoria = new frmCadCatServico("novo", this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadCatServico formCategoria = new frmCadCatServico("editar",this.GetDTO(), this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadCatServico formCategoria = new frmCadCatServico("visualizar", this.GetDTO(), this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CatServicoDAO catServicoDAO = new CatServicoDAO();
            lista = new List<CatServico>();
            if (rdbCodigo.Checked)
                lista.Add(catServicoDAO.Read(int.Parse(txtBusca.Text)));
            else if (rdbCategoria.Checked)
                lista = catServicoDAO.FindByName(txtBusca.Text);
            dgvCatServicos.DataSource = lista;
        }

        //Cria a entidade(DTO) com as informações da linha selecionada na visão
        private CatServico GetDTO()
        {
            CatServico catServico = new CatServico();
            catServico.Codigo = (int)dgvCatServicos.CurrentRow.Cells[0].Value;
            catServico.Categoria = (string)dgvCatServicos.CurrentRow.Cells[1].Value;

            return catServico;
        }

        //Atualiza o DataGrid mantendo a configuração da última busca
        public void AtualizarDGV()
        {
            btnBuscar_Click(btnBuscar, new EventArgs());
        }
    }
}
