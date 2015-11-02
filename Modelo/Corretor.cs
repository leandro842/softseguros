using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Corretor : Pessoa
    {
        public Corretor()
        {
            this.Id_corretor = 0;
            this.Cod_susep = "";
        }

        private int id_corretor;
        public int Id_corretor
        {
            get { return id_corretor; }
            set { id_corretor = value; }
        }

        private string cod_susep;
        public string Cod_susep
        {
            get { return cod_susep; }
            set { cod_susep = value; }
        }
    }
}
