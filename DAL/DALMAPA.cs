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

        public DataTable Localizar12(long inivenda, long fimvenda, int tipo, int numcaixa)
        {
            /* Tipo de Emissao:
             * -----Cupons Re-Digitados = 1
             * -----Cupons Normais e Danfe = 2
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
            if (tipo == 1)
            {
                comando1 = comando1 + "SUM(PPI.QT / PCE.QTUNIT) QTCOMP, " + "\n";
                comando1 = comando1 + "SUM(PPI.PVENDA * 1) VALCOMP, " + "\n";
                comando1 = comando1 + "SUM((PPI.PVENDA * PCE.QTUNIT) * (PPI.QT / PCE.QTUNIT)) VALTOTAL " + "\n";
            }else // if (tipo == 2)
            {
                comando1 = comando1 + "SUM(PPI.QT / PCE.QTUNIT) QTCOMP, " + "\n";
                comando1 = comando1 + "SUM(PPI.PVENDA * 1) VALCOMP, " + "\n";
                comando1 = comando1 + "SUM((PPI.PVENDA * PCE.QTUNIT) * (PPI.QT / PCE.QTUNIT)) VALTOTAL " + "\n";
            }
            comando1 = comando1 + " FROM " + "\n";
            comando1 = comando1 + " pcvendaconsum PVC, " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + " TABPED TPD, " + "\n";
            }
            comando1 = comando1 + " PCPEDCECF PCD, " + "\n";
            comando1 = comando1 + " PCPEDIECF PPI, " + "\n";
            comando1 = comando1 + " PCPRODUT PPD, " + "\n";
            comando1 = comando1 + " PCEMBALAGEM PCE " + "\n";
            comando1 = comando1 + "WHERE PPI.NUMPEDECF = PCD.NUMPEDECF " + "\n";
            comando1 = comando1 + " AND PCD.POSICAO <> 'A' " + "\n";
            comando1 = comando1 + " AND PVC.NUMPED = PCD.NUMPED " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + " AND TPD.NUMPED = PCD.NUMPED " + "\n";
            }
            comando1 = comando1 + " AND PCD.NUMCUPOM = PPI.NUMCOO " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + " AND TPD.CODAUXILIAR = PCE.CODAUXILIAR " + "\n";
            }else
            {
                comando1 = comando1 + " AND PPI.CODAUXILIAR = PCE.CODAUXILIAR " + "\n";
            }
            comando1 = comando1 + " AND PCE.CODPROD = PPD.CODPROD " + "\n";
            comando1 = comando1 + " AND PPD.CODPROD = PPI.CODPROD " + "\n";
            if (tipo == 1)
            {
                comando1 = comando1 + " AND PCD.NUMPED BETWEEN " + inivenda + " AND " + fimvenda + "\n";
            }else
            {
                comando1 = comando1 + " AND PCD.NUMCUPOM BETWEEN " + inivenda + " AND " + fimvenda + "\n";
            }
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
        
    }
}
