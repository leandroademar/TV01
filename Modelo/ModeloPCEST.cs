using System;

namespace Modelo
{
    public class ModeloPCEST
    {
        private int _codprod;
        private int _fimestoque;
        private int _qtpendente;
        private int _qtreserv;
        private int _qtvendaperdida;
        private DateTime _dtultsaida;

        public int codprod
        {
            get
            {
                return this._codprod;
            }
            set
            {
                this._codprod = value;
            }
        }

        public int fimestoque
        {
            get
            {
                return this._fimestoque;
            }
            set
            {
                this._fimestoque = value;
            }
        }

        public int qtpendente
        {
            get
            {
                return this._qtpendente;
            }
            set
            {
                this._qtpendente = value;
            }
        }
        public int qtreserv
        {
            get
            {
                return this._qtreserv;
            }
            set
            {
                this._qtreserv = value;
            }
        }
        public int qtvendaperdida
        {
            get
            {
                return this._qtvendaperdida;
            }
            set
            {
                this._qtvendaperdida = value;
            }
        }
        public DateTime dtultsaida
        {
            get
            {
                return this._dtultsaida;
            }
            set
            {
                this._dtultsaida = value;
            }
        }

    }
}

