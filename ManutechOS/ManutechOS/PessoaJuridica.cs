using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    public class PessoaJuridica:Cliente
    {
        //Atributos
        private string razaoSocial, cnpj, insc;
        private int situacao;
        private DateTime dataCad, dataFund;

        //Propriedades
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Insc
        {
            get { return insc; }
            set { insc = value; }
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = (value == 1) ? value: 0; }
        }
        public DateTime DataCad
        {
            get { return dataCad; }
            set { dataCad = value; }
        }
        public DateTime DataFund
        {
            get { return dataFund; }
            set { dataFund = value; }
        }
    }
}
