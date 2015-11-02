using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DALPessoa
    {
        private DALConexao conexao;

        public DALPessoa(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(Pessoa pessoa)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "insert into pessoa(nome, data_nascimento, sexo, estado_civil, fone, celular,"+
                "cep, logradouro, bairro, localidade, uf) values (@nome, @data_nascimento, @sexo, @estado_civil,"+
                "@fone, @celular, @cep, @logradouro, @bairro, @localidade, @uf); select @@IDENTITY;";
            com.Parameters.AddWithValue("@nome", pessoa.Nome);
            com.Parameters.AddWithValue("@data_nascimento", pessoa.Data_nascimento);
            com.Parameters.AddWithValue("@sexo", pessoa.Sexo);
            com.Parameters.AddWithValue("@estado_civil", pessoa.Estado_civil);
            com.Parameters.AddWithValue("@fone", pessoa.Fone);
            com.Parameters.AddWithValue("@celular", pessoa.Celular);
            com.Parameters.AddWithValue("@cep", pessoa.End.Cep);
            com.Parameters.AddWithValue("@logradouro", pessoa.End.Logradouro);
            com.Parameters.AddWithValue("@bairro", pessoa.End.Bairro);
            com.Parameters.AddWithValue("@localidade", pessoa.End.Localidade);
            com.Parameters.AddWithValue("@uf", pessoa.End.Uf);
            conexao.Conectar();
            pessoa.Id_pessoa = Convert.ToInt32(com.ExecuteScalar()); //Obter pouca informação do banco
            conexao.Desconectar();
        }

        public void Alterar(Pessoa pessoa)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "update pessoa set estado_civil = @estado_civil where id_pessoa = @id_pessoa;";
            com.Parameters.AddWithValue("@estado_civil",pessoa.Estado_civil);
            com.Parameters.AddWithValue("@cpf", pessoa.Id_pessoa);
            conexao.Conectar();
            com.ExecuteNonQuery();
            conexao.Desconectar();      
        }

        public void Excluir(String id_pessoa)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "delete from pessoa where id_pessoa = @id_pessoa;";
            com.Parameters.AddWithValue("@id_pessoa", id_pessoa);
            conexao.Conectar();
            com.ExecuteNonQuery(); //Não obter informação do banco
            conexao.Desconectar();  
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from pessoa where nome like '%"+valor+"%'",conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public Pessoa CarregaModeloPessoa(String id_pessoa)
        {
            Pessoa modelo = new Pessoa();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from pessoa where id_pessoa = @id_pessoa;";
            com.Parameters.AddWithValue("@id_pessoa", id_pessoa);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader(); //Obter varios registros
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_pessoa = Convert.ToInt32(registro["id_pessoa"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Data_nascimento = Convert.ToDateTime(registro["data_nascimento"]);
                modelo.Sexo = Convert.ToString(registro["sexo"]);
                modelo.Estado_civil = Convert.ToString(registro["estado_civil"]);
                modelo.Fone = Convert.ToString(registro["fone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.End.Cep = Convert.ToString(registro["cep"]);
                modelo.End.Logradouro = Convert.ToString(registro["logradouro"]);
                modelo.End.Bairro = Convert.ToString(registro["bairro"]);
                modelo.End.Localidade = Convert.ToString(registro["localidade"]);
                modelo.End.Uf = Convert.ToString(registro["uf"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
