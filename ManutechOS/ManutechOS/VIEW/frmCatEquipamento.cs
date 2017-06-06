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
    public partial class frmCatEquipamento : Form
    {
        private List<CatEquipamento> lista = null;

        public frmCatEquipamento()
        {
            InitializeComponent();
            AtualizarDGV();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadCatEquipamento formCategoria = new frmCadCatEquipamento("novo", this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadCatEquipamento formCategoria = new frmCadCatEquipamento("editar", this.GetDTO(), this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmCadCatEquipamento formCategoria = new frmCadCatEquipamento("visualizar", this.GetDTO(), this);
            formCategoria.BringToFront();
            formCategoria.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
            lista = new List<CatEquipamento>();
            if (rdbCodigo.Checked)
                lista.Add(catEquipamentoDAO.Read(int.Parse(txtBusca.Text)));
            else if (rdbCategoria.Checked)
                lista = catEquipamentoDAO.FindByName(txtBusca.Text);
            dgvCatEquipamentos.DataSource = lista;
        }

        //Cria a entidade(DTO) com as informações da linha selecionada na visão
        private CatEquipamento GetDTO()
        {
            CatEquipamento catEquipamento = new CatEquipamento();
            catEquipamento.Codigo = (int)dgvCatEquipamentos.CurrentRow.Cells[0].Value;
            catEquipamento.Categoria = (string)dgvCatEquipamentos.CurrentRow.Cells[1].Value;

            return catEquipamento;
        }

        //Atualiza o DataGrid mantendo a configuração da última busca
        public void AtualizarDGV()
        {
            btnBuscar_Click(btnBuscar, new EventArgs());
        }
    }
}
