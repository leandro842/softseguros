using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DTO;
using DAL;
using BLL;
using System.Globalization;


namespace UI // UI - User Interface
{
    public partial class frm_master : Form
    {
        public frm_master()
        {
            InitializeComponent();
        }

        private void frm_master_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                Pessoa p = new Pessoa();
                p.Nome = txt_nome.Text;
                p.Data_nascimento = Convert.ToDateTime(txt_data_nasc.Text);
                if (comb_sexo.SelectedIndex == 0) 
                    p.Sexo = "M";
                else if (comb_sexo.SelectedIndex == 1)
                    p.Sexo = "F";
                p.Estado_civil = comb_est_civil.Text;
                p.Fone = txt_fone.Text;
                p.Fone = txt_celular.Text;
                p.Celular = txt_celular.Text;
                p.End.Cep = txt_cep.Text;
                p.End.Logradouro = txt_endereco.Text;
                p.End.Bairro = txt_bairro.Text;
                p.End.Localidade = txt_cidade.Text;
                p.End.Uf = comb_uf.Text;
                BLLPessoa bll_p = new BLLPessoa(cx);
                bll_p.Incluir(p);

                Corretor c = new Corretor();
                c.Cod_susep = txt_cod_susep.Text;
                BLLCorretor bll_c = new BLLCorretor(cx);
                bll_c.Incluir(c);

                MessageBox.Show("Cadastro Realizado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//throw ex;
            }
        }
    }
}
