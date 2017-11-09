using DAL;
using Modelo;

namespace BLL
{
    public class BLLVAR
    {

        private DALConexao conexao;
        public BLLVAR(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void AlterarNW(ModeloVAR modelo)
        {
            // Função para alterar o Proxnumped do usuário

            DALVAR DALObj = new DALVAR(conexao);
            DALObj.Alterar(modelo);

        }
        public ModeloVAR CarregaNewNumPed(long codigo)
        {
            DALVAR DALObj = new DALVAR(conexao);
            return DALObj.CarreganewNUMPED(codigo);
        }
    }
}
