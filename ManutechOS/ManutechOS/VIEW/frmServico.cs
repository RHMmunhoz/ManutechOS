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

namespace ManutechOS
{
    public partial class frmServico : Form
    {
        private List<Servico> lista = null;

        public frmServico()
        {
            InitializeComponent();
            AtualizarDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadServicos formCadServico = new frmCadServicos("novo", this);
            formCadServico.BringToFront();
            formCadServico.ShowDialog();
        }

        //Cria a entidade(DTO) com as informações da linha selecionada na visão
        private Servico GetDTO()
        {
            Servico servico = new Servico();
            servico.Codigo = (int)dgvServicos.CurrentRow.Cells[0].Value;
            servico.Descricao = (string)dgvServicos.CurrentRow.Cells[1].Value;
            servico.Categoria = (string)dgvServicos.CurrentRow.Cells[2].Value;

            return servico;
        }

        //Atualiza o DataGrid mantendo a configuração da última busca
        public void AtualizarDGV()
        {
            btnBuscar_Click(btnBuscar, new EventArgs());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            lista = new List<Servico>();
            if (rdbCodigo.Checked)
                lista.Add(servicoDAO.Read(int.Parse(txtBusca.Text)));
            else if (rdbServico.Checked)
                lista = servicoDAO.FindByName(txtBusca.Text);
            dgvServicos.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadServicos formServico = new frmCadServicos("editar", this.GetDTO(), this);
            formServico.BringToFront();
            formServico.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadServicos formServicos = new frmCadServicos("visualizar", this.GetDTO(), this);
            formServicos.BringToFront();
            formServicos.ShowDialog();
        }
    }
}
