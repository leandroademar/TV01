using System;
using System.Collections.Generic;
using System.Data;
using Modelo;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMAPA
    {
        public DALConexao conexao;
        public DALMAPA(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(long inivenda, long fimvenda, int tipo, int numcaixa)
        {
            /* Tipo de Emissao:
             * -----Cupons Re-Digitados = 1
             * -----Cupons Normais = 2
             * Numcaixa:
             * -----10 - Série 20
             * -----11 - Série 21
             * -----12 - Série 22
             */
            String comando1 = "";
            comando1 = comando1 + "SELECT " + "\n";
            comando1 = comando1 + "PVC.CLIENTE, " + "\n";
            comando1 = comando1 + "PPI.CODPROD, " + "\n";
            comando1 = comando1 + "(SELECT NOME FROM pcusuari WHERE CODUSUR = PCD.CODUSUR) RECEPCAO, " + "\n";
            comando1 = comando1 + "(SELECT NOME FROM PCEMPR WHERE MATRICULA = PCD.CODFUNCCX) CAIXA, " + "\n";
            comando1 = comando1 + inivenda + " AS INI, " + "\n";
            comando1 = comando1 + fimvenda + " AS FIM, " + "\n";
            comando1 = comando1 + "PCD.NUMCAIXAFISCAL AS SERIE, " + "\n";
            comando1 = comando1 + "PPD.DESCRICAO, " + "\n";
            comando1 = comando1 + "PCE.EMBALAGEM, " + "\n";
            comando1 = comando1 + "PCE.QTUNIT, " + "\n";
            comando1 = comando1 + "ROUND(SUM(PPI.QT / PCE.QTUNIT),2) QTCOMP, " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + "ROUND((SUM((PPI.PVENDA * PCE.QTUNIT) * (PPI.QT / PCE.QTUNIT))/SUM(PPI.QT / PCE.QTUNIT)),2) VALCOMP,  " + "\n";
            }else// if (tipo == 2)
            {
                comando1 = comando1 + "ROUND(SUM(PPI.PVENDA * PCE.QTUNIT),2) VALCOMP, " + "\n";
            }
            comando1 = comando1 + "ROUND(SUM((PPI.PVENDA * PCE.QTUNIT) * (PPI.QT / PCE.QTUNIT)),2) VALTOTAL " + "\n";
            comando1 = comando1 + " FROM " + "\n";
            comando1 = comando1 + " pcvendaconsum PVC, " + "\n";
            if (numcaixa == 10)
            {
                if (tipo == 1)
                {
                    comando1 = comando1 + " TABPED TPD, " + "\n";
                }
                comando1 = comando1 + " PCPEDCECF@DBLATAC10 PCD, " + "\n";
                comando1 = comando1 + " PCPEDIECF@DBLATAC10 PPI, " + "\n";
                comando1 = comando1 + " PCPRODUT@DBLATAC10 PPD, " + "\n";
                comando1 = comando1 + " PCEMBALAGEM@DBLATAC10 PCE " + "\n";
            }
            if (numcaixa == 11)
            {
                if (tipo == 1)
                {
                    comando1 = comando1 + " TABPED TPD, " + "\n";
                }
                comando1 = comando1 + " PCPEDCECF@DBLATAC11 PCD, " + "\n";
                comando1 = comando1 + " PCPEDIECF@DBLATAC11 PPI, " + "\n";
                comando1 = comando1 + " PCPRODUT@DBLATAC11 PPD, " + "\n";
                comando1 = comando1 + " PCEMBALAGEM@DBLATAC11 PCE " + "\n";
            }
            if (numcaixa == 12)
            {
                if (tipo == 1)
                {
                    comando1 = comando1 + " TABPED TPD, " + "\n";
                }
                comando1 = comando1 + " PCPEDCECF@DBLATAC12 PCD, " + "\n";
                comando1 = comando1 + " PCPEDIECF@DBLATAC12 PPI, " + "\n";
                comando1 = comando1 + " PCPRODUT@DBLATAC12 PPD, " + "\n";
                comando1 = comando1 + " PCEMBALAGEM@DBLATAC12 PCE " + "\n";
            }
            comando1 = comando1 + "WHERE PPI.NUMPEDECF = PCD.NUMPEDECF " + "\n";
            comando1 = comando1 + " AND PCD.POSICAO <> 'A' " + "\n";
            comando1 = comando1 + " AND PVC.NUMPED = PCD.NUMPED " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + " AND TPD.NUMPED = PCD.NUMPED " + "\n";
                comando1 = comando1 + " AND TPD.CODAUXILIAR = PCE.CODAUXILIAR " + "\n";
                comando1 = comando1 + " AND PCD.NUMPED BETWEEN " + inivenda + " AND " + fimvenda + "\n";
            }
            else
            {
                comando1 = comando1 + " AND PPI.CODAUXILIAR = PCE.CODAUXILIAR " + "\n";
                comando1 = comando1 + " AND PCD.NUMCUPOM BETWEEN " + inivenda + " AND " + fimvenda + "\n";
            }
            comando1 = comando1 + " AND PCD.NUMCUPOM = PPI.NUMCOO " + "\n";
            comando1 = comando1 + " AND PCE.CODPROD = PPD.CODPROD " + "\n";
            comando1 = comando1 + " AND PPD.CODPROD = PPI.CODPROD " + "\n";
            comando1 = comando1 + "GROUP BY " + "\n";
            comando1 = comando1 + "PPI.CODPROD, " + "\n";
            comando1 = comando1 + "PPD.DESCRICAO, " + "\n";
            comando1 = comando1 + "PCE.EMBALAGEM, " + "\n";
            comando1 = comando1 + "PCE.QTUNIT, " + "\n";
            comando1 = comando1 + "PVC.CLIENTE, " + "\n";
            comando1 = comando1 + "PCD.CODUSUR, " + "\n";
            comando1 = comando1 + "PCD.NUMCAIXAFISCAL, " + "\n";
            comando1 = comando1 + "PCD.CODFUNCCX " + "\n";
            comando1 = comando1 + " ORDER BY 8";


            DataTable tabela = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(comando1, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloMAPA CarregaMapa (long inivenda, long fimvenda, int numcaixa)
        {
            String comando2 = "";
            comando2 = comando2 + "SELECT " + "\n";
            comando2 = comando2 + "PVC.CLIENTE, " + "\n";
            comando2 = comando2 + "(SELECT NOME FROM pcusuari WHERE CODUSUR = PCD.CODUSUR) RECEPCAO, " + "\n";
            comando2 = comando2 + "(SELECT NOME FROM PCEMPR WHERE MATRICULA = PCD.CODFUNCCX) CAIXA, " + "\n";
            comando2 = comando2 + "PCD.NUMCAIXAFISCAL AS SERIE " + "\n";
            comando2 = comando2 + " FROM " + "\n";
            comando2 = comando2 + " pcvendaconsum PVC, " + "\n";
            if (numcaixa == 10)
            {
                comando2 = comando2 + " PCPEDCECF PCD, " + "\n";
                comando2 = comando2 + " PCPEDIECF PPI, " + "\n";
                comando2 = comando2 + " PCPRODUT PPD, " + "\n";
                comando2 = comando2 + " PCEMBALAGEM PCE " + "\n";
            }
            if (numcaixa == 11)
            {
                comando2 = comando2 + " PCPEDCECF@DBLATAC11 PCD, " + "\n";
                comando2 = comando2 + " PCPEDIECF@DBLATAC11 PPI, " + "\n";
                comando2 = comando2 + " PCPRODUT@DBLATAC11 PPD, " + "\n";
                comando2 = comando2 + " PCEMBALAGEM@DBLATAC11 PCE " + "\n";
            }
            if (numcaixa == 12)
            {
                comando2 = comando2 + " PCPEDCECF@DBLATAC12 PCD, " + "\n";
                comando2 = comando2 + " PCPEDIECF@DBLATAC12 PPI, " + "\n";
                comando2 = comando2 + " PCPRODUT@DBLATAC12 PPD, " + "\n";
                comando2 = comando2 + " PCEMBALAGEM@DBLATAC12 PCE " + "\n";
            }
            comando2 = comando2 + "WHERE PPI.NUMPEDECF = PCD.NUMPEDECF " + "\n";
            comando2 = comando2 + " AND PCD.POSICAO <> 'A' " + "\n";
            comando2 = comando2 + " AND PVC.NUMPED = PCD.NUMPED " + "\n";
            comando2 = comando2 + " AND PCD.NUMCUPOM = PPI.NUMCOO " + "\n";
            comando2 = comando2 + " AND PPI.CODAUXILIAR = PCE.CODAUXILIAR " + "\n";
            comando2 = comando2 + " AND PCE.CODPROD = PPD.CODPROD " + "\n";
            comando2 = comando2 + " AND PPD.CODPROD = PPI.CODPROD " + "\n";
            comando2 = comando2 + " AND PCD.NUMPED BETWEEN :NUMPED AND :NUMPED " + "\n";
            comando2 = comando2 + " GROUP BY " + "\n";
            comando2 = comando2 + "PVC.CLIENTE, " + "\n";
            comando2 = comando2 + "PCD.CODUSUR, " + "\n";
            comando2 = comando2 + "PCD.NUMCAIXAFISCAL, " + "\n";
            comando2 = comando2 + "PCD.CODFUNCCX"; ;

            ModeloMAPA modelo = new ModeloMAPA();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.CommandType = System.Data.CommandType.Text;
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                if (registro["CLIENTE"] != DBNull.Value) { modelo.cliente = registro["CLIENTE"].ToString(); }
                if (registro["RECEPCAO"] != DBNull.Value) { modelo.recepcao = registro["RECEPCAO"].ToString(); }
                if (registro["CAIXA"] != DBNull.Value) { modelo.caixa = registro["CAIXA"].ToString(); }
                if (registro["SERIE"] != DBNull.Value) { modelo.serie = Convert.ToInt32(registro["SERIE"]); }
            }

            conexao.Desconectar();
            return modelo;
        }
        
    }
}
