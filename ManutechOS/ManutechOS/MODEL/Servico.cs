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
        private int codigo, categoria;
        private string descricao;

        //Propriedades
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
