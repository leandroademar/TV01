using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPCVENDACONSUM
    {
        public ModeloPCVENDACONSUM()
        {
            this.cliente = "CONSUMIRDOR FINAL";
            this.cgcent = "11111111111";
        }
        
        private long? _numped;
        private string _cliente;
        private string _cgcent;
        private string _enderent;
        private string _bairroent;
        private string _telent;
        private string _municent;
        private string _estent;
        private string _cepent;
        private string _ieent;
        private string _nomecontato;
        private string _telefonecontato;
        private string _obscontato;
        private string _email;
        private int? _codcidade;
        private string _numeroent;
        public long? numped
        {
            get
            {
                return this._numped;
            }
            set
            {
                this._numped = value;
            }
        }
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
        public string cgcent
        {
            get
            {
                return this._cgcent;
            }
            set
            {
                this._cgcent = value;
            }
        }
        public string enderent
        {
            get
            {
                return this._enderent;
            }
            set
            {
                this._enderent = value;
            }
        }
        public string bairroent
        {
            get
            {
                return this._bairroent;
            }
            set
            {
                this._bairroent = value;
            }
        }
        public string telent
        {
            get
            {
                return this._telent;
            }
            set
            {
                this._telent = value;
            }
        }
        public string municent
        {
            get
            {
                return this._municent;
            }
            set
            {
                this._municent = value;
            }
        }
        public string estent
        {
            get
            {
                return this._estent;
            }
            set
            {
                this._estent = value;
            }
        }
        public string cepent
        {
            get
            {
                return this._cepent;
            }
            set
            {
                this._cepent = value;
            }
        }
        public string ieent
        {
            get
            {
                return this._ieent;
            }
            set
            {
                this._ieent = value;
            }
        }
        public string nomecontato
        {
            get
            {
                return this._nomecontato;
            }
            set
            {
                this._nomecontato = value;
            }
        }
        public string telefonecontato
        {
            get
            {
                return this._telefonecontato;
            }
            set
            {
                this._telefonecontato = value;
            }
        }
        public string obscontato
        {
            get
            {
                return this._obscontato;
            }
            set
            {
                this._obscontato = value;
            }
        }
        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        public int? codcidade
        {
            get
            {
                return this._codcidade;
            }
            set
            {
                this._codcidade = value;
            }
        }
        public string numeroent
        {
            get
            {
                return this._numeroent;
            }
            set
            {
                this._numeroent = value;
            }
        }
        
    }
}
