using System;
using DAL;
using Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPCPEDI
    {
        private DALConexao conexao;
        public BLLPCPEDI(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPCPEDI modelo)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            DALObj.Incluir(modelo);

        }
        public ModeloPCPEDI CarregaPCPEDI(long codigo)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            return DALObj.CarregaModeloPCPEDI(codigo);
        }
    }
}
