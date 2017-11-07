using System;
using Modelo;
using System.Data.OracleClient;

namespace DAL
{
    public class DALPCEST
    {
        private DALConexao conexao;
        public DALPCEST(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Alterar(ModeloPCEST modelo)
        {
            String comando1 = "";
            
            comando1 = comando1 + "update PCEST " + "\n";
            comando1 = comando1 + "    set " + "\n";
            comando1 = comando1 + "      FIMESTOQUE = :FIMESTOQUE, " + "\n";
            comando1 = comando1 + "      QTPENDENTE = :QTPENDENTE, " + "\n";
            comando1 = comando1 + "      QTRESERV = :QTRESERV, " + "\n";
            comando1 = comando1 + "      QTVENDAPERDIDA = :QTVENDAPERDIDA, " + "\n";
            comando1 = comando1 + "      DTULTSAIDA = :DTULTSAIDA " + "\n";
            comando1 = comando1 + "    where " + "\n";
            comando1 = comando1 + "      CODPROD = :OLD_CODPROD and " + "\n";
            comando1 = comando1 + "      CODFILIAL = '1'";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando1;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue(":OLD_CODPROD", modelo.codprod);
            cmd.Parameters.AddWithValue(":FIMESTOQUE", modelo.fimestoque);
            cmd.Parameters.AddWithValue(":QTPENDENTE", modelo.qtpendente);
            cmd.Parameters.AddWithValue(":QTRESERV", modelo.qtreserv);
            cmd.Parameters.AddWithValue(":QTVENDAPERDIDA", modelo.qtvendaperdida);
            cmd.Parameters.AddWithValue(":DTULTSAIDA", modelo.dtultsaida);
            
        }

        public ModeloPCEST CarregaModeloPCEST (int codigo)
        {
            String comando2 = "";
            comando2 = comando2 + "SELECT CodProd, " + "\n";
            comando2 = comando2 + "           CODFILIAL, " + "\n";
            comando2 = comando2 + "           FIMESTOQUE, " + "\n";
            comando2 = comando2 + "           QTESTGER, " + "\n";
            comando2 = comando2 + "           QTPENDENTE, " + "\n";
            comando2 = comando2 + "           QTRESERV, " + "\n";
            comando2 = comando2 + "           QTBLOQUEADA, " + "\n";
            comando2 = comando2 + "           QTVENDAPERDIDA, " + "\n";
            comando2 = comando2 + "           DTULTSAIDA, " + "\n";
            comando2 = comando2 + "    GREATEST(DECODE((SELECT TIPOMERC FROM PCPRODUT WHERE CODPROD = PCEST.CODPROD),'CB', " + "\n";
            comando2 = comando2 + "     DECODE(FERRAMENTAS.F_BUSCARPARAMETRO_ALFA('FIL_MONTARKITAUTOMATICAMENTE',PCEST.CODFILIAL,'N'),'S', " + "\n";
            comando2 = comando2 + "     (SELECT QTDISP FROM TABLE(VENDAS.ESTOQUE_CB(PCEST.CODPROD,PCEST.CODFILIAL))),0)+ (NVL(PCEST.QTESTGER,0) - NVL(PCEST.QTRESERV,0) - NVL(PCEST.QTBLOQUEADA,0)),(NVL(PCEST.QTESTGER,0) - NVL(PCEST.QTRESERV,0) - NVL(PCEST.QTBLOQUEADA,0))),0) QTDISP " + "\n";
            comando2 = comando2 + "      FROM PCEST " + "\n";
            comando2 = comando2 + "WHERE CODPROD = :CODPROD " + "\n";
            comando2 = comando2 + "AND CODFILIAL = '1'";

            ModeloPCEST modelo = new ModeloPCEST();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue(":CODPROD", codigo);
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                if (registro["FIMESTOQUE"] != DBNull.Value) { modelo.fimestoque = Convert.ToInt32(registro["FIMESTOQUE"]); }
                if (registro["CodProd"] != DBNull.Value) { modelo.codprod = Convert.ToInt32(registro["CodProd"]); }
                if (registro["QTRESERV"] != DBNull.Value) { modelo.qtreserv = Convert.ToInt32(registro["QTRESERV"]); }
                if (registro["QTVENDAPERDIDA"] != DBNull.Value) { modelo.qtvendaperdida = Convert.ToInt32(registro["QTVENDAPERDIDA"]); }
                if (registro["DTULTSAIDA"] != DBNull.Value) { modelo.dtultsaida = Convert.ToDateTime(registro["DTULTSAIDA"]); }

            }

            conexao.Desconectar();
            return modelo;
        }
    }
}
