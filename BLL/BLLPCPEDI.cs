using DAL;
using Modelo;
using System.Data;

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
        public void IncluirQT(ModeloPCPEDI modelo)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            DALObj.IncluirQT(modelo);

        }
        public void AlterarQT(ModeloPCPEDI modelo)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            DALObj.AlterarQT(modelo);

        }
        public DataTable Localizar(long codigovenda)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            return DALObj.Localizar(codigovenda);
        }
        public ModeloPCPEDI CarregaPCPEDI(long codigo)
        {
            DALPCPEDI DALObj = new DALPCPEDI(conexao);
            return DALObj.CarregaModeloPCPEDI(codigo);
        }
    }
}
