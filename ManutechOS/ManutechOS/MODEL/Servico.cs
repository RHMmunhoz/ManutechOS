using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    public class Servico
    {
        //Atributos
        private string descricao, categoria;

        //Propriedades
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}
