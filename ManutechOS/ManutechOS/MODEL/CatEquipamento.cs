using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS.MODEL
{
    public class CatEquipamento
    {
        //Atributos
        private int codigo;
        private string categoria;

        //Propriedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}
