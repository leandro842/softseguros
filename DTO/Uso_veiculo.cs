using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Uso_veiculo
    {
        public Uso_veiculo()
        {
            this.Id_uso_veiculo = 0;
            this.Id_veiculo = 0;
            this.Ida_volta_trab = false;
            this._Ida_volta_trab = "";
            this._Gar_est_trab = "";
            this.Gar_est_trab = false;
            this.Ativ_comer = false;
            this._Ativ_comer = "";
            this._Gar_fecha_res = "";
            this.Gar_fecha_res = false;
            this.Port_manual = false;
            this._Port_manual = "";
        }

        private int id_uso_veiculo;
        public int Id_uso_veiculo
        {
            get { return id_uso_veiculo; }
            set { id_uso_veiculo = value; }
        }

        private int id_veiculo;
        public int Id_veiculo
        {
            get { return id_veiculo; }
            set { id_veiculo = value; }
        }

        private string _ida_volta_trab;
        public string _Ida_volta_trab
        {
            get { return _ida_volta_trab; }
            set { _ida_volta_trab = value; }
        }

        private bool ida_volta_trab;
        public bool Ida_volta_trab
        {
            get { return ida_volta_trab; }
            set { ida_volta_trab = value; }
        }

        private string _gar_est_trab;
        public string _Gar_est_trab
        {
            get { return _gar_est_trab; }
            set { _gar_est_trab = value; }
        }

        private bool gar_est_trab;
        public bool Gar_est_trab
        {
            get { return gar_est_trab; }
            set { gar_est_trab = value; }
        }

        private string _ativ_comer;
        public string _Ativ_comer
        {
            get { return _ativ_comer; }
            set { _ativ_comer = value; }
        }

        private bool ativ_comer;
        public bool Ativ_comer
        {
            get { return ativ_comer; }
            set { ativ_comer = value; }
        }

        private string _gar_fecha_res;
        public string _Gar_fecha_res
        {
            get { return _gar_fecha_res; }
            set { _gar_fecha_res = value; }
        }

        private bool gar_fecha_res;
        public bool Gar_fecha_res
        {
            get { return gar_fecha_res; }
            set { gar_fecha_res = value; }
        }

        private string _port_manual;
        public string _Port_manual
        {
            get { return _port_manual; }
            set { _port_manual = value; }
        }

        private bool port_manual;
        public bool Port_manual
        {
            get { return port_manual; }
            set { port_manual = value; }
        }

        public bool valida_ida_volta_trab()
        {
            if (this._Ida_volta_trab == "true")
            {
                this.Ida_volta_trab = true;
                return true;
            }
            else if (this._Ida_volta_trab == "false")
            {
                return true;
            }
            else
                return false;
        }

        public bool valida_ativ_comer()
        {
            if (this._Ativ_comer == "true")
            {
                this.Ativ_comer = true;
                return true;
            }
            else if (this._Ativ_comer == "false")
            {
                return true;
            }else
                return false;
        }

        public bool valida_gar_fecha_res()
        {
            if (this._Gar_fecha_res == "true")
            {
                this.Gar_fecha_res = true;
                return true;
            }
            else if (this._Gar_fecha_res == "false")
            {
                return true;
            }
            else
                return false;
        }

        public bool valida_port_manual()
        {
            if (this._Port_manual == "true")
            {
                this.Port_manual = true;
                return true;
            }else if (this._Port_manual == "false")
            {
                return true;
            }else
                return false;
        }

        public bool valida_gar_est_trab()
        {
            if (this._Gar_est_trab == "true")
            {
                this.Gar_est_trab = true;
                return true;
            }else if (this._Gar_est_trab == "false")
                return true;
            else
                return false;
        }
    }
}