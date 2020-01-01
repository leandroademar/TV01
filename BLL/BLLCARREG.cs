using DAL;
using Modelo;


namespace BLL
{
    public class BLLCARREG
    {
        private DALConexao conexao;
        public BLLCARREG(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPCCARREG modelo)
        {
            DALPCCARREG DALObj = new DALPCCARREG(conexao);
            DALObj.Incluir(modelo);

        }
        public ModeloPCCARREG CarregaNewNumPed(long numped)
        {
            DALPCCARREG DALObj = new DALPCCARREG(conexao);
            return DALObj.CarreganewNUMCAR(numped);
        }
    }
}
