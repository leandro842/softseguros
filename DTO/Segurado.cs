using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Segurado : Pessoa
    {
        public Segurado() 
        {
            this.Id_segurado = 0;
            this.Escolaridade = "";
            this.Estudante = false;
            this._Estudante = "";
            this.Periodo = "";
            this.Profissao = "";
            this.Nome_banco = "";
            this.Cond = new Condutor();
        }

        private string _estudante;
        public string _Estudante
        {
            get { return _estudante; }
            set { _estudante = value; }
        }

        private Condutor cond;
        public Condutor Cond
        {
            get { return cond; }
            set { cond = value; }
        }

        private int id_segurado;
        public int Id_segurado
        {
            get { return id_segurado; }
            set { id_segurado = value; }
        }
        private string escolaridade;

        public string Escolaridade
        {
            get { return escolaridade; }
            set { escolaridade = value; }
        }

        private bool estudante;
        public bool Estudante
        {
            get { return estudante; }
            set { estudante = value; }
        }
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        private string profissao;

        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }
        private string nome_banco;

        public string Nome_banco
        {
            get { return nome_banco; }
            set { nome_banco = value; }
        }

        public bool validaEstudante()
        {
            if (this._Estudante == "true")
            {
                this.Estudante = true;
                return true;
            }
            else if (this._Estudante == "false")
                return true;
            else
                return false;
        }
    }
}