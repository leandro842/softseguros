using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

// Bussiness Logic Layer - Camada de negócios - BLL - responsável por armazenar a lógica da aplicação
//classe responsavel por interagir com a interface - Regra de Negócio
namespace BLL 
{   
    public class BLLPessoa     
    {
        private DALConexao conexao;

        public  BLLPessoa(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(Pessoa pessoa)
        {
            if (pessoa.Nome.Trim().Length == 0) throw new Exception("O Nome é obrigatório");

            if (pessoa.Data_nascimento.Date == null) throw new Exception("A Data de Nascimento é obrigatório");

            if (pessoa.Sexo.Trim().Length == 0) throw new Exception("O Sexo é obrigatório");

            if (pessoa.Estado_civil.Trim().Length == 0) throw new Exception("Estado Civil obrigatório");

            if (pessoa.Celular.Trim().Length == 0) throw new Exception("O Celular é obrigatório");

            if (pessoa.End.Logradouro.Trim().Length == 0) throw new Exception("O Endereço é obrigatório");

            if (pessoa.End.Bairro.Trim().Length == 0) throw new Exception("O Bairro é obrigatório");

            if (pessoa.End.Cep.Trim().Length == 0) throw new Exception("O CEP é obrigatório");

            if (pessoa.End.Localidade.Trim().Length == 0) throw new Exception("A Cidade é obrigatória");

            if (pessoa.End.Uf.Trim().Length == 0) throw new Exception("Sigla UF obrigatória");
                        
            DALPessoa DALobj = new DALPessoa(conexao);
            DALobj.Incluir(pessoa);
        }
 
        public void Alterar(Pessoa pessoa)
        {
            if (pessoa.Nome == "")
            {
                throw new Exception("O Nome é obrigatório");
            }
            if (pessoa.Estado_civil.Trim().Length == 0)
            {
                throw new Exception("O Estado Civil é obrigatório");
            }
            DALPessoa DALobj = new DALPessoa(conexao);
            DALobj.Alterar(pessoa);
        }

        public void Excluir(String id_pessoa)
        {
            DALPessoa DALobj = new DALPessoa(conexao);
            DALobj.Excluir(id_pessoa);
        }

        public DataTable Localizar(String valor)//retorna DataTable 
        {
            DALPessoa DALobj = new DALPessoa(conexao);
            return DALobj.Localizar(valor);
        }

        public Pessoa CarregaModeloPessoa(String id_pessoa)
        {
            DALPessoa DALobj = new DALPessoa(conexao);
            return DALobj.CarregaModeloPessoa(id_pessoa);
        }
    }
}
