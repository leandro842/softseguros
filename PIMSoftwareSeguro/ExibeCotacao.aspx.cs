using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DTO;


namespace SoftSeguros
{
    public partial class ExibeCotacao : System.Web.UI.Page
    {
        private int ID_seg;
        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        protected void Page_Load(object sender, EventArgs e)
        {
            DALGeral DALObj = new DALGeral(cx);
            Segurado s_id = DALObj.RetornaId();
            ID_seg = s_id.Id_segurado;
            Pessoa p = DALObj.CerregaModeloPessoa(ID_seg);
            Segurado s = DALObj.CerregaModeloSegurado(ID_seg);
            Condutor c = DALObj.CarregaModeloCondutor(ID_seg);
            Veiculo v = DALObj.CarregaModeloVeiculo(ID_seg);
            Uso_veiculo u = DALObj.CarregaModeloUsoVeiculo(ID_seg);

            lblNome.Text = p.Nome;
            lblEmail.Text = "";
            lblFone.Text = p.Fone;
            lblCel.Text = p.Celular;
            if (p.Sexo == "M") lblSexo.Text = "Masculino"; else lblSexo.Text = "Feminino";
            lblDataNascimento.Text = p.Data_nascimento.ToString();
            lblEstadoCivil.Text = p.Estado_civil;
            lblEscolaridade.Text = s.Escolaridade;
            lblProfissao.Text = s.Profissao;
            lblNomeBanco.Text = s.Nome_banco;
            if (s.Estudante == true) lblEstudante.Text = "Sim"; else lblEstudante.Text = "Não";
            lblCepEndereco.Text = p.End.Cep;
            lblLogradouro.Text = p.End.Logradouro;
            lblBairro.Text = p.End.Bairro;
            lblLocalidade.Text = p.End.Localidade;
            lblUf.Text = p.End.Uf;
            lblCpfSegurado.Text = "";
            lblCnhSegurado.Text = c.Cnh_segurado;
            lblCpfCond1.Text = c.Cpf_condutor_a;
            lblCnhCond1.Text = c.Cnh_condutor_a;
            lblParentescoCondutor.Text = c.Parentesco_cond_a;
            lblMarcaVeiculo.Text = v.Marca;
            lblModeloVeiculo.Text = v.Modelo;
            lblAnoFabricacao.Text = v.Ano_fabricacao.ToString();
            lblAnoModelo.Text = v.Ano_modelo.ToString();
            if (v.Carro_zero == true) lblCarroZero.Text = "Sim"; else lblCarroZero.Text = "Não";
            lblCombustivel.Text = v.Combustivel;
            lblChassi.Text = v.Chassi;
            lblPlaca.Text = v.Placa;
            if (v.Disp_anti_furto == true) lblDispAntFurto.Text = "Sim"; else lblDispAntFurto.Text = "Não";
            if (v.Kit_gas == true) lblKitGas.Text = "Sim"; else lblKitGas.Text = "Não";
            if (v.Blindagem == true) lblBlindagem.Text = "Sim"; else lblBlindagem.Text = "Não";
            if (v.Blindagem == true) lblBlindagem.Text = "Sim"; else lblBlindagem.Text = "Não";
            lblCepPernoite.Text = v.Cep_pernoite;
            if (u.Gar_est_trab == true) lblEstacionamentoTrab.Text = "Sim"; else lblEstacionamentoTrab.Text = "Não";
            if (u.Gar_fecha_res == true) lblGaragemCasa.Text = "Sim"; else lblGaragemCasa.Text = "Não";
            if (u.Port_manual == true) lblPortao.Text = "Sim"; else lblPortao.Text = "Não";
            if (u.Ativ_comer == true) lblUsoComercial.Text = "Sim"; else lblUsoComercial.Text = "Não";
        }
    }
}