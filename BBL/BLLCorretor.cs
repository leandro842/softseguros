using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLLCorretor
    {
        private DALConexao conexao;

        public BLLCorretor(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(Corretor corretor)
        {
            if (corretor.Cod_susep.Trim().Length == 0) throw new Exception("O Código Susep é obrigatório");
            
            DALCorretor DALobj = new DALCorretor(conexao);
            DALobj.Incluir(corretor);
        }

        public void Alterar(Corretor corretor)
        {
            if (corretor.Cod_susep == "")
            {
                throw new Exception("O Código Susep é obrigatório");
            }
            DALCorretor DALobj = new DALCorretor(conexao);
            DALobj.Alterar(corretor);
        }

        public void Excluir(String id_corretor)
        {
            DALCorretor DALobj = new DALCorretor(conexao);
            DALobj.Excluir(id_corretor);
        }

        public DataTable Localizar(String valor)//retorna DataTable 
        {
            DALCorretor DALobj = new DALCorretor(conexao);
            return DALobj.Localizar(valor);
        }

        public Corretor CarregaModeloCorretor(String id_corretor)
        {
            DALCorretor DALobj = new DALCorretor(conexao);
            return DALobj.CarregaModeloCorretor(id_corretor);
        }
    }
}
