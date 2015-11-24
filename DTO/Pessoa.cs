using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Pessoa
    {
        public Pessoa() 
        {
            this.Id_pessoa = 0;
            this.Nome = "";
            this.Data_nascimento = Convert.ToDateTime("01/01/2010");
            this.Sexo = "";
            this.Estado_civil = "";
            this.Fone = "";
            this.Celular = "";
            this.End = new Endereco();
        }

        private int id_pessoa;
        public int Id_pessoa
        {
            get { return id_pessoa; }
            set { id_pessoa = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime data_nascimento;
        public DateTime Data_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }

        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string estado_civil;
        public string Estado_civil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }

        private string fone;
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

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

        private Endereco end;
        public Endereco End
        {
            get { return end; }
            set { end = value; }
        }
    }
}