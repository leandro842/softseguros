using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

// data access layer Camada de acesso a dados - DAL - responsável por realizar 
//o acesso e a persistência aos dados fazendo a comunicação entre a BLL e UI
namespace DAL 
{
    public class DALConexao
    {
        private String _stringConexao;
        private MySqlConnection _conexao;

        public DALConexao(String dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public MySqlConnection Conexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }

    }
}
