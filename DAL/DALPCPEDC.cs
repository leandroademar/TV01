using System;
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
            if (modelo.codusur != null) { comando1 = comando1 + "CODUSUR," + "\n"; }
            if (modelo.codcli != null) { comando1 = comando1 + "CODCLI," + "\n"; }
            if (modelo.numitens != null) { comando1 = comando1 + "NUMITENS," + "\n"; }
            if (modelo.vlatend != null) { comando1 = comando1 + "VLATEND," + "\n"; }
            if (modelo.codpraca != null) { comando1 = comando1 + "CODPRACA," + "\n"; }
            if (modelo.posicao != null) { comando1 = comando1 + "POSICAO," + "\n"; }
            if (modelo.numcar != null) { comando1 = comando1 + "NUMCAR," + "\n"; }
            if (modelo.codsupervisor != null) { comando1 = comando1 + "CODSUPERVISOR," + "\n"; }
            if (modelo.codfilial != null) { comando1 = comando1 + "CODFILIAL," + "\n"; }
            if (modelo.vltotal != null) { comando1 = comando1 + "VLTOTAL," + "\n"; }
            if (modelo.vltabela != null) { comando1 = comando1 + "VLTABELA," + "\n"; }
            if (modelo.vlcustoreal != null) { comando1 = comando1 + "VLCUSTOREAL," + "\n"; }
            if (modelo.vlcustofin != null) { comando1 = comando1 + "VLCUSTOFIN," + "\n"; }
            if (modelo.totpeso != null) { comando1 = comando1 + "TOTPESO," + "\n"; }
            if (modelo.totvolume != null) { comando1 = comando1 + "TOTVOLUME," + "\n"; }
            if (modelo.codemitente != null) { comando1 = comando1 + "CODEMITENTE," + "\n"; }
            if (modelo.operacao != null) { comando1 = comando1 + "OPERACAO," + "\n"; }
            if (modelo.tipovenda != null) { comando1 = comando1 + "TIPOVENDA," + "\n"; }
            if (modelo.obs != null) { comando1 = comando1 + "OBS," + "\n"; }
            if (modelo.codcob != null) { comando1 = comando1 + "CODCOB," + "\n"; }
            if (modelo.hora != null) { comando1 = comando1 + "HORA," + "\n"; }
            if (modelo.minuto != null) { comando1 = comando1 + "MINUTO," + "\n"; }
            if (modelo.codplpag != null) { comando1 = comando1 + "CODPLPAG," + "\n"; }
            if (modelo.numpedcli != null) { comando1 = comando1 + "NUMPEDCLI," + "\n"; }
            if (modelo.percvenda != null) { comando1 = comando1 + "PERCVENDA," + "\n"; }
            if (modelo.perdesc != null) { comando1 = comando1 + "PERDESC," + "\n"; }
            if (modelo.vldesconto != null) { comando1 = comando1 + "VLDESCONTO," + "\n"; }
            if (modelo.vlfrete != null) { comando1 = comando1 + "VLFRETE," + "\n"; }
            if (modelo.vloutrasdesp != null) { comando1 = comando1 + "VLOUTRASDESP," + "\n"; }
            if (modelo.obs1 != null) { comando1 = comando1 + "OBS1," + "\n"; }
            if (modelo.obs2 != null) { comando1 = comando1 + "OBS2," + "\n"; }
            if (modelo.condvenda != null) { comando1 = comando1 + "CONDVENDA," + "\n"; }
            if (modelo.dtentrega != null) { comando1 = comando1 + "DTENTREGA," + "\n"; }
            if (modelo.numpedrca != null) { comando1 = comando1 + "NUMPEDRCA," + "\n"; }
            if (modelo.fretedespacho != null) { comando1 = comando1 + "FRETEDESPACHO," + "\n"; }
            if (modelo.freteredespacho != null) { comando1 = comando1 + "FRETEREDESPACHO," + "\n"; }
            if (modelo.codfornecfrete != null) { comando1 = comando1 + "CODFORNECFRETE," + "\n"; }
            if (modelo.codfornecredespacho != null) { comando1 = comando1 + "CODFORNECREDESPACHO," + "\n"; }
            if (modelo.tipocarga != null) { comando1 = comando1 + "TIPOCARGA," + "\n"; }
            if (modelo.prazo1 != null) { comando1 = comando1 + "PRAZO1," + "\n"; }
            if (modelo.prazo2 != null) { comando1 = comando1 + "PRAZO2," + "\n"; }
            if (modelo.prazo3 != null) { comando1 = comando1 + "PRAZO3," + "\n"; }
            if (modelo.prazo4 != null) { comando1 = comando1 + "PRAZO4," + "\n"; }
            if (modelo.prazo5 != null) { comando1 = comando1 + "PRAZO5," + "\n"; }
            if (modelo.prazo6 != null) { comando1 = comando1 + "PRAZO6," + "\n"; }
            if (modelo.prazo7 != null) { comando1 = comando1 + "PRAZO7," + "\n"; }
            if (modelo.prazo8 != null) { comando1 = comando1 + "PRAZO8," + "\n"; }
            if (modelo.prazo9 != null) { comando1 = comando1 + "PRAZO9," + "\n"; }
            if (modelo.prazo10 != null) { comando1 = comando1 + "PRAZO10," + "\n"; }
            if (modelo.prazo11 != null) { comando1 = comando1 + "PRAZO11," + "\n"; }
            if (modelo.prazo12 != null) { comando1 = comando1 + "PRAZO12," + "\n"; }
            if (modelo.prazomedio != null) { comando1 = comando1 + "PRAZOMEDIO," + "\n"; }
            if (modelo.obsentrega1 != null) { comando1 = comando1 + "OBSENTREGA1," + "\n"; }
            if (modelo.obsentrega2 != null) { comando1 = comando1 + "OBSENTREGA2," + "\n"; }
            if (modelo.obsentrega3 != null) { comando1 = comando1 + "OBSENTREGA3," + "\n"; }
            if (modelo.tipoembalagem != null) { comando1 = comando1 + "TIPOEMBALAGEM," + "\n"; }
            if (modelo.codepto != null) { comando1 = comando1 + "CODEPTO," + "\n"; }
            if (modelo.campanha != null) { comando1 = comando1 + "CAMPANHA," + "\n"; }
            if (modelo.coddistrib != null) { comando1 = comando1 + "CODDISTRIB," + "\n"; }
            if (modelo.vlcustocont != null) { comando1 = comando1 + "VLCUSTOCONT," + "\n"; }
            if (modelo.vlcustorep != null) { comando1 = comando1 + "VLCUSTOREP," + "\n"; }
            if (modelo.numnotamanif != null) { comando1 = comando1 + "NUMNOTAMANIF," + "\n"; }
            if (modelo.seriemanif != null) { comando1 = comando1 + "SERIEMANIF," + "\n"; }
            if (modelo.origemped != null) { comando1 = comando1 + "ORIGEMPED," + "\n"; }
            if (modelo.especiemanif != null) { comando1 = comando1 + "ESPECIEMANIF," + "\n"; }
            if (modelo.numpedentfut != null) { comando1 = comando1 + "NUMPEDENTFUT," + "\n"; }
            if (modelo.codfilialnf != null) { comando1 = comando1 + "CODFILIALNF," + "\n"; }
            if (modelo.numcarmanif != null) { comando1 = comando1 + "NUMCARMANIF," + "\n"; }
            if (modelo.numorca != null) { comando1 = comando1 + "NUMORCA," + "\n"; }
            if (modelo.codcontrato != null) { comando1 = comando1 + "CODCONTRATO," + "\n"; }
            if (modelo.datapedcli != null) { comando1 = comando1 + "DATAPEDCLI," + "\n"; }
            if (modelo.numpedbnf != null) { comando1 = comando1 + "NUMPEDBNF," + "\n"; }
            if (modelo.broker != null) { comando1 = comando1 + "BROKER," + "\n"; }
            if (modelo.codestabelecimento != null) { comando1 = comando1 + "CODESTABELECIMENTO," + "\n"; }
            if (modelo.numtabela != null) { comando1 = comando1 + "NUMTABELA," + "\n"; }
            if (modelo.motivoposicao != null) { comando1 = comando1 + "MOTIVOPOSICAO," + "\n"; }
            if (modelo.dtagendaentrega != null) { comando1 = comando1 + "DTAGENDAENTREGA," + "\n"; }
            if (modelo.tipooper != null) { comando1 = comando1 + "TIPOOPER," + "\n"; }
            if (modelo.codmotbloqueio != null) { comando1 = comando1 + "CODMOTBLOQUEIO," + "\n"; }
            if (modelo.serieecf != null) { comando1 = comando1 + "SERIEECF," + "\n"; }
            if (modelo.numcupom != null) { comando1 = comando1 + "NUMCUPOM," + "\n"; }
            if (modelo.codclirecebedor != null) { comando1 = comando1 + "CODCLIRECEBEDOR," + "\n"; }
            if (modelo.conciliaimportacao != null) { comando1 = comando1 + "CONCILIAIMPORTACAO," + "\n"; }
            if (modelo.numregiao != null) { comando1 = comando1 + "NUMREGIAO," + "\n"; }
            if (modelo.numnota != null) { comando1 = comando1 + "NUMNOTA," + "\n"; }
            if (modelo.perdescfin != null) { comando1 = comando1 + "PERDESCFIN," + "\n"; }
            if (modelo.restricaotransp != null) { comando1 = comando1 + "RESTRICAOTRANSP," + "\n"; }
            if (modelo.geracp != null) { comando1 = comando1 + "GERACP," + "\n"; }
            if (modelo.usaintegracaowms != null) { comando1 = comando1 + "USAINTEGRACAOWMS," + "\n"; }
            if (modelo.vendaassistida != null) { comando1 = comando1 + "VENDAASSISTIDA," + "\n"; }
            if (modelo.codmotivo != null) { comando1 = comando1 + "CODMOTIVO," + "\n"; }
            if (modelo.log != null) { comando1 = comando1 + "LOG," + "\n"; }
            if (modelo.dtcalcfrete != null) { comando1 = comando1 + "DTCALCFRETE," + "\n"; }
            if (modelo.codfunccalcfrete != null) { comando1 = comando1 + "CODFUNCCALCFRETE," + "\n"; }
            if (modelo.eancobranca != null) { comando1 = comando1 + "EANCOBRANCA," + "\n"; }
            if (modelo.eanentrega != null) { comando1 = comando1 + "EANENTREGA," + "\n"; }
            if (modelo.usacfopvendanatv10 != null) { comando1 = comando1 + "USACFOPVENDANATV10," + "\n"; }
            if (modelo.tipoprioridadeentrega != null) { comando1 = comando1 + "TIPOPRIORIDADEENTREGA," + "\n"; }
            if (modelo.codusur2 != null) { comando1 = comando1 + "CODUSUR2," + "\n"; }
            if (modelo.codusur3 != null) { comando1 = comando1 + "CODUSUR3," + "\n"; }
            if (modelo.codusur4 != null) { comando1 = comando1 + "CODUSUR4," + "\n"; }
            if (modelo.codclinf != null) { comando1 = comando1 + "CODCLINF," + "\n"; }
            if (modelo.numpedtv1 != null) { comando1 = comando1 + "NUMPEDTV1," + "\n"; }
            if (modelo.usadebcredrca != null) { comando1 = comando1 + "USADEBCREDRCA," + "\n"; }
            if (modelo.brinde != null) { comando1 = comando1 + "BRINDE," + "\n"; }
            if (modelo.bonificaltdebcredrca != null) { comando1 = comando1 + "BONIFICALTDEBCREDRCA," + "\n"; }
            if (modelo.trocaaltdebcredrca != null) { comando1 = comando1 + "TROCAALTDEBCREDRCA," + "\n"; }
            if (modelo.brokeraltdebcredrca != null) { comando1 = comando1 + "BROKERALTDEBCREDRCA," + "\n"; }
            if (modelo.crmaltdebcredrca != null) { comando1 = comando1 + "CRMALTDEBCREDRCA," + "\n"; }
            if (modelo.tipomovccrca != null) { comando1 = comando1 + "TIPOMOVCCRCA," + "\n"; }
            if (modelo.usacredrca != null) { comando1 = comando1 + "USACREDRCA," + "\n"; }
            if (modelo.gerardadosnfpaulista != null) { comando1 = comando1 + "GERARDADOSNFPAULISTA," + "\n"; }
            if (modelo.usasaldocontacorrentedescfin != null) { comando1 = comando1 + "USASALDOCONTACORRENTEDESCFIN," + "\n"; }
            if (modelo.valordescfin != null) { comando1 = comando1 + "VALORDESCFIN," + "\n"; }
            if (modelo.codvisita != null) { comando1 = comando1 + "CODVISITA," + "\n"; }
            if (modelo.codatendimento != null) { comando1 = comando1 + "CODATENDIMENTO," + "\n"; }
            if (modelo.vendatriangular != null) { comando1 = comando1 + "VENDATRIANGULAR," + "\n"; }
            if (modelo.vlentrada != null) { comando1 = comando1 + "VLENTRADA," + "\n"; }
            if (modelo.ufdesembaraco != null) { comando1 = comando1 + "UFDESEMBARACO," + "\n"; }
            if (modelo.localdesembaraco != null) { comando1 = comando1 + "LOCALDESEMBARACO," + "\n"; }
            if (modelo.custobonificacao != null) { comando1 = comando1 + "CUSTOBONIFICACAO," + "\n"; }
            if (modelo.codfornecbonific != null) { comando1 = comando1 + "CODFORNECBONIFIC," + "\n"; }
            if (modelo.codbnf != null) { comando1 = comando1 + "CODBNF," + "\n"; }
            if (modelo.tipodocumento != null) { comando1 = comando1 + "TIPODOCUMENTO," + "\n"; }
            if (modelo.cfopbnfdegusta != null) { comando1 = comando1 + "CFOPBNFDEGUSTA," + "\n"; }
            if (modelo.contaordem != null) { comando1 = comando1 + "CONTAORDEM," + "\n"; }
            if (modelo.dataempenho != null) { comando1 = comando1 + "DATAEMPENHO," + "\n"; }
            if (modelo.numempenho != null) { comando1 = comando1 + "NUMEMPENHO," + "\n"; }
            if (modelo.codunidadeexecutora != null) { comando1 = comando1 + "CODUNIDADEEXECUTORA," + "\n"; }
            if (modelo.placaveiculo != null) { comando1 = comando1 + "PLACAVEICULO," + "\n"; }
            if (modelo.dtlimitefat != null) { comando1 = comando1 + "DTLIMITEFAT," + "\n"; }
            if (modelo.reservaestoquetv7 != null) { comando1 = comando1 + "RESERVAESTOQUETV7," + "\n"; }
            if (modelo.fornecentrega != null) { comando1 = comando1 + "FORNECENTREGA," + "\n"; }
            if (modelo.codclitv8 != null) { comando1 = comando1 + "CODCLITV8," + "\n"; }
            if (modelo.ufveiculo != null) { comando1 = comando1 + "UFVEICULO," + "\n"; }
            if (modelo.motoristaveiculo != null) { comando1 = comando1 + "MOTORISTAVEICULO," + "\n"; }
            if (modelo.dtiniciodigitacaopedido != null) { comando1 = comando1 + "DTINICIODIGITACAOPEDIDO," + "\n"; }
            if (modelo.dtfimdigitacaopedido != null) { comando1 = comando1 + "DTFIMDIGITACAOPEDIDO," + "\n"; }
            if (modelo.vldescabatimento != null) { comando1 = comando1 + "VLDESCABATIMENTO," + "\n"; }
            if (modelo.agrupamento != null) { comando1 = comando1 + "AGRUPAMENTO," + "\n"; }
            if (modelo.vendaexportacao != null) { comando1 = comando1 + "VENDAEXPORTACAO," + "\n"; }
            if (modelo.turnoentrega != null) { comando1 = comando1 + "TURNOENTREGA," + "\n"; }
            if (modelo.numtransvendatv13 != null) { comando1 = comando1 + "NUMTRANSVENDATV13," + "\n"; }
            if (modelo.codendentcli != null) { comando1 = comando1 + "CODENDENTCLI," + "\n"; }
            if (modelo.utilizavendaporembalagem != null) { comando1 = comando1 + "UTILIZAVENDAPOREMBALAGEM," + "\n"; }
            if (modelo.codcontato != null) { comando1 = comando1 + "CODCONTATO," + "\n"; }
            if (modelo.numregexp != null) { comando1 = comando1 + "NUMREGEXP," + "\n"; }
            if (modelo.numchaveexp != null) { comando1 = comando1 + "NUMCHAVEEXP," + "\n"; }
            if (modelo.numdrawback != null) { comando1 = comando1 + "NUMDRAWBACK," + "\n"; }
            if (modelo.dtnftransf != null) { comando1 = comando1 + "DTNFTRANSF," + "\n"; }
            if (modelo.rotinalanc != null) { comando1 = comando1 + "ROTINALANC," + "\n"; }
            if (modelo.numpedorigem != null) { comando1 = comando1 + "NUMPEDORIGEM," + "\n"; }
            if (modelo.pedduplicado != null) { comando1 = comando1 + "PEDDUPLICADO," + "\n"; }
            if (modelo.vlbonific != null) { comando1 = comando1 + "VLBONIFIC," + "\n"; }
            if (modelo.vendalocestrang != null) { comando1 = comando1 + "VENDALOCESTRANG," + "\n"; }
            if (modelo.copiaidenticapeddup != null) { comando1 = comando1 + "COPIAIDENTICAPEDDUP," + "\n"; }
            if (modelo.assinatura != null) { comando1 = comando1 + "ASSINATURA," + "\n"; }
            if (modelo.condfinanc != null) { comando1 = comando1 + "CONDFINANC," + "\n"; }
            if (modelo.planosuppli != null) { comando1 = comando1 + "PLANOSUPPLI," + "\n"; }
            if (modelo.pagchequemoradia != null) { comando1 = comando1 + "PAGCHEQUEMORADIA," + "\n"; }
            comando1 = comando1 + "       NUMVOLUME " + "\n";
            comando1 = comando1 + "       ) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "      (:NUMPED, " + "\n";
            comando1 = comando1 + "       :DATA, " + "\n";
            if (modelo.codusur != null) { comando1 = comando1 + ":CODUSUR," + "\n"; }
            if (modelo.codcli != null) { comando1 = comando1 + ":CODCLI," + "\n"; }
            if (modelo.numitens != null) { comando1 = comando1 + ":NUMITENS," + "\n"; }
            if (modelo.vlatend != null) { comando1 = comando1 + ":VLATEND," + "\n"; }
            if (modelo.codpraca != null) { comando1 = comando1 + ":CODPRACA," + "\n"; }
            if (modelo.posicao != null) { comando1 = comando1 + ":POSICAO," + "\n"; }
            if (modelo.numcar != null) { comando1 = comando1 + ":NUMCAR," + "\n"; }
            if (modelo.codsupervisor != null) { comando1 = comando1 + ":CODSUPERVISOR," + "\n"; }
            if (modelo.codfilial != null) { comando1 = comando1 + ":CODFILIAL," + "\n"; }
            if (modelo.vltotal != null) { comando1 = comando1 + ":VLTOTAL," + "\n"; }
            if (modelo.vltabela != null) { comando1 = comando1 + ":VLTABELA," + "\n"; }
            if (modelo.vlcustoreal != null) { comando1 = comando1 + ":VLCUSTOREAL," + "\n"; }
            if (modelo.vlcustofin != null) { comando1 = comando1 + ":VLCUSTOFIN," + "\n"; }
            if (modelo.totpeso != null) { comando1 = comando1 + ":TOTPESO," + "\n"; }
            if (modelo.totvolume != null) { comando1 = comando1 + ":TOTVOLUME," + "\n"; }
            if (modelo.codemitente != null) { comando1 = comando1 + ":CODEMITENTE," + "\n"; }
            if (modelo.operacao != null) { comando1 = comando1 + ":OPERACAO," + "\n"; }
            if (modelo.tipovenda != null) { comando1 = comando1 + ":TIPOVENDA," + "\n"; }
            if (modelo.obs != null) { comando1 = comando1 + ":OBS," + "\n"; }
            if (modelo.codcob != null) { comando1 = comando1 + ":CODCOB," + "\n"; }
            if (modelo.hora != null) { comando1 = comando1 + ":HORA," + "\n"; }
            if (modelo.minuto != null) { comando1 = comando1 + ":MINUTO," + "\n"; }
            if (modelo.codplpag != null) { comando1 = comando1 + ":CODPLPAG," + "\n"; }
            if (modelo.numpedcli != null) { comando1 = comando1 + ":NUMPEDCLI," + "\n"; }
            if (modelo.percvenda != null) { comando1 = comando1 + ":PERCVENDA," + "\n"; }
            if (modelo.perdesc != null) { comando1 = comando1 + ":PERDESC," + "\n"; }
            if (modelo.vldesconto != null) { comando1 = comando1 + ":VLDESCONTO," + "\n"; }
            if (modelo.vlfrete != null) { comando1 = comando1 + ":VLFRETE," + "\n"; }
            if (modelo.vloutrasdesp != null) { comando1 = comando1 + ":VLOUTRASDESP," + "\n"; }
            if (modelo.obs1 != null) { comando1 = comando1 + ":OBS1," + "\n"; }
            if (modelo.obs2 != null) { comando1 = comando1 + ":OBS2," + "\n"; }
            if (modelo.condvenda != null) { comando1 = comando1 + ":CONDVENDA," + "\n"; }
            if (modelo.dtentrega != null) { comando1 = comando1 + ":DTENTREGA," + "\n"; }
            if (modelo.numpedrca != null) { comando1 = comando1 + ":NUMPEDRCA," + "\n"; }
            if (modelo.fretedespacho != null) { comando1 = comando1 + ":FRETEDESPACHO," + "\n"; }
            if (modelo.freteredespacho != null) { comando1 = comando1 + ":FRETEREDESPACHO," + "\n"; }
            if (modelo.codfornecfrete != null) { comando1 = comando1 + ":CODFORNECFRETE," + "\n"; }
            if (modelo.codfornecredespacho != null) { comando1 = comando1 + ":CODFORNECREDESPACHO," + "\n"; }
            if (modelo.tipocarga != null) { comando1 = comando1 + ":TIPOCARGA," + "\n"; }
            if (modelo.prazo1 != null) { comando1 = comando1 + ":PRAZO1," + "\n"; }
            if (modelo.prazo2 != null) { comando1 = comando1 + ":PRAZO2," + "\n"; }
            if (modelo.prazo3 != null) { comando1 = comando1 + ":PRAZO3," + "\n"; }
            if (modelo.prazo4 != null) { comando1 = comando1 + ":PRAZO4," + "\n"; }
            if (modelo.prazo5 != null) { comando1 = comando1 + ":PRAZO5," + "\n"; }
            if (modelo.prazo6 != null) { comando1 = comando1 + ":PRAZO6," + "\n"; }
            if (modelo.prazo7 != null) { comando1 = comando1 + ":PRAZO7," + "\n"; }
            if (modelo.prazo8 != null) { comando1 = comando1 + ":PRAZO8," + "\n"; }
            if (modelo.prazo9 != null) { comando1 = comando1 + ":PRAZO9," + "\n"; }
            if (modelo.prazo10 != null) { comando1 = comando1 + ":PRAZO10," + "\n"; }
            if (modelo.prazo11 != null) { comando1 = comando1 + ":PRAZO11," + "\n"; }
            if (modelo.prazo12 != null) { comando1 = comando1 + ":PRAZO12," + "\n"; }
            if (modelo.prazomedio != null) { comando1 = comando1 + ":PRAZOMEDIO," + "\n"; }
            if (modelo.obsentrega1 != null) { comando1 = comando1 + ":OBSENTREGA1," + "\n"; }
            if (modelo.obsentrega2 != null) { comando1 = comando1 + ":OBSENTREGA2," + "\n"; }
            if (modelo.obsentrega3 != null) { comando1 = comando1 + ":OBSENTREGA3," + "\n"; }
            if (modelo.tipoembalagem != null) { comando1 = comando1 + ":TIPOEMBALAGEM," + "\n"; }
            if (modelo.codepto != null) { comando1 = comando1 + ":CODEPTO," + "\n"; }
            if (modelo.campanha != null) { comando1 = comando1 + ":CAMPANHA," + "\n"; }
            if (modelo.coddistrib != null) { comando1 = comando1 + ":CODDISTRIB," + "\n"; }
            if (modelo.vlcustocont != null) { comando1 = comando1 + ":VLCUSTOCONT," + "\n"; }
            if (modelo.vlcustorep != null) { comando1 = comando1 + ":VLCUSTOREP," + "\n"; }
            if (modelo.numnotamanif != null) { comando1 = comando1 + ":NUMNOTAMANIF," + "\n"; }
            if (modelo.seriemanif != null) { comando1 = comando1 + ":SERIEMANIF," + "\n"; }
            if (modelo.origemped != null) { comando1 = comando1 + ":ORIGEMPED," + "\n"; }
            if (modelo.especiemanif != null) { comando1 = comando1 + ":ESPECIEMANIF," + "\n"; }
            if (modelo.numpedentfut != null) { comando1 = comando1 + ":NUMPEDENTFUT," + "\n"; }
            if (modelo.codfilialnf != null) { comando1 = comando1 + ":CODFILIALNF," + "\n"; }
            if (modelo.numcarmanif != null) { comando1 = comando1 + ":NUMCARMANIF," + "\n"; }
            if (modelo.numorca != null) { comando1 = comando1 + ":NUMORCA," + "\n"; }
            if (modelo.codcontrato != null) { comando1 = comando1 + ":CODCONTRATO," + "\n"; }
            if (modelo.datapedcli != null) { comando1 = comando1 + ":DATAPEDCLI," + "\n"; }
            if (modelo.numpedbnf != null) { comando1 = comando1 + ":NUMPEDBNF," + "\n"; }
            if (modelo.broker != null) { comando1 = comando1 + ":BROKER," + "\n"; }
            if (modelo.codestabelecimento != null) { comando1 = comando1 + ":CODESTABELECIMENTO," + "\n"; }
            if (modelo.numtabela != null) { comando1 = comando1 + ":NUMTABELA," + "\n"; }
            if (modelo.motivoposicao != null) { comando1 = comando1 + ":MOTIVOPOSICAO," + "\n"; }
            if (modelo.dtagendaentrega != null) { comando1 = comando1 + ":DTAGENDAENTREGA," + "\n"; }
            if (modelo.tipooper != null) { comando1 = comando1 + ":TIPOOPER," + "\n"; }
            if (modelo.codmotbloqueio != null) { comando1 = comando1 + ":CODMOTBLOQUEIO," + "\n"; }
            if (modelo.serieecf != null) { comando1 = comando1 + ":SERIEECF," + "\n"; }
            if (modelo.numcupom != null) { comando1 = comando1 + ":NUMCUPOM," + "\n"; }
            if (modelo.codclirecebedor != null) { comando1 = comando1 + ":CODCLIRECEBEDOR," + "\n"; }
            if (modelo.conciliaimportacao != null) { comando1 = comando1 + ":CONCILIAIMPORTACAO," + "\n"; }
            if (modelo.numregiao != null) { comando1 = comando1 + ":NUMREGIAO," + "\n"; }
            if (modelo.numnota != null) { comando1 = comando1 + ":NUMNOTA," + "\n"; }
            if (modelo.perdescfin != null) { comando1 = comando1 + ":PERDESCFIN," + "\n"; }
            if (modelo.restricaotransp != null) { comando1 = comando1 + ":RESTRICAOTRANSP," + "\n"; }
            if (modelo.geracp != null) { comando1 = comando1 + ":GERACP," + "\n"; }
            if (modelo.usaintegracaowms != null) { comando1 = comando1 + ":USAINTEGRACAOWMS," + "\n"; }
            if (modelo.vendaassistida != null) { comando1 = comando1 + ":VENDAASSISTIDA," + "\n"; }
            if (modelo.codmotivo != null) { comando1 = comando1 + ":CODMOTIVO," + "\n"; }
            if (modelo.log != null) { comando1 = comando1 + ":LOG," + "\n"; }
            if (modelo.dtcalcfrete != null) { comando1 = comando1 + ":DTCALCFRETE," + "\n"; }
            if (modelo.codfunccalcfrete != null) { comando1 = comando1 + ":CODFUNCCALCFRETE," + "\n"; }
            if (modelo.eancobranca != null) { comando1 = comando1 + ":EANCOBRANCA," + "\n"; }
            if (modelo.eanentrega != null) { comando1 = comando1 + ":EANENTREGA," + "\n"; }
            if (modelo.usacfopvendanatv10 != null) { comando1 = comando1 + ":USACFOPVENDANATV10," + "\n"; }
            if (modelo.tipoprioridadeentrega != null) { comando1 = comando1 + ":TIPOPRIORIDADEENTREGA," + "\n"; }
            if (modelo.codusur2 != null) { comando1 = comando1 + ":CODUSUR2," + "\n"; }
            if (modelo.codusur3 != null) { comando1 = comando1 + ":CODUSUR3," + "\n"; }
            if (modelo.codusur4 != null) { comando1 = comando1 + ":CODUSUR4," + "\n"; }
            if (modelo.codclinf != null) { comando1 = comando1 + ":CODCLINF," + "\n"; }
            if (modelo.numpedtv1 != null) { comando1 = comando1 + ":NUMPEDTV1," + "\n"; }
            if (modelo.usadebcredrca != null) { comando1 = comando1 + ":USADEBCREDRCA," + "\n"; }
            if (modelo.brinde != null) { comando1 = comando1 + ":BRINDE," + "\n"; }
            if (modelo.bonificaltdebcredrca != null) { comando1 = comando1 + ":BONIFICALTDEBCREDRCA," + "\n"; }
            if (modelo.trocaaltdebcredrca != null) { comando1 = comando1 + ":TROCAALTDEBCREDRCA," + "\n"; }
            if (modelo.brokeraltdebcredrca != null) { comando1 = comando1 + ":BROKERALTDEBCREDRCA," + "\n"; }
            if (modelo.crmaltdebcredrca != null) { comando1 = comando1 + ":CRMALTDEBCREDRCA," + "\n"; }
            if (modelo.tipomovccrca != null) { comando1 = comando1 + ":TIPOMOVCCRCA," + "\n"; }
            if (modelo.usacredrca != null) { comando1 = comando1 + ":USACREDRCA," + "\n"; }
            if (modelo.gerardadosnfpaulista != null) { comando1 = comando1 + ":GERARDADOSNFPAULISTA," + "\n"; }
            if (modelo.usasaldocontacorrentedescfin != null) { comando1 = comando1 + ":USASALDOCONTACORRENTEDESCFIN," + "\n"; }
            if (modelo.valordescfin != null) { comando1 = comando1 + ":VALORDESCFIN," + "\n"; }
            if (modelo.codvisita != null) { comando1 = comando1 + ":CODVISITA," + "\n"; }
            if (modelo.codatendimento != null) { comando1 = comando1 + ":CODATENDIMENTO," + "\n"; }
            if (modelo.vendatriangular != null) { comando1 = comando1 + ":VENDATRIANGULAR," + "\n"; }
            if (modelo.vlentrada != null) { comando1 = comando1 + ":VLENTRADA," + "\n"; }
            if (modelo.ufdesembaraco != null) { comando1 = comando1 + ":UFDESEMBARACO," + "\n"; }
            if (modelo.localdesembaraco != null) { comando1 = comando1 + ":LOCALDESEMBARACO," + "\n"; }
            if (modelo.custobonificacao != null) { comando1 = comando1 + ":CUSTOBONIFICACAO," + "\n"; }
            if (modelo.codfornecbonific != null) { comando1 = comando1 + ":CODFORNECBONIFIC," + "\n"; }
            if (modelo.codbnf != null) { comando1 = comando1 + ":CODBNF," + "\n"; }
            if (modelo.tipodocumento != null) { comando1 = comando1 + ":TIPODOCUMENTO," + "\n"; }
            if (modelo.cfopbnfdegusta != null) { comando1 = comando1 + ":CFOPBNFDEGUSTA," + "\n"; }
            if (modelo.contaordem != null) { comando1 = comando1 + ":CONTAORDEM," + "\n"; }
            if (modelo.dataempenho != null) { comando1 = comando1 + ":DATAEMPENHO," + "\n"; }
            if (modelo.numempenho != null) { comando1 = comando1 + ":NUMEMPENHO," + "\n"; }
            if (modelo.codunidadeexecutora != null) { comando1 = comando1 + ":CODUNIDADEEXECUTORA," + "\n"; }
            if (modelo.placaveiculo != null) { comando1 = comando1 + ":PLACAVEICULO," + "\n"; }
            if (modelo.dtlimitefat != null) { comando1 = comando1 + ":DTLIMITEFAT," + "\n"; }
            if (modelo.reservaestoquetv7 != null) { comando1 = comando1 + ":RESERVAESTOQUETV7," + "\n"; }
            if (modelo.fornecentrega != null) { comando1 = comando1 + ":FORNECENTREGA," + "\n"; }
            if (modelo.codclitv8 != null) { comando1 = comando1 + ":CODCLITV8," + "\n"; }
            if (modelo.ufveiculo != null) { comando1 = comando1 + ":UFVEICULO," + "\n"; }
            if (modelo.motoristaveiculo != null) { comando1 = comando1 + ":MOTORISTAVEICULO," + "\n"; }
            if (modelo.dtiniciodigitacaopedido != null) { comando1 = comando1 + ":DTINICIODIGITACAOPEDIDO," + "\n"; }
            if (modelo.dtfimdigitacaopedido != null) { comando1 = comando1 + ":DTFIMDIGITACAOPEDIDO," + "\n"; }
            if (modelo.vldescabatimento != null) { comando1 = comando1 + ":VLDESCABATIMENTO," + "\n"; }
            if (modelo.agrupamento != null) { comando1 = comando1 + ":AGRUPAMENTO," + "\n"; }
            if (modelo.vendaexportacao != null) { comando1 = comando1 + ":VENDAEXPORTACAO," + "\n"; }
            if (modelo.turnoentrega != null) { comando1 = comando1 + ":TURNOENTREGA," + "\n"; }
            if (modelo.numtransvendatv13 != null) { comando1 = comando1 + ":NUMTRANSVENDATV13," + "\n"; }
            if (modelo.codendentcli != null) { comando1 = comando1 + ":CODENDENTCLI," + "\n"; }
            if (modelo.utilizavendaporembalagem != null) { comando1 = comando1 + ":UTILIZAVENDAPOREMBALAGEM," + "\n"; }
            if (modelo.codcontato != null) { comando1 = comando1 + ":CODCONTATO," + "\n"; }
            if (modelo.numregexp != null) { comando1 = comando1 + ":NUMREGEXP," + "\n"; }
            if (modelo.numchaveexp != null) { comando1 = comando1 + ":NUMCHAVEEXP," + "\n"; }
            if (modelo.numdrawback != null) { comando1 = comando1 + ":NUMDRAWBACK," + "\n"; }
            if (modelo.dtnftransf != null) { comando1 = comando1 + ":DTNFTRANSF," + "\n"; }
            if (modelo.rotinalanc != null) { comando1 = comando1 + ":ROTINALANC," + "\n"; }
            if (modelo.numpedorigem != null) { comando1 = comando1 + ":NUMPEDORIGEM," + "\n"; }
            if (modelo.pedduplicado != null) { comando1 = comando1 + ":PEDDUPLICADO," + "\n"; }
            if (modelo.vlbonific != null) { comando1 = comando1 + ":VLBONIFIC," + "\n"; }
            if (modelo.vendalocestrang != null) { comando1 = comando1 + ":VENDALOCESTRANG," + "\n"; }
            if (modelo.copiaidenticapeddup != null) { comando1 = comando1 + ":COPIAIDENTICAPEDDUP," + "\n"; }
            if (modelo.assinatura != null) { comando1 = comando1 + ":ASSINATURA," + "\n"; }
            if (modelo.condfinanc != null) { comando1 = comando1 + ":CONDFINANC," + "\n"; }
            if (modelo.planosuppli != null) { comando1 = comando1 + ":PLANOSUPPLI," + "\n"; }
            if (modelo.pagchequemoradia != null) { comando1 = comando1 + ":PAGCHEQUEMORADIA," + "\n"; }
            comando1 = comando1 + "       :NUMVOLUME " + "\n";
            comando1 = comando1 + "     )";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue(":NUMPED", modelo.numped);
            cmd.Parameters.AddWithValue(":DATA", modelo.data);
            if (modelo.codusur != null) { cmd.Parameters.AddWithValue(":CODUSUR", modelo.codusur); }
            if (modelo.codcli != null) { cmd.Parameters.AddWithValue(":CODCLI", modelo.codcli); }
            if (modelo.numitens != null) { cmd.Parameters.AddWithValue(":NUMITENS", modelo.numitens); }
            if (modelo.vlatend != null) { cmd.Parameters.AddWithValue(":VLATEND", modelo.vlatend); }
            if (modelo.codpraca != null) { cmd.Parameters.AddWithValue(":CODPRACA", modelo.codpraca); }
            if (modelo.posicao != null) { cmd.Parameters.AddWithValue(":POSICAO", modelo.posicao); }
            if (modelo.numcar != null) { cmd.Parameters.AddWithValue(":NUMCAR", modelo.numcar); }
            if (modelo.codsupervisor != null) { cmd.Parameters.AddWithValue(":CODSUPERVISOR", modelo.codsupervisor); }
            if (modelo.codfilial != null) { cmd.Parameters.AddWithValue(":CODFILIAL", modelo.codfilial); }
            if (modelo.vltotal != null) { cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal); }
            if (modelo.vltabela != null) { cmd.Parameters.AddWithValue(":VLTABELA", modelo.vltabela); }
            if (modelo.vlcustoreal != null) { cmd.Parameters.AddWithValue(":VLCUSTOREAL", modelo.vlcustoreal); }
            if (modelo.vlcustofin != null) { cmd.Parameters.AddWithValue(":VLCUSTOFIN", modelo.vlcustofin); }
            if (modelo.totpeso != null) { cmd.Parameters.AddWithValue(":TOTPESO", modelo.totpeso); }
            if (modelo.totvolume != null) { cmd.Parameters.AddWithValue(":TOTVOLUME", modelo.totvolume); }
            if (modelo.codemitente != null) { cmd.Parameters.AddWithValue(":CODEMITENTE", modelo.codemitente); }
            if (modelo.operacao != null) { cmd.Parameters.AddWithValue(":OPERACAO", modelo.operacao); }
            if (modelo.tipovenda != null) { cmd.Parameters.AddWithValue(":TIPOVENDA", modelo.tipovenda); }
            if (modelo.obs != null) { cmd.Parameters.AddWithValue(":OBS", modelo.obs); }
            if (modelo.codcob != null) { cmd.Parameters.AddWithValue(":CODCOB", modelo.codcob); }
            if (modelo.hora != null) { cmd.Parameters.AddWithValue(":HORA", modelo.hora); }
            if (modelo.minuto != null) { cmd.Parameters.AddWithValue(":MINUTO", modelo.minuto); }
            if (modelo.codplpag != null) { cmd.Parameters.AddWithValue(":CODPLPAG", modelo.codplpag); }
            if (modelo.numpedcli != null) { cmd.Parameters.AddWithValue(":NUMPEDCLI", modelo.numpedcli); }
            if (modelo.percvenda != null) { cmd.Parameters.AddWithValue(":PERCVENDA", modelo.percvenda); }
            if (modelo.perdesc != null) { cmd.Parameters.AddWithValue(":PERDESC", modelo.perdesc); }
            if (modelo.vldesconto != null) { cmd.Parameters.AddWithValue(":VLDESCONTO", modelo.vldesconto); }
            if (modelo.vlfrete != null) { cmd.Parameters.AddWithValue(":VLFRETE", modelo.vlfrete); }
            if (modelo.vloutrasdesp != null) { cmd.Parameters.AddWithValue(":VLOUTRASDESP", modelo.vloutrasdesp); }
            if (modelo.obs1 != null) { cmd.Parameters.AddWithValue(":OBS1", modelo.obs1); }
            if (modelo.obs2 != null) { cmd.Parameters.AddWithValue(":OBS2", modelo.obs2); }
            if (modelo.condvenda != null) { cmd.Parameters.AddWithValue(":CONDVENDA", modelo.condvenda); }
            if (modelo.dtentrega != null) { cmd.Parameters.AddWithValue(":DTENTREGA", modelo.dtentrega); }
            if (modelo.numpedrca != null) { cmd.Parameters.AddWithValue(":NUMPEDRCA", modelo.numpedrca); }
            if (modelo.fretedespacho != null) { cmd.Parameters.AddWithValue(":FRETEDESPACHO", modelo.fretedespacho); }
            if (modelo.freteredespacho != null) { cmd.Parameters.AddWithValue(":FRETEREDESPACHO", modelo.freteredespacho); }
            if (modelo.codfornecfrete != null) { cmd.Parameters.AddWithValue(":CODFORNECFRETE", modelo.codfornecfrete); }
            if (modelo.codfornecredespacho != null) { cmd.Parameters.AddWithValue(":CODFORNECREDESPACHO", modelo.codfornecredespacho); }
            if (modelo.tipocarga != null) { cmd.Parameters.AddWithValue(":TIPOCARGA", modelo.tipocarga); }
            if (modelo.prazo1 != null) { cmd.Parameters.AddWithValue(":PRAZO1", modelo.prazo1); }
            if (modelo.prazo2 != null) { cmd.Parameters.AddWithValue(":PRAZO2", modelo.prazo2); }
            if (modelo.prazo3 != null) { cmd.Parameters.AddWithValue(":PRAZO3", modelo.prazo3); }
            if (modelo.prazo4 != null) { cmd.Parameters.AddWithValue(":PRAZO4", modelo.prazo4); }
            if (modelo.prazo5 != null) { cmd.Parameters.AddWithValue(":PRAZO5", modelo.prazo5); }
            if (modelo.prazo6 != null) { cmd.Parameters.AddWithValue(":PRAZO6", modelo.prazo6); }
            if (modelo.prazo7 != null) { cmd.Parameters.AddWithValue(":PRAZO7", modelo.prazo7); }
            if (modelo.prazo8 != null) { cmd.Parameters.AddWithValue(":PRAZO8", modelo.prazo8); }
            if (modelo.prazo9 != null) { cmd.Parameters.AddWithValue(":PRAZO9", modelo.prazo9); }
            if (modelo.prazo10 != null) { cmd.Parameters.AddWithValue(":PRAZO10", modelo.prazo10); }
            if (modelo.prazo11 != null) { cmd.Parameters.AddWithValue(":PRAZO11", modelo.prazo11); }
            if (modelo.prazo12 != null) { cmd.Parameters.AddWithValue(":PRAZO12", modelo.prazo12); }
            if (modelo.prazomedio != null) { cmd.Parameters.AddWithValue(":PRAZOMEDIO", modelo.prazomedio); }
            if (modelo.obsentrega1 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA1", modelo.obsentrega1); }
            if (modelo.obsentrega2 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA2", modelo.obsentrega2); }
            if (modelo.obsentrega3 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA3", modelo.obsentrega3); }
            if (modelo.tipoembalagem != null) { cmd.Parameters.AddWithValue(":TIPOEMBALAGEM", modelo.tipoembalagem); }
            if (modelo.codepto != null) { cmd.Parameters.AddWithValue(":CODEPTO", modelo.codepto); }
            if (modelo.campanha != null) { cmd.Parameters.AddWithValue(":CAMPANHA", modelo.campanha); }
            if (modelo.coddistrib != null) { cmd.Parameters.AddWithValue(":CODDISTRIB", modelo.coddistrib); }
            if (modelo.vlcustocont != null) { cmd.Parameters.AddWithValue(":VLCUSTOCONT", modelo.vlcustocont); }
            if (modelo.vlcustorep != null) { cmd.Parameters.AddWithValue(":VLCUSTOREP", modelo.vlcustorep); }
            if (modelo.numnotamanif != null) { cmd.Parameters.AddWithValue(":NUMNOTAMANIF", modelo.numnotamanif); }
            if (modelo.seriemanif != null) { cmd.Parameters.AddWithValue(":SERIEMANIF", modelo.seriemanif); }
            if (modelo.origemped != null) { cmd.Parameters.AddWithValue(":ORIGEMPED", modelo.origemped); }
            if (modelo.especiemanif != null) { cmd.Parameters.AddWithValue(":ESPECIEMANIF", modelo.especiemanif); }
            if (modelo.numpedentfut != null) { cmd.Parameters.AddWithValue(":NUMPEDENTFUT", modelo.numpedentfut); }
            if (modelo.codfilialnf != null) { cmd.Parameters.AddWithValue(":CODFILIALNF", modelo.codfilialnf); }
            if (modelo.numcarmanif != null) { cmd.Parameters.AddWithValue(":NUMCARMANIF", modelo.numcarmanif); }
            if (modelo.numorca != null) { cmd.Parameters.AddWithValue(":NUMORCA", modelo.numorca); }
            if (modelo.codcontrato != null) { cmd.Parameters.AddWithValue(":CODCONTRATO", modelo.codcontrato); }
            if (modelo.datapedcli != null) { cmd.Parameters.AddWithValue(":DATAPEDCLI", modelo.datapedcli); }
            if (modelo.numpedbnf != null) { cmd.Parameters.AddWithValue(":NUMPEDBNF", modelo.numpedbnf); }
            if (modelo.broker != null) { cmd.Parameters.AddWithValue(":BROKER", modelo.broker); }
            if (modelo.codestabelecimento != null) { cmd.Parameters.AddWithValue(":CODESTABELECIMENTO", modelo.codestabelecimento); }
            if (modelo.numtabela != null) { cmd.Parameters.AddWithValue(":NUMTABELA", modelo.numtabela); }
            if (modelo.motivoposicao != null) { cmd.Parameters.AddWithValue(":MOTIVOPOSICAO", modelo.motivoposicao); }
            if (modelo.dtagendaentrega != null) { cmd.Parameters.AddWithValue(":DTAGENDAENTREGA", modelo.dtagendaentrega); }
            if (modelo.tipooper != null) { cmd.Parameters.AddWithValue(":TIPOOPER", modelo.tipooper); }
            if (modelo.codmotbloqueio != null) { cmd.Parameters.AddWithValue(":CODMOTBLOQUEIO", modelo.codmotbloqueio); }
            if (modelo.serieecf != null) { cmd.Parameters.AddWithValue(":SERIEECF", modelo.serieecf); }
            if (modelo.numcupom != null) { cmd.Parameters.AddWithValue(":NUMCUPOM", modelo.numcupom); }
            if (modelo.codclirecebedor != null) { cmd.Parameters.AddWithValue(":CODCLIRECEBEDOR", modelo.codclirecebedor); }
            if (modelo.conciliaimportacao != null) { cmd.Parameters.AddWithValue(":CONCILIAIMPORTACAO", modelo.conciliaimportacao); }
            if (modelo.numregiao != null) { cmd.Parameters.AddWithValue(":NUMREGIAO", modelo.numregiao); }
            if (modelo.numnota != null) { cmd.Parameters.AddWithValue(":NUMNOTA", modelo.numnota); }
            if (modelo.perdescfin != null) { cmd.Parameters.AddWithValue(":PERDESCFIN", modelo.perdescfin); }
            if (modelo.restricaotransp != null) { cmd.Parameters.AddWithValue(":RESTRICAOTRANSP", modelo.restricaotransp); }
            if (modelo.geracp != null) { cmd.Parameters.AddWithValue(":GERACP", modelo.geracp); }
            if (modelo.usaintegracaowms != null) { cmd.Parameters.AddWithValue(":USAINTEGRACAOWMS", modelo.usaintegracaowms); }
            if (modelo.vendaassistida != null) { cmd.Parameters.AddWithValue(":VENDAASSISTIDA", modelo.vendaassistida); }
            if (modelo.codmotivo != null) { cmd.Parameters.AddWithValue(":CODMOTIVO", modelo.codmotivo); }
            if (modelo.log != null) { cmd.Parameters.AddWithValue(":LOG", modelo.log); }
            if (modelo.dtcalcfrete != null) { cmd.Parameters.AddWithValue(":DTCALCFRETE", modelo.dtcalcfrete); }
            if (modelo.codfunccalcfrete != null) { cmd.Parameters.AddWithValue(":CODFUNCCALCFRETE", modelo.codfunccalcfrete); }
            if (modelo.eancobranca != null) { cmd.Parameters.AddWithValue(":EANCOBRANCA", modelo.eancobranca); }
            if (modelo.eanentrega != null) { cmd.Parameters.AddWithValue(":EANENTREGA", modelo.eanentrega); }
            if (modelo.usacfopvendanatv10 != null) { cmd.Parameters.AddWithValue(":USACFOPVENDANATV10", modelo.usacfopvendanatv10); }
            if (modelo.tipoprioridadeentrega != null) { cmd.Parameters.AddWithValue(":TIPOPRIORIDADEENTREGA", modelo.tipoprioridadeentrega); }
            if (modelo.codusur2 != null) { cmd.Parameters.AddWithValue(":CODUSUR2", modelo.codusur2); }
            if (modelo.codusur3 != null) { cmd.Parameters.AddWithValue(":CODUSUR3", modelo.codusur3); }
            if (modelo.codusur4 != null) { cmd.Parameters.AddWithValue(":CODUSUR4", modelo.codusur4); }
            if (modelo.codclinf != null) { cmd.Parameters.AddWithValue(":CODCLINF", modelo.codclinf); }
            if (modelo.numpedtv1 != null) { cmd.Parameters.AddWithValue(":NUMPEDTV1", modelo.numpedtv1); }
            if (modelo.usadebcredrca != null) { cmd.Parameters.AddWithValue(":USADEBCREDRCA", modelo.usadebcredrca); }
            if (modelo.brinde != null) { cmd.Parameters.AddWithValue(":BRINDE", modelo.brinde); }
            if (modelo.bonificaltdebcredrca != null) { cmd.Parameters.AddWithValue(":BONIFICALTDEBCREDRCA", modelo.bonificaltdebcredrca); }
            if (modelo.trocaaltdebcredrca != null) { cmd.Parameters.AddWithValue(":TROCAALTDEBCREDRCA", modelo.trocaaltdebcredrca); }
            if (modelo.brokeraltdebcredrca != null) { cmd.Parameters.AddWithValue(":BROKERALTDEBCREDRCA", modelo.brokeraltdebcredrca); }
            if (modelo.crmaltdebcredrca != null) { cmd.Parameters.AddWithValue(":CRMALTDEBCREDRCA", modelo.crmaltdebcredrca); }
            if (modelo.tipomovccrca != null) { cmd.Parameters.AddWithValue(":TIPOMOVCCRCA", modelo.tipomovccrca); }
            if (modelo.usacredrca != null) { cmd.Parameters.AddWithValue(":USACREDRCA", modelo.usacredrca); }
            if (modelo.gerardadosnfpaulista != null) { cmd.Parameters.AddWithValue(":GERARDADOSNFPAULISTA", modelo.gerardadosnfpaulista); }
            if (modelo.usasaldocontacorrentedescfin != null) { cmd.Parameters.AddWithValue(":USASALDOCONTACORRENTEDESCFIN", modelo.usasaldocontacorrentedescfin); }
            if (modelo.valordescfin != null) { cmd.Parameters.AddWithValue(":VALORDESCFIN", modelo.valordescfin); }
            if (modelo.codvisita != null) { cmd.Parameters.AddWithValue(":CODVISITA", modelo.codvisita); }
            if (modelo.codatendimento != null) { cmd.Parameters.AddWithValue(":CODATENDIMENTO", modelo.codatendimento); }
            if (modelo.vendatriangular != null) { cmd.Parameters.AddWithValue(":VENDATRIANGULAR", modelo.vendatriangular); }
            if (modelo.vlentrada != null) { cmd.Parameters.AddWithValue(":VLENTRADA", modelo.vlentrada); }
            if (modelo.ufdesembaraco != null) { cmd.Parameters.AddWithValue(":UFDESEMBARACO", modelo.ufdesembaraco); }
            if (modelo.localdesembaraco != null) { cmd.Parameters.AddWithValue(":LOCALDESEMBARACO", modelo.localdesembaraco); }
            if (modelo.custobonificacao != null) { cmd.Parameters.AddWithValue(":CUSTOBONIFICACAO", modelo.custobonificacao); }
            if (modelo.codfornecbonific != null) { cmd.Parameters.AddWithValue(":CODFORNECBONIFIC", modelo.codfornecbonific); }
            if (modelo.codbnf != null) { cmd.Parameters.AddWithValue(":CODBNF", modelo.codbnf); }
            if (modelo.tipodocumento != null) { cmd.Parameters.AddWithValue(":TIPODOCUMENTO", modelo.tipodocumento); }
            if (modelo.cfopbnfdegusta != null) { cmd.Parameters.AddWithValue(":CFOPBNFDEGUSTA", modelo.cfopbnfdegusta); }
            if (modelo.contaordem != null) { cmd.Parameters.AddWithValue(":CONTAORDEM", modelo.contaordem); }
            if (modelo.dataempenho != null) { cmd.Parameters.AddWithValue(":DATAEMPENHO", modelo.dataempenho); }
            if (modelo.numempenho != null) { cmd.Parameters.AddWithValue(":NUMEMPENHO", modelo.numempenho); }
            if (modelo.codunidadeexecutora != null) { cmd.Parameters.AddWithValue(":CODUNIDADEEXECUTORA", modelo.codunidadeexecutora); }
            if (modelo.placaveiculo != null) { cmd.Parameters.AddWithValue(":PLACAVEICULO", modelo.placaveiculo); }
            if (modelo.dtlimitefat != null) { cmd.Parameters.AddWithValue(":DTLIMITEFAT", modelo.dtlimitefat); }
            if (modelo.reservaestoquetv7 != null) { cmd.Parameters.AddWithValue(":RESERVAESTOQUETV7", modelo.reservaestoquetv7); }
            if (modelo.fornecentrega != null) { cmd.Parameters.AddWithValue(":FORNECENTREGA", modelo.fornecentrega); }
            if (modelo.codclitv8 != null) { cmd.Parameters.AddWithValue(":CODCLITV8", modelo.codclitv8); }
            if (modelo.ufveiculo != null) { cmd.Parameters.AddWithValue(":UFVEICULO", modelo.ufveiculo); }
            if (modelo.motoristaveiculo != null) { cmd.Parameters.AddWithValue(":MOTORISTAVEICULO", modelo.motoristaveiculo); }
            if (modelo.dtiniciodigitacaopedido != null) { cmd.Parameters.AddWithValue(":DTINICIODIGITACAOPEDIDO", modelo.dtiniciodigitacaopedido); }
            if (modelo.dtfimdigitacaopedido != null) { cmd.Parameters.AddWithValue(":DTFIMDIGITACAOPEDIDO", modelo.dtfimdigitacaopedido); }
            if (modelo.vldescabatimento != null) { cmd.Parameters.AddWithValue(":VLDESCABATIMENTO", modelo.vldescabatimento); }
            if (modelo.agrupamento != null) { cmd.Parameters.AddWithValue(":AGRUPAMENTO", modelo.agrupamento); }
            if (modelo.vendaexportacao != null) { cmd.Parameters.AddWithValue(":VENDAEXPORTACAO", modelo.vendaexportacao); }
            if (modelo.turnoentrega != null) { cmd.Parameters.AddWithValue(":TURNOENTREGA", modelo.turnoentrega); }
            if (modelo.numtransvendatv13 != null) { cmd.Parameters.AddWithValue(":NUMTRANSVENDATV13", modelo.numtransvendatv13); }
            if (modelo.codendentcli != null) { cmd.Parameters.AddWithValue(":CODENDENTCLI", modelo.codendentcli); }
            if (modelo.utilizavendaporembalagem != null) { cmd.Parameters.AddWithValue(":UTILIZAVENDAPOREMBALAGEM", modelo.utilizavendaporembalagem); }
            if (modelo.codcontato != null) { cmd.Parameters.AddWithValue(":CODCONTATO", modelo.codcontato); }
            if (modelo.numregexp != null) { cmd.Parameters.AddWithValue(":NUMREGEXP", modelo.numregexp); }
            if (modelo.numchaveexp != null) { cmd.Parameters.AddWithValue(":NUMCHAVEEXP", modelo.numchaveexp); }
            if (modelo.numdrawback != null) { cmd.Parameters.AddWithValue(":NUMDRAWBACK", modelo.numdrawback); }
            if (modelo.dtnftransf != null) { cmd.Parameters.AddWithValue(":DTNFTRANSF", modelo.dtnftransf); }
            if (modelo.rotinalanc != null) { cmd.Parameters.AddWithValue(":ROTINALANC", modelo.rotinalanc); }
            if (modelo.numpedorigem != null) { cmd.Parameters.AddWithValue(":NUMPEDORIGEM", modelo.numpedorigem); }
            if (modelo.pedduplicado != null) { cmd.Parameters.AddWithValue(":PEDDUPLICADO", modelo.pedduplicado); }
            if (modelo.vlbonific != null) { cmd.Parameters.AddWithValue(":VLBONIFIC", modelo.vlbonific); }
            if (modelo.vendalocestrang != null) { cmd.Parameters.AddWithValue(":VENDALOCESTRANG", modelo.vendalocestrang); }
            if (modelo.copiaidenticapeddup != null) { cmd.Parameters.AddWithValue(":COPIAIDENTICAPEDDUP", modelo.copiaidenticapeddup); }
            if (modelo.assinatura != null) { cmd.Parameters.AddWithValue(":ASSINATURA", modelo.assinatura); }
            if (modelo.condfinanc != null) { cmd.Parameters.AddWithValue(":CONDFINANC", modelo.condfinanc); }
            if (modelo.planosuppli != null) { cmd.Parameters.AddWithValue(":PLANOSUPPLI", modelo.planosuppli); }
            if (modelo.pagchequemoradia != null) { cmd.Parameters.AddWithValue(":PAGCHEQUEMORADIA", modelo.pagchequemoradia); }
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
            if (modelo.codusur != null) { comando2 = comando2 + "  CODUSUR   = :CODUSUR, " + "\n"; }
            if (modelo.codcli != null) { comando2 = comando2 + "  CODCLI   = :CODCLI, " + "\n"; }
            if (modelo.numitens != null) { comando2 = comando2 + "  NUMITENS              = :NUMITENS, " + "\n"; }
            if (modelo.vlatend != null) { comando2 = comando2 + "  VLATEND               = :VLATEND, " + "\n"; }
            if (modelo.codpraca != null) { comando2 = comando2 + "  CODPRACA              = :CODPRACA, " + "\n"; }
            if (modelo.posicao != null) { comando2 = comando2 + "  POSICAO               = :POSICAO, " + "\n"; }
            if (modelo.numcar != null) { comando2 = comando2 + "  NUMCAR   = :NUMCAR, " + "\n"; }
            if (modelo.codsupervisor != null) { comando2 = comando2 + "  CODSUPERVISOR         = :CODSUPERVISOR, " + "\n"; }
            if (modelo.codfilial != null) { comando2 = comando2 + "  CODFILIAL             = :CODFILIAL, " + "\n"; }
            if (modelo.codfilialnf != null) { comando2 = comando2 + "  CODFILIALNF           = :CODFILIALNF, " + "\n"; }
            if (modelo.vltotal != null) { comando2 = comando2 + "  VLTOTAL               = :VLTOTAL, " + "\n"; }
            if (modelo.vltabela != null) { comando2 = comando2 + "  VLTABELA              = :VLTABELA, " + "\n"; }
            if (modelo.vlcustoreal != null) { comando2 = comando2 + "  VLCUSTOREAL           = :VLCUSTOREAL, " + "\n"; }
            if (modelo.vlcustofin != null) { comando2 = comando2 + "  VLCUSTOFIN            = :VLCUSTOFIN, " + "\n"; }
            if (modelo.totpeso != null) { comando2 = comando2 + "  TOTPESO               = :TOTPESO, " + "\n"; }
            if (modelo.totvolume != null) { comando2 = comando2 + "  TOTVOLUME             = :TOTVOLUME, " + "\n"; }
            if (modelo.codemitente != null) { comando2 = comando2 + "  CODEMITENTE           = :CODEMITENTE, " + "\n"; }
            if (modelo.operacao != null) { comando2 = comando2 + "  OPERACAO              = :OPERACAO, " + "\n"; }
            if (modelo.tipovenda != null) { comando2 = comando2 + "  TIPOVENDA             = :TIPOVENDA, " + "\n"; }
            if (modelo.obs != null) { comando2 = comando2 + "  OBS      = :OBS, " + "\n"; }
            if (modelo.codcob != null) { comando2 = comando2 + "  CODCOB   = :CODCOB, " + "\n"; }
            if (modelo.hora != null) { comando2 = comando2 + "  HORA     = :HORA, " + "\n"; }
            if (modelo.minuto != null) { comando2 = comando2 + "  MINUTO   = :MINUTO, " + "\n"; }
            if (modelo.codplpag != null) { comando2 = comando2 + "  CODPLPAG              = :CODPLPAG, " + "\n"; }
            if (modelo.numpedcli != null) { comando2 = comando2 + "  NUMPEDCLI             = :NUMPEDCLI, " + "\n"; }
            if (modelo.percvenda != null) { comando2 = comando2 + "  PERCVENDA             = :PERCVENDA, " + "\n"; }
            if (modelo.perdesc != null) { comando2 = comando2 + "  PERDESC               = :PERDESC, " + "\n"; }
            if (modelo.vldesconto != null) { comando2 = comando2 + "  VLDESCONTO            = :VLDESCONTO, " + "\n"; }
            if (modelo.vlfrete != null) { comando2 = comando2 + "  VLFRETE               = :VLFRETE, " + "\n"; }
            if (modelo.vloutrasdesp != null) { comando2 = comando2 + "  VLOUTRASDESP          = :VLOUTRASDESP, " + "\n"; }
            if (modelo.obs1 != null) { comando2 = comando2 + "  OBS1     = :OBS1, " + "\n"; }
            if (modelo.obs2 != null) { comando2 = comando2 + "  OBS2     = :OBS2, " + "\n"; }
            if (modelo.condvenda != null) { comando2 = comando2 + "  CONDVENDA             = :CONDVENDA, " + "\n"; }
            if (modelo.dtentrega != null) { comando2 = comando2 + "  DTENTREGA             = :DTENTREGA, " + "\n"; }
            if (modelo.numpedrca != null) { comando2 = comando2 + "  NUMPEDRCA             = :NUMPEDRCA, " + "\n"; }
            if (modelo.fretedespacho != null) { comando2 = comando2 + "  FRETEDESPACHO         = :FRETEDESPACHO, " + "\n"; }
            if (modelo.freteredespacho != null) { comando2 = comando2 + "  FRETEREDESPACHO       = :FRETEREDESPACHO, " + "\n"; }
            if (modelo.codfornecfrete != null) { comando2 = comando2 + "  CODFORNECFRETE        = :CODFORNECFRETE, " + "\n"; }
            if (modelo.codfornecredespacho != null) { comando2 = comando2 + "  CODFORNECREDESPACHO   = :CODFORNECREDESPACHO, " + "\n"; }
            if (modelo.tipocarga != null) { comando2 = comando2 + "  TIPOCARGA             = :TIPOCARGA, " + "\n"; }
            if (modelo.prazo1 != null) { comando2 = comando2 + "  PRAZO1   = :PRAZO1, " + "\n"; }
            if (modelo.prazo2 != null) { comando2 = comando2 + "  PRAZO2   = :PRAZO2, " + "\n"; }
            if (modelo.prazo3 != null) { comando2 = comando2 + "  PRAZO3   = :PRAZO3, " + "\n"; }
            if (modelo.prazo4 != null) { comando2 = comando2 + "  PRAZO4   = :PRAZO4, " + "\n"; }
            if (modelo.prazo5 != null) { comando2 = comando2 + "  PRAZO5   = :PRAZO5, " + "\n"; }
            if (modelo.prazo6 != null) { comando2 = comando2 + "  PRAZO6   = :PRAZO6, " + "\n"; }
            if (modelo.prazo7 != null) { comando2 = comando2 + "  PRAZO7   = :PRAZO7, " + "\n"; }
            if (modelo.prazo8 != null) { comando2 = comando2 + "  PRAZO8   = :PRAZO8, " + "\n"; }
            if (modelo.prazo9 != null) { comando2 = comando2 + "  PRAZO9   = :PRAZO9, " + "\n"; }
            if (modelo.prazo10 != null) { comando2 = comando2 + "  PRAZO10               = :PRAZO10, " + "\n"; }
            if (modelo.prazo11 != null) { comando2 = comando2 + "  PRAZO11               = :PRAZO11, " + "\n"; }
            if (modelo.prazo12 != null) { comando2 = comando2 + "  PRAZO12               = :PRAZO12, " + "\n"; }
            if (modelo.prazomedio != null) { comando2 = comando2 + "  PRAZOMEDIO            = :PRAZOMEDIO, " + "\n"; }
            if (modelo.obsentrega1 != null) { comando2 = comando2 + "  OBSENTREGA1           = :OBSENTREGA1, " + "\n"; }
            if (modelo.obsentrega2 != null) { comando2 = comando2 + "  OBSENTREGA2           = :OBSENTREGA2, " + "\n"; }
            if (modelo.obsentrega3 != null) { comando2 = comando2 + "  OBSENTREGA3           = :OBSENTREGA3, " + "\n"; }
            if (modelo.tipoembalagem != null) { comando2 = comando2 + "  TIPOEMBALAGEM         = :TIPOEMBALAGEM, " + "\n"; }
            if (modelo.codepto != null) { comando2 = comando2 + "  CODEPTO               = :CODEPTO, " + "\n"; }
            if (modelo.campanha != null) { comando2 = comando2 + "  CAMPANHA              = :CAMPANHA, " + "\n"; }
            if (modelo.coddistrib != null) { comando2 = comando2 + "  CODDISTRIB            = :CODDISTRIB, " + "\n"; }
            if (modelo.numnotamanif != null) { comando2 = comando2 + "  NUMNOTAMANIF          = :NUMNOTAMANIF, " + "\n"; }
            if (modelo.seriemanif != null) { comando2 = comando2 + "  SERIEMANIF            = :SERIEMANIF, " + "\n"; }
            if (modelo.origemped != null) { comando2 = comando2 + "  ORIGEMPED             = :ORIGEMPED, " + "\n"; }
            if (modelo.especiemanif != null) { comando2 = comando2 + "  ESPECIEMANIF          = :ESPECIEMANIF, " + "\n"; }
            if (modelo.numcarmanif != null) { comando2 = comando2 + "  NUMCARMANIF           = :NUMCARMANIF, " + "\n"; }
            if (modelo.numorca != null) { comando2 = comando2 + "  NUMORCA               = :NUMORCA, " + "\n"; }
            if (modelo.codcontrato != null) { comando2 = comando2 + "  CODCONTRATO           = :CODCONTRATO, " + "\n"; }
            if (modelo.datapedcli != null) { comando2 = comando2 + "  DATAPEDCLI            = :DATAPEDCLI, " + "\n"; }
            if (modelo.numpedbnf != null) { comando2 = comando2 + "  NUMPEDBNF             = :NUMPEDBNF, " + "\n"; }
            if (modelo.broker != null) { comando2 = comando2 + "  BROKER   = :BROKER, " + "\n"; }
            if (modelo.codestabelecimento != null) { comando2 = comando2 + "  CODESTABELECIMENTO    = :CODESTABELECIMENTO, " + "\n"; }
            if (modelo.numtabela != null) { comando2 = comando2 + "  NUMTABELA             = :NUMTABELA, " + "\n"; }
            if (modelo.motivoposicao != null) { comando2 = comando2 + "  MOTIVOPOSICAO         = :MOTIVOPOSICAO, " + "\n"; }
            if (modelo.dtagendaentrega != null) { comando2 = comando2 + "  DTAGENDAENTREGA       = :DTAGENDAENTREGA, " + "\n"; }
            if (modelo.tipooper != null) { comando2 = comando2 + "  TIPOOPER              = :TIPOOPER, " + "\n"; }
            if (modelo.codmotbloqueio != null) { comando2 = comando2 + "  CODMOTBLOQUEIO        = :CODMOTBLOQUEIO, " + "\n"; }
            if (modelo.serieecf != null) { comando2 = comando2 + "  SERIEECF              = :SERIEECF, " + "\n"; }
            if (modelo.numcupom != null) { comando2 = comando2 + "  NUMCUPOM              = :NUMCUPOM, " + "\n"; }
            if (modelo.codclirecebedor != null) { comando2 = comando2 + "  CODCLIRECEBEDOR       = :CODCLIRECEBEDOR, " + "\n"; }
            if (modelo.conciliaimportacao != null) { comando2 = comando2 + "  CONCILIAIMPORTACAO    = :CONCILIAIMPORTACAO, " + "\n"; }
            if (modelo.numregiao != null) { comando2 = comando2 + "  NUMREGIAO             = :NUMREGIAO, " + "\n"; }
            if (modelo.numnota != null) { comando2 = comando2 + "  NUMNOTA               = :NUMNOTA, " + "\n"; }
            if (modelo.perdescfin != null) { comando2 = comando2 + "  PERDESCFIN            = :PERDESCFIN, " + "\n"; }
            if (modelo.restricaotransp != null) { comando2 = comando2 + "  RESTRICAOTRANSP       = :RESTRICAOTRANSP, " + "\n"; }
            if (modelo.geracp != null) { comando2 = comando2 + "  GERACP   = :GERACP, " + "\n"; }
            if (modelo.usaintegracaowms != null) { comando2 = comando2 + "  USAINTEGRACAOWMS      = :USAINTEGRACAOWMS, " + "\n"; }
            if (modelo.vendaassistida != null) { comando2 = comando2 + "  VENDAASSISTIDA        = :VENDAASSISTIDA, " + "\n"; }
            if (modelo.codmotivo != null) { comando2 = comando2 + "  CODMOTIVO             = :CODMOTIVO, " + "\n"; }
            if (modelo.log != null) { comando2 = comando2 + "  LOG      = :LOG, " + "\n"; }
            if (modelo.codfunccalcfrete != null) { comando2 = comando2 + "  CODFUNCCALCFRETE      = :CODFUNCCALCFRETE, " + "\n"; }
            if (modelo.dtcalcfrete != null) { comando2 = comando2 + "  DTCALCFRETE           = :DTCALCFRETE, " + "\n"; }
            if (modelo.eanentrega != null) { comando2 = comando2 + "  EANENTREGA            = :EANENTREGA, " + "\n"; }
            if (modelo.eancobranca != null) { comando2 = comando2 + "  EANCOBRANCA           = :EANCOBRANCA, " + "\n"; }
            if (modelo.usacfopvendanatv10 != null) { comando2 = comando2 + "  USACFOPVENDANATV10    = :USACFOPVENDANATV10, " + "\n"; }
            if (modelo.tipoprioridadeentrega != null) { comando2 = comando2 + "  TIPOPRIORIDADEENTREGA        =	:TIPOPRIORIDADEENTREGA, " + "\n"; }
            if (modelo.codusur2 != null) { comando2 = comando2 + "  CODUSUR2              = :CODUSUR2, " + "\n"; }
            if (modelo.codusur3 != null) { comando2 = comando2 + "  CODUSUR3              = :CODUSUR3, " + "\n"; }
            if (modelo.codusur4 != null) { comando2 = comando2 + "  CODUSUR4              = :CODUSUR4, " + "\n"; }
            if (modelo.codclinf != null) { comando2 = comando2 + "  CODCLINF              = :CODCLINF, " + "\n"; }
            if (modelo.numpedtv1 != null) { comando2 = comando2 + "  NUMPEDTV1             = :NUMPEDTV1, " + "\n"; }
            if (modelo.usadebcredrca != null) { comando2 = comando2 + "  USADEBCREDRCA         = :USADEBCREDRCA, " + "\n"; }
            if (modelo.brinde != null) { comando2 = comando2 + "  BRINDE   = :BRINDE, " + "\n"; }
            if (modelo.bonificaltdebcredrca != null) { comando2 = comando2 + "  BONIFICALTDEBCREDRCA         =	:BONIFICALTDEBCREDRCA, " + "\n"; }
            if (modelo.trocaaltdebcredrca != null) { comando2 = comando2 + "  TROCAALTDEBCREDRCA    = :TROCAALTDEBCREDRCA, " + "\n"; }
            if (modelo.brokeraltdebcredrca != null) { comando2 = comando2 + "  BROKERALTDEBCREDRCA   = :BROKERALTDEBCREDRCA, " + "\n"; }
            if (modelo.crmaltdebcredrca != null) { comando2 = comando2 + "  CRMALTDEBCREDRCA      = :CRMALTDEBCREDRCA, " + "\n"; }
            if (modelo.tipomovccrca != null) { comando2 = comando2 + "  TIPOMOVCCRCA          = :TIPOMOVCCRCA, " + "\n"; }
            if (modelo.usacredrca != null) { comando2 = comando2 + "  USACREDRCA            = :USACREDRCA, " + "\n"; }
            if (modelo.gerardadosnfpaulista != null) { comando2 = comando2 + "  GERARDADOSNFPAULISTA         =	:GERARDADOSNFPAULISTA, " + "\n"; }
            if (modelo.usasaldocontacorrentedescfin != null) { comando2 = comando2 + "  USASALDOCONTACORRENTEDESCFIN =	:USASALDOCONTACORRENTEDESCFIN, " + "\n"; }
            if (modelo.valordescfin != null) { comando2 = comando2 + "  VALORDESCFIN          = :VALORDESCFIN, " + "\n"; }
            if (modelo.codvisita != null) { comando2 = comando2 + "  CODVISITA             = :CODVISITA, " + "\n"; }
            if (modelo.codatendimento != null) { comando2 = comando2 + "  CODATENDIMENTO        = :CODATENDIMENTO, " + "\n"; }
            if (modelo.vendatriangular != null) { comando2 = comando2 + "  VENDATRIANGULAR       = :VENDATRIANGULAR, " + "\n"; }
            if (modelo.vlentrada != null) { comando2 = comando2 + "  VLENTRADA             = :VLENTRADA, " + "\n"; }
            if (modelo.ufdesembaraco != null) { comando2 = comando2 + "  UFDESEMBARACO         = :UFDESEMBARACO, " + "\n"; }
            if (modelo.localdesembaraco != null) { comando2 = comando2 + "  LOCALDESEMBARACO      = :LOCALDESEMBARACO, " + "\n"; }
            if (modelo.custobonificacao != null) { comando2 = comando2 + "  CUSTOBONIFICACAO      = :CUSTOBONIFICACAO, " + "\n"; }
            if (modelo.codfornecbonific != null) { comando2 = comando2 + "  CODFORNECBONIFIC      = :CODFORNECBONIFIC, " + "\n"; }
            if (modelo.codbnf != null) { comando2 = comando2 + "  CODBNF   = :CODBNF, " + "\n"; }
            if (modelo.tipodocumento != null) { comando2 = comando2 + "  TIPODOCUMENTO         = :TIPODOCUMENTO, " + "\n"; }
            if (modelo.cfopbnfdegusta != null) { comando2 = comando2 + "  CFOPBNFDEGUSTA        = :CFOPBNFDEGUSTA, " + "\n"; }
            if (modelo.contaordem != null) { comando2 = comando2 + "  CONTAORDEM            = :CONTAORDEM, " + "\n"; }
            if (modelo.dataempenho != null) { comando2 = comando2 + "  DATAEMPENHO           = :DATAEMPENHO, " + "\n"; }
            if (modelo.numempenho != null) { comando2 = comando2 + "  NUMEMPENHO            = :NUMEMPENHO, " + "\n"; }
            if (modelo.codunidadeexecutora != null) { comando2 = comando2 + "  CODUNIDADEEXECUTORA   = :CODUNIDADEEXECUTORA, " + "\n"; }
            if (modelo.placaveiculo != null) { comando2 = comando2 + "  PLACAVEICULO          = :PLACAVEICULO, " + "\n"; }
            if (modelo.dtlimitefat != null) { comando2 = comando2 + "  DTLIMITEFAT           = :DTLIMITEFAT, " + "\n"; }
            if (modelo.reservaestoquetv7 != null) { comando2 = comando2 + "  RESERVAESTOQUETV7     = :RESERVAESTOQUETV7, " + "\n"; }
            if (modelo.fornecentrega != null) { comando2 = comando2 + "  FORNECENTREGA         = :FORNECENTREGA, " + "\n"; }
            if (modelo.codclitv8 != null) { comando2 = comando2 + "  CODCLITV8             = :CODCLITV8, " + "\n"; }
            if (modelo.ufveiculo != null) { comando2 = comando2 + "  UFVEICULO             = :UFVEICULO, " + "\n"; }
            if (modelo.motoristaveiculo != null) { comando2 = comando2 + "  MOTORISTAVEICULO      = :MOTORISTAVEICULO, " + "\n"; }
            if (modelo.dtiniciodigitacaopedido != null) { comando2 = comando2 + "  DTINICIODIGITACAOPEDIDO      =	:DTINICIODIGITACAOPEDIDO, " + "\n"; }
            if (modelo.dtfimdigitacaopedido != null) { comando2 = comando2 + "  DTFIMDIGITACAOPEDIDO         =	:DTFIMDIGITACAOPEDIDO, " + "\n"; }
            if (modelo.vldescabatimento != null) { comando2 = comando2 + "  VLDESCABATIMENTO      = :VLDESCABATIMENTO, " + "\n"; }
            if (modelo.agrupamento != null) { comando2 = comando2 + "  AGRUPAMENTO           = :AGRUPAMENTO, " + "\n"; }
            if (modelo.vendaexportacao != null) { comando2 = comando2 + "  VENDAEXPORTACAO       = :VENDAEXPORTACAO, " + "\n"; }
            if (modelo.turnoentrega != null) { comando2 = comando2 + "  TURNOENTREGA          = :TURNOENTREGA, " + "\n"; }
            if (modelo.numtransvendatv13 != null) { comando2 = comando2 + "  NUMTRANSVENDATV13     = :NUMTRANSVENDATV13, " + "\n"; }
            if (modelo.codendentcli != null) { comando2 = comando2 + "  CODENDENTCLI          = :CODENDENTCLI, " + "\n"; }
            if (modelo.utilizavendaporembalagem != null) { comando2 = comando2 + "  UTILIZAVENDAPOREMBALAGEM     =	:UTILIZAVENDAPOREMBALAGEM, " + "\n"; }
            if (modelo.codcontato != null) { comando2 = comando2 + "  CODCONTATO            = :CODCONTATO, " + "\n"; }
            if (modelo.numregexp != null) { comando2 = comando2 + "  NUMREGEXP             = :NUMREGEXP, " + "\n"; }
            if (modelo.numchaveexp != null) { comando2 = comando2 + "  NUMCHAVEEXP           = :NUMCHAVEEXP, " + "\n"; }
            if (modelo.numdrawback != null) { comando2 = comando2 + "  NUMDRAWBACK           = :NUMDRAWBACK, " + "\n"; }
            if (modelo.dtnftransf != null) { comando2 = comando2 + "  DTNFTRANSF            = :DTNFTRANSF, " + "\n"; }
            if (modelo.rotinalanc != null) { comando2 = comando2 + "  ROTINALANC            = :ROTINALANC, " + "\n"; }
            if (modelo.numpedorigem != null) { comando2 = comando2 + "  NUMPEDORIGEM          = :NUMPEDORIGEM, " + "\n"; }
            if (modelo.pedduplicado != null) { comando2 = comando2 + "  PEDDUPLICADO          = :PEDDUPLICADO, " + "\n"; }
            if (modelo.vlbonific != null) { comando2 = comando2 + "  VLBONIFIC             = :VLBONIFIC, " + "\n"; }
            if (modelo.vendalocestrang != null) { comando2 = comando2 + "  VENDALOCESTRANG       = :VENDALOCESTRANG, " + "\n"; }
            if (modelo.copiaidenticapeddup != null) { comando2 = comando2 + "  COPIAIDENTICAPEDDUP   = :COPIAIDENTICAPEDDUP, " + "\n"; }
            if (modelo.assinatura != null) { comando2 = comando2 + "  ASSINATURA            = :ASSINATURA, " + "\n"; }
            if (modelo.planosuppli != null) { comando2 = comando2 + "  PLANOSUPPLI           = :PLANOSUPPLI, " + "\n"; }
            if (modelo.pagchequemoradia != null) { comando2 = comando2 + "  PAGCHEQUEMORADIA      = :PAGCHEQUEMORADIA, " + "\n"; }
            comando2 = comando2 + "           NUMVOLUME                    = :NUMVOLUME " + "\n";
            comando2 = comando2 + "            " + "\n";
            comando2 = comando2 + "     WHERE NUMPED = :OLD_NUMPED";
            cmd.CommandText = comando2;
            if (modelo.numped != null) { cmd.Parameters.AddWithValue(":OLD_NUMPED", modelo.numped); }
            if (modelo.numped != null) { cmd.Parameters.AddWithValue(":NUMPED", modelo.numped); }
            if (modelo.data != null) { cmd.Parameters.AddWithValue(":DATA", modelo.data); }
            if (modelo.codusur != null) { cmd.Parameters.AddWithValue(":CODUSUR", modelo.codusur); }
            if (modelo.codcli != null) { cmd.Parameters.AddWithValue(":CODCLI", modelo.codcli); }
            if (modelo.numitens != null) { cmd.Parameters.AddWithValue(":NUMITENS", modelo.numitens); }
            if (modelo.vlatend != null) { cmd.Parameters.AddWithValue(":VLATEND", modelo.vlatend); }
            if (modelo.codpraca != null) { cmd.Parameters.AddWithValue(":CODPRACA", modelo.codpraca); }
            if (modelo.posicao != null) { cmd.Parameters.AddWithValue(":POSICAO", modelo.posicao); }
            if (modelo.numcar != null) { cmd.Parameters.AddWithValue(":NUMCAR", modelo.numcar); }
            if (modelo.codsupervisor != null) { cmd.Parameters.AddWithValue(":CODSUPERVISOR", modelo.codsupervisor); }
            if (modelo.codfilial != null) { cmd.Parameters.AddWithValue(":CODFILIAL", modelo.codfilial); }
            if (modelo.vltotal != null) { cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal); }
            if (modelo.vltabela != null) { cmd.Parameters.AddWithValue(":VLTABELA", modelo.vltabela); }
            if (modelo.vlcustoreal != null) { cmd.Parameters.AddWithValue(":VLCUSTOREAL", modelo.vlcustoreal); }
            if (modelo.vlcustofin != null) { cmd.Parameters.AddWithValue(":VLCUSTOFIN", modelo.vlcustofin); }
            if (modelo.totpeso != null) { cmd.Parameters.AddWithValue(":TOTPESO", modelo.totpeso); }
            if (modelo.totvolume != null) { cmd.Parameters.AddWithValue(":TOTVOLUME", modelo.totvolume); }
            if (modelo.codemitente != null) { cmd.Parameters.AddWithValue(":CODEMITENTE", modelo.codemitente); }
            if (modelo.operacao != null) { cmd.Parameters.AddWithValue(":OPERACAO", modelo.operacao); }
            if (modelo.tipovenda != null) { cmd.Parameters.AddWithValue(":TIPOVENDA", modelo.tipovenda); }
            if (modelo.obs != null) { cmd.Parameters.AddWithValue(":OBS", modelo.obs); }
            if (modelo.codcob != null) { cmd.Parameters.AddWithValue(":CODCOB", modelo.codcob); }
            if (modelo.hora != null) { cmd.Parameters.AddWithValue(":HORA", modelo.hora); }
            if (modelo.minuto != null) { cmd.Parameters.AddWithValue(":MINUTO", modelo.minuto); }
            if (modelo.codplpag != null) { cmd.Parameters.AddWithValue(":CODPLPAG", modelo.codplpag); }
            if (modelo.numpedcli != null) { cmd.Parameters.AddWithValue(":NUMPEDCLI", modelo.numpedcli); }
            if (modelo.percvenda != null) { cmd.Parameters.AddWithValue(":PERCVENDA", modelo.percvenda); }
            if (modelo.perdesc != null) { cmd.Parameters.AddWithValue(":PERDESC", modelo.perdesc); }
            if (modelo.vldesconto != null) { cmd.Parameters.AddWithValue(":VLDESCONTO", modelo.vldesconto); }
            if (modelo.vlfrete != null) { cmd.Parameters.AddWithValue(":VLFRETE", modelo.vlfrete); }
            if (modelo.vloutrasdesp != null) { cmd.Parameters.AddWithValue(":VLOUTRASDESP", modelo.vloutrasdesp); }
            if (modelo.obs1 != null) { cmd.Parameters.AddWithValue(":OBS1", modelo.obs1); }
            if (modelo.obs2 != null) { cmd.Parameters.AddWithValue(":OBS2", modelo.obs2); }
            if (modelo.condvenda != null) { cmd.Parameters.AddWithValue(":CONDVENDA", modelo.condvenda); }
            if (modelo.dtentrega != null) { cmd.Parameters.AddWithValue(":DTENTREGA", modelo.dtentrega); }
            if (modelo.numpedrca != null) { cmd.Parameters.AddWithValue(":NUMPEDRCA", modelo.numpedrca); }
            if (modelo.fretedespacho != null) { cmd.Parameters.AddWithValue(":FRETEDESPACHO", modelo.fretedespacho); }
            if (modelo.freteredespacho != null) { cmd.Parameters.AddWithValue(":FRETEREDESPACHO", modelo.freteredespacho); }
            if (modelo.codfornecfrete != null) { cmd.Parameters.AddWithValue(":CODFORNECFRETE", modelo.codfornecfrete); }
            if (modelo.codfornecredespacho != null) { cmd.Parameters.AddWithValue(":CODFORNECREDESPACHO", modelo.codfornecredespacho); }
            if (modelo.tipocarga != null) { cmd.Parameters.AddWithValue(":TIPOCARGA", modelo.tipocarga); }
            if (modelo.prazo1 != null) { cmd.Parameters.AddWithValue(":PRAZO1", modelo.prazo1); }
            if (modelo.prazo2 != null) { cmd.Parameters.AddWithValue(":PRAZO2", modelo.prazo2); }
            if (modelo.prazo3 != null) { cmd.Parameters.AddWithValue(":PRAZO3", modelo.prazo3); }
            if (modelo.prazo4 != null) { cmd.Parameters.AddWithValue(":PRAZO4", modelo.prazo4); }
            if (modelo.prazo5 != null) { cmd.Parameters.AddWithValue(":PRAZO5", modelo.prazo5); }
            if (modelo.prazo6 != null) { cmd.Parameters.AddWithValue(":PRAZO6", modelo.prazo6); }
            if (modelo.prazo7 != null) { cmd.Parameters.AddWithValue(":PRAZO7", modelo.prazo7); }
            if (modelo.prazo8 != null) { cmd.Parameters.AddWithValue(":PRAZO8", modelo.prazo8); }
            if (modelo.prazo9 != null) { cmd.Parameters.AddWithValue(":PRAZO9", modelo.prazo9); }
            if (modelo.prazo10 != null) { cmd.Parameters.AddWithValue(":PRAZO10", modelo.prazo10); }
            if (modelo.prazo11 != null) { cmd.Parameters.AddWithValue(":PRAZO11", modelo.prazo11); }
            if (modelo.prazo12 != null) { cmd.Parameters.AddWithValue(":PRAZO12", modelo.prazo12); }
            if (modelo.prazomedio != null) { cmd.Parameters.AddWithValue(":PRAZOMEDIO", modelo.prazomedio); }
            if (modelo.obsentrega1 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA1", modelo.obsentrega1); }
            if (modelo.obsentrega2 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA2", modelo.obsentrega2); }
            if (modelo.obsentrega3 != null) { cmd.Parameters.AddWithValue(":OBSENTREGA3", modelo.obsentrega3); }
            if (modelo.tipoembalagem != null) { cmd.Parameters.AddWithValue(":TIPOEMBALAGEM", modelo.tipoembalagem); }
            if (modelo.codepto != null) { cmd.Parameters.AddWithValue(":CODEPTO", modelo.codepto); }
            if (modelo.campanha != null) { cmd.Parameters.AddWithValue(":CAMPANHA", modelo.campanha); }
            if (modelo.coddistrib != null) { cmd.Parameters.AddWithValue(":CODDISTRIB", modelo.coddistrib); }
            if (modelo.vlcustocont != null) { cmd.Parameters.AddWithValue(":VLCUSTOCONT", modelo.vlcustocont); }
            if (modelo.vlcustorep != null) { cmd.Parameters.AddWithValue(":VLCUSTOREP", modelo.vlcustorep); }
            if (modelo.numnotamanif != null) { cmd.Parameters.AddWithValue(":NUMNOTAMANIF", modelo.numnotamanif); }
            if (modelo.seriemanif != null) { cmd.Parameters.AddWithValue(":SERIEMANIF", modelo.seriemanif); }
            if (modelo.origemped != null) { cmd.Parameters.AddWithValue(":ORIGEMPED", modelo.origemped); }
            if (modelo.especiemanif != null) { cmd.Parameters.AddWithValue(":ESPECIEMANIF", modelo.especiemanif); }
            if (modelo.numpedentfut != null) { cmd.Parameters.AddWithValue(":NUMPEDENTFUT", modelo.numpedentfut); }
            if (modelo.codfilialnf != null) { cmd.Parameters.AddWithValue(":CODFILIALNF", modelo.codfilialnf); }
            if (modelo.numcarmanif != null) { cmd.Parameters.AddWithValue(":NUMCARMANIF", modelo.numcarmanif); }
            if (modelo.numorca != null) { cmd.Parameters.AddWithValue(":NUMORCA", modelo.numorca); }
            if (modelo.codcontrato != null) { cmd.Parameters.AddWithValue(":CODCONTRATO", modelo.codcontrato); }
            if (modelo.datapedcli != null) { cmd.Parameters.AddWithValue(":DATAPEDCLI", modelo.datapedcli); }
            if (modelo.numpedbnf != null) { cmd.Parameters.AddWithValue(":NUMPEDBNF", modelo.numpedbnf); }
            if (modelo.broker != null) { cmd.Parameters.AddWithValue(":BROKER", modelo.broker); }
            if (modelo.codestabelecimento != null) { cmd.Parameters.AddWithValue(":CODESTABELECIMENTO", modelo.codestabelecimento); }
            if (modelo.numtabela != null) { cmd.Parameters.AddWithValue(":NUMTABELA", modelo.numtabela); }
            if (modelo.motivoposicao != null) { cmd.Parameters.AddWithValue(":MOTIVOPOSICAO", modelo.motivoposicao); }
            if (modelo.dtagendaentrega != null) { cmd.Parameters.AddWithValue(":DTAGENDAENTREGA", modelo.dtagendaentrega); }
            if (modelo.tipooper != null) { cmd.Parameters.AddWithValue(":TIPOOPER", modelo.tipooper); }
            if (modelo.codmotbloqueio != null) { cmd.Parameters.AddWithValue(":CODMOTBLOQUEIO", modelo.codmotbloqueio); }
            if (modelo.serieecf != null) { cmd.Parameters.AddWithValue(":SERIEECF", modelo.serieecf); }
            if (modelo.numcupom != null) { cmd.Parameters.AddWithValue(":NUMCUPOM", modelo.numcupom); }
            if (modelo.codclirecebedor != null) { cmd.Parameters.AddWithValue(":CODCLIRECEBEDOR", modelo.codclirecebedor); }
            if (modelo.conciliaimportacao != null) { cmd.Parameters.AddWithValue(":CONCILIAIMPORTACAO", modelo.conciliaimportacao); }
            if (modelo.numregiao != null) { cmd.Parameters.AddWithValue(":NUMREGIAO", modelo.numregiao); }
            if (modelo.numnota != null) { cmd.Parameters.AddWithValue(":NUMNOTA", modelo.numnota); }
            if (modelo.perdescfin != null) { cmd.Parameters.AddWithValue(":PERDESCFIN", modelo.perdescfin); }
            if (modelo.restricaotransp != null) { cmd.Parameters.AddWithValue(":RESTRICAOTRANSP", modelo.restricaotransp); }
            if (modelo.geracp != null) { cmd.Parameters.AddWithValue(":GERACP", modelo.geracp); }
            if (modelo.usaintegracaowms != null) { cmd.Parameters.AddWithValue(":USAINTEGRACAOWMS", modelo.usaintegracaowms); }
            if (modelo.vendaassistida != null) { cmd.Parameters.AddWithValue(":VENDAASSISTIDA", modelo.vendaassistida); }
            if (modelo.codmotivo != null) { cmd.Parameters.AddWithValue(":CODMOTIVO", modelo.codmotivo); }
            if (modelo.log != null) { cmd.Parameters.AddWithValue(":LOG", modelo.log); }
            if (modelo.dtcalcfrete != null) { cmd.Parameters.AddWithValue(":DTCALCFRETE", modelo.dtcalcfrete); }
            if (modelo.codfunccalcfrete != null) { cmd.Parameters.AddWithValue(":CODFUNCCALCFRETE", modelo.codfunccalcfrete); }
            if (modelo.eancobranca != null) { cmd.Parameters.AddWithValue(":EANCOBRANCA", modelo.eancobranca); }
            if (modelo.eanentrega != null) { cmd.Parameters.AddWithValue(":EANENTREGA", modelo.eanentrega); }
            if (modelo.usacfopvendanatv10 != null) { cmd.Parameters.AddWithValue(":USACFOPVENDANATV10", modelo.usacfopvendanatv10); }
            if (modelo.tipoprioridadeentrega != null) { cmd.Parameters.AddWithValue(":TIPOPRIORIDADEENTREGA", modelo.tipoprioridadeentrega); }
            if (modelo.codusur2 != null) { cmd.Parameters.AddWithValue(":CODUSUR2", modelo.codusur2); }
            if (modelo.codusur3 != null) { cmd.Parameters.AddWithValue(":CODUSUR3", modelo.codusur3); }
            if (modelo.codusur4 != null) { cmd.Parameters.AddWithValue(":CODUSUR4", modelo.codusur4); }
            if (modelo.codclinf != null) { cmd.Parameters.AddWithValue(":CODCLINF", modelo.codclinf); }
            if (modelo.numpedtv1 != null) { cmd.Parameters.AddWithValue(":NUMPEDTV1", modelo.numpedtv1); }
            if (modelo.usadebcredrca != null) { cmd.Parameters.AddWithValue(":USADEBCREDRCA", modelo.usadebcredrca); }
            if (modelo.brinde != null) { cmd.Parameters.AddWithValue(":BRINDE", modelo.brinde); }
            if (modelo.bonificaltdebcredrca != null) { cmd.Parameters.AddWithValue(":BONIFICALTDEBCREDRCA", modelo.bonificaltdebcredrca); }
            if (modelo.trocaaltdebcredrca != null) { cmd.Parameters.AddWithValue(":TROCAALTDEBCREDRCA", modelo.trocaaltdebcredrca); }
            if (modelo.brokeraltdebcredrca != null) { cmd.Parameters.AddWithValue(":BROKERALTDEBCREDRCA", modelo.brokeraltdebcredrca); }
            if (modelo.crmaltdebcredrca != null) { cmd.Parameters.AddWithValue(":CRMALTDEBCREDRCA", modelo.crmaltdebcredrca); }
            if (modelo.tipomovccrca != null) { cmd.Parameters.AddWithValue(":TIPOMOVCCRCA", modelo.tipomovccrca); }
            if (modelo.usacredrca != null) { cmd.Parameters.AddWithValue(":USACREDRCA", modelo.usacredrca); }
            if (modelo.gerardadosnfpaulista != null) { cmd.Parameters.AddWithValue(":GERARDADOSNFPAULISTA", modelo.gerardadosnfpaulista); }
            if (modelo.usasaldocontacorrentedescfin != null) { cmd.Parameters.AddWithValue(":USASALDOCONTACORRENTEDESCFIN", modelo.usasaldocontacorrentedescfin); }
            if (modelo.valordescfin != null) { cmd.Parameters.AddWithValue(":VALORDESCFIN", modelo.valordescfin); }
            if (modelo.codvisita != null) { cmd.Parameters.AddWithValue(":CODVISITA", modelo.codvisita); }
            if (modelo.codatendimento != null) { cmd.Parameters.AddWithValue(":CODATENDIMENTO", modelo.codatendimento); }
            if (modelo.vendatriangular != null) { cmd.Parameters.AddWithValue(":VENDATRIANGULAR", modelo.vendatriangular); }
            if (modelo.vlentrada != null) { cmd.Parameters.AddWithValue(":VLENTRADA", modelo.vlentrada); }
            if (modelo.ufdesembaraco != null) { cmd.Parameters.AddWithValue(":UFDESEMBARACO", modelo.ufdesembaraco); }
            if (modelo.localdesembaraco != null) { cmd.Parameters.AddWithValue(":LOCALDESEMBARACO", modelo.localdesembaraco); }
            if (modelo.custobonificacao != null) { cmd.Parameters.AddWithValue(":CUSTOBONIFICACAO", modelo.custobonificacao); }
            if (modelo.codfornecbonific != null) { cmd.Parameters.AddWithValue(":CODFORNECBONIFIC", modelo.codfornecbonific); }
            if (modelo.codbnf != null) { cmd.Parameters.AddWithValue(":CODBNF", modelo.codbnf); }
            if (modelo.tipodocumento != null) { cmd.Parameters.AddWithValue(":TIPODOCUMENTO", modelo.tipodocumento); }
            if (modelo.cfopbnfdegusta != null) { cmd.Parameters.AddWithValue(":CFOPBNFDEGUSTA", modelo.cfopbnfdegusta); }
            if (modelo.contaordem != null) { cmd.Parameters.AddWithValue(":CONTAORDEM", modelo.contaordem); }
            if (modelo.dataempenho != null) { cmd.Parameters.AddWithValue(":DATAEMPENHO", modelo.dataempenho); }
            if (modelo.numempenho != null) { cmd.Parameters.AddWithValue(":NUMEMPENHO", modelo.numempenho); }
            if (modelo.codunidadeexecutora != null) { cmd.Parameters.AddWithValue(":CODUNIDADEEXECUTORA", modelo.codunidadeexecutora); }
            if (modelo.placaveiculo != null) { cmd.Parameters.AddWithValue(":PLACAVEICULO", modelo.placaveiculo); }
            if (modelo.dtlimitefat != null) { cmd.Parameters.AddWithValue(":DTLIMITEFAT", modelo.dtlimitefat); }
            if (modelo.reservaestoquetv7 != null) { cmd.Parameters.AddWithValue(":RESERVAESTOQUETV7", modelo.reservaestoquetv7); }
            if (modelo.fornecentrega != null) { cmd.Parameters.AddWithValue(":FORNECENTREGA", modelo.fornecentrega); }
            if (modelo.codclitv8 != null) { cmd.Parameters.AddWithValue(":CODCLITV8", modelo.codclitv8); }
            if (modelo.ufveiculo != null) { cmd.Parameters.AddWithValue(":UFVEICULO", modelo.ufveiculo); }
            if (modelo.motoristaveiculo != null) { cmd.Parameters.AddWithValue(":MOTORISTAVEICULO", modelo.motoristaveiculo); }
            if (modelo.dtiniciodigitacaopedido != null) { cmd.Parameters.AddWithValue(":DTINICIODIGITACAOPEDIDO", modelo.dtiniciodigitacaopedido); }
            if (modelo.dtfimdigitacaopedido != null) { cmd.Parameters.AddWithValue(":DTFIMDIGITACAOPEDIDO", modelo.dtfimdigitacaopedido); }
            if (modelo.vldescabatimento != null) { cmd.Parameters.AddWithValue(":VLDESCABATIMENTO", modelo.vldescabatimento); }
            if (modelo.agrupamento != null) { cmd.Parameters.AddWithValue(":AGRUPAMENTO", modelo.agrupamento); }
            if (modelo.vendaexportacao != null) { cmd.Parameters.AddWithValue(":VENDAEXPORTACAO", modelo.vendaexportacao); }
            if (modelo.turnoentrega != null) { cmd.Parameters.AddWithValue(":TURNOENTREGA", modelo.turnoentrega); }
            if (modelo.numtransvendatv13 != null) { cmd.Parameters.AddWithValue(":NUMTRANSVENDATV13", modelo.numtransvendatv13); }
            if (modelo.codendentcli != null) { cmd.Parameters.AddWithValue(":CODENDENTCLI", modelo.codendentcli); }
            if (modelo.utilizavendaporembalagem != null) { cmd.Parameters.AddWithValue(":UTILIZAVENDAPOREMBALAGEM", modelo.utilizavendaporembalagem); }
            if (modelo.codcontato != null) { cmd.Parameters.AddWithValue(":CODCONTATO", modelo.codcontato); }
            if (modelo.numregexp != null) { cmd.Parameters.AddWithValue(":NUMREGEXP", modelo.numregexp); }
            if (modelo.numchaveexp != null) { cmd.Parameters.AddWithValue(":NUMCHAVEEXP", modelo.numchaveexp); }
            if (modelo.numdrawback != null) { cmd.Parameters.AddWithValue(":NUMDRAWBACK", modelo.numdrawback); }
            if (modelo.dtnftransf != null) { cmd.Parameters.AddWithValue(":DTNFTRANSF", modelo.dtnftransf); }
            if (modelo.rotinalanc != null) { cmd.Parameters.AddWithValue(":ROTINALANC", modelo.rotinalanc); }
            if (modelo.numpedorigem != null) { cmd.Parameters.AddWithValue(":NUMPEDORIGEM", modelo.numpedorigem); }
            if (modelo.pedduplicado != null) { cmd.Parameters.AddWithValue(":PEDDUPLICADO", modelo.pedduplicado); }
            if (modelo.vlbonific != null) { cmd.Parameters.AddWithValue(":VLBONIFIC", modelo.vlbonific); }
            if (modelo.vendalocestrang != null) { cmd.Parameters.AddWithValue(":VENDALOCESTRANG", modelo.vendalocestrang); }
            if (modelo.copiaidenticapeddup != null) { cmd.Parameters.AddWithValue(":COPIAIDENTICAPEDDUP", modelo.copiaidenticapeddup); }
            if (modelo.assinatura != null) { cmd.Parameters.AddWithValue(":ASSINATURA", modelo.assinatura); }
            if (modelo.condfinanc != null) { cmd.Parameters.AddWithValue(":CONDFINANC", modelo.condfinanc); }
            if (modelo.planosuppli != null) { cmd.Parameters.AddWithValue(":PLANOSUPPLI", modelo.planosuppli); }
            if (modelo.pagchequemoradia != null) { cmd.Parameters.AddWithValue(":PAGCHEQUEMORADIA", modelo.pagchequemoradia); }
            cmd.Parameters.AddWithValue(":NUMVOLUME", modelo.numvolume);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void AlterarPC(ModeloPCPEDC modelo)
        {
            String comando4 = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando4 = comando4 + "UPDATE PCPEDC " + "\n";
            comando4 = comando4 + "       SET VLTOTAL                      = :VLTOTAL, " + "\n";
            comando4 = comando4 + "           VLTABELA                     = :VLTABELA, " + "\n";
            comando4 = comando4 + "           VLCUSTOREAL                  = :VLCUSTOREAL " + "\n";
            comando4 = comando4 + "           VLCUSTOFIN                  = :VLCUSTOFIN " + "\n";
            comando4 = comando4 + "           VLATEND                  = :VLATEND " + "\n";
            comando4 = comando4 + "           VLCUSTOREP                  = :VLCUSTOREP " + "\n";
            comando4 = comando4 + "           VLCUSTOCONT                  = :VLCUSTOCONT " + "\n";
            comando4 = comando4 + "            " + "\n";
            comando4 = comando4 + "     WHERE NUMPED = :OLD_NUMPED";
            cmd.CommandText = comando4;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue(":OLD_NUMPED", modelo.numped);
            cmd.Parameters.AddWithValue(":VLTOTAL", modelo.vltotal);
            cmd.Parameters.AddWithValue(":VLTABELA", modelo.vltotal);
            cmd.Parameters.AddWithValue(":VLCUSTOREAL", modelo.vlcustoreal);
            cmd.Parameters.AddWithValue(":VLCUSTOFIN", modelo.vlcustofin);
            cmd.Parameters.AddWithValue(":VLATEND", modelo.vlatend);
            cmd.Parameters.AddWithValue(":VLCUSTOREP", modelo.vlcustorep);
            cmd.Parameters.AddWithValue(":VLCUSTOCONT", modelo.vlcustocont);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        public ModeloPCPEDC CarregaModeloPCPEDC(long codigo)
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
            if (registro.HasRows)
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
