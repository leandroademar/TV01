using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLMAPA
    {
        private DALConexao conexao;
        public BLLMAPA(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable Localizar(long inivenda, long fimvenda, int tipo, int numcaixa)
        {
            DALMAPA DALObj = new DALMAPA(conexao);
            return DALObj.Localizar(inivenda,fimvenda,tipo,numcaixa);
        }
    }
}
