using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public static class BLLGeral
    {
        public static string ValidaCampos(Segurado seg, Condutor cond, Uso_veiculo u, Veiculo v)
        {
            if (seg.Nome.Trim().Length == 0) return "Você precisa informar um nome!";
            //else if (seg.Data_nascimento.ToString() == "01/01/2010") return "Informe sua data de nascimento!";
            else if (seg.Sexo.Trim().Length == 0) return "Selecione o sexo!";
            else if (seg.Estado_civil.Trim().Length == 0) return "Informe o estado civil!";
            else if (seg.Celular.Trim().Length == 0) return "Informe um número de celular!";
            else if (seg.End.Cep.Trim().Length != 8) return "Informe um CEP válido (apenas números)!";
            else if (seg.End.Logradouro.Trim().Length == 0) return "Informe um logradouro!";
            else if (seg.End.Bairro.Trim().Length == 0) return "Informe um bairro!";
            else if (seg.End.Localidade.Trim().Length == 0) return "Informe uma localidade (cidade/município ou distrito)!";
            else if (seg.End.Uf.Trim().Length != 2) return "Informe um UF (Estado) Válido (Ex: SP)!";

            else if (seg.Escolaridade.Trim().Length == 0) return "O campo Escolaridade não pode ser nulo!";
            else if (seg.validaEstudante() == false) return "A opção estudante deve ser selecionada!";
            else if (seg.Estudante == true && seg.Periodo.Trim().Length == 0) return "Você deve selecionar o período em que estuda!";
            else if (seg.Profissao.Trim().Length == 0) return "Você deve informar sua profissão!";
            else if (seg.Nome_banco.Trim().Length == 0) return "Você deve selecionar um banco!";

            else if (cond.Cnh_segurado.Trim().Length == 0) return "Informe a CNH do segurado!";

            else if (u.valida_ida_volta_trab() == false) return "Você precisa selecionar uma opção de ida/volta do trabalho!";
            else if (u.valida_gar_est_trab() == false) return "Você precisa selecionar uma opção de garagem!";
            else if (u.valida_ativ_comer() == false) return "Você precisa selecionar uma opção de uso comercial!";
            else if (u.valida_gar_fecha_res() == false) return "Você precisa selecionar um tipo de garagem!";
            else if (u.valida_port_manual() == false) return "Você precisa selecionar um tipo de portão!";

            else if (v.Placa.Trim().Length < 1) return "Informe uma placa válida!";
            else if (v.Cep_pernoite.Trim().Length != 8) return "Informe um CEP pernoite válido!";
            else if (v.Marca.Trim().Length == 0) return "Informe a marca do veículo!";
            else if (v.Modelo.Trim().Length == 0) return "Informe o modelo do veículo!";
            else if (v.Ano_fabricacao < 1900 || v.Ano_fabricacao > 2099) return "Informe o ano de fabricação!";
            else if (v.Ano_modelo < 1900 || v.Ano_modelo > 2099) return "Informe o ano do modelo!";
            else if (v.valida_carro_zero() == false) return "Informe se o veículo é 0 Km!";
            else if (v.Combustivel.Trim().Length == 0) return "Informe o tipo de combustivel!";
            else if (v.Chassi.Trim().Length == 0) return "Informe o Nº do Chassi!";
            else if (v.valida_disp_anti_furto() == false) return "Informe se possui disp. antifurto!";
            else if (v.valida_kit_gas() == false) return "Informe se possui Kit Gás!";
            else if (v.valida_blindagem() == false) return "Informe se o veículo possui blindagem!";

            else return "ok";
        }
    }
}
