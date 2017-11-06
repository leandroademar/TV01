using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPCPEDC
    {
        private DALConexao conexao;
        public BLLPCPEDC(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.Incluir(modelo);

        }
        public ModeloPCPEDC CarregaPCPEDC(long codigo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            return DALObj.CarregaModeloPCPEDC(codigo);
        }
    }
}
