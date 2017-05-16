using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    class OrdemServico
    {
        //Atributos
        private Cliente cliente = new Cliente();
        private List<Servico> servicos = new List<Servico>();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        private string status, info;
        private DateTime dataAbertura, dataFechamento, dataInicio, dataFim;
    }
}
