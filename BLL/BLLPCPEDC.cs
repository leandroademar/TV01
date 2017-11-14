using DAL;
using Modelo;

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
        public void AlterarPC(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.AlterarPC(modelo);

        }
        public void Revert1(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.Revert1(modelo);

        }
        public void Revert2(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.Revert2(modelo);

        }
        public void Revert3(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.Revert3(modelo);

        }
        public void Revert4(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.Revert4(modelo);

        }
        public void AlterarVT(ModeloPCPEDC modelo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            DALObj.AlterarVT(modelo);

        }
        public ModeloPCPEDC CarregaPCPEDC(long codigo)
        {
            DALPCPEDC DALObj = new DALPCPEDC(conexao);
            return DALObj.CarregaModeloPCPEDC(codigo);
        }
    }
}
