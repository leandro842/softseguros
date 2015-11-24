using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Condutor
    {
        public Condutor()
        {
            this.Id_condutor = 0;
            this.Cnh_segurado = "";
            this.Cpf_condutor_a = "";
            this.Cpf_condutor_b = "";
            this.Cnh_condutor_a = "";
            this.Cnh_condutor_b = "";
            this.Parentesco_cond_a = "";
            this.Parentesco_cond_b = "";
        }

        private int id_condutor;
        public int Id_condutor
        {
            get { return id_condutor; }
            set { id_condutor = value; }
        }

        private string cnh_segurado;
        public string Cnh_segurado
        {
            get { return cnh_segurado; }
            set { cnh_segurado = value; }
        }

        private string cpf_condutor_a;
        public string Cpf_condutor_a
        {
            get { return cpf_condutor_a; }
            set { cpf_condutor_a = value; }
        }

        private string cpf_condutor_b;
        public string Cpf_condutor_b
        {
            get { return cpf_condutor_b; }
            set { cpf_condutor_b = value; }
        }

        private string cnh_condutor_a;
        public string Cnh_condutor_a
        {
            get { return cnh_condutor_a; }
            set { cnh_condutor_a = value; }
        }

        private string cnh_condutor_b;
        public string Cnh_condutor_b
        {
            get { return cnh_condutor_b; }
            set { cnh_condutor_b = value; }
        }

        private string parentesco_cond_a;
        public string Parentesco_cond_a
        {
            get { return parentesco_cond_a; }
            set { parentesco_cond_a = value; }
        }

        private string parentesco_cond_b;
        public string Parentesco_cond_b
        {
            get { return parentesco_cond_b; }
            set { parentesco_cond_b = value; }
        }
    }
}