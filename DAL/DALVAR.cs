using System;
using Modelo;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVAR
    {
        private DALConexao conexao;

        public DALVAR(DALConexao cx)
        {
            this.conexao = cx;
        }
        public ModeloVAR CarreganewNUMPED(int CODUSUR)
        {
            String comando1 = "SELECT NVL(PROXNUMPED,1) PROXNUMPED,CODUSUR FROM PCUSUARI WHERE CODUSUR = :CODUSUR ";

            ModeloVAR modelo = new ModeloVAR();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando1;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue(":CODUSUR", CODUSUR);
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                if (registro["PROXNUMPED"] != DBNull.Value) { modelo.newnumped = Convert.ToInt64(registro["PROXNUMPED"]); }
                if (registro["CODUSUR"] != DBNull.Value) { modelo.codusur = Convert.ToInt32(registro["CODUSUR"]); }


            }

            conexao.Desconectar();
            return modelo;
        }
        public void Alterar(ModeloVAR modelo)
        {
            String comando2 = " UPDATE PCUSUARI SET PROXNUMPED = NVL(PROXNUMPED,1) + 1 WHERE CODUSUR = :CODUSUR ";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Parameters.AddWithValue(":CODUSUR", modelo.codusur);
            cmd.CommandText = comando2;
            cmd.CommandType = System.Data.CommandType.Text;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
