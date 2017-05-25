using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutechOS
{
    public class Cliente
    {
        private List<Equipamento> equipamentos = new List<Equipamento>();
        //Atributos de Endereco
        private string rua, bairro, cidade, complemento, uf, referencia, cep;
        private int num;
        //Atributos de Contato
        private string email, foneRes, foneCom, foneCel, info;

        //Propriedades
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = (value > 0) ? value : 0; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FoneRes
        {
            get { return foneRes; }
            set { foneRes = value; }
        }
        public string FoneCom
        {
            get { return foneCom; }
            set { foneCom = value; }
        }
        public string FoneCel
        {
            get { return foneCel; }
            set { foneCel = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
    }
}
