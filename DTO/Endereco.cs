using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Endereco
    {
        public Endereco() { }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string logradouro;
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string localidade;
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}