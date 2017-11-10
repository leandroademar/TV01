using Modelo;
using System.Data.OracleClient;
using System;
using System.Data;

namespace DAL
{
    public class DALPCCARREG
    {
        private DALConexao conexao;
        public DALPCCARREG(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPCCARREG modelo)
        {
            String comando1 = "";

#pragma warning disable CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
#pragma warning disable CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
#pragma warning restore CS0618 // "OracleCommand" é obsoleto: "OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260"
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO PCCARREG " + "\n";
            comando1 = comando1 + "    (NUMCAR, DTSAIDA, TOTPESO, TOTVOLUME, " + "\n";
            comando1 = comando1 + "     VLTOTAL, DESTINO, DATAMON, " + "\n";
            comando1 = comando1 + "     CODVEICULO, CODFUNCMON " + "\n";
            comando1 = comando1 + "     ,DTFECHA " + "\n";
            comando1 = comando1 + "     ,HORAMON, MINUTOMON) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "    (:NUMCAR, TO_DATE(SYSDATE, 'DD/MM/YYYY'), 0, 0, " + "\n";
            comando1 = comando1 + "     :VLTOTAL, 'VENDA BALCAO', TO_DATE(SYSDATE, 'DD/MM/YYYY'), " + "\n";
            comando1 = comando1 + "     0, :CODFUNCMON " + "\n";
            comando1 = comando1 + "     ,TO_DATE(SYSDATE, 'DD/MM/YYYY') " + "\n";
            comando1 = comando1 + "     ,to_number(to_char(SYSDATE,'hh24')), to_number(to_char(SYSDATE,'mi')))";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue(":NUMCAR", modelo.numcar);
            cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal);
            cmd.Parameters.AddWithValue(":CODFUNCMON", modelo.codfuncmon);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public ModeloPCCARREG CarreganewNUMCAR()
        {
            String comando1 = "select ferramentas.F_PROX_NUMCAR as NC from dual ";

            ModeloPCCARREG modelo = new ModeloPCCARREG();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando1;
            cmd.CommandType = System.Data.CommandType.Text;
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                if (registro["NC"] != DBNull.Value) { modelo.numcar = Convert.ToInt32(registro["NC"]); }
            }

            conexao.Desconectar();
            return modelo;
        }
    }

}
