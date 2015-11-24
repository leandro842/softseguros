using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Veiculo
    {
        public Veiculo()
        {
            this.Id_veiculo = 0;
            this.Placa = "";
            this.Cep_pernoite = "";
            this.Marca = "";
            this.Modelo = "";
            this.Ano_fabricacao = 0;
            this.ano_modelo = 0;
            this._Carro_zero = "";
            this.Carro_zero = false;
            this.Combustivel = "";
            this.Chassi = "";
            this._Disp_anti_furto = "";
            this.Disp_anti_furto = false;
            this._Kit_gas = "";
            this.Kit_gas = false;
            this._Blindagem = "";
            this.Blindagem = false;
        }

        private int id_veiculo;
        public int Id_veiculo
        {
            get { return id_veiculo; }
            set { id_veiculo = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string cep_pernoite;
        public string Cep_pernoite
        {
            get { return cep_pernoite; }
            set { cep_pernoite = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int ano_fabricacao;
        public int Ano_fabricacao
        {
            get { return ano_fabricacao; }
            set { ano_fabricacao = value; }
        }

        private int ano_modelo;
        public int Ano_modelo
        {
            get { return ano_modelo; }
            set { ano_modelo = value; }
        }

        private bool carro_zero;
        public bool Carro_zero
        {
            get { return carro_zero; }
            set { carro_zero = value; }
        }

        private string _carro_zero;
        public string _Carro_zero
        {
            get { return _carro_zero; }
            set { _carro_zero = value; }
        }

        private string combustivel;
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        private string chassi;
        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        private bool disp_anti_furto;
        public bool Disp_anti_furto
        {
            get { return disp_anti_furto; }
            set { disp_anti_furto = value; }
        }

        private string _disp_anti_furto;
        public string _Disp_anti_furto
        {
            get { return _disp_anti_furto; }
            set { _disp_anti_furto = value; }
        }

        private bool kit_gas;
        public bool Kit_gas
        {
            get { return kit_gas; }
            set { kit_gas = value; }
        }

        private string _kit_gas;
        public string _Kit_gas
        {
            get { return _kit_gas; }
            set { _kit_gas = value; }
        }

        private bool blindagem;
        public bool Blindagem
        {
            get { return blindagem; }
            set { blindagem = value; }
        }

        private string _blindagem;
        public string _Blindagem
        {
            get { return _blindagem; }
            set { _blindagem = value; }
        }

        public bool valida_carro_zero()
        {
            if (this._Carro_zero == "true")
            {
                this.Carro_zero = true;
                return true;
            }
            else if (this._Carro_zero == "false")
            {
                return true;
            }
            else
                return false;
        }

        public bool valida_disp_anti_furto()
        {
            if (this._Disp_anti_furto == "true")
            {
                this.Disp_anti_furto = true;
                return true;
            }else if (this._Disp_anti_furto == "false")
            {
                return true;
            }else
                return false;
        }

        public bool valida_kit_gas()
        {
            if (this._Kit_gas == "true")
            {
                this.Kit_gas = true;
                return true;
            }
            else if (this._Kit_gas == "false")
            {
                return true;
            }
            else
                return false;
        }

        public bool valida_blindagem()
        {
            if (this._Blindagem == "true")
            {
                this.Blindagem = true;
                return true;
            }
            else if (this._Blindagem == "false")
            {
                return true;
            }
            else
                return false;
        }
    }
}
