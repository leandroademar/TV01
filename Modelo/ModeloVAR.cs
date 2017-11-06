using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVAR
    {
        private long _newnumped;

        public long newnumped
        {
            get
            {
                return this._newnumped;
            }
            set
            {
                this._newnumped = value;
            }
        }

    }
}
