using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    public class PessoaFisica:Cliente
    {
        //Atributos
        private string nome, cpf, rg;
        private char sexo;
        private DateTime dataCad, dataNasc;

        //Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public DateTime DataCad
        {
            get { return dataCad; }
            set { dataCad = value; }
        }
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
    }
}
