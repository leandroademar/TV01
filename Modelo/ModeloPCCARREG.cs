using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPCCARREG
    {
        private int _numcar;
        private DateTime? _dtsaida;
        private double? _totpeso;
        private double? _totvolume;
        private double? _vltotal;
        private string _destino;
        private DateTime? _datamon;
        private short? _codveiculo;
        private int? _codfuncmon;
        private DateTime? _dtfecha;
        private short? _horamon;
        private short? _minutomon;

        public int numcar
        {
            get
            {
                return this._numcar;
            }
            set
            {
                this._numcar = value;
            }
        }
        public DateTime? dtsaida
        {
            get
            {
                return this._dtsaida;
            }
            set
            {
                this._dtsaida = value;
            }
        }
        public double? totpeso
        {
            get
            {
                return this._totpeso;
            }
            set
            {
                this._totpeso = value;
            }
        }
        public double? totvolume
        {
            get
            {
                return this._totvolume;
            }
            set
            {
                this._totvolume = value;
            }
        }
        public double? vltotal
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
        public string destino
        {
            get
            {
                return this._destino;
            }
            set
            {
                this._destino = value;
            }
        }
        public DateTime? datamon
        {
            get
            {
                return this._datamon;
            }
            set
            {
                this._datamon = value;
            }
        }
        public short? codveiculo
        {
            get
            {
                return this._codveiculo;
            }
            set
            {
                this._codveiculo = value;
            }
        }
        public int? codfuncmon
        {
            get
            {
                return this._codfuncmon;
            }
            set
            {
                this._codfuncmon = value;
            }
        }
        public DateTime? dtfecha
        {
            get
            {
                return this._dtfecha;
            }
            set
            {
                this._dtfecha = value;
            }
        }
        public short? horamon
        {
            get
            {
                return this._horamon;
            }
            set
            {
                this._horamon = value;
            }
        }
        public short? minutomon
        {
            get
            {
                return this._minutomon;
            }
            set
            {
                this._minutomon = value;
            }
        }

    }
}
