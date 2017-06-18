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
        private int codigo;
        private string descricao, categoria;

        //Propriedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

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
