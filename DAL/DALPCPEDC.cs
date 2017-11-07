using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Modelo;

namespace DAL
{
   
    public class DALPCPEDC
    {
        private DALConexao conexao;

        public DALPCPEDC(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPCPEDC modelo)
        {
            String comando1 = "";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO PCPEDC " + "\n";
            comando1 = comando1 + "      (NUMPED, " + "\n";
            comando1 = comando1 + "       DATA, " + "\n";
            comando1 = comando1 + "       CODUSUR, " + "\n";
            comando1 = comando1 + "       CODCLI, " + "\n";
            comando1 = comando1 + "       NUMITENS, " + "\n";
            comando1 = comando1 + "       VLATEND, " + "\n";
            comando1 = comando1 + "       CODPRACA, " + "\n";
            comando1 = comando1 + "       POSICAO, " + "\n";
            comando1 = comando1 + "       NUMCAR, " + "\n";
            comando1 = comando1 + "       CODSUPERVISOR, " + "\n";
            comando1 = comando1 + "       CODFILIAL, " + "\n";
            comando1 = comando1 + "       VLTOTAL, " + "\n";
            comando1 = comando1 + "       VLTABELA, " + "\n";
            comando1 = comando1 + "       VLCUSTOREAL, " + "\n";
            comando1 = comando1 + "       VLCUSTOFIN, " + "\n";
            comando1 = comando1 + "       TOTPESO, " + "\n";
            comando1 = comando1 + "       TOTVOLUME, " + "\n";
            comando1 = comando1 + "       CODEMITENTE, " + "\n";
            comando1 = comando1 + "       OPERACAO, " + "\n";
            comando1 = comando1 + "       TIPOVENDA, " + "\n";
            comando1 = comando1 + "       OBS, " + "\n";
            comando1 = comando1 + "       CODCOB, " + "\n";
            comando1 = comando1 + "       HORA, " + "\n";
            comando1 = comando1 + "       MINUTO, " + "\n";
            comando1 = comando1 + "       CODPLPAG, " + "\n";
            comando1 = comando1 + "       NUMPEDCLI, " + "\n";
            comando1 = comando1 + "       PERCVENDA, " + "\n";
            comando1 = comando1 + "       PERDESC, " + "\n";
            comando1 = comando1 + "       VLDESCONTO, " + "\n";
            comando1 = comando1 + "       VLFRETE, " + "\n";
            comando1 = comando1 + "       VLOUTRASDESP, " + "\n";
            comando1 = comando1 + "       OBS1, " + "\n";
            comando1 = comando1 + "       OBS2, " + "\n";
            comando1 = comando1 + "       CONDVENDA, " + "\n";
            comando1 = comando1 + "       DTENTREGA, " + "\n";
            comando1 = comando1 + "       NUMPEDRCA, " + "\n";
            comando1 = comando1 + "       FRETEDESPACHO, " + "\n";
            comando1 = comando1 + "       FRETEREDESPACHO, " + "\n";
            comando1 = comando1 + "       CODFORNECFRETE, " + "\n";
            comando1 = comando1 + "       CODFORNECREDESPACHO, " + "\n";
            comando1 = comando1 + "       TIPOCARGA, " + "\n";
            if (modelo.prazo1 != null)
            { comando1 = comando1 + "       PRAZO1, " + "\n"; }
            if (modelo.prazo2 != null)
            { comando1 = comando1 + "       PRAZO2, " + "\n"; }
            comando1 = comando1 + "       PRAZO3, " + "\n";
            comando1 = comando1 + "       PRAZO4, " + "\n";
            comando1 = comando1 + "       PRAZO5, " + "\n";
            comando1 = comando1 + "       PRAZO6, " + "\n";
            comando1 = comando1 + "       PRAZO7, " + "\n";
            comando1 = comando1 + "       PRAZO8, " + "\n";
            comando1 = comando1 + "       PRAZO9, " + "\n";
            comando1 = comando1 + "       PRAZO10, " + "\n";
            comando1 = comando1 + "       PRAZO11, " + "\n";
            comando1 = comando1 + "       PRAZO12, " + "\n";
            comando1 = comando1 + "       PRAZOMEDIO, " + "\n";
            comando1 = comando1 + "       OBSENTREGA1, " + "\n";
            comando1 = comando1 + "       OBSENTREGA2, " + "\n";
            comando1 = comando1 + "       OBSENTREGA3, " + "\n";
            comando1 = comando1 + "       TIPOEMBALAGEM, " + "\n";
            comando1 = comando1 + "       CODEPTO, " + "\n";
            comando1 = comando1 + "       CAMPANHA, " + "\n";
            comando1 = comando1 + "       CODDISTRIB, " + "\n";
            comando1 = comando1 + "       VLCUSTOCONT, " + "\n";
            comando1 = comando1 + "       VLCUSTOREP, " + "\n";
            comando1 = comando1 + "       NUMNOTAMANIF, " + "\n";
            comando1 = comando1 + "       SERIEMANIF, " + "\n";
            comando1 = comando1 + "       ORIGEMPED, " + "\n";
            comando1 = comando1 + "       ESPECIEMANIF, " + "\n";
            comando1 = comando1 + "       NUMPEDENTFUT, " + "\n";
            comando1 = comando1 + "       CODFILIALNF, " + "\n";
            comando1 = comando1 + "       NUMCARMANIF, " + "\n";
            comando1 = comando1 + "       NUMORCA, " + "\n";
            comando1 = comando1 + "       CODCONTRATO, " + "\n";
            comando1 = comando1 + "       DATAPEDCLI, " + "\n";
            comando1 = comando1 + "       NUMPEDBNF, " + "\n";
            comando1 = comando1 + "       BROKER, " + "\n";
            comando1 = comando1 + "       CODESTABELECIMENTO, " + "\n";
            comando1 = comando1 + "       NUMTABELA, " + "\n";
            comando1 = comando1 + "       MOTIVOPOSICAO, " + "\n";
            comando1 = comando1 + "       DTAGENDAENTREGA, " + "\n";
            comando1 = comando1 + "       TIPOOPER, " + "\n";
            comando1 = comando1 + "       CODMOTBLOQUEIO, " + "\n";
            comando1 = comando1 + "       SERIEECF, " + "\n";
            comando1 = comando1 + "       NUMCUPOM, " + "\n";
            comando1 = comando1 + "       CODCLIRECEBEDOR, " + "\n";
            comando1 = comando1 + "       CONCILIAIMPORTACAO, " + "\n";
            comando1 = comando1 + "       NUMREGIAO, " + "\n";
            comando1 = comando1 + "       NUMNOTA, " + "\n";
            comando1 = comando1 + "       PERDESCFIN, " + "\n";
            comando1 = comando1 + "       RESTRICAOTRANSP, " + "\n";
            comando1 = comando1 + "       GERACP, " + "\n";
            comando1 = comando1 + "       USAINTEGRACAOWMS, " + "\n";
            comando1 = comando1 + "       VENDAASSISTIDA, " + "\n";
            comando1 = comando1 + "       CODMOTIVO, " + "\n";
            comando1 = comando1 + "       LOG, " + "\n";
            comando1 = comando1 + "       DTCALCFRETE, " + "\n";
            comando1 = comando1 + "       CODFUNCCALCFRETE, " + "\n";
            comando1 = comando1 + "       EANCOBRANCA, " + "\n";
            comando1 = comando1 + "       EANENTREGA, " + "\n";
            comando1 = comando1 + "       USACFOPVENDANATV10, " + "\n";
            comando1 = comando1 + "       TIPOPRIORIDADEENTREGA, " + "\n";
            comando1 = comando1 + "       CODUSUR2, " + "\n";
            comando1 = comando1 + "       CODUSUR3, " + "\n";
            comando1 = comando1 + "       CODUSUR4, " + "\n";
            comando1 = comando1 + "       CODCLINF, " + "\n";
            comando1 = comando1 + "       NUMPEDTV1, " + "\n";
            comando1 = comando1 + "       USADEBCREDRCA, " + "\n";
            comando1 = comando1 + "       BRINDE, " + "\n";
            comando1 = comando1 + "       BONIFICALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       TROCAALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       BROKERALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       CRMALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       TIPOMOVCCRCA, " + "\n";
            comando1 = comando1 + "       USACREDRCA, " + "\n";
            comando1 = comando1 + "       GERARDADOSNFPAULISTA, " + "\n";
            comando1 = comando1 + "       USASALDOCONTACORRENTEDESCFIN, " + "\n";
            comando1 = comando1 + "       VALORDESCFIN, " + "\n";
            comando1 = comando1 + "       CODVISITA, " + "\n";
            comando1 = comando1 + "       CODATENDIMENTO, " + "\n";
            comando1 = comando1 + "       VENDATRIANGULAR, " + "\n";
            comando1 = comando1 + "       VLENTRADA, " + "\n";
            comando1 = comando1 + "       UFDESEMBARACO, " + "\n";
            comando1 = comando1 + "       LOCALDESEMBARACO, " + "\n";
            comando1 = comando1 + "       CUSTOBONIFICACAO, " + "\n";
            comando1 = comando1 + "       CODFORNECBONIFIC, " + "\n";
            comando1 = comando1 + "       CODBNF, " + "\n";
            comando1 = comando1 + "       TIPODOCUMENTO, " + "\n";
            comando1 = comando1 + "       CFOPBNFDEGUSTA, " + "\n";
            comando1 = comando1 + "       CONTAORDEM, " + "\n";
            comando1 = comando1 + "       DATAEMPENHO, " + "\n";
            comando1 = comando1 + "       NUMEMPENHO, " + "\n";
            comando1 = comando1 + "       CODUNIDADEEXECUTORA, " + "\n";
            comando1 = comando1 + "       PLACAVEICULO, " + "\n";
            comando1 = comando1 + "       DTLIMITEFAT, " + "\n";
            comando1 = comando1 + "       RESERVAESTOQUETV7, " + "\n";
            comando1 = comando1 + "       FORNECENTREGA, " + "\n";
            comando1 = comando1 + "       CODCLITV8, " + "\n";
            comando1 = comando1 + "       UFVEICULO, " + "\n";
            comando1 = comando1 + "       MOTORISTAVEICULO, " + "\n";
            comando1 = comando1 + "       DTINICIODIGITACAOPEDIDO, " + "\n";
            comando1 = comando1 + "       DTFIMDIGITACAOPEDIDO, " + "\n";
            comando1 = comando1 + "       VLDESCABATIMENTO, " + "\n";
            comando1 = comando1 + "       AGRUPAMENTO, " + "\n";
            comando1 = comando1 + "       VENDAEXPORTACAO, " + "\n";
            comando1 = comando1 + "       TURNOENTREGA, " + "\n";
            comando1 = comando1 + "       NUMTRANSVENDATV13, " + "\n";
            comando1 = comando1 + "       CODENDENTCLI, " + "\n";
            comando1 = comando1 + "       UTILIZAVENDAPOREMBALAGEM, " + "\n";
            comando1 = comando1 + "       CODCONTATO, " + "\n";
            comando1 = comando1 + "       NUMREGEXP, " + "\n";
            comando1 = comando1 + "       NUMCHAVEEXP, " + "\n";
            comando1 = comando1 + "       NUMDRAWBACK, " + "\n";
            comando1 = comando1 + "       DTNFTRANSF, " + "\n";
            comando1 = comando1 + "       ROTINALANC, " + "\n";
            comando1 = comando1 + "       NUMPEDORIGEM, " + "\n";
            comando1 = comando1 + "       PEDDUPLICADO, " + "\n";
            comando1 = comando1 + "       VLBONIFIC, " + "\n";
            comando1 = comando1 + "       VENDALOCESTRANG, " + "\n";
            comando1 = comando1 + "       COPIAIDENTICAPEDDUP, " + "\n";
            comando1 = comando1 + "       ASSINATURA, " + "\n";
            comando1 = comando1 + "       IDPARCEIRO, " + "\n";
            comando1 = comando1 + "       UIDREGISTRO, " + "\n";
            comando1 = comando1 + "       CONDFINANC, " + "\n";
            comando1 = comando1 + "       PLANOSUPPLI, " + "\n";
            comando1 = comando1 + "       PAGCHEQUEMORADIA, " + "\n";
            comando1 = comando1 + "       NUMVOLUME " + "\n";
            comando1 = comando1 + "       ) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "      (:NUMPED, " + "\n";
            comando1 = comando1 + "       :DATA, " + "\n";
            comando1 = comando1 + "       :CODUSUR, " + "\n";
            comando1 = comando1 + "       :CODCLI, " + "\n";
            comando1 = comando1 + "       :NUMITENS, " + "\n";
            comando1 = comando1 + "       :VLATEND, " + "\n";
            comando1 = comando1 + "       :CODPRACA, " + "\n";
            comando1 = comando1 + "       :POSICAO, " + "\n";
            comando1 = comando1 + "       :NUMCAR, " + "\n";
            comando1 = comando1 + "       :CODSUPERVISOR, " + "\n";
            comando1 = comando1 + "       :CODFILIAL, " + "\n";
            comando1 = comando1 + "       :VLTOTAL, " + "\n";
            comando1 = comando1 + "       :VLTABELA, " + "\n";
            comando1 = comando1 + "       :VLCUSTOREAL, " + "\n";
            comando1 = comando1 + "       :VLCUSTOFIN, " + "\n";
            comando1 = comando1 + "       :TOTPESO, " + "\n";
            comando1 = comando1 + "       :TOTVOLUME, " + "\n";
            comando1 = comando1 + "       :CODEMITENTE, " + "\n";
            comando1 = comando1 + "       :OPERACAO, " + "\n";
            comando1 = comando1 + "       :TIPOVENDA, " + "\n";
            comando1 = comando1 + "       :OBS, " + "\n";
            comando1 = comando1 + "       :CODCOB, " + "\n";
            comando1 = comando1 + "       :HORA, " + "\n";
            comando1 = comando1 + "       :MINUTO, " + "\n";
            comando1 = comando1 + "       :CODPLPAG, " + "\n";
            comando1 = comando1 + "       :NUMPEDCLI, " + "\n";
            comando1 = comando1 + "       :PERCVENDA, " + "\n";
            comando1 = comando1 + "       :PERDESC, " + "\n";
            comando1 = comando1 + "       :VLDESCONTO, " + "\n";
            comando1 = comando1 + "       :VLFRETE, " + "\n";
            comando1 = comando1 + "       :VLOUTRASDESP, " + "\n";
            comando1 = comando1 + "       :OBS1, " + "\n";
            comando1 = comando1 + "       :OBS2, " + "\n";
            comando1 = comando1 + "       :CONDVENDA, " + "\n";
            comando1 = comando1 + "       :DTENTREGA, " + "\n";
            comando1 = comando1 + "       :NUMPEDRCA, " + "\n";
            comando1 = comando1 + "       :FRETEDESPACHO, " + "\n";
            comando1 = comando1 + "       :FRETEREDESPACHO, " + "\n";
            comando1 = comando1 + "       :CODFORNECFRETE, " + "\n";
            comando1 = comando1 + "       :CODFORNECREDESPACHO, " + "\n";
            comando1 = comando1 + "       :TIPOCARGA, " + "\n";
            if (modelo.prazo1 != null)
            { comando1 = comando1 + "       :PRAZO1, " + "\n"; }
            if (modelo.prazo2 != null)
            { comando1 = comando1 + "       :PRAZO2, " + "\n"; }
            comando1 = comando1 + "       :PRAZO3, " + "\n";
            comando1 = comando1 + "       :PRAZO4, " + "\n";
            comando1 = comando1 + "       :PRAZO5, " + "\n";
            comando1 = comando1 + "       :PRAZO6, " + "\n";
            comando1 = comando1 + "       :PRAZO7, " + "\n";
            comando1 = comando1 + "       :PRAZO8, " + "\n";
            comando1 = comando1 + "       :PRAZO9, " + "\n";
            comando1 = comando1 + "       :PRAZO10, " + "\n";
            comando1 = comando1 + "       :PRAZO11, " + "\n";
            comando1 = comando1 + "       :PRAZO12, " + "\n";
            comando1 = comando1 + "       :PRAZOMEDIO, " + "\n";
            comando1 = comando1 + "       :OBSENTREGA1, " + "\n";
            comando1 = comando1 + "       :OBSENTREGA2, " + "\n";
            comando1 = comando1 + "       :OBSENTREGA3, " + "\n";
            comando1 = comando1 + "       :TIPOEMBALAGEM, " + "\n";
            comando1 = comando1 + "       :CODEPTO, " + "\n";
            comando1 = comando1 + "       :CAMPANHA, " + "\n";
            comando1 = comando1 + "       :CODDISTRIB, " + "\n";
            comando1 = comando1 + "       :VLCUSTOCONT, " + "\n";
            comando1 = comando1 + "       :VLCUSTOREP, " + "\n";
            comando1 = comando1 + "       :NUMNOTAMANIF, " + "\n";
            comando1 = comando1 + "       :SERIEMANIF, " + "\n";
            comando1 = comando1 + "       :ORIGEMPED, " + "\n";
            comando1 = comando1 + "       :ESPECIEMANIF, " + "\n";
            comando1 = comando1 + "       :NUMPEDENTFUT, " + "\n";
            comando1 = comando1 + "       :CODFILIALNF, " + "\n";
            comando1 = comando1 + "       :NUMCARMANIF, " + "\n";
            comando1 = comando1 + "       :NUMORCA, " + "\n";
            comando1 = comando1 + "       :CODCONTRATO, " + "\n";
            comando1 = comando1 + "       :DATAPEDCLI, " + "\n";
            comando1 = comando1 + "       :NUMPEDBNF, " + "\n";
            comando1 = comando1 + "       :BROKER, " + "\n";
            comando1 = comando1 + "       :CODESTABELECIMENTO, " + "\n";
            comando1 = comando1 + "       :NUMTABELA, " + "\n";
            comando1 = comando1 + "       :MOTIVOPOSICAO, " + "\n";
            comando1 = comando1 + "       :DTAGENDAENTREGA, " + "\n";
            comando1 = comando1 + "       :TIPOOPER, " + "\n";
            comando1 = comando1 + "       :CODMOTBLOQUEIO, " + "\n";
            comando1 = comando1 + "       :SERIEECF, " + "\n";
            comando1 = comando1 + "       :NUMCUPOM, " + "\n";
            comando1 = comando1 + "       :CODCLIRECEBEDOR, " + "\n";
            comando1 = comando1 + "       :CONCILIAIMPORTACAO, " + "\n";
            comando1 = comando1 + "       :NUMREGIAO, " + "\n";
            comando1 = comando1 + "       :NUMNOTA, " + "\n";
            comando1 = comando1 + "       :PERDESCFIN, " + "\n";
            comando1 = comando1 + "       :RESTRICAOTRANSP, " + "\n";
            comando1 = comando1 + "       :GERACP, " + "\n";
            comando1 = comando1 + "       :USAINTEGRACAOWMS, " + "\n";
            comando1 = comando1 + "       :VENDAASSISTIDA, " + "\n";
            comando1 = comando1 + "       :CODMOTIVO, " + "\n";
            comando1 = comando1 + "       :LOG, " + "\n";
            comando1 = comando1 + "       :DTCALCFRETE, " + "\n";
            comando1 = comando1 + "       :CODFUNCCALCFRETE, " + "\n";
            comando1 = comando1 + "       :EANCOBRANCA, " + "\n";
            comando1 = comando1 + "       :EANENTREGA, " + "\n";
            comando1 = comando1 + "       :USACFOPVENDANATV10, " + "\n";
            comando1 = comando1 + "       :TIPOPRIORIDADEENTREGA, " + "\n";
            comando1 = comando1 + "       :CODUSUR2, " + "\n";
            comando1 = comando1 + "       :CODUSUR3, " + "\n";
            comando1 = comando1 + "       :CODUSUR4, " + "\n";
            comando1 = comando1 + "       :CODCLINF, " + "\n";
            comando1 = comando1 + "       :NUMPEDTV1, " + "\n";
            comando1 = comando1 + "       :USADEBCREDRCA, " + "\n";
            comando1 = comando1 + "       :BRINDE, " + "\n";
            comando1 = comando1 + "       :BONIFICALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       :TROCAALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       :BROKERALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       :CRMALTDEBCREDRCA, " + "\n";
            comando1 = comando1 + "       :TIPOMOVCCRCA, " + "\n";
            comando1 = comando1 + "       :USACREDRCA, " + "\n";
            comando1 = comando1 + "       :GERARDADOSNFPAULISTA, " + "\n";
            comando1 = comando1 + "       :USASALDOCONTACORRENTEDESCFIN, " + "\n";
            comando1 = comando1 + "       :VALORDESCFIN, " + "\n";
            comando1 = comando1 + "       :CODVISITA, " + "\n";
            comando1 = comando1 + "       :CODATENDIMENTO, " + "\n";
            comando1 = comando1 + "       :VENDATRIANGULAR, " + "\n";
            comando1 = comando1 + "       :VLENTRADA, " + "\n";
            comando1 = comando1 + "       :UFDESEMBARACO, " + "\n";
            comando1 = comando1 + "       :LOCALDESEMBARACO, " + "\n";
            comando1 = comando1 + "       :CUSTOBONIFICACAO, " + "\n";
            comando1 = comando1 + "       :CODFORNECBONIFIC, " + "\n";
            comando1 = comando1 + "       :CODBNF, " + "\n";
            comando1 = comando1 + "       :TIPODOCUMENTO, " + "\n";
            comando1 = comando1 + "       :CFOPBNFDEGUSTA, " + "\n";
            comando1 = comando1 + "       :CONTAORDEM, " + "\n";
            comando1 = comando1 + "       :DATAEMPENHO, " + "\n";
            comando1 = comando1 + "       :NUMEMPENHO, " + "\n";
            comando1 = comando1 + "       :CODUNIDADEEXECUTORA, " + "\n";
            comando1 = comando1 + "       :PLACAVEICULO, " + "\n";
            comando1 = comando1 + "       :DTLIMITEFAT, " + "\n";
            comando1 = comando1 + "       :RESERVAESTOQUETV7, " + "\n";
            comando1 = comando1 + "       :FORNECENTREGA, " + "\n";
            comando1 = comando1 + "       :CODCLITV8, " + "\n";
            comando1 = comando1 + "       :UFVEICULO, " + "\n";
            comando1 = comando1 + "       :MOTORISTAVEICULO, " + "\n";
            comando1 = comando1 + "       :DTINICIODIGITACAOPEDIDO, " + "\n";
            comando1 = comando1 + "       :DTFIMDIGITACAOPEDIDO, " + "\n";
            comando1 = comando1 + "       :VLDESCABATIMENTO, " + "\n";
            comando1 = comando1 + "       :AGRUPAMENTO, " + "\n";
            comando1 = comando1 + "       :VENDAEXPORTACAO, " + "\n";
            comando1 = comando1 + "       :TURNOENTREGA, " + "\n";
            comando1 = comando1 + "       :NUMTRANSVENDATV13, " + "\n";
            comando1 = comando1 + "       :CODENDENTCLI, " + "\n";
            comando1 = comando1 + "       :UTILIZAVENDAPOREMBALAGEM, " + "\n";
            comando1 = comando1 + "       :CODCONTATO, " + "\n";
            comando1 = comando1 + "       :NUMREGEXP, " + "\n";
            comando1 = comando1 + "       :NUMCHAVEEXP, " + "\n";
            comando1 = comando1 + "       :NUMDRAWBACK, " + "\n";
            comando1 = comando1 + "       :DTNFTRANSF, " + "\n";
            comando1 = comando1 + "       :ROTINALANC, " + "\n";
            comando1 = comando1 + "       :NUMPEDORIGEM, " + "\n";
            comando1 = comando1 + "       :PEDDUPLICADO, " + "\n";
            comando1 = comando1 + "       :VLBONIFIC, " + "\n";
            comando1 = comando1 + "       :VENDALOCESTRANG, " + "\n";
            comando1 = comando1 + "       :COPIAIDENTICAPEDDUP, " + "\n";
            comando1 = comando1 + "       :ASSINATURA, " + "\n";
            comando1 = comando1 + "       :IDPARCEIRO, " + "\n";
            comando1 = comando1 + "       :UIDREGISTRO, " + "\n";
            comando1 = comando1 + "       :CONDFINANC, " + "\n";
            comando1 = comando1 + "       :PLANOSUPPLI, " + "\n";
            comando1 = comando1 + "       :PAGCHEQUEMORADIA, " + "\n";
            comando1 = comando1 + "       :NUMVOLUME " + "\n";
            comando1 = comando1 + "     )";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue(":NUMPED", modelo.numped);
            cmd.Parameters.AddWithValue(":DATA", modelo.data);
            cmd.Parameters.AddWithValue(":CODUSUR", modelo.codusur);
            cmd.Parameters.AddWithValue(":CODCLI", modelo.codcli);
            cmd.Parameters.AddWithValue(":NUMITENS", modelo.numitens);
            cmd.Parameters.AddWithValue(":VLATEND", modelo.vlatend);
            cmd.Parameters.AddWithValue(":CODPRACA", modelo.codpraca);
            cmd.Parameters.AddWithValue(":POSICAO", modelo.posicao);
            cmd.Parameters.AddWithValue(":NUMCAR", modelo.numcar);
            cmd.Parameters.AddWithValue(":CODSUPERVISOR", modelo.codsupervisor);
            cmd.Parameters.AddWithValue(":CODFILIAL", modelo.codfilial);
            cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal);
            cmd.Parameters.AddWithValue(":VLTABELA", modelo.vltabela);
            cmd.Parameters.AddWithValue(":VLCUSTOREAL", modelo.vlcustoreal);
            cmd.Parameters.AddWithValue(":VLCUSTOFIN", modelo.vlcustofin);
            cmd.Parameters.AddWithValue(":TOTPESO", modelo.totpeso);
            cmd.Parameters.AddWithValue(":TOTVOLUME", modelo.totvolume);
            cmd.Parameters.AddWithValue(":CODEMITENTE", modelo.codemitente);
            cmd.Parameters.AddWithValue(":OPERACAO", modelo.operacao);
            cmd.Parameters.AddWithValue(":TIPOVENDA", modelo.tipovenda);
            cmd.Parameters.AddWithValue(":OBS", modelo.obs);
            cmd.Parameters.AddWithValue(":CODCOB", modelo.codcob);
            cmd.Parameters.AddWithValue(":HORA", modelo.hora);
            cmd.Parameters.AddWithValue(":MINUTO", modelo.minuto);
            cmd.Parameters.AddWithValue(":CODPLPAG", modelo.codplpag);
            cmd.Parameters.AddWithValue(":NUMPEDCLI", modelo.numpedcli);
            cmd.Parameters.AddWithValue(":PERCVENDA", modelo.percvenda);
            cmd.Parameters.AddWithValue(":PERDESC", modelo.perdesc);
            cmd.Parameters.AddWithValue(":VLDESCONTO", modelo.vldesconto);
            cmd.Parameters.AddWithValue(":VLFRETE", modelo.vlfrete);
            cmd.Parameters.AddWithValue(":VLOUTRASDESP", modelo.vloutrasdesp);
            cmd.Parameters.AddWithValue(":OBS1", modelo.obs1);
            cmd.Parameters.AddWithValue(":OBS2", modelo.obs2);
            cmd.Parameters.AddWithValue(":CONDVENDA", modelo.condvenda);
            cmd.Parameters.AddWithValue(":DTENTREGA", modelo.dtentrega);
            cmd.Parameters.AddWithValue(":NUMPEDRCA", modelo.numpedrca);
            cmd.Parameters.AddWithValue(":FRETEDESPACHO", modelo.fretedespacho);
            cmd.Parameters.AddWithValue(":FRETEREDESPACHO", modelo.freteredespacho);
            cmd.Parameters.AddWithValue(":CODFORNECFRETE", modelo.codfornecfrete);
            cmd.Parameters.AddWithValue(":CODFORNECREDESPACHO", modelo.codfornecredespacho);
            cmd.Parameters.AddWithValue(":TIPOCARGA", modelo.tipocarga);
            if (modelo.prazo1 != null) { cmd.Parameters.AddWithValue(":PRAZO1", modelo.prazo1); }
            if (modelo.prazo2 != null) { cmd.Parameters.AddWithValue(":PRAZO2", modelo.prazo2); }
            cmd.Parameters.AddWithValue(":PRAZO3", modelo.prazo3);
            cmd.Parameters.AddWithValue(":PRAZO4", modelo.prazo4);
            cmd.Parameters.AddWithValue(":PRAZO5", modelo.prazo5);
            cmd.Parameters.AddWithValue(":PRAZO6", modelo.prazo6);
            cmd.Parameters.AddWithValue(":PRAZO7", modelo.prazo7);
            cmd.Parameters.AddWithValue(":PRAZO8", modelo.prazo8);
            cmd.Parameters.AddWithValue(":PRAZO9", modelo.prazo9);
            cmd.Parameters.AddWithValue(":PRAZO10", modelo.prazo10);
            cmd.Parameters.AddWithValue(":PRAZO11", modelo.prazo11);
            cmd.Parameters.AddWithValue(":PRAZO12", modelo.prazo12);
            cmd.Parameters.AddWithValue(":PRAZOMEDIO", modelo.prazomedio);
            cmd.Parameters.AddWithValue(":OBSENTREGA1", modelo.obsentrega1);
            cmd.Parameters.AddWithValue(":OBSENTREGA2", modelo.obsentrega2);
            cmd.Parameters.AddWithValue(":OBSENTREGA3", modelo.obsentrega3);
            cmd.Parameters.AddWithValue(":TIPOEMBALAGEM", modelo.tipoembalagem);
            cmd.Parameters.AddWithValue(":CODEPTO", modelo.codepto);
            cmd.Parameters.AddWithValue(":CAMPANHA", modelo.campanha);
            cmd.Parameters.AddWithValue(":CODDISTRIB", modelo.coddistrib);
            cmd.Parameters.AddWithValue(":VLCUSTOCONT", modelo.vlcustocont);
            cmd.Parameters.AddWithValue(":VLCUSTOREP", modelo.vlcustorep);
            cmd.Parameters.AddWithValue(":NUMNOTAMANIF", modelo.numnotamanif);
            cmd.Parameters.AddWithValue(":SERIEMANIF", modelo.seriemanif);
            cmd.Parameters.AddWithValue(":ORIGEMPED", modelo.origemped);
            cmd.Parameters.AddWithValue(":ESPECIEMANIF", modelo.especiemanif);
            cmd.Parameters.AddWithValue(":NUMPEDENTFUT", modelo.numpedentfut);
            cmd.Parameters.AddWithValue(":CODFILIALNF", modelo.codfilialnf);
            cmd.Parameters.AddWithValue(":NUMCARMANIF", modelo.numcarmanif);
            cmd.Parameters.AddWithValue(":NUMORCA", modelo.numorca);
            cmd.Parameters.AddWithValue(":CODCONTRATO", modelo.codcontrato);
            cmd.Parameters.AddWithValue(":DATAPEDCLI", modelo.datapedcli);
            cmd.Parameters.AddWithValue(":NUMPEDBNF", modelo.numpedbnf);
            cmd.Parameters.AddWithValue(":BROKER", modelo.broker);
            cmd.Parameters.AddWithValue(":CODESTABELECIMENTO", modelo.codestabelecimento);
            cmd.Parameters.AddWithValue(":NUMTABELA", modelo.numtabela);
            cmd.Parameters.AddWithValue(":MOTIVOPOSICAO", modelo.motivoposicao);
            cmd.Parameters.AddWithValue(":DTAGENDAENTREGA", modelo.dtagendaentrega);
            cmd.Parameters.AddWithValue(":TIPOOPER", modelo.tipooper);
            cmd.Parameters.AddWithValue(":CODMOTBLOQUEIO", modelo.codmotbloqueio);
            cmd.Parameters.AddWithValue(":SERIEECF", modelo.serieecf);
            cmd.Parameters.AddWithValue(":NUMCUPOM", modelo.numcupom);
            cmd.Parameters.AddWithValue(":CODCLIRECEBEDOR", modelo.codclirecebedor);
            cmd.Parameters.AddWithValue(":CONCILIAIMPORTACAO", modelo.conciliaimportacao);
            cmd.Parameters.AddWithValue(":NUMREGIAO", modelo.numregiao);
            cmd.Parameters.AddWithValue(":NUMNOTA", modelo.numnota);
            cmd.Parameters.AddWithValue(":PERDESCFIN", modelo.perdescfin);
            cmd.Parameters.AddWithValue(":RESTRICAOTRANSP", modelo.restricaotransp);
            cmd.Parameters.AddWithValue(":GERACP", modelo.geracp);
            cmd.Parameters.AddWithValue(":USAINTEGRACAOWMS", modelo.usaintegracaowms);
            cmd.Parameters.AddWithValue(":VENDAASSISTIDA", modelo.vendaassistida);
            cmd.Parameters.AddWithValue(":CODMOTIVO", modelo.codmotivo);
            cmd.Parameters.AddWithValue(":LOG", modelo.log);
            cmd.Parameters.AddWithValue(":DTCALCFRETE", modelo.dtcalcfrete);
            cmd.Parameters.AddWithValue(":CODFUNCCALCFRETE", modelo.codfunccalcfrete);
            cmd.Parameters.AddWithValue(":EANCOBRANCA", modelo.eancobranca);
            cmd.Parameters.AddWithValue(":EANENTREGA", modelo.eanentrega);
            cmd.Parameters.AddWithValue(":USACFOPVENDANATV10", modelo.usacfopvendanatv10);
            cmd.Parameters.AddWithValue(":TIPOPRIORIDADEENTREGA", modelo.tipoprioridadeentrega);
            cmd.Parameters.AddWithValue(":CODUSUR2", modelo.codusur2);
            cmd.Parameters.AddWithValue(":CODUSUR3", modelo.codusur3);
            cmd.Parameters.AddWithValue(":CODUSUR4", modelo.codusur4);
            cmd.Parameters.AddWithValue(":CODCLINF", modelo.codclinf);
            cmd.Parameters.AddWithValue(":NUMPEDTV1", modelo.numpedtv1);
            cmd.Parameters.AddWithValue(":USADEBCREDRCA", modelo.usadebcredrca);
            cmd.Parameters.AddWithValue(":BRINDE", modelo.brinde);
            cmd.Parameters.AddWithValue(":BONIFICALTDEBCREDRCA", modelo.bonificaltdebcredrca);
            cmd.Parameters.AddWithValue(":TROCAALTDEBCREDRCA", modelo.trocaaltdebcredrca);
            cmd.Parameters.AddWithValue(":BROKERALTDEBCREDRCA", modelo.brokeraltdebcredrca);
            cmd.Parameters.AddWithValue(":CRMALTDEBCREDRCA", modelo.crmaltdebcredrca);
            cmd.Parameters.AddWithValue(":TIPOMOVCCRCA", modelo.tipomovccrca);
            cmd.Parameters.AddWithValue(":USACREDRCA", modelo.usacredrca);
            cmd.Parameters.AddWithValue(":GERARDADOSNFPAULISTA", modelo.gerardadosnfpaulista);
            cmd.Parameters.AddWithValue(":USASALDOCONTACORRENTEDESCFIN", modelo.usasaldocontacorrentedescfin);
            cmd.Parameters.AddWithValue(":VALORDESCFIN", modelo.valordescfin);
            cmd.Parameters.AddWithValue(":CODVISITA", modelo.codvisita);
            cmd.Parameters.AddWithValue(":CODATENDIMENTO", modelo.codatendimento);
            cmd.Parameters.AddWithValue(":VENDATRIANGULAR", modelo.vendatriangular);
            cmd.Parameters.AddWithValue(":VLENTRADA", modelo.vlentrada);
            cmd.Parameters.AddWithValue(":UFDESEMBARACO", modelo.ufdesembaraco);
            cmd.Parameters.AddWithValue(":LOCALDESEMBARACO", modelo.localdesembaraco);
            cmd.Parameters.AddWithValue(":CUSTOBONIFICACAO", modelo.custobonificacao);
            cmd.Parameters.AddWithValue(":CODFORNECBONIFIC", modelo.codfornecbonific);
            cmd.Parameters.AddWithValue(":CODBNF", modelo.codbnf);
            cmd.Parameters.AddWithValue(":TIPODOCUMENTO", modelo.tipodocumento);
            cmd.Parameters.AddWithValue(":CFOPBNFDEGUSTA", modelo.cfopbnfdegusta);
            cmd.Parameters.AddWithValue(":CONTAORDEM", modelo.contaordem);
            cmd.Parameters.AddWithValue(":DATAEMPENHO", modelo.dataempenho);
            cmd.Parameters.AddWithValue(":NUMEMPENHO", modelo.numempenho);
            cmd.Parameters.AddWithValue(":CODUNIDADEEXECUTORA", modelo.codunidadeexecutora);
            cmd.Parameters.AddWithValue(":PLACAVEICULO", modelo.placaveiculo);
            cmd.Parameters.AddWithValue(":DTLIMITEFAT", modelo.dtlimitefat);
            cmd.Parameters.AddWithValue(":RESERVAESTOQUETV7", modelo.reservaestoquetv7);
            cmd.Parameters.AddWithValue(":FORNECENTREGA", modelo.fornecentrega);
            cmd.Parameters.AddWithValue(":CODCLITV8", modelo.codclitv8);
            cmd.Parameters.AddWithValue(":UFVEICULO", modelo.ufveiculo);
            cmd.Parameters.AddWithValue(":MOTORISTAVEICULO", modelo.motoristaveiculo);
            cmd.Parameters.AddWithValue(":DTINICIODIGITACAOPEDIDO", modelo.dtiniciodigitacaopedido);
            cmd.Parameters.AddWithValue(":DTFIMDIGITACAOPEDIDO", modelo.dtfimdigitacaopedido);
            cmd.Parameters.AddWithValue(":VLDESCABATIMENTO", modelo.vldescabatimento);
            cmd.Parameters.AddWithValue(":AGRUPAMENTO", modelo.agrupamento);
            cmd.Parameters.AddWithValue(":VENDAEXPORTACAO", modelo.vendaexportacao);
            cmd.Parameters.AddWithValue(":TURNOENTREGA", modelo.turnoentrega);
            cmd.Parameters.AddWithValue(":NUMTRANSVENDATV13", modelo.numtransvendatv13);
            cmd.Parameters.AddWithValue(":CODENDENTCLI", modelo.codendentcli);
            cmd.Parameters.AddWithValue(":UTILIZAVENDAPOREMBALAGEM", modelo.utilizavendaporembalagem);
            cmd.Parameters.AddWithValue(":CODCONTATO", modelo.codcontato);
            cmd.Parameters.AddWithValue(":NUMREGEXP", modelo.numregexp);
            cmd.Parameters.AddWithValue(":NUMCHAVEEXP", modelo.numchaveexp);
            cmd.Parameters.AddWithValue(":NUMDRAWBACK", modelo.numdrawback);
            cmd.Parameters.AddWithValue(":DTNFTRANSF", modelo.dtnftransf);
            cmd.Parameters.AddWithValue(":ROTINALANC", modelo.rotinalanc);
            cmd.Parameters.AddWithValue(":NUMPEDORIGEM", modelo.numpedorigem);
            cmd.Parameters.AddWithValue(":PEDDUPLICADO", modelo.pedduplicado);
            cmd.Parameters.AddWithValue(":VLBONIFIC", modelo.vlbonific);
            cmd.Parameters.AddWithValue(":VENDALOCESTRANG", modelo.vendalocestrang);
            cmd.Parameters.AddWithValue(":COPIAIDENTICAPEDDUP", modelo.copiaidenticapeddup);
            cmd.Parameters.AddWithValue(":ASSINATURA", modelo.assinatura);
            cmd.Parameters.AddWithValue(":IDPARCEIRO", modelo.idparceiro);
            cmd.Parameters.AddWithValue(":UIDREGISTRO", modelo.uidregistro);
            cmd.Parameters.AddWithValue(":CONDFINANC", modelo.condfinanc);
            cmd.Parameters.AddWithValue(":PLANOSUPPLI", modelo.planosuppli);
            cmd.Parameters.AddWithValue(":PAGCHEQUEMORADIA", modelo.pagchequemoradia);
            cmd.Parameters.AddWithValue(":NUMVOLUME", modelo.numvolume);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void Alterar(ModeloPCPEDC modelo)
        {
            String comando2 = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando2 = comando2 + "UPDATE PCPEDC " + "\n";
            comando2 = comando2 + "       SET NUMPED                       = :NUMPED, " + "\n";
            comando2 = comando2 + "           DATA                         = :DATA, " + "\n";
            comando2 = comando2 + "           CODUSUR                      = :CODUSUR, " + "\n";
            comando2 = comando2 + "           CODCLI                       = :CODCLI, " + "\n";
            comando2 = comando2 + "           NUMITENS                     = :NUMITENS, " + "\n";
            comando2 = comando2 + "           VLATEND                      = :VLATEND, " + "\n";
            comando2 = comando2 + "           CODPRACA                     = :CODPRACA, " + "\n";
            comando2 = comando2 + "           POSICAO                      = :POSICAO, " + "\n";
            comando2 = comando2 + "           NUMCAR                       = :NUMCAR, " + "\n";
            comando2 = comando2 + "           CODSUPERVISOR                = :CODSUPERVISOR, " + "\n";
            comando2 = comando2 + "           CODFILIAL                    = :CODFILIAL, " + "\n";
            comando2 = comando2 + "           CODFILIALNF                  = :CODFILIALNF, " + "\n";
            comando2 = comando2 + "           VLTOTAL                      = :VLTOTAL, " + "\n";
            comando2 = comando2 + "           VLTABELA                     = :VLTABELA, " + "\n";
            comando2 = comando2 + "           VLCUSTOREAL                  = :VLCUSTOREAL, " + "\n";
            comando2 = comando2 + "           VLCUSTOFIN                   = :VLCUSTOFIN, " + "\n";
            comando2 = comando2 + "           TOTPESO                      = :TOTPESO, " + "\n";
            comando2 = comando2 + "           TOTVOLUME                    = :TOTVOLUME, " + "\n";
            comando2 = comando2 + "           CODEMITENTE                  = :CODEMITENTE, " + "\n";
            comando2 = comando2 + "           OPERACAO                     = :OPERACAO, " + "\n";
            comando2 = comando2 + "           TIPOVENDA                    = :TIPOVENDA, " + "\n";
            comando2 = comando2 + "           OBS                          = :OBS, " + "\n";
            comando2 = comando2 + "           CODCOB                       = :CODCOB, " + "\n";
            comando2 = comando2 + "           HORA                         = :HORA, " + "\n";
            comando2 = comando2 + "           MINUTO                       = :MINUTO, " + "\n";
            comando2 = comando2 + "           CODPLPAG                     = :CODPLPAG, " + "\n";
            comando2 = comando2 + "           NUMPEDCLI                    = :NUMPEDCLI, " + "\n";
            comando2 = comando2 + "           PERCVENDA                    = :PERCVENDA, " + "\n";
            comando2 = comando2 + "           PERDESC                      = :PERDESC, " + "\n";
            comando2 = comando2 + "           VLDESCONTO                   = :VLDESCONTO, " + "\n";
            comando2 = comando2 + "           VLFRETE                      = :VLFRETE, " + "\n";
            comando2 = comando2 + "           VLOUTRASDESP                 = :VLOUTRASDESP, " + "\n";
            comando2 = comando2 + "           OBS1                         = :OBS1, " + "\n";
            comando2 = comando2 + "           OBS2                         = :OBS2, " + "\n";
            comando2 = comando2 + "           CONDVENDA                    = :CONDVENDA, " + "\n";
            comando2 = comando2 + "           DTENTREGA                    = :DTENTREGA, " + "\n";
            comando2 = comando2 + "           NUMPEDRCA                    = :NUMPEDRCA, " + "\n";
            comando2 = comando2 + "           FRETEDESPACHO                = :FRETEDESPACHO, " + "\n";
            comando2 = comando2 + "           FRETEREDESPACHO              = :FRETEREDESPACHO, " + "\n";
            comando2 = comando2 + "           CODFORNECFRETE               = :CODFORNECFRETE, " + "\n";
            comando2 = comando2 + "           CODFORNECREDESPACHO          = :CODFORNECREDESPACHO, " + "\n";
            comando2 = comando2 + "           TIPOCARGA                    = :TIPOCARGA, " + "\n";
            comando2 = comando2 + "           PRAZO1                       = :PRAZO1, " + "\n";
            comando2 = comando2 + "           PRAZO2                       = :PRAZO2, " + "\n";
            comando2 = comando2 + "           PRAZO3                       = :PRAZO3, " + "\n";
            comando2 = comando2 + "           PRAZO4                       = :PRAZO4, " + "\n";
            comando2 = comando2 + "           PRAZO5                       = :PRAZO5, " + "\n";
            comando2 = comando2 + "           PRAZO6                       = :PRAZO6, " + "\n";
            comando2 = comando2 + "           PRAZO7                       = :PRAZO7, " + "\n";
            comando2 = comando2 + "           PRAZO8                       = :PRAZO8, " + "\n";
            comando2 = comando2 + "           PRAZO9                       = :PRAZO9, " + "\n";
            comando2 = comando2 + "           PRAZO10                      = :PRAZO10, " + "\n";
            comando2 = comando2 + "           PRAZO11                      = :PRAZO11, " + "\n";
            comando2 = comando2 + "           PRAZO12                      = :PRAZO12, " + "\n";
            comando2 = comando2 + "           PRAZOMEDIO                   = :PRAZOMEDIO, " + "\n";
            comando2 = comando2 + "           OBSENTREGA1                  = :OBSENTREGA1, " + "\n";
            comando2 = comando2 + "           OBSENTREGA2                  = :OBSENTREGA2, " + "\n";
            comando2 = comando2 + "           OBSENTREGA3                  = :OBSENTREGA3, " + "\n";
            comando2 = comando2 + "           TIPOEMBALAGEM                = :TIPOEMBALAGEM, " + "\n";
            comando2 = comando2 + "           CODEPTO                      = :CODEPTO, " + "\n";
            comando2 = comando2 + "           CAMPANHA                     = :CAMPANHA, " + "\n";
            comando2 = comando2 + "           CODDISTRIB                   = :CODDISTRIB, " + "\n";
            comando2 = comando2 + "           NUMNOTAMANIF                 = :NUMNOTAMANIF, " + "\n";
            comando2 = comando2 + "           SERIEMANIF                   = :SERIEMANIF, " + "\n";
            comando2 = comando2 + "           ORIGEMPED                    = :ORIGEMPED, " + "\n";
            comando2 = comando2 + "           ESPECIEMANIF                 = :ESPECIEMANIF, " + "\n";
            comando2 = comando2 + "           NUMCARMANIF                  = :NUMCARMANIF, " + "\n";
            comando2 = comando2 + "           NUMORCA                      = :NUMORCA, " + "\n";
            comando2 = comando2 + "           CODCONTRATO                  = :CODCONTRATO, " + "\n";
            comando2 = comando2 + "           DATAPEDCLI                   = :DATAPEDCLI, " + "\n";
            comando2 = comando2 + "           NUMPEDBNF                    = :NUMPEDBNF, " + "\n";
            comando2 = comando2 + "           BROKER                       = :BROKER, " + "\n";
            comando2 = comando2 + "           CODESTABELECIMENTO           = :CODESTABELECIMENTO, " + "\n";
            comando2 = comando2 + "           NUMTABELA                    = :NUMTABELA, " + "\n";
            comando2 = comando2 + "           MOTIVOPOSICAO                = :MOTIVOPOSICAO, " + "\n";
            comando2 = comando2 + "           DTAGENDAENTREGA              = :DTAGENDAENTREGA, " + "\n";
            comando2 = comando2 + "           TIPOOPER                     = :TIPOOPER, " + "\n";
            comando2 = comando2 + "           CODMOTBLOQUEIO               = :CODMOTBLOQUEIO, " + "\n";
            comando2 = comando2 + "           SERIEECF                     = :SERIEECF, " + "\n";
            comando2 = comando2 + "           NUMCUPOM                     = :NUMCUPOM, " + "\n";
            comando2 = comando2 + "           CODCLIRECEBEDOR              = :CODCLIRECEBEDOR, " + "\n";
            comando2 = comando2 + "           CONCILIAIMPORTACAO           = :CONCILIAIMPORTACAO, " + "\n";
            comando2 = comando2 + "           NUMREGIAO                    = :NUMREGIAO, " + "\n";
            comando2 = comando2 + "           NUMNOTA                      = :NUMNOTA, " + "\n";
            comando2 = comando2 + "           PERDESCFIN                   = :PERDESCFIN, " + "\n";
            comando2 = comando2 + "           RESTRICAOTRANSP              = :RESTRICAOTRANSP, " + "\n";
            comando2 = comando2 + "           GERACP                       = :GERACP, " + "\n";
            comando2 = comando2 + "           USAINTEGRACAOWMS             = :USAINTEGRACAOWMS, " + "\n";
            comando2 = comando2 + "           VENDAASSISTIDA               = :VENDAASSISTIDA, " + "\n";
            comando2 = comando2 + "           CODMOTIVO                    = :CODMOTIVO, " + "\n";
            comando2 = comando2 + "           LOG                          = :LOG, " + "\n";
            comando2 = comando2 + "           CODFUNCCALCFRETE             = :CODFUNCCALCFRETE, " + "\n";
            comando2 = comando2 + "           DTCALCFRETE                  = :DTCALCFRETE, " + "\n";
            comando2 = comando2 + "           EANENTREGA                   = :EANENTREGA, " + "\n";
            comando2 = comando2 + "           EANCOBRANCA                  = :EANCOBRANCA, " + "\n";
            comando2 = comando2 + "           USACFOPVENDANATV10           = :USACFOPVENDANATV10, " + "\n";
            comando2 = comando2 + "           TIPOPRIORIDADEENTREGA        = :TIPOPRIORIDADEENTREGA, " + "\n";
            comando2 = comando2 + "           CODUSUR2                     = :CODUSUR2, " + "\n";
            comando2 = comando2 + "           CODUSUR3                     = :CODUSUR3, " + "\n";
            comando2 = comando2 + "           CODUSUR4                     = :CODUSUR4, " + "\n";
            comando2 = comando2 + "           CODCLINF                     = :CODCLINF, " + "\n";
            comando2 = comando2 + "           NUMPEDTV1                    = :NUMPEDTV1, " + "\n";
            comando2 = comando2 + "           USADEBCREDRCA                = :USADEBCREDRCA, " + "\n";
            comando2 = comando2 + "           BRINDE                       = :BRINDE, " + "\n";
            comando2 = comando2 + "           BONIFICALTDEBCREDRCA         = :BONIFICALTDEBCREDRCA, " + "\n";
            comando2 = comando2 + "           TROCAALTDEBCREDRCA           = :TROCAALTDEBCREDRCA, " + "\n";
            comando2 = comando2 + "           BROKERALTDEBCREDRCA          = :BROKERALTDEBCREDRCA, " + "\n";
            comando2 = comando2 + "           CRMALTDEBCREDRCA             = :CRMALTDEBCREDRCA, " + "\n";
            comando2 = comando2 + "           TIPOMOVCCRCA                 = :TIPOMOVCCRCA, " + "\n";
            comando2 = comando2 + "           USACREDRCA                   = :USACREDRCA, " + "\n";
            comando2 = comando2 + "           GERARDADOSNFPAULISTA         = :GERARDADOSNFPAULISTA, " + "\n";
            comando2 = comando2 + "           USASALDOCONTACORRENTEDESCFIN = :USASALDOCONTACORRENTEDESCFIN, " + "\n";
            comando2 = comando2 + "           VALORDESCFIN                 = :VALORDESCFIN, " + "\n";
            comando2 = comando2 + "           CODVISITA                    = :CODVISITA, " + "\n";
            comando2 = comando2 + "           CODATENDIMENTO               = :CODATENDIMENTO, " + "\n";
            comando2 = comando2 + "           VENDATRIANGULAR              = :VENDATRIANGULAR, " + "\n";
            comando2 = comando2 + "           VLENTRADA                    = :VLENTRADA, " + "\n";
            comando2 = comando2 + "           UFDESEMBARACO                = :UFDESEMBARACO, " + "\n";
            comando2 = comando2 + "           LOCALDESEMBARACO             = :LOCALDESEMBARACO, " + "\n";
            comando2 = comando2 + "           CUSTOBONIFICACAO             = :CUSTOBONIFICACAO, " + "\n";
            comando2 = comando2 + "           CODFORNECBONIFIC             = :CODFORNECBONIFIC, " + "\n";
            comando2 = comando2 + "           CODBNF                       = :CODBNF, " + "\n";
            comando2 = comando2 + "           TIPODOCUMENTO                = :TIPODOCUMENTO, " + "\n";
            comando2 = comando2 + "           CFOPBNFDEGUSTA               = :CFOPBNFDEGUSTA, " + "\n";
            comando2 = comando2 + "           CONTAORDEM                   = :CONTAORDEM, " + "\n";
            comando2 = comando2 + "           DATAEMPENHO                  = :DATAEMPENHO, " + "\n";
            comando2 = comando2 + "           NUMEMPENHO                   = :NUMEMPENHO, " + "\n";
            comando2 = comando2 + "           CODUNIDADEEXECUTORA          = :CODUNIDADEEXECUTORA, " + "\n";
            comando2 = comando2 + "           PLACAVEICULO                 = :PLACAVEICULO, " + "\n";
            comando2 = comando2 + "           DTLIMITEFAT                  = :DTLIMITEFAT, " + "\n";
            comando2 = comando2 + "           RESERVAESTOQUETV7            = :RESERVAESTOQUETV7, " + "\n";
            comando2 = comando2 + "           FORNECENTREGA                = :FORNECENTREGA, " + "\n";
            comando2 = comando2 + "           CODCLITV8                    = :CODCLITV8, " + "\n";
            comando2 = comando2 + "           UFVEICULO                    = :UFVEICULO, " + "\n";
            comando2 = comando2 + "           MOTORISTAVEICULO             = :MOTORISTAVEICULO, " + "\n";
            comando2 = comando2 + "           DTINICIODIGITACAOPEDIDO      = :DTINICIODIGITACAOPEDIDO, " + "\n";
            comando2 = comando2 + "           DTFIMDIGITACAOPEDIDO         = :DTFIMDIGITACAOPEDIDO, " + "\n";
            comando2 = comando2 + "           VLDESCABATIMENTO             = :VLDESCABATIMENTO, " + "\n";
            comando2 = comando2 + "           AGRUPAMENTO                  = :AGRUPAMENTO, " + "\n";
            comando2 = comando2 + "           VENDAEXPORTACAO              = :VENDAEXPORTACAO, " + "\n";
            comando2 = comando2 + "           TURNOENTREGA                 = :TURNOENTREGA, " + "\n";
            comando2 = comando2 + "           NUMTRANSVENDATV13            = :NUMTRANSVENDATV13, " + "\n";
            comando2 = comando2 + "           CODENDENTCLI                 = :CODENDENTCLI, " + "\n";
            comando2 = comando2 + "           UTILIZAVENDAPOREMBALAGEM     = :UTILIZAVENDAPOREMBALAGEM, " + "\n";
            comando2 = comando2 + "           CODCONTATO                   = :CODCONTATO, " + "\n";
            comando2 = comando2 + "           NUMREGEXP                    = :NUMREGEXP, " + "\n";
            comando2 = comando2 + "           NUMCHAVEEXP                  = :NUMCHAVEEXP, " + "\n";
            comando2 = comando2 + "           NUMDRAWBACK                  = :NUMDRAWBACK, " + "\n";
            comando2 = comando2 + "           DTNFTRANSF                   = :DTNFTRANSF, " + "\n";
            comando2 = comando2 + "           ROTINALANC                   = :ROTINALANC, " + "\n";
            comando2 = comando2 + "           NUMPEDORIGEM                 = :NUMPEDORIGEM, " + "\n";
            comando2 = comando2 + "           PEDDUPLICADO                 = :PEDDUPLICADO, " + "\n";
            comando2 = comando2 + "           VLBONIFIC                    = :VLBONIFIC, " + "\n";
            comando2 = comando2 + "           VENDALOCESTRANG              = :VENDALOCESTRANG, " + "\n";
            comando2 = comando2 + "           COPIAIDENTICAPEDDUP          = :COPIAIDENTICAPEDDUP, " + "\n";
            comando2 = comando2 + "           ASSINATURA                   = :ASSINATURA, " + "\n";
            comando2 = comando2 + "           IDPARCEIRO                   = :IDPARCEIRO, " + "\n";
            comando2 = comando2 + "           UIDREGISTRO                  = :UIDREGISTRO, " + "\n";
            comando2 = comando2 + "           PLANOSUPPLI                  = :PLANOSUPPLI, " + "\n";
            comando2 = comando2 + "           PAGCHEQUEMORADIA             = :PAGCHEQUEMORADIA, " + "\n";
            comando2 = comando2 + "           NUMVOLUME                    = :NUMVOLUME " + "\n";
            comando2 = comando2 + "            " + "\n";
            comando2 = comando2 + "     WHERE NUMPED = :OLD_NUMPED";
            cmd.CommandText = comando2;
            cmd.Parameters.AddWithValue(":OLD_NUMPED", modelo.numped);
            cmd.Parameters.AddWithValue(":NUMPED", modelo.numped);
            cmd.Parameters.AddWithValue(":DATA", modelo.data);
            cmd.Parameters.AddWithValue(":CODUSUR", modelo.codusur);
            cmd.Parameters.AddWithValue(":CODCLI", modelo.codcli);
            cmd.Parameters.AddWithValue(":NUMITENS", modelo.numitens);
            cmd.Parameters.AddWithValue(":VLATEND", modelo.vlatend);
            cmd.Parameters.AddWithValue(":CODPRACA", modelo.codpraca);
            cmd.Parameters.AddWithValue(":POSICAO", modelo.posicao);
            cmd.Parameters.AddWithValue(":NUMCAR", modelo.numcar);
            cmd.Parameters.AddWithValue(":CODSUPERVISOR", modelo.codsupervisor);
            cmd.Parameters.AddWithValue(":CODFILIAL", modelo.codfilial);
            cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal);
            cmd.Parameters.AddWithValue(":VLTABELA", modelo.vltabela);
            cmd.Parameters.AddWithValue(":VLCUSTOREAL", modelo.vlcustoreal);
            cmd.Parameters.AddWithValue(":VLCUSTOFIN", modelo.vlcustofin);
            cmd.Parameters.AddWithValue(":TOTPESO", modelo.totpeso);
            cmd.Parameters.AddWithValue(":TOTVOLUME", modelo.totvolume);
            cmd.Parameters.AddWithValue(":CODEMITENTE", modelo.codemitente);
            cmd.Parameters.AddWithValue(":OPERACAO", modelo.operacao);
            cmd.Parameters.AddWithValue(":TIPOVENDA", modelo.tipovenda);
            cmd.Parameters.AddWithValue(":OBS", modelo.obs);
            cmd.Parameters.AddWithValue(":CODCOB", modelo.codcob);
            cmd.Parameters.AddWithValue(":HORA", modelo.hora);
            cmd.Parameters.AddWithValue(":MINUTO", modelo.minuto);
            cmd.Parameters.AddWithValue(":CODPLPAG", modelo.codplpag);
            cmd.Parameters.AddWithValue(":NUMPEDCLI", modelo.numpedcli);
            cmd.Parameters.AddWithValue(":PERCVENDA", modelo.percvenda);
            cmd.Parameters.AddWithValue(":PERDESC", modelo.perdesc);
            cmd.Parameters.AddWithValue(":VLDESCONTO", modelo.vldesconto);
            cmd.Parameters.AddWithValue(":VLFRETE", modelo.vlfrete);
            cmd.Parameters.AddWithValue(":VLOUTRASDESP", modelo.vloutrasdesp);
            cmd.Parameters.AddWithValue(":OBS1", modelo.obs1);
            cmd.Parameters.AddWithValue(":OBS2", modelo.obs2);
            cmd.Parameters.AddWithValue(":CONDVENDA", modelo.condvenda);
            cmd.Parameters.AddWithValue(":DTENTREGA", modelo.dtentrega);
            cmd.Parameters.AddWithValue(":NUMPEDRCA", modelo.numpedrca);
            cmd.Parameters.AddWithValue(":FRETEDESPACHO", modelo.fretedespacho);
            cmd.Parameters.AddWithValue(":FRETEREDESPACHO", modelo.freteredespacho);
            cmd.Parameters.AddWithValue(":CODFORNECFRETE", modelo.codfornecfrete);
            cmd.Parameters.AddWithValue(":CODFORNECREDESPACHO", modelo.codfornecredespacho);
            cmd.Parameters.AddWithValue(":TIPOCARGA", modelo.tipocarga);
            cmd.Parameters.AddWithValue(":PRAZO1", modelo.prazo1);
            cmd.Parameters.AddWithValue(":PRAZO2", modelo.prazo2);
            cmd.Parameters.AddWithValue(":PRAZO3", modelo.prazo3);
            cmd.Parameters.AddWithValue(":PRAZO4", modelo.prazo4);
            cmd.Parameters.AddWithValue(":PRAZO5", modelo.prazo5);
            cmd.Parameters.AddWithValue(":PRAZO6", modelo.prazo6);
            cmd.Parameters.AddWithValue(":PRAZO7", modelo.prazo7);
            cmd.Parameters.AddWithValue(":PRAZO8", modelo.prazo8);
            cmd.Parameters.AddWithValue(":PRAZO9", modelo.prazo9);
            cmd.Parameters.AddWithValue(":PRAZO10", modelo.prazo10);
            cmd.Parameters.AddWithValue(":PRAZO11", modelo.prazo11);
            cmd.Parameters.AddWithValue(":PRAZO12", modelo.prazo12);
            cmd.Parameters.AddWithValue(":PRAZOMEDIO", modelo.prazomedio);
            cmd.Parameters.AddWithValue(":OBSENTREGA1", modelo.obsentrega1);
            cmd.Parameters.AddWithValue(":OBSENTREGA2", modelo.obsentrega2);
            cmd.Parameters.AddWithValue(":OBSENTREGA3", modelo.obsentrega3);
            cmd.Parameters.AddWithValue(":TIPOEMBALAGEM", modelo.tipoembalagem);
            cmd.Parameters.AddWithValue(":CODEPTO", modelo.codepto);
            cmd.Parameters.AddWithValue(":CAMPANHA", modelo.campanha);
            cmd.Parameters.AddWithValue(":CODDISTRIB", modelo.coddistrib);
            cmd.Parameters.AddWithValue(":VLCUSTOCONT", modelo.vlcustocont);
            cmd.Parameters.AddWithValue(":VLCUSTOREP", modelo.vlcustorep);
            cmd.Parameters.AddWithValue(":NUMNOTAMANIF", modelo.numnotamanif);
            cmd.Parameters.AddWithValue(":SERIEMANIF", modelo.seriemanif);
            cmd.Parameters.AddWithValue(":ORIGEMPED", modelo.origemped);
            cmd.Parameters.AddWithValue(":ESPECIEMANIF", modelo.especiemanif);
            cmd.Parameters.AddWithValue(":NUMPEDENTFUT", modelo.numpedentfut);
            cmd.Parameters.AddWithValue(":CODFILIALNF", modelo.codfilialnf);
            cmd.Parameters.AddWithValue(":NUMCARMANIF", modelo.numcarmanif);
            cmd.Parameters.AddWithValue(":NUMORCA", modelo.numorca);
            cmd.Parameters.AddWithValue(":CODCONTRATO", modelo.codcontrato);
            cmd.Parameters.AddWithValue(":DATAPEDCLI", modelo.datapedcli);
            cmd.Parameters.AddWithValue(":NUMPEDBNF", modelo.numpedbnf);
            cmd.Parameters.AddWithValue(":BROKER", modelo.broker);
            cmd.Parameters.AddWithValue(":CODESTABELECIMENTO", modelo.codestabelecimento);
            cmd.Parameters.AddWithValue(":NUMTABELA", modelo.numtabela);
            cmd.Parameters.AddWithValue(":MOTIVOPOSICAO", modelo.motivoposicao);
            cmd.Parameters.AddWithValue(":DTAGENDAENTREGA", modelo.dtagendaentrega);
            cmd.Parameters.AddWithValue(":TIPOOPER", modelo.tipooper);
            cmd.Parameters.AddWithValue(":CODMOTBLOQUEIO", modelo.codmotbloqueio);
            cmd.Parameters.AddWithValue(":SERIEECF", modelo.serieecf);
            cmd.Parameters.AddWithValue(":NUMCUPOM", modelo.numcupom);
            cmd.Parameters.AddWithValue(":CODCLIRECEBEDOR", modelo.codclirecebedor);
            cmd.Parameters.AddWithValue(":CONCILIAIMPORTACAO", modelo.conciliaimportacao);
            cmd.Parameters.AddWithValue(":NUMREGIAO", modelo.numregiao);
            cmd.Parameters.AddWithValue(":NUMNOTA", modelo.numnota);
            cmd.Parameters.AddWithValue(":PERDESCFIN", modelo.perdescfin);
            cmd.Parameters.AddWithValue(":RESTRICAOTRANSP", modelo.restricaotransp);
            cmd.Parameters.AddWithValue(":GERACP", modelo.geracp);
            cmd.Parameters.AddWithValue(":USAINTEGRACAOWMS", modelo.usaintegracaowms);
            cmd.Parameters.AddWithValue(":VENDAASSISTIDA", modelo.vendaassistida);
            cmd.Parameters.AddWithValue(":CODMOTIVO", modelo.codmotivo);
            cmd.Parameters.AddWithValue(":LOG", modelo.log);
            cmd.Parameters.AddWithValue(":DTCALCFRETE", modelo.dtcalcfrete);
            cmd.Parameters.AddWithValue(":CODFUNCCALCFRETE", modelo.codfunccalcfrete);
            cmd.Parameters.AddWithValue(":EANCOBRANCA", modelo.eancobranca);
            cmd.Parameters.AddWithValue(":EANENTREGA", modelo.eanentrega);
            cmd.Parameters.AddWithValue(":USACFOPVENDANATV10", modelo.usacfopvendanatv10);
            cmd.Parameters.AddWithValue(":TIPOPRIORIDADEENTREGA", modelo.tipoprioridadeentrega);
            cmd.Parameters.AddWithValue(":CODUSUR2", modelo.codusur2);
            cmd.Parameters.AddWithValue(":CODUSUR3", modelo.codusur3);
            cmd.Parameters.AddWithValue(":CODUSUR4", modelo.codusur4);
            cmd.Parameters.AddWithValue(":CODCLINF", modelo.codclinf);
            cmd.Parameters.AddWithValue(":NUMPEDTV1", modelo.numpedtv1);
            cmd.Parameters.AddWithValue(":USADEBCREDRCA", modelo.usadebcredrca);
            cmd.Parameters.AddWithValue(":BRINDE", modelo.brinde);
            cmd.Parameters.AddWithValue(":BONIFICALTDEBCREDRCA", modelo.bonificaltdebcredrca);
            cmd.Parameters.AddWithValue(":TROCAALTDEBCREDRCA", modelo.trocaaltdebcredrca);
            cmd.Parameters.AddWithValue(":BROKERALTDEBCREDRCA", modelo.brokeraltdebcredrca);
            cmd.Parameters.AddWithValue(":CRMALTDEBCREDRCA", modelo.crmaltdebcredrca);
            cmd.Parameters.AddWithValue(":TIPOMOVCCRCA", modelo.tipomovccrca);
            cmd.Parameters.AddWithValue(":USACREDRCA", modelo.usacredrca);
            cmd.Parameters.AddWithValue(":GERARDADOSNFPAULISTA", modelo.gerardadosnfpaulista);
            cmd.Parameters.AddWithValue(":USASALDOCONTACORRENTEDESCFIN", modelo.usasaldocontacorrentedescfin);
            cmd.Parameters.AddWithValue(":VALORDESCFIN", modelo.valordescfin);
            cmd.Parameters.AddWithValue(":CODVISITA", modelo.codvisita);
            cmd.Parameters.AddWithValue(":CODATENDIMENTO", modelo.codatendimento);
            cmd.Parameters.AddWithValue(":VENDATRIANGULAR", modelo.vendatriangular);
            cmd.Parameters.AddWithValue(":VLENTRADA", modelo.vlentrada);
            cmd.Parameters.AddWithValue(":UFDESEMBARACO", modelo.ufdesembaraco);
            cmd.Parameters.AddWithValue(":LOCALDESEMBARACO", modelo.localdesembaraco);
            cmd.Parameters.AddWithValue(":CUSTOBONIFICACAO", modelo.custobonificacao);
            cmd.Parameters.AddWithValue(":CODFORNECBONIFIC", modelo.codfornecbonific);
            cmd.Parameters.AddWithValue(":CODBNF", modelo.codbnf);
            cmd.Parameters.AddWithValue(":TIPODOCUMENTO", modelo.tipodocumento);
            cmd.Parameters.AddWithValue(":CFOPBNFDEGUSTA", modelo.cfopbnfdegusta);
            cmd.Parameters.AddWithValue(":CONTAORDEM", modelo.contaordem);
            cmd.Parameters.AddWithValue(":DATAEMPENHO", modelo.dataempenho);
            cmd.Parameters.AddWithValue(":NUMEMPENHO", modelo.numempenho);
            cmd.Parameters.AddWithValue(":CODUNIDADEEXECUTORA", modelo.codunidadeexecutora);
            cmd.Parameters.AddWithValue(":PLACAVEICULO", modelo.placaveiculo);
            cmd.Parameters.AddWithValue(":DTLIMITEFAT", modelo.dtlimitefat);
            cmd.Parameters.AddWithValue(":RESERVAESTOQUETV7", modelo.reservaestoquetv7);
            cmd.Parameters.AddWithValue(":FORNECENTREGA", modelo.fornecentrega);
            cmd.Parameters.AddWithValue(":CODCLITV8", modelo.codclitv8);
            cmd.Parameters.AddWithValue(":UFVEICULO", modelo.ufveiculo);
            cmd.Parameters.AddWithValue(":MOTORISTAVEICULO", modelo.motoristaveiculo);
            cmd.Parameters.AddWithValue(":DTINICIODIGITACAOPEDIDO", modelo.dtiniciodigitacaopedido);
            cmd.Parameters.AddWithValue(":DTFIMDIGITACAOPEDIDO", modelo.dtfimdigitacaopedido);
            cmd.Parameters.AddWithValue(":VLDESCABATIMENTO", modelo.vldescabatimento);
            cmd.Parameters.AddWithValue(":AGRUPAMENTO", modelo.agrupamento);
            cmd.Parameters.AddWithValue(":VENDAEXPORTACAO", modelo.vendaexportacao);
            cmd.Parameters.AddWithValue(":TURNOENTREGA", modelo.turnoentrega);
            cmd.Parameters.AddWithValue(":NUMTRANSVENDATV13", modelo.numtransvendatv13);
            cmd.Parameters.AddWithValue(":CODENDENTCLI", modelo.codendentcli);
            cmd.Parameters.AddWithValue(":UTILIZAVENDAPOREMBALAGEM", modelo.utilizavendaporembalagem);
            cmd.Parameters.AddWithValue(":CODCONTATO", modelo.codcontato);
            cmd.Parameters.AddWithValue(":NUMREGEXP", modelo.numregexp);
            cmd.Parameters.AddWithValue(":NUMCHAVEEXP", modelo.numchaveexp);
            cmd.Parameters.AddWithValue(":NUMDRAWBACK", modelo.numdrawback);
            cmd.Parameters.AddWithValue(":DTNFTRANSF", modelo.dtnftransf);
            cmd.Parameters.AddWithValue(":ROTINALANC", modelo.rotinalanc);
            cmd.Parameters.AddWithValue(":NUMPEDORIGEM", modelo.numpedorigem);
            cmd.Parameters.AddWithValue(":PEDDUPLICADO", modelo.pedduplicado);
            cmd.Parameters.AddWithValue(":VLBONIFIC", modelo.vlbonific);
            cmd.Parameters.AddWithValue(":VENDALOCESTRANG", modelo.vendalocestrang);
            cmd.Parameters.AddWithValue(":COPIAIDENTICAPEDDUP", modelo.copiaidenticapeddup);
            cmd.Parameters.AddWithValue(":ASSINATURA", modelo.assinatura);
            cmd.Parameters.AddWithValue(":IDPARCEIRO", modelo.idparceiro);
            cmd.Parameters.AddWithValue(":UIDREGISTRO", modelo.uidregistro);
            cmd.Parameters.AddWithValue(":CONDFINANC", modelo.condfinanc);
            cmd.Parameters.AddWithValue(":PLANOSUPPLI", modelo.planosuppli);
            cmd.Parameters.AddWithValue(":PAGCHEQUEMORADIA", modelo.pagchequemoradia);
            cmd.Parameters.AddWithValue(":NUMVOLUME", modelo.numvolume);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

     

        public ModeloPCPEDC CarregaModeloPCPEDC (long codigo)
        {
           String comando3 = "SELECT * FROM PCPEDC WHERE NUMPED = :codigo AND POSICAO <> 'F' AND CONDVENDA = 7 ";

            ModeloPCPEDC modelo = new ModeloPCPEDC();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando3;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue(":codigo", codigo);
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                if (registro["NUMPED"] != DBNull.Value) { modelo.numped = Convert.ToInt64(registro["NUMPED"]); }
                if (registro["DATA"] != DBNull.Value) { modelo.data = Convert.ToDateTime(registro["DATA"]); }
                if (registro["CODUSUR"] != DBNull.Value) { modelo.codusur = Convert.ToInt16(registro["CODUSUR"]); }
                if (registro["CODCLI"] != DBNull.Value) { modelo.codcli = Convert.ToInt32(registro["CODCLI"]); }
                if (registro["NUMITENS"] != DBNull.Value) { modelo.numitens = Convert.ToInt16(registro["NUMITENS"]); }
                if (registro["VLATEND"] != DBNull.Value) { modelo.vlatend = Convert.ToDecimal(registro["VLATEND"]); }
                if (registro["CODPRACA"] != DBNull.Value) { modelo.codpraca = Convert.ToInt16(registro["CODPRACA"]); }
                if (registro["POSICAO"] != DBNull.Value) { modelo.posicao = Convert.ToString(registro["POSICAO"]); }
                if (registro["NUMCAR"] != DBNull.Value) { modelo.numcar = Convert.ToInt32(registro["NUMCAR"]); }
                if (registro["CODSUPERVISOR"] != DBNull.Value) { modelo.codsupervisor = Convert.ToInt16(registro["CODSUPERVISOR"]); }
                if (registro["CODFILIAL"] != DBNull.Value) { modelo.codfilial = Convert.ToString(registro["CODFILIAL"]); }
                if (registro["VLTOTAL"] != DBNull.Value) { modelo.vltotal = Convert.ToDecimal(registro["VLTOTAL"]); }
                if (registro["VLTABELA"] != DBNull.Value) { modelo.vltabela = Convert.ToDecimal(registro["VLTABELA"]); }
                if (registro["VLCUSTOREAL"] != DBNull.Value) { modelo.vlcustoreal = Convert.ToDouble(registro["VLCUSTOREAL"]); }
                if (registro["VLCUSTOFIN"] != DBNull.Value) { modelo.vlcustofin = Convert.ToDouble(registro["VLCUSTOFIN"]); }
                if (registro["TOTPESO"] != DBNull.Value) { modelo.totpeso = Convert.ToDecimal(registro["TOTPESO"]); }
                if (registro["TOTVOLUME"] != DBNull.Value) { modelo.totvolume = Convert.ToDecimal(registro["TOTVOLUME"]); }
                if (registro["CODEMITENTE"] != DBNull.Value) { modelo.codemitente = Convert.ToInt32(registro["CODEMITENTE"]); }
                if (registro["OPERACAO"] != DBNull.Value) { modelo.operacao = Convert.ToString(registro["OPERACAO"]); }
                if (registro["TIPOVENDA"] != DBNull.Value) { modelo.tipovenda = Convert.ToString(registro["TIPOVENDA"]); }
                if (registro["OBS"] != DBNull.Value) { modelo.obs = Convert.ToString(registro["OBS"]); }
                if (registro["CODCOB"] != DBNull.Value) { modelo.codcob = Convert.ToString(registro["CODCOB"]); }
                if (registro["HORA"] != DBNull.Value) { modelo.hora = Convert.ToInt16(registro["HORA"]); }
                if (registro["MINUTO"] != DBNull.Value) { modelo.minuto = Convert.ToInt16(registro["MINUTO"]); }
                if (registro["CODPLPAG"] != DBNull.Value) { modelo.codplpag = Convert.ToInt16(registro["CODPLPAG"]); }
                if (registro["NUMPEDCLI"] != DBNull.Value) { modelo.numpedcli = Convert.ToString(registro["NUMPEDCLI"]); }
                if (registro["PERCVENDA"] != DBNull.Value) { modelo.percvenda = Convert.ToSingle(registro["PERCVENDA"]); }
                if (registro["PERDESC"] != DBNull.Value) { modelo.perdesc = Convert.ToDecimal(registro["PERDESC"]); }
                if (registro["VLDESCONTO"] != DBNull.Value) { modelo.vldesconto = Convert.ToDecimal(registro["VLDESCONTO"]); }
                if (registro["VLFRETE"] != DBNull.Value) { modelo.vlfrete = Convert.ToDecimal(registro["VLFRETE"]); }
                if (registro["VLOUTRASDESP"] != DBNull.Value) { modelo.vloutrasdesp = Convert.ToDecimal(registro["VLOUTRASDESP"]); }
                if (registro["OBS1"] != DBNull.Value) { modelo.obs1 = Convert.ToString(registro["OBS1"]); }
                if (registro["OBS2"] != DBNull.Value) { modelo.obs2 = Convert.ToString(registro["OBS2"]); }
                if (registro["CONDVENDA"] != DBNull.Value) { modelo.condvenda = Convert.ToInt32(registro["CONDVENDA"]); }
                if (registro["DTENTREGA"] != DBNull.Value) { modelo.dtentrega = Convert.ToDateTime(registro["DTENTREGA"]); }
                if (registro["NUMPEDRCA"] != DBNull.Value) { modelo.numpedrca = Convert.ToInt64(registro["NUMPEDRCA"]); }
                if (registro["FRETEDESPACHO"] != DBNull.Value) { modelo.fretedespacho = Convert.ToString(registro["FRETEDESPACHO"]); }
                if (registro["FRETEREDESPACHO"] != DBNull.Value) { modelo.freteredespacho = Convert.ToString(registro["FRETEREDESPACHO"]); }
                if (registro["CODFORNECFRETE"] != DBNull.Value) { modelo.codfornecfrete = Convert.ToInt32(registro["CODFORNECFRETE"]); }
                if (registro["CODFORNECREDESPACHO"] != DBNull.Value) { modelo.codfornecredespacho = Convert.ToInt32(registro["CODFORNECREDESPACHO"]); }
                if (registro["TIPOCARGA"] != DBNull.Value) { modelo.tipocarga = Convert.ToString(registro["TIPOCARGA"]); }
                if (registro["PRAZO1"] != DBNull.Value) { modelo.prazo1 = Convert.ToInt16(registro["PRAZO1"]); }
                if (registro["PRAZO2"] != DBNull.Value) { modelo.prazo2 = Convert.ToInt16(registro["PRAZO2"]); }
                if (registro["PRAZO3"] != DBNull.Value) { modelo.prazo3 = Convert.ToInt16(registro["PRAZO3"]); }
                if (registro["PRAZO4"] != DBNull.Value) { modelo.prazo4 = Convert.ToInt16(registro["PRAZO4"]); }
                if (registro["PRAZO5"] != DBNull.Value) { modelo.prazo5 = Convert.ToInt16(registro["PRAZO5"]); }
                if (registro["PRAZO6"] != DBNull.Value) { modelo.prazo6 = Convert.ToInt16(registro["PRAZO6"]); }
                if (registro["PRAZO7"] != DBNull.Value) { modelo.prazo7 = Convert.ToInt16(registro["PRAZO7"]); }
                if (registro["PRAZO8"] != DBNull.Value) { modelo.prazo8 = Convert.ToInt16(registro["PRAZO8"]); }
                if (registro["PRAZO9"] != DBNull.Value) { modelo.prazo9 = Convert.ToInt16(registro["PRAZO9"]); }
                if (registro["PRAZO10"] != DBNull.Value) { modelo.prazo10 = Convert.ToInt16(registro["PRAZO10"]); }
                if (registro["PRAZO11"] != DBNull.Value) { modelo.prazo11 = Convert.ToInt16(registro["PRAZO11"]); }
                if (registro["PRAZO12"] != DBNull.Value) { modelo.prazo12 = Convert.ToInt16(registro["PRAZO12"]); }
                if (registro["PRAZOMEDIO"] != DBNull.Value) { modelo.prazomedio = Convert.ToInt16(registro["PRAZOMEDIO"]); }
                if (registro["OBSENTREGA1"] != DBNull.Value) { modelo.obsentrega1 = Convert.ToString(registro["OBSENTREGA1"]); }
                if (registro["OBSENTREGA2"] != DBNull.Value) { modelo.obsentrega2 = Convert.ToString(registro["OBSENTREGA2"]); }
                if (registro["OBSENTREGA3"] != DBNull.Value) { modelo.obsentrega3 = Convert.ToString(registro["OBSENTREGA3"]); }
                if (registro["TIPOEMBALAGEM"] != DBNull.Value) { modelo.tipoembalagem = Convert.ToString(registro["TIPOEMBALAGEM"]); }
                if (registro["CODEPTO"] != DBNull.Value) { modelo.codepto = Convert.ToInt32(registro["CODEPTO"]); }
                if (registro["CAMPANHA"] != DBNull.Value) { modelo.campanha = Convert.ToString(registro["CAMPANHA"]); }
                if (registro["CODDISTRIB"] != DBNull.Value) { modelo.coddistrib = Convert.ToString(registro["CODDISTRIB"]); }
                if (registro["VLCUSTOCONT"] != DBNull.Value) { modelo.vlcustocont = Convert.ToDouble(registro["VLCUSTOCONT"]); }
                if (registro["VLCUSTOREP"] != DBNull.Value) { modelo.vlcustorep = Convert.ToDouble(registro["VLCUSTOREP"]); }
                if (registro["NUMNOTAMANIF"] != DBNull.Value) { modelo.numnotamanif = Convert.ToInt64(registro["NUMNOTAMANIF"]); }
                if (registro["SERIEMANIF"] != DBNull.Value) { modelo.seriemanif = Convert.ToString(registro["SERIEMANIF"]); }
                if (registro["ORIGEMPED"] != DBNull.Value) { modelo.origemped = Convert.ToString(registro["ORIGEMPED"]); }
                if (registro["ESPECIEMANIF"] != DBNull.Value) { modelo.especiemanif = Convert.ToString(registro["ESPECIEMANIF"]); }
                if (registro["NUMPEDENTFUT"] != DBNull.Value) { modelo.numpedentfut = Convert.ToInt64(registro["NUMPEDENTFUT"]); }
                if (registro["CODFILIALNF"] != DBNull.Value) { modelo.codfilialnf = Convert.ToString(registro["CODFILIALNF"]); }
                if (registro["NUMCARMANIF"] != DBNull.Value) { modelo.numcarmanif = Convert.ToInt32(registro["NUMCARMANIF"]); }
                if (registro["NUMORCA"] != DBNull.Value) { modelo.numorca = Convert.ToInt64(registro["NUMORCA"]); }
                if (registro["CODCONTRATO"] != DBNull.Value) { modelo.codcontrato = Convert.ToInt32(registro["CODCONTRATO"]); }
                if (registro["DATAPEDCLI"] != DBNull.Value) { modelo.datapedcli = Convert.ToDateTime(registro["DATAPEDCLI"]); }
                if (registro["NUMPEDBNF"] != DBNull.Value) { modelo.numpedbnf = Convert.ToInt64(registro["NUMPEDBNF"]); }
                if (registro["BROKER"] != DBNull.Value) { modelo.broker = Convert.ToString(registro["BROKER"]); }
                if (registro["CODESTABELECIMENTO"] != DBNull.Value) { modelo.codestabelecimento = Convert.ToString(registro["CODESTABELECIMENTO"]); }
                if (registro["NUMTABELA"] != DBNull.Value) { modelo.numtabela = Convert.ToString(registro["NUMTABELA"]); }
                if (registro["MOTIVOPOSICAO"] != DBNull.Value) { modelo.motivoposicao = Convert.ToString(registro["MOTIVOPOSICAO"]); }
                if (registro["DTAGENDAENTREGA"] != DBNull.Value) { modelo.dtagendaentrega = Convert.ToDateTime(registro["DTAGENDAENTREGA"]); }
                if (registro["TIPOOPER"] != DBNull.Value) { modelo.tipooper = Convert.ToString(registro["TIPOOPER"]); }
                if (registro["CODMOTBLOQUEIO"] != DBNull.Value) { modelo.codmotbloqueio = Convert.ToInt32(registro["CODMOTBLOQUEIO"]); }
                if (registro["SERIEECF"] != DBNull.Value) { modelo.serieecf = Convert.ToString(registro["SERIEECF"]); }
                if (registro["NUMCUPOM"] != DBNull.Value) { modelo.numcupom = Convert.ToInt64(registro["NUMCUPOM"]); }
                if (registro["CODCLIRECEBEDOR"] != DBNull.Value) { modelo.codclirecebedor = Convert.ToInt32(registro["CODCLIRECEBEDOR"]); }
                if (registro["CONCILIAIMPORTACAO"] != DBNull.Value) { modelo.conciliaimportacao = Convert.ToString(registro["CONCILIAIMPORTACAO"]); }
                if (registro["NUMREGIAO"] != DBNull.Value) { modelo.numregiao = Convert.ToInt16(registro["NUMREGIAO"]); }
                if (registro["NUMNOTA"] != DBNull.Value) { modelo.numnota = Convert.ToInt64(registro["NUMNOTA"]); }
                if (registro["PERDESCFIN"] != DBNull.Value) { modelo.perdescfin = Convert.ToDouble(registro["PERDESCFIN"]); }
                if (registro["RESTRICAOTRANSP"] != DBNull.Value) { modelo.restricaotransp = Convert.ToString(registro["RESTRICAOTRANSP"]); }
                if (registro["GERACP"] != DBNull.Value) { modelo.geracp = Convert.ToString(registro["GERACP"]); }
                if (registro["USAINTEGRACAOWMS"] != DBNull.Value) { modelo.usaintegracaowms = Convert.ToString(registro["USAINTEGRACAOWMS"]); }
                if (registro["VENDAASSISTIDA"] != DBNull.Value) { modelo.vendaassistida = Convert.ToString(registro["VENDAASSISTIDA"]); }
                if (registro["CODMOTIVO"] != DBNull.Value) { modelo.codmotivo = Convert.ToInt32(registro["CODMOTIVO"]); }
                if (registro["LOG"] != DBNull.Value) { modelo.log = Convert.ToString(registro["LOG"]); }
                if (registro["DTCALCFRETE"] != DBNull.Value) { modelo.dtcalcfrete = Convert.ToDateTime(registro["DTCALCFRETE"]); }
                if (registro["CODFUNCCALCFRETE"] != DBNull.Value) { modelo.codfunccalcfrete = Convert.ToInt32(registro["CODFUNCCALCFRETE"]); }
                if (registro["EANCOBRANCA"] != DBNull.Value) { modelo.eancobranca = Convert.ToInt64(registro["EANCOBRANCA"]); }
                if (registro["EANENTREGA"] != DBNull.Value) { modelo.eanentrega = Convert.ToInt64(registro["EANENTREGA"]); }
                if (registro["USACFOPVENDANATV10"] != DBNull.Value) { modelo.usacfopvendanatv10 = Convert.ToString(registro["USACFOPVENDANATV10"]); }
                if (registro["TIPOPRIORIDADEENTREGA"] != DBNull.Value) { modelo.tipoprioridadeentrega = Convert.ToString(registro["TIPOPRIORIDADEENTREGA"]); }
                if (registro["CODUSUR2"] != DBNull.Value) { modelo.codusur2 = Convert.ToInt32(registro["CODUSUR2"]); }
                if (registro["CODUSUR3"] != DBNull.Value) { modelo.codusur3 = Convert.ToInt32(registro["CODUSUR3"]); }
                if (registro["CODUSUR4"] != DBNull.Value) { modelo.codusur4 = Convert.ToInt32(registro["CODUSUR4"]); }
                if (registro["CODCLINF"] != DBNull.Value) { modelo.codclinf = Convert.ToInt32(registro["CODCLINF"]); }
                if (registro["NUMPEDTV1"] != DBNull.Value) { modelo.numpedtv1 = Convert.ToInt64(registro["NUMPEDTV1"]); }
                if (registro["USADEBCREDRCA"] != DBNull.Value) { modelo.usadebcredrca = Convert.ToString(registro["USADEBCREDRCA"]); }
                if (registro["BRINDE"] != DBNull.Value) { modelo.brinde = Convert.ToString(registro["BRINDE"]); }
                if (registro["BONIFICALTDEBCREDRCA"] != DBNull.Value) { modelo.bonificaltdebcredrca = Convert.ToString(registro["BONIFICALTDEBCREDRCA"]); }
                if (registro["TROCAALTDEBCREDRCA"] != DBNull.Value) { modelo.trocaaltdebcredrca = Convert.ToString(registro["TROCAALTDEBCREDRCA"]); }
                if (registro["BROKERALTDEBCREDRCA"] != DBNull.Value) { modelo.brokeraltdebcredrca = Convert.ToString(registro["BROKERALTDEBCREDRCA"]); }
                if (registro["CRMALTDEBCREDRCA"] != DBNull.Value) { modelo.crmaltdebcredrca = Convert.ToString(registro["CRMALTDEBCREDRCA"]); }
                if (registro["TIPOMOVCCRCA"] != DBNull.Value) { modelo.tipomovccrca = Convert.ToString(registro["TIPOMOVCCRCA"]); }
                if (registro["USACREDRCA"] != DBNull.Value) { modelo.usacredrca = Convert.ToString(registro["USACREDRCA"]); }
                if (registro["GERARDADOSNFPAULISTA"] != DBNull.Value) { modelo.gerardadosnfpaulista = Convert.ToString(registro["GERARDADOSNFPAULISTA"]); }
                if (registro["USASALDOCONTACORRENTEDESCFIN"] != DBNull.Value) { modelo.usasaldocontacorrentedescfin = Convert.ToString(registro["USASALDOCONTACORRENTEDESCFIN"]); }
                if (registro["VALORDESCFIN"] != DBNull.Value) { modelo.valordescfin = Convert.ToDecimal(registro["VALORDESCFIN"]); }
                if (registro["CODVISITA"] != DBNull.Value) { modelo.codvisita = Convert.ToInt64(registro["CODVISITA"]); }
                if (registro["CODATENDIMENTO"] != DBNull.Value) { modelo.codatendimento = Convert.ToInt32(registro["CODATENDIMENTO"]); }
                if (registro["VENDATRIANGULAR"] != DBNull.Value) { modelo.vendatriangular = Convert.ToString(registro["VENDATRIANGULAR"]); }
                if (registro["VLENTRADA"] != DBNull.Value) { modelo.vlentrada = Convert.ToDecimal(registro["VLENTRADA"]); }
                if (registro["UFDESEMBARACO"] != DBNull.Value) { modelo.ufdesembaraco = Convert.ToString(registro["UFDESEMBARACO"]); }
                if (registro["LOCALDESEMBARACO"] != DBNull.Value) { modelo.localdesembaraco = Convert.ToString(registro["LOCALDESEMBARACO"]); }
                if (registro["CUSTOBONIFICACAO"] != DBNull.Value) { modelo.custobonificacao = Convert.ToString(registro["CUSTOBONIFICACAO"]); }
                if (registro["CODFORNECBONIFIC"] != DBNull.Value) { modelo.codfornecbonific = Convert.ToInt32(registro["CODFORNECBONIFIC"]); }
                if (registro["CODBNF"] != DBNull.Value) { modelo.codbnf = Convert.ToInt16(registro["CODBNF"]); }
                if (registro["TIPODOCUMENTO"] != DBNull.Value) { modelo.tipodocumento = Convert.ToString(registro["TIPODOCUMENTO"]); }
                if (registro["CFOPBNFDEGUSTA"] != DBNull.Value) { modelo.cfopbnfdegusta = Convert.ToInt32(registro["CFOPBNFDEGUSTA"]); }
                if (registro["CONTAORDEM"] != DBNull.Value) { modelo.contaordem = Convert.ToString(registro["CONTAORDEM"]); }
                if (registro["DATAEMPENHO"] != DBNull.Value) { modelo.dataempenho = Convert.ToDateTime(registro["DATAEMPENHO"]); }
                if (registro["NUMEMPENHO"] != DBNull.Value) { modelo.numempenho = Convert.ToString(registro["NUMEMPENHO"]); }
                if (registro["CODUNIDADEEXECUTORA"] != DBNull.Value) { modelo.codunidadeexecutora = Convert.ToString(registro["CODUNIDADEEXECUTORA"]); }
                if (registro["PLACAVEICULO"] != DBNull.Value) { modelo.placaveiculo = Convert.ToString(registro["PLACAVEICULO"]); }
                if (registro["DTLIMITEFAT"] != DBNull.Value) { modelo.dtlimitefat = Convert.ToDateTime(registro["DTLIMITEFAT"]); }
                if (registro["RESERVAESTOQUETV7"] != DBNull.Value) { modelo.reservaestoquetv7 = Convert.ToString(registro["RESERVAESTOQUETV7"]); }
                if (registro["FORNECENTREGA"] != DBNull.Value) { modelo.fornecentrega = Convert.ToString(registro["FORNECENTREGA"]); }
                if (registro["CODCLITV8"] != DBNull.Value) { modelo.codclitv8 = Convert.ToInt32(registro["CODCLITV8"]); }
                if (registro["UFVEICULO"] != DBNull.Value) { modelo.ufveiculo = Convert.ToString(registro["UFVEICULO"]); }
                if (registro["MOTORISTAVEICULO"] != DBNull.Value) { modelo.motoristaveiculo = Convert.ToString(registro["MOTORISTAVEICULO"]); }
                if (registro["DTINICIODIGITACAOPEDIDO"] != DBNull.Value) { modelo.dtiniciodigitacaopedido = Convert.ToDateTime(registro["DTINICIODIGITACAOPEDIDO"]); }
                if (registro["DTFIMDIGITACAOPEDIDO"] != DBNull.Value) { modelo.dtfimdigitacaopedido = Convert.ToDateTime(registro["DTFIMDIGITACAOPEDIDO"]); }
                if (registro["VLDESCABATIMENTO"] != DBNull.Value) { modelo.vldescabatimento = Convert.ToDecimal(registro["VLDESCABATIMENTO"]); }
                if (registro["AGRUPAMENTO"] != DBNull.Value) { modelo.agrupamento = Convert.ToString(registro["AGRUPAMENTO"]); }
                if (registro["VENDAEXPORTACAO"] != DBNull.Value) { modelo.vendaexportacao = Convert.ToString(registro["VENDAEXPORTACAO"]); }
                if (registro["TURNOENTREGA"] != DBNull.Value) { modelo.turnoentrega = Convert.ToString(registro["TURNOENTREGA"]); }
                if (registro["NUMTRANSVENDATV13"] != DBNull.Value) { modelo.numtransvendatv13 = Convert.ToInt64(registro["NUMTRANSVENDATV13"]); }
                if (registro["CODENDENTCLI"] != DBNull.Value) { modelo.codendentcli = Convert.ToInt32(registro["CODENDENTCLI"]); }
                if (registro["UTILIZAVENDAPOREMBALAGEM"] != DBNull.Value) { modelo.utilizavendaporembalagem = Convert.ToString(registro["UTILIZAVENDAPOREMBALAGEM"]); }
                if (registro["CODCONTATO"] != DBNull.Value) { modelo.codcontato = Convert.ToInt32(registro["CODCONTATO"]); }
                if (registro["NUMREGEXP"] != DBNull.Value) { modelo.numregexp = Convert.ToInt64(registro["NUMREGEXP"]); }
                if (registro["NUMCHAVEEXP"] != DBNull.Value) { modelo.numchaveexp = Convert.ToString(registro["NUMCHAVEEXP"]); }
                if (registro["NUMDRAWBACK"] != DBNull.Value) { modelo.numdrawback = Convert.ToInt64(registro["NUMDRAWBACK"]); }
                if (registro["DTNFTRANSF"] != DBNull.Value) { modelo.dtnftransf = Convert.ToDateTime(registro["DTNFTRANSF"]); }
                if (registro["ROTINALANC"] != DBNull.Value) { modelo.rotinalanc = Convert.ToString(registro["ROTINALANC"]); }
                if (registro["NUMPEDORIGEM"] != DBNull.Value) { modelo.numpedorigem = Convert.ToInt64(registro["NUMPEDORIGEM"]); }
                if (registro["PEDDUPLICADO"] != DBNull.Value) { modelo.pedduplicado = Convert.ToString(registro["PEDDUPLICADO"]); }
                if (registro["VLBONIFIC"] != DBNull.Value) { modelo.vlbonific = Convert.ToDecimal(registro["VLBONIFIC"]); }
                if (registro["VENDALOCESTRANG"] != DBNull.Value) { modelo.vendalocestrang = Convert.ToString(registro["VENDALOCESTRANG"]); }
                if (registro["COPIAIDENTICAPEDDUP"] != DBNull.Value) { modelo.copiaidenticapeddup = Convert.ToString(registro["COPIAIDENTICAPEDDUP"]); }
                if (registro["ASSINATURA"] != DBNull.Value) { modelo.assinatura = Convert.ToString(registro["ASSINATURA"]); }
                if (registro["IDPARCEIRO"] != DBNull.Value) { modelo.idparceiro = Convert.ToString(registro["IDPARCEIRO"]); }
                if (registro["UIDREGISTRO"] != DBNull.Value) { modelo.uidregistro = Convert.ToInt64(registro["UIDREGISTRO"]); }
                if (registro["CONDFINANC"] != DBNull.Value) { modelo.condfinanc = Convert.ToString(registro["CONDFINANC"]); }
                if (registro["PLANOSUPPLI"] != DBNull.Value) { modelo.planosuppli = Convert.ToInt16(registro["PLANOSUPPLI"]); }
                if (registro["PAGCHEQUEMORADIA"] != DBNull.Value) { modelo.pagchequemoradia = Convert.ToString(registro["PAGCHEQUEMORADIA"]); }
                if (registro["NUMVOLUME"] != DBNull.Value) { modelo.numvolume = Convert.ToInt32(registro["NUMVOLUME"]); }


            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
