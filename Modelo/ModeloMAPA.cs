using System;

namespace Modelo
{
    public class ModeloMAPA
    {
        private string _cliente;
        private int _codprod;
        private string _recepcao;
        private string _caixa;
        private int _ini;
        private int _fim;
        private long _inumped;
        private long _fnumped;
        private int _serie;
        private string _descricao;
        private string _embalagem;
        private decimal _qtunit;
        private decimal _qtcomp;
        private decimal _valcomp;
        private decimal _vltotal;

        public string cliente
        {
            get
            {
                return this._cliente;
            }
            set
            {
                this._cliente = value;
            }
        }
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
        public string recepcao
        {
            get
            {
                return this._recepcao;
            }
            set
            {
                this._recepcao = value;
            }
        }
        public string caixa
        {
            get
            {
                return this._caixa;
            }
            set
            {
                this._caixa = value;
            }
        }
        public string descricao
        {
            get
            {
                return this._descricao;
            }
            set
            {
                this._descricao = value;
            }
        }
        public string embalagem
        {
            get
            {
                return this._embalagem;
            }
            set
            {
                this._embalagem = value;
            }
        }
        public int ini
        {
            get
            {
                return this._ini;
            }
            set
            {
                this._ini = value;
            }
        }
        public int fim
        {
            get
            {
                return this._fim;
            }
            set
            {
                this._fim = value;
            }
        }
        public int serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }
        public long inumped
        {
            get
            {
                return this._inumped;
            }
            set
            {
                this._inumped = value;
            }
        }
        public long fnumped
        {
            get
            {
                return this._fnumped;
            }
            set
            {
                this._fnumped = value;
            }
        }
        public decimal qtunit
        {
            get
            {
                return this._qtunit;
            }
            set
            {
                this._qtunit = value;
            }
        }
        public decimal qtcomp
        {
            get
            {
                return this._qtcomp;
            }
            set
            {
                this._qtcomp = value;
            }
        }
        public decimal valcomp
        {
            get
            {
                return this._valcomp;
            }
            set
            {
                this._valcomp = value;
            }
        }
        public decimal vltotal
        {
            get
            {
                return this._vltotal;
            }
            set
            {
                this._vltotal = value;
            }
        }
    }
}
