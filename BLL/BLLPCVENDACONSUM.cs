using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;

namespace BLL
{
    public class BLLPCVENDACONSUM
    {
        private DALConexao conexao;
        public BLLPCVENDACONSUM(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPCVENDACONSUM modelo)
        {
            DALPCVENDACONSUM DALObj = new DALPCVENDACONSUM(conexao);
            DALObj.Incluir(modelo);
            
        }
        public ModeloPCVENDACONSUM CarregaPCVENDACONSUM(long codigo)
        {
            DALPCVENDACONSUM DALObj = new DALPCVENDACONSUM(conexao);
            return DALObj.CarregaPCVENDACONSUM(codigo);
        }
    }
}
