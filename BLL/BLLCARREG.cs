using DAL;
using Modelo;


namespace BLL
{
    class BLLCARREG
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
        public ModeloPCCARREG CarregaNewNumPed()
        {
            DALPCCARREG DALObj = new DALPCCARREG(conexao);
            return DALObj.CarreganewNUMCAR();
        }
    }
}
