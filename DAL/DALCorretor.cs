using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DALCorretor
    {
        private DALConexao conexao;

        public DALCorretor(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(Corretor corretor)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "insert into corretor(cod_susep) values (@cod_susep); select @@IDENTITY;";
            com.Parameters.AddWithValue("@cod_susep", corretor.Cod_susep);
            conexao.Conectar();
            corretor.Id_corretor = Convert.ToInt32(com.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(Corretor corretor)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "update corretor set cod_susep = @cod_susep where id_corretor = @id_corretor;";
            com.Parameters.AddWithValue("@cod_susep", corretor.Cod_susep);
            com.Parameters.AddWithValue("@id_corretor", corretor.Id_corretor);
            conexao.Conectar();
            com.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(String id_corretor)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "delete from corretor where id_corretor = @id_corretor;";
            com.Parameters.AddWithValue("@id_corretor", id_corretor);
            conexao.Conectar();
            com.ExecuteNonQuery(); //Não obter informação do banco
            conexao.Desconectar();
        }

        public DataTable Localizar(String id_corretor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from corretor where id_corretor =  @valor", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public Corretor CarregaModeloCorretor(String id_corretor)
        {
            Corretor modelo = new Corretor();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from corretor where id_corretor = @id_corretor;";
            com.Parameters.AddWithValue("@id_corretor", id_corretor);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader(); //Obter varios registros
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_corretor = Convert.ToInt32(registro["id_corretor"]);
                modelo.Cod_susep = Convert.ToString(registro["cod_susep"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
