using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    class Equipamento
    {
        private int codigo;
        //Atributos técnicos
        private string descricao, categoria, fabricante, modelo, numSerie;
        //Atributos proprietário
        private string nome, chave;

        private DateTime dataCad;
        private string info;

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
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Chave
        {
            get { return chave; }
            set { chave = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public DateTime DataCad
        {
            get { return dataCad; }
            set { dataCad = value; }
        }
    }
}
