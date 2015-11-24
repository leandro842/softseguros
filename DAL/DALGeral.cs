using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class DALGeral
    {
        private int ID_segurado;
        private int ID_veiculo;
        private DALConexao conexao;

        public DALGeral(DALConexao conn)
        {
            this.conexao = conn;
        }

        public void Incluir(Segurado segurado)
        {
            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = conexao.Conexao;
                com.CommandText = "insert into pessoa(nome, data_nascimento, sexo, estado_civil, fone, celular," +
                    "cep, logradouro, bairro, localidade, uf) values (@nome, @data_nascimento, @sexo, @estado_civil," +
                    "@fone, @celular, @cep, @logradouro, @bairro, @localidade, @uf); select @@IDENTITY;";
                com.Parameters.AddWithValue("@nome", segurado.Nome);
                com.Parameters.AddWithValue("@data_nascimento", segurado.Data_nascimento);
                com.Parameters.AddWithValue("@sexo", segurado.Sexo);
                com.Parameters.AddWithValue("@estado_civil", segurado.Estado_civil);
                com.Parameters.AddWithValue("@fone", segurado.Fone);
                com.Parameters.AddWithValue("@celular", segurado.Celular);
                com.Parameters.AddWithValue("@cep", segurado.End.Cep);
                com.Parameters.AddWithValue("@logradouro", segurado.End.Logradouro);
                com.Parameters.AddWithValue("@bairro", segurado.End.Bairro);
                com.Parameters.AddWithValue("@localidade", segurado.End.Localidade);
                com.Parameters.AddWithValue("@uf", segurado.End.Uf);
                conexao.Conectar();
                segurado.Id_pessoa = Convert.ToInt32(com.ExecuteScalar());
                ID_segurado = segurado.Id_pessoa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }


            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = conexao.Conexao;
                com.CommandText = "insert into segurado(escolaridade, estudante, periodo, profissao, nome_banco, id_pessoa)" +
                    " values(@escolaridade, @estudante, @periodo, @profissao, @nome_banco, @id_pessoa); select @@IDENTITY; ";
                com.Parameters.AddWithValue("@escolaridade", segurado.Escolaridade);
                com.Parameters.AddWithValue("@estudante", segurado.Estudante);
                com.Parameters.AddWithValue("@periodo", segurado.Periodo);
                com.Parameters.AddWithValue("@profissao", segurado.Profissao);
                com.Parameters.AddWithValue("@nome_banco", segurado.Nome_banco);
                com.Parameters.AddWithValue("@id_pessoa", segurado.Id_pessoa);
                conexao.Conectar();
                segurado.Id_segurado = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Incluir(Condutor condutor)
        {
            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = conexao.Conexao;
                com.CommandText = "insert into condutor(id_segurado, cnh_segurado, cpf_condutor_a, cpf_condutor_b, cnh_condutor_a,"+
                    "cnh_condutor_b, parentesco_cond_a, parentesco_cond_b) values (@id_segurado, @cnh_segurado, @cpf_condutor_a,"+
                    "@cpf_condutor_b, @cnh_condutor_a, @cnh_condutor_b, @parentesco_cond_a, @parentesco_cond_b); select @@IDENTITY;";
                com.Parameters.AddWithValue("@id_segurado", ID_segurado);
                com.Parameters.AddWithValue("@cnh_segurado", condutor.Cnh_segurado);
                com.Parameters.AddWithValue("@cpf_condutor_a", condutor.Cpf_condutor_a);
                com.Parameters.AddWithValue("@cpf_condutor_b", condutor.Cpf_condutor_b);
                com.Parameters.AddWithValue("@cnh_condutor_a", condutor.Cnh_condutor_a);
                com.Parameters.AddWithValue("@cnh_condutor_b", condutor.Cnh_condutor_b);
                com.Parameters.AddWithValue("@parentesco_cond_a", condutor.Parentesco_cond_a);
                com.Parameters.AddWithValue("@parentesco_cond_b", condutor.Parentesco_cond_b);
                conexao.Conectar();
                condutor.Id_condutor = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Incluir(Veiculo veiculo)
        {
            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = conexao.Conexao;
                com.CommandText = "insert into veiculo(placa, cep_pernoite, marca, modelo, ano_fabricacao," +
                    "ano_modelo, carro_zero, combustivel, chassi, disp_anti_furto, kit_gas, blindagem) values (@placa, @cep_pernoite, @marca," +
                    "@modelo, @ano_fabricacao, @ano_modelo, @carro_zero, @combustivel, @chassi, @disp_anti_furto, @kit_gas, @blindagem); select @@IDENTITY;";
                com.Parameters.AddWithValue("@placa", veiculo.Placa);
                com.Parameters.AddWithValue("@cep_pernoite", veiculo.Cep_pernoite);
                com.Parameters.AddWithValue("@marca", veiculo.Marca);
                com.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                com.Parameters.AddWithValue("@ano_fabricacao", veiculo.Ano_fabricacao);
                com.Parameters.AddWithValue("@ano_modelo", veiculo.Ano_modelo);
                com.Parameters.AddWithValue("@carro_zero", veiculo.Carro_zero);
                com.Parameters.AddWithValue("@combustivel", veiculo.Combustivel);
                com.Parameters.AddWithValue("@chassi", veiculo.Chassi);
                com.Parameters.AddWithValue("@disp_anti_furto", veiculo.Disp_anti_furto);
                com.Parameters.AddWithValue("@kit_gas", veiculo.Kit_gas);
                com.Parameters.AddWithValue("@blindagem", veiculo.Blindagem);
                conexao.Conectar();
                veiculo.Id_veiculo = Convert.ToInt32(com.ExecuteScalar());
                ID_veiculo = veiculo.Id_veiculo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Incluir(Uso_veiculo uso)
        {
            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = conexao.Conexao;
                com.CommandText = "insert into uso_veiculo(id_veiculo, ida_volta_trab, gar_est_trab, ativ_comer, gar_fecha_res, port_manual)" +
                    "values (@id_veiculo, @ida_volta_trab, @gar_est_trab, @ativ_comer, @gar_fecha_res, @port_manual); select @@IDENTITY;";
                com.Parameters.AddWithValue("@id_veiculo", ID_veiculo);
                com.Parameters.AddWithValue("@ida_volta_trab", uso.Ida_volta_trab);
                com.Parameters.AddWithValue("@gar_est_trab", uso.Gar_est_trab);
                com.Parameters.AddWithValue("@ativ_comer", uso.Ativ_comer);
                com.Parameters.AddWithValue("@gar_fecha_res", uso.Gar_fecha_res);
                com.Parameters.AddWithValue("@port_manual", uso.Port_manual);
                conexao.Conectar();
                uso.Id_uso_veiculo = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public Pessoa CerregaModeloPessoa(int id_pessoa)
        {
            Segurado modelo = new Segurado();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from pessoa where id_pessoa = @id_pessoa;";
            com.Parameters.AddWithValue("@id_pessoa", id_pessoa);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader();
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

        public Segurado CerregaModeloSegurado(int id_segurado)
        {
            Segurado modelo = new Segurado();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from segurado where id_segurado = @id_segurado;";
            com.Parameters.AddWithValue("@id_segurado", id_segurado);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Escolaridade = Convert.ToString(registro["escolaridade"]);
                modelo.Estudante = Convert.ToBoolean(registro["estudante"]);
                modelo.Periodo = Convert.ToString(registro["periodo"]);
                modelo.Profissao = Convert.ToString(registro["profissao"]);
                modelo.Nome_banco = Convert.ToString(registro["nome_banco"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public Segurado RetornaId()
        {
            Segurado modelo = new Segurado();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select id_segurado from segurado order by id_segurado desc limit 1;";
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_segurado = Convert.ToInt32(registro["id_segurado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public Condutor CarregaModeloCondutor(int id_condutor)
        {
            Condutor modelo = new Condutor();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from condutor where id_condutor = @id_condutor;";
            com.Parameters.AddWithValue("@id_condutor", id_condutor);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader(); //Obter varios registros
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_condutor = Convert.ToInt32(registro["id_condutor"]);
                modelo.Cnh_segurado = Convert.ToString(registro["cnh_segurado"]);
                modelo.Cpf_condutor_a = Convert.ToString(registro["cpf_condutor_a"]);
                modelo.Cpf_condutor_b = Convert.ToString(registro["cpf_condutor_b"]);
                modelo.Cnh_condutor_a = Convert.ToString(registro["cnh_condutor_a"]);
                modelo.Cnh_condutor_b = Convert.ToString(registro["cnh_condutor_b"]);
                modelo.Parentesco_cond_a = Convert.ToString(registro["parentesco_cond_a"]);
                modelo.Parentesco_cond_b = Convert.ToString(registro["parentesco_cond_b"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public Veiculo CarregaModeloVeiculo(int id_veiculo)
        {
            Veiculo modelo = new Veiculo();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from veiculo where id_veiculo = @id_veiculo;";
            com.Parameters.AddWithValue("@id_veiculo", id_veiculo);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_veiculo = Convert.ToInt32(registro["id_veiculo"]);
                modelo.Placa = Convert.ToString(registro["placa"]);
                modelo.Cep_pernoite = Convert.ToString(registro["cep_pernoite"]);
                modelo.Marca = Convert.ToString(registro["marca"]);
                modelo.Modelo = Convert.ToString(registro["modelo"]);
                modelo.Ano_fabricacao = Convert.ToInt32(registro["ano_fabricacao"]);
                modelo.Ano_modelo = Convert.ToInt32(registro["ano_modelo"]);
                modelo.Carro_zero = Convert.ToBoolean(registro["carro_zero"]);
                modelo.Combustivel = Convert.ToString(registro["combustivel"]);
                modelo.Chassi = Convert.ToString(registro["chassi"]);
                modelo.Disp_anti_furto = Convert.ToBoolean(registro["disp_anti_furto"]);
                modelo.Kit_gas = Convert.ToBoolean(registro["kit_gas"]);
                modelo.Blindagem = Convert.ToBoolean(registro["blindagem"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public Uso_veiculo CarregaModeloUsoVeiculo(int id_uso_veiculo)
        {
            Uso_veiculo modelo = new Uso_veiculo();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexao.Conexao;
            com.CommandText = "select * from uso_veiculo where id_uso_veiculo = @id_uso_veiculo;";
            com.Parameters.AddWithValue("@id_uso_veiculo", id_uso_veiculo);
            conexao.Conectar();
            MySqlDataReader registro = com.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_veiculo = Convert.ToInt32(registro["id_veiculo"]);
                modelo.Ida_volta_trab = Convert.ToBoolean(registro["ida_volta_trab"]);
                modelo.Gar_est_trab = Convert.ToBoolean(registro["gar_est_trab"]);
                modelo.Ativ_comer = Convert.ToBoolean(registro["ativ_comer"]);
                modelo.Gar_fecha_res = Convert.ToBoolean(registro["gar_fecha_res"]);
                modelo.Port_manual = Convert.ToBoolean(registro["port_manual"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}