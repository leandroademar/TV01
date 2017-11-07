using System;
using DAL;
using Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVAR
    {

        private DALConexao conexao;
        public BLLVAR(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void AlterarNW(ModeloPCPEDC modelo)
        {
            // Função para alterar o Proxnumped do usuário

            DALVAR DALObj = new DALVAR(conexao);
            DALObj.Alterar(modelo);

        }
        public ModeloVAR CarregaNewNumPed(int codigo)
        {
            DALVAR DALObj = new DALVAR(conexao);
            return DALObj.CarreganewNUMPED(codigo);
        }
    }
}
