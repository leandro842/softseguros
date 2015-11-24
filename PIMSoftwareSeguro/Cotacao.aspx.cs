using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DTO;
using BLL;

namespace SoftSeguros
{
    public partial class Cotacao : System.Web.UI.Page
    {
        private int ok;
        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Incluir();
            if (ok == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "RedirectDecision();", true);
            }
        }

        private void Incluir()
        {
            try
            {
                DALGeral DALObj = new DALGeral(cx);
                Segurado s = new Segurado();
                s.Nome = txtNome.Text;
                s.Data_nascimento = Convert.ToDateTime(txtDate.Text);
                if (MaleRadioButton.Checked == true) s.Sexo = "M"; else if (FameleRadioButton.Checked == true) s.Sexo = "F";
                s.Estado_civil = CombEstCivil.SelectedValue;
                s.Fone = txtTelefone.Text;
                s.Celular = txtCelular.Text;
                s.End.Cep = txtCEP.Text;
                s.End.Logradouro = txtLogradouro.Text;
                s.End.Bairro = txtBairro.Text;
                s.End.Localidade = txtLocalidade.Text;
                s.End.Uf = CombUf.SelectedValue;
                s.Escolaridade = CombEscolaridade.SelectedValue;
                if (SimEstudante.Checked == true && NãoEstudante.Checked == false) s._Estudante = "true";
                else if (NãoEstudante.Checked == true && SimEstudante.Checked == false) s._Estudante = "false"; else s._Estudante = "";
                if (DiurnoRadioButton.Checked == true && NoturnoRadioButton.Checked == false) s.Periodo = DiurnoRadioButton.Text;
                else if (NoturnoRadioButton.Checked == true && DiurnoRadioButton.Checked == false) s.Periodo = NoturnoRadioButton.Text; else s.Periodo = "";
                s.Profissao = txtProfissao.Text;
                s.Nome_banco = CombBanco.SelectedValue;

                Condutor c = new Condutor();
                c.Cnh_segurado = txtCNHSegurado.Text;
                c.Cpf_condutor_a = txtCPFCondutor_a.Text;
                c.Cnh_condutor_a = txtCNHCondutor_a.Text;
                c.Parentesco_cond_a = CombParentesco.SelectedValue;

                Veiculo v = new Veiculo();
                v.Marca = txtVeiculo.Text;
                v.Modelo = txtModelo.Text;
                v.Ano_fabricacao = Convert.ToInt32(txtAnofabricacao.Text);
                v.Ano_modelo = Convert.ToInt32(txtAnoModelo.Text);
                v._Carro_zero = "true";
                //if (SimZero.Checked == true && NaoZero.Checked == false) v.Carro_zero = true;
                //else if (NaoZero.Checked == true && SimZero.Checked == false) v._Carro_zero = "false"; else v._Carro_zero = "";
                v.Combustivel = CombCombustivel.SelectedValue;
                v.Chassi = txtChassi.Text;
                v.Placa = txtPlaca.Text;
                if (SimDispositivo.Checked == true && NaoDispositivo.Checked == false) v._Disp_anti_furto = "true";
                else if (NaoDispositivo.Checked == true && SimDispositivo.Checked == false) v._Disp_anti_furto = "false"; else v._Disp_anti_furto = "";
                if (SimGas.Checked == true && NaoGas.Checked == false) v._Kit_gas = "true";
                else if (NaoGas.Checked == true && SimGas.Checked == false) v._Kit_gas = "false"; else v._Kit_gas = "";
                if (SimBlindagem.Checked == true && NaoBlindagem.Checked == false) v._Blindagem = "true";
                else if (NaoBlindagem.Checked == true && SimBlindagem.Checked == false) v._Blindagem = "false"; else v._Blindagem = "";
                v.Cep_pernoite = txtcepPernoite.Text;

                Uso_veiculo u = new Uso_veiculo();
                if (SimTrab.Checked == true && NaoTrab.Checked == false) u._Ida_volta_trab = "true";
                else if (NaoTrab.Checked == true && SimTrab.Checked == false) u._Ida_volta_trab = "false"; else u._Ida_volta_trab = "";
                if (SimEstTrab.Checked == true && NaoEstTrab.Checked == false) u._Gar_est_trab = "true";
                else if (NaoEstTrab.Checked == true && SimEstTrab.Checked == false) u._Gar_est_trab = "false"; else u._Gar_est_trab = "";
                if (SimGarFechaCasa.Checked == true && NaoGarFechaCasa.Checked == false) u._Gar_fecha_res = "true";
                else if (NaoGarFechaCasa.Checked == true && SimGarFechaCasa.Checked == false) u._Gar_fecha_res = "false"; else u._Gar_fecha_res = "";
                if (SimPortManual.Checked == true && NaoPortManual.Checked == false) u._Port_manual = "true";
                else if (NaoPortManual.Checked == true && SimPortManual.Checked == false) u._Port_manual = "false"; else u._Port_manual = "";
                if (SimUsoComercial.Checked == true && NaoUsoComercial.Checked == false) u._Ativ_comer = "true";
                else if (NaoUsoComercial.Checked == true && SimUsoComercial.Checked == false) u._Ativ_comer = "false"; else u._Ativ_comer = "";

                string valida = BLLGeral.ValidaCampos(s, c, u, v);
                if (valida == "ok")
                {
                    DALObj.Incluir(s);
                    DALObj.Incluir(c);
                    DALObj.Incluir(v);
                    DALObj.Incluir(u);
                    ok = 1;
                }
                else
                {
                    Response.Write("<script language='javascript' type='text/javascript'>alert(' " + valida + " ')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.WriteFile(ex.Message);
            }
        }

        

        protected void Estudante_CheckedChanged(object sender, EventArgs e)
        {
            if (SimEstudante.Checked == true)
            {
                DiurnoRadioButton.Enabled = true;
                NoturnoRadioButton.Enabled = true;
            }
            else
            {
                DiurnoRadioButton.Enabled= false;
                NoturnoRadioButton.Enabled = false;
                DiurnoRadioButton.Checked = false;
                NoturnoRadioButton.Checked = false;
            }
        }
        protected void Trabalho_CheckedChanged(object sender, EventArgs e)
        {
            if (SimTrab.Checked == true)
            {
                SimEstTrab.Enabled = true;
                NaoEstTrab.Enabled = true;
            }
            else
            {
                SimEstTrab.Enabled = false;
                NaoEstTrab.Enabled = false;
                SimEstTrab.Checked = false;
                NaoEstTrab.Checked = false;
            }
        }
    }
}