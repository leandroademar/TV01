using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPCPEDC
    {
       
        public ModeloPCPEDC()
        {
      
            this.numvolume = 1;

        }
        

        private long _numped;
        private DateTime _data;
        private short _codusur;
        private int _codcli;
        private short? _numitens;
        private decimal? _vlatend;
        private short _codpraca;
        private string _posicao;
        private int? _numcar;
        private short _codsupervisor;
        private string _codfilial;
        private decimal? _vltotal;
        private decimal? _vltabela;
        private double? _vlcustoreal;
        private double? _vlcustofin;
        private decimal? _totpeso;
        private decimal? _totvolume;
        private int? _codemitente;
        private string _operacao;
        private string _tipovenda;
        private string _obs;
        private string _codcob;
        private short? _hora;
        private short? _minuto;
        private short _codplpag;
        private string _numpedcli;
        private float? _percvenda;
        private decimal? _perdesc;
        private decimal? _vldesconto;
        private decimal? _vlfrete;
        private decimal? _vloutrasdesp;
        private string _obs1;
        private string _obs2;
        private int? _condvenda;
        private DateTime? _dtentrega;
        private long? _numpedrca;
        private string _fretedespacho;
        private string _freteredespacho;
        private int? _codfornecfrete;
        private int? _codfornecredespacho;
        private string _tipocarga;
        private short? _prazo1;
        private short? _prazo2;
        private short? _prazo3;
        private short? _prazo4;
        private short? _prazo5;
        private short? _prazo6;
        private short? _prazo7;
        private short? _prazo8;
        private short? _prazo9;
        private short? _prazo10;
        private short? _prazo11;
        private short? _prazo12;
        private short? _prazomedio;
        private string _obsentrega1;
        private string _obsentrega2;
        private string _obsentrega3;
        private string _tipoembalagem;
        private int? _codepto;
        private string _campanha;
        private string _coddistrib;
        private double? _vlcustocont;
        private double? _vlcustorep;
        private long? _numnotamanif;
        private string _seriemanif;
        private string _origemped;
        private string _especiemanif;
        private long? _numpedentfut;
        private string _codfilialnf;
        private int? _numcarmanif;
        private long? _numorca;
        private int? _codcontrato;
        private DateTime? _datapedcli;
        private long? _numpedbnf;
        private string _broker;
        private string _codestabelecimento;
        private string _numtabela;
        private string _motivoposicao;
        private DateTime? _dtagendaentrega;
        private string _tipooper;
        private int? _codmotbloqueio;
        private string _serieecf;
        private long? _numcupom;
        private int? _codclirecebedor;
        private string _conciliaimportacao;
        private short? _numregiao;
        private long? _numnota;
        private double? _perdescfin;
        private string _restricaotransp;
        private string _geracp;
        private string _usaintegracaowms;
        private string _vendaassistida;
        private int? _codmotivo;
        private string _log;
        private DateTime? _dtcalcfrete;
        private int? _codfunccalcfrete;
        private long? _eancobranca;
        private long? _eanentrega;
        private string _usacfopvendanatv10;
        private string _tipoprioridadeentrega;
        private int? _codusur2;
        private int? _codusur3;
        private int? _codusur4;
        private int? _codclinf;
        private long? _numpedtv1;
        private string _usadebcredrca;
        private string _brinde;
        private string _bonificaltdebcredrca;
        private string _trocaaltdebcredrca;
        private string _brokeraltdebcredrca;
        private string _crmaltdebcredrca;
        private string _tipomovccrca;
        private string _usacredrca;
        private string _gerardadosnfpaulista;
        private string _usasaldocontacorrentedescfin;
        private decimal? _valordescfin;
        private long? _codvisita;
        private int? _codatendimento;
        private string _vendatriangular;
        private decimal? _vlentrada;
        private string _ufdesembaraco;
        private string _localdesembaraco;
        private string _custobonificacao;
        private int? _codfornecbonific;
        private short? _codbnf;
        private string _tipodocumento;
        private int? _cfopbnfdegusta;
        private string _contaordem;
        private DateTime? _dataempenho;
        private string _numempenho;
        private string _codunidadeexecutora;
        private string _placaveiculo;
        private DateTime? _dtlimitefat;
        private string _reservaestoquetv7;
        private string _fornecentrega;
        private int? _codclitv8;
        private string _ufveiculo;
        private string _motoristaveiculo;
        private DateTime? _dtiniciodigitacaopedido;
        private DateTime? _dtfimdigitacaopedido;
        private decimal? _vldescabatimento;
        private string _agrupamento;
        private string _vendaexportacao;
        private string _turnoentrega;
        private long? _numtransvendatv13;
        private int? _codendentcli;
        private string _utilizavendaporembalagem;
        private int? _codcontato;
        private long? _numregexp;
        private string _numchaveexp;
        private long? _numdrawback;
        private DateTime? _dtnftransf;
        private string _rotinalanc;
        private long? _numpedorigem;
        private string _pedduplicado;
        private decimal? _vlbonific;
        private string _vendalocestrang;
        private string _copiaidenticapeddup;
        private string _assinatura;
        private string _idparceiro;
        private long? _uidregistro;
        private string _condfinanc;
        private short? _planosuppli;
        private string _pagchequemoradia;
        private int? _numvolume;
        public long numped
        {
            get
            {
                return this._numped;
            }
            set
            {
                this._numped = value;
            }
        }
        public DateTime data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        public short codusur
        {
            get
            {
                return this._codusur;
            }
            set
            {
                this._codusur = value;
            }
        }
        public int codcli
        {
            get
            {
                return this._codcli;
            }
            set
            {
                this._codcli = value;
            }
        }
        public short? numitens
        {
            get
            {
                return this._numitens;
            }
            set
            {
                this._numitens = value;
            }
        }
        public decimal? vlatend
        {
            get
            {
                return this._vlatend;
            }
            set
            {
                this._vlatend = value;
            }
        }
        public short codpraca
        {
            get
            {
                return this._codpraca;
            }
            set
            {
                this._codpraca = value;
            }
        }
        public string posicao
        {
            get
            {
                return this._posicao;
            }
            set
            {
                this._posicao = value;
            }
        }
        public int? numcar
        {
            get
            {
                return this._numcar;
            }
            set
            {
                this._numcar = value;
            }
        }
        public short codsupervisor
        {
            get
            {
                return this._codsupervisor;
            }
            set
            {
                this._codsupervisor = value;
            }
        }
        public string codfilial
        {
            get
            {
                return this._codfilial;
            }
            set
            {
                this._codfilial = value;
            }
        }
        public decimal? vltotal
        {
            get
            {
                return this._vltotal;
            }
            set
            {
                this._vltotal = value;
            }
        }
        public decimal? vltabela
        {
            get
            {
                return this._vltabela;
            }
            set
            {
                this._vltabela = value;
            }
        }
        public double? vlcustoreal
        {
            get
            {
                return this._vlcustoreal;
            }
            set
            {
                this._vlcustoreal = value;
            }
        }
        public double? vlcustofin
        {
            get
            {
                return this._vlcustofin;
            }
            set
            {
                this._vlcustofin = value;
            }
        }
        public decimal? totpeso
        {
            get
            {
                return this._totpeso;
            }
            set
            {
                this._totpeso = value;
            }
        }
        public decimal? totvolume
        {
            get
            {
                return this._totvolume;
            }
            set
            {
                this._totvolume = value;
            }
        }
        public int? codemitente
        {
            get
            {
                return this._codemitente;
            }
            set
            {
                this._codemitente = value;
            }
        }
        public string operacao
        {
            get
            {
                return this._operacao;
            }
            set
            {
                this._operacao = value;
            }
        }
        public string tipovenda
        {
            get
            {
                return this._tipovenda;
            }
            set
            {
                this._tipovenda = value;
            }
        }
        public string obs
        {
            get
            {
                return this._obs;
            }
            set
            {
                this._obs = value;
            }
        }
        public string codcob
        {
            get
            {
                return this._codcob;
            }
            set
            {
                this._codcob = value;
            }
        }
        public short? hora
        {
            get
            {
                return this._hora;
            }
            set
            {
                this._hora = value;
            }
        }
        public short? minuto
        {
            get
            {
                return this._minuto;
            }
            set
            {
                this._minuto = value;
            }
        }
        public short codplpag
        {
            get
            {
                return this._codplpag;
            }
            set
            {
                this._codplpag = value;
            }
        }
        public string numpedcli
        {
            get
            {
                return this._numpedcli;
            }
            set
            {
                this._numpedcli = value;
            }
        }
        public float? percvenda
        {
            get
            {
                return this._percvenda;
            }
            set
            {
                this._percvenda = value;
            }
        }
        public decimal? perdesc
        {
            get
            {
                return this._perdesc;
            }
            set
            {
                this._perdesc = value;
            }
        }
        public decimal? vldesconto
        {
            get
            {
                return this._vldesconto;
            }
            set
            {
                this._vldesconto = value;
            }
        }
        public decimal? vlfrete
        {
            get
            {
                return this._vlfrete;
            }
            set
            {
                this._vlfrete = value;
            }
        }
        public decimal? vloutrasdesp
        {
            get
            {
                return this._vloutrasdesp;
            }
            set
            {
                this._vloutrasdesp = value;
            }
        }
        public string obs1
        {
            get
            {
                return this._obs1;
            }
            set
            {
                this._obs1 = value;
            }
        }
        public string obs2
        {
            get
            {
                return this._obs2;
            }
            set
            {
                this._obs2 = value;
            }
        }
        public int? condvenda
        {
            get
            {
                return this._condvenda;
            }
            set
            {
                this._condvenda = value;
            }
        }
        public DateTime? dtentrega
        {
            get
            {
                return this._dtentrega;
            }
            set
            {
                this._dtentrega = value;
            }
        }
        public long? numpedrca
        {
            get
            {
                return this._numpedrca;
            }
            set
            {
                this._numpedrca = value;
            }
        }
        public string fretedespacho
        {
            get
            {
                return this._fretedespacho;
            }
            set
            {
                this._fretedespacho = value;
            }
        }
        public string freteredespacho
        {
            get
            {
                return this._freteredespacho;
            }
            set
            {
                this._freteredespacho = value;
            }
        }
        public int? codfornecfrete
        {
            get
            {
                return this._codfornecfrete;
            }
            set
            {
                this._codfornecfrete = value;
            }
        }
        public int? codfornecredespacho
        {
            get
            {
                return this._codfornecredespacho;
            }
            set
            {
                this._codfornecredespacho = value;
            }
        }
        public string tipocarga
        {
            get
            {
                return this._tipocarga;
            }
            set
            {
                this._tipocarga = value;
            }
        }
        public short? prazo1
        {
            get
            {
                return this._prazo1;
            }
            set
            {
                this._prazo1 = value;
            }
        }
        public short? prazo2
        {
            get
            {
                return this._prazo2;
            }
            set
            {
                this._prazo2 = value;
            }
        }
        public short? prazo3
        {
            get
            {
                return this._prazo3;
            }
            set
            {
                this._prazo3 = value;
            }
        }
        public short? prazo4
        {
            get
            {
                return this._prazo4;
            }
            set
            {
                this._prazo4 = value;
            }
        }
        public short? prazo5
        {
            get
            {
                return this._prazo5;
            }
            set
            {
                this._prazo5 = value;
            }
        }
        public short? prazo6
        {
            get
            {
                return this._prazo6;
            }
            set
            {
                this._prazo6 = value;
            }
        }
        public short? prazo7
        {
            get
            {
                return this._prazo7;
            }
            set
            {
                this._prazo7 = value;
            }
        }
        public short? prazo8
        {
            get
            {
                return this._prazo8;
            }
            set
            {
                this._prazo8 = value;
            }
        }
        public short? prazo9
        {
            get
            {
                return this._prazo9;
            }
            set
            {
                this._prazo9 = value;
            }
        }
        public short? prazo10
        {
            get
            {
                return this._prazo10;
            }
            set
            {
                this._prazo10 = value;
            }
        }
        public short? prazo11
        {
            get
            {
                return this._prazo11;
            }
            set
            {
                this._prazo11 = value;
            }
        }
        public short? prazo12
        {
            get
            {
                return this._prazo12;
            }
            set
            {
                this._prazo12 = value;
            }
        }
        public short? prazomedio
        {
            get
            {
                return this._prazomedio;
            }
            set
            {
                this._prazomedio = value;
            }
        }
        public string obsentrega1
        {
            get
            {
                return this._obsentrega1;
            }
            set
            {
                this._obsentrega1 = value;
            }
        }
        public string obsentrega2
        {
            get
            {
                return this._obsentrega2;
            }
            set
            {
                this._obsentrega2 = value;
            }
        }
        public string obsentrega3
        {
            get
            {
                return this._obsentrega3;
            }
            set
            {
                this._obsentrega3 = value;
            }
        }
        public string tipoembalagem
        {
            get
            {
                return this._tipoembalagem;
            }
            set
            {
                this._tipoembalagem = value;
            }
        }
        public int? codepto
        {
            get
            {
                return this._codepto;
            }
            set
            {
                this._codepto = value;
            }
        }
        public string campanha
        {
            get
            {
                return this._campanha;
            }
            set
            {
                this._campanha = value;
            }
        }
        public string coddistrib
        {
            get
            {
                return this._coddistrib;
            }
            set
            {
                this._coddistrib = value;
            }
        }
        public double? vlcustocont
        {
            get
            {
                return this._vlcustocont;
            }
            set
            {
                this._vlcustocont = value;
            }
        }
        public double? vlcustorep
        {
            get
            {
                return this._vlcustorep;
            }
            set
            {
                this._vlcustorep = value;
            }
        }
        public long? numnotamanif
        {
            get
            {
                return this._numnotamanif;
            }
            set
            {
                this._numnotamanif = value;
            }
        }
        public string seriemanif
        {
            get
            {
                return this._seriemanif;
            }
            set
            {
                this._seriemanif = value;
            }
        }
        public string origemped
        {
            get
            {
                return this._origemped;
            }
            set
            {
                this._origemped = value;
            }
        }
        public string especiemanif
        {
            get
            {
                return this._especiemanif;
            }
            set
            {
                this._especiemanif = value;
            }
        }
        public long? numpedentfut
        {
            get
            {
                return this._numpedentfut;
            }
            set
            {
                this._numpedentfut = value;
            }
        }
        public string codfilialnf
        {
            get
            {
                return this._codfilialnf;
            }
            set
            {
                this._codfilialnf = value;
            }
        }
        public int? numcarmanif
        {
            get
            {
                return this._numcarmanif;
            }
            set
            {
                this._numcarmanif = value;
            }
        }
        public long? numorca
        {
            get
            {
                return this._numorca;
            }
            set
            {
                this._numorca = value;
            }
        }
        public int? codcontrato
        {
            get
            {
                return this._codcontrato;
            }
            set
            {
                this._codcontrato = value;
            }
        }
        public DateTime? datapedcli
        {
            get
            {
                return this._datapedcli;
            }
            set
            {
                this._datapedcli = value;
            }
        }
        public long? numpedbnf
        {
            get
            {
                return this._numpedbnf;
            }
            set
            {
                this._numpedbnf = value;
            }
        }
        public string broker
        {
            get
            {
                return this._broker;
            }
            set
            {
                this._broker = value;
            }
        }
        public string codestabelecimento
        {
            get
            {
                return this._codestabelecimento;
            }
            set
            {
                this._codestabelecimento = value;
            }
        }
        public string numtabela
        {
            get
            {
                return this._numtabela;
            }
            set
            {
                this._numtabela = value;
            }
        }
        public string motivoposicao
        {
            get
            {
                return this._motivoposicao;
            }
            set
            {
                this._motivoposicao = value;
            }
        }
        public DateTime? dtagendaentrega
        {
            get
            {
                return this._dtagendaentrega;
            }
            set
            {
                this._dtagendaentrega = value;
            }
        }
        public string tipooper
        {
            get
            {
                return this._tipooper;
            }
            set
            {
                this._tipooper = value;
            }
        }
        public int? codmotbloqueio
        {
            get
            {
                return this._codmotbloqueio;
            }
            set
            {
                this._codmotbloqueio = value;
            }
        }
        public string serieecf
        {
            get
            {
                return this._serieecf;
            }
            set
            {
                this._serieecf = value;
            }
        }
        public long? numcupom
        {
            get
            {
                return this._numcupom;
            }
            set
            {
                this._numcupom = value;
            }
        }
        public int? codclirecebedor
        {
            get
            {
                return this._codclirecebedor;
            }
            set
            {
                this._codclirecebedor = value;
            }
        }
        public string conciliaimportacao
        {
            get
            {
                return this._conciliaimportacao;
            }
            set
            {
                this._conciliaimportacao = value;
            }
        }
        public short? numregiao
        {
            get
            {
                return this._numregiao;
            }
            set
            {
                this._numregiao = value;
            }
        }
        public long? numnota
        {
            get
            {
                return this._numnota;
            }
            set
            {
                this._numnota = value;
            }
        }
        public double? perdescfin
        {
            get
            {
                return this._perdescfin;
            }
            set
            {
                this._perdescfin = value;
            }
        }
        public string restricaotransp
        {
            get
            {
                return this._restricaotransp;
            }
            set
            {
                this._restricaotransp = value;
            }
        }
        public string geracp
        {
            get
            {
                return this._geracp;
            }
            set
            {
                this._geracp = value;
            }
        }
        public string usaintegracaowms
        {
            get
            {
                return this._usaintegracaowms;
            }
            set
            {
                this._usaintegracaowms = value;
            }
        }
        public string vendaassistida
        {
            get
            {
                return this._vendaassistida;
            }
            set
            {
                this._vendaassistida = value;
            }
        }
        public int? codmotivo
        {
            get
            {
                return this._codmotivo;
            }
            set
            {
                this._codmotivo = value;
            }
        }
        public string log
        {
            get
            {
                return this._log;
            }
            set
            {
                this._log = value;
            }
        }
        public DateTime? dtcalcfrete
        {
            get
            {
                return this._dtcalcfrete;
            }
            set
            {
                this._dtcalcfrete = value;
            }
        }
        public int? codfunccalcfrete
        {
            get
            {
                return this._codfunccalcfrete;
            }
            set
            {
                this._codfunccalcfrete = value;
            }
        }
        public long? eancobranca
        {
            get
            {
                return this._eancobranca;
            }
            set
            {
                this._eancobranca = value;
            }
        }
        public long? eanentrega
        {
            get
            {
                return this._eanentrega;
            }
            set
            {
                this._eanentrega = value;
            }
        }
        public string usacfopvendanatv10
        {
            get
            {
                return this._usacfopvendanatv10;
            }
            set
            {
                this._usacfopvendanatv10 = value;
            }
        }
        public string tipoprioridadeentrega
        {
            get
            {
                return this._tipoprioridadeentrega;
            }
            set
            {
                this._tipoprioridadeentrega = value;
            }
        }
        public int? codusur2
        {
            get
            {
                return this._codusur2;
            }
            set
            {
                this._codusur2 = value;
            }
        }
        public int? codusur3
        {
            get
            {
                return this._codusur3;
            }
            set
            {
                this._codusur3 = value;
            }
        }
        public int? codusur4
        {
            get
            {
                return this._codusur4;
            }
            set
            {
                this._codusur4 = value;
            }
        }
        public int? codclinf
        {
            get
            {
                return this._codclinf;
            }
            set
            {
                this._codclinf = value;
            }
        }
        public long? numpedtv1
        {
            get
            {
                return this._numpedtv1;
            }
            set
            {
                this._numpedtv1 = value;
            }
        }
        public string usadebcredrca
        {
            get
            {
                return this._usadebcredrca;
            }
            set
            {
                this._usadebcredrca = value;
            }
        }
        public string brinde
        {
            get
            {
                return this._brinde;
            }
            set
            {
                this._brinde = value;
            }
        }
        public string bonificaltdebcredrca
        {
            get
            {
                return this._bonificaltdebcredrca;
            }
            set
            {
                this._bonificaltdebcredrca = value;
            }
        }
        public string trocaaltdebcredrca
        {
            get
            {
                return this._trocaaltdebcredrca;
            }
            set
            {
                this._trocaaltdebcredrca = value;
            }
        }
        public string brokeraltdebcredrca
        {
            get
            {
                return this._brokeraltdebcredrca;
            }
            set
            {
                this._brokeraltdebcredrca = value;
            }
        }
        public string crmaltdebcredrca
        {
            get
            {
                return this._crmaltdebcredrca;
            }
            set
            {
                this._crmaltdebcredrca = value;
            }
        }
        public string tipomovccrca
        {
            get
            {
                return this._tipomovccrca;
            }
            set
            {
                this._tipomovccrca = value;
            }
        }
        public string usacredrca
        {
            get
            {
                return this._usacredrca;
            }
            set
            {
                this._usacredrca = value;
            }
        }
        public string gerardadosnfpaulista
        {
            get
            {
                return this._gerardadosnfpaulista;
            }
            set
            {
                this._gerardadosnfpaulista = value;
            }
        }
        public string usasaldocontacorrentedescfin
        {
            get
            {
                return this._usasaldocontacorrentedescfin;
            }
            set
            {
                this._usasaldocontacorrentedescfin = value;
            }
        }
        public decimal? valordescfin
        {
            get
            {
                return this._valordescfin;
            }
            set
            {
                this._valordescfin = value;
            }
        }
        public long? codvisita
        {
            get
            {
                return this._codvisita;
            }
            set
            {
                this._codvisita = value;
            }
        }
        public int? codatendimento
        {
            get
            {
                return this._codatendimento;
            }
            set
            {
                this._codatendimento = value;
            }
        }
        public string vendatriangular
        {
            get
            {
                return this._vendatriangular;
            }
            set
            {
                this._vendatriangular = value;
            }
        }
        public decimal? vlentrada
        {
            get
            {
                return this._vlentrada;
            }
            set
            {
                this._vlentrada = value;
            }
        }
        public string ufdesembaraco
        {
            get
            {
                return this._ufdesembaraco;
            }
            set
            {
                this._ufdesembaraco = value;
            }
        }
        public string localdesembaraco
        {
            get
            {
                return this._localdesembaraco;
            }
            set
            {
                this._localdesembaraco = value;
            }
        }
        public string custobonificacao
        {
            get
            {
                return this._custobonificacao;
            }
            set
            {
                this._custobonificacao = value;
            }
        }
        public int? codfornecbonific
        {
            get
            {
                return this._codfornecbonific;
            }
            set
            {
                this._codfornecbonific = value;
            }
        }
        public short? codbnf
        {
            get
            {
                return this._codbnf;
            }
            set
            {
                this._codbnf = value;
            }
        }
        public string tipodocumento
        {
            get
            {
                return this._tipodocumento;
            }
            set
            {
                this._tipodocumento = value;
            }
        }
        public int? cfopbnfdegusta
        {
            get
            {
                return this._cfopbnfdegusta;
            }
            set
            {
                this._cfopbnfdegusta = value;
            }
        }
        public string contaordem
        {
            get
            {
                return this._contaordem;
            }
            set
            {
                this._contaordem = value;
            }
        }
        public DateTime? dataempenho
        {
            get
            {
                return this._dataempenho;
            }
            set
            {
                this._dataempenho = value;
            }
        }
        public string numempenho
        {
            get
            {
                return this._numempenho;
            }
            set
            {
                this._numempenho = value;
            }
        }
        public string codunidadeexecutora
        {
            get
            {
                return this._codunidadeexecutora;
            }
            set
            {
                this._codunidadeexecutora = value;
            }
        }
        public string placaveiculo
        {
            get
            {
                return this._placaveiculo;
            }
            set
            {
                this._placaveiculo = value;
            }
        }
        public DateTime? dtlimitefat
        {
            get
            {
                return this._dtlimitefat;
            }
            set
            {
                this._dtlimitefat = value;
            }
        }
        public string reservaestoquetv7
        {
            get
            {
                return this._reservaestoquetv7;
            }
            set
            {
                this._reservaestoquetv7 = value;
            }
        }
        public string fornecentrega
        {
            get
            {
                return this._fornecentrega;
            }
            set
            {
                this._fornecentrega = value;
            }
        }
        public int? codclitv8
        {
            get
            {
                return this._codclitv8;
            }
            set
            {
                this._codclitv8 = value;
            }
        }
        public string ufveiculo
        {
            get
            {
                return this._ufveiculo;
            }
            set
            {
                this._ufveiculo = value;
            }
        }
        public string motoristaveiculo
        {
            get
            {
                return this._motoristaveiculo;
            }
            set
            {
                this._motoristaveiculo = value;
            }
        }
        public DateTime? dtiniciodigitacaopedido
        {
            get
            {
                return this._dtiniciodigitacaopedido;
            }
            set
            {
                this._dtiniciodigitacaopedido = value;
            }
        }
        public DateTime? dtfimdigitacaopedido
        {
            get
            {
                return this._dtfimdigitacaopedido;
            }
            set
            {
                this._dtfimdigitacaopedido = value;
            }
        }
        public decimal? vldescabatimento
        {
            get
            {
                return this._vldescabatimento;
            }
            set
            {
                this._vldescabatimento = value;
            }
        }
        public string agrupamento
        {
            get
            {
                return this._agrupamento;
            }
            set
            {
                this._agrupamento = value;
            }
        }
        public string vendaexportacao
        {
            get
            {
                return this._vendaexportacao;
            }
            set
            {
                this._vendaexportacao = value;
            }
        }
        public string turnoentrega
        {
            get
            {
                return this._turnoentrega;
            }
            set
            {
                this._turnoentrega = value;
            }
        }
        public long? numtransvendatv13
        {
            get
            {
                return this._numtransvendatv13;
            }
            set
            {
                this._numtransvendatv13 = value;
            }
        }
        public int? codendentcli
        {
            get
            {
                return this._codendentcli;
            }
            set
            {
                this._codendentcli = value;
            }
        }
        public string utilizavendaporembalagem
        {
            get
            {
                return this._utilizavendaporembalagem;
            }
            set
            {
                this._utilizavendaporembalagem = value;
            }
        }
        public int? codcontato
        {
            get
            {
                return this._codcontato;
            }
            set
            {
                this._codcontato = value;
            }
        }
        public long? numregexp
        {
            get
            {
                return this._numregexp;
            }
            set
            {
                this._numregexp = value;
            }
        }
        public string numchaveexp
        {
            get
            {
                return this._numchaveexp;
            }
            set
            {
                this._numchaveexp = value;
            }
        }
        public long? numdrawback
        {
            get
            {
                return this._numdrawback;
            }
            set
            {
                this._numdrawback = value;
            }
        }
        public DateTime? dtnftransf
        {
            get
            {
                return this._dtnftransf;
            }
            set
            {
                this._dtnftransf = value;
            }
        }
        public string rotinalanc
        {
            get
            {
                return this._rotinalanc;
            }
            set
            {
                this._rotinalanc = value;
            }
        }
        public long? numpedorigem
        {
            get
            {
                return this._numpedorigem;
            }
            set
            {
                this._numpedorigem = value;
            }
        }
        public string pedduplicado
        {
            get
            {
                return this._pedduplicado;
            }
            set
            {
                this._pedduplicado = value;
            }
        }
        public decimal? vlbonific
        {
            get
            {
                return this._vlbonific;
            }
            set
            {
                this._vlbonific = value;
            }
        }
        public string vendalocestrang
        {
            get
            {
                return this._vendalocestrang;
            }
            set
            {
                this._vendalocestrang = value;
            }
        }
        public string copiaidenticapeddup
        {
            get
            {
                return this._copiaidenticapeddup;
            }
            set
            {
                this._copiaidenticapeddup = value;
            }
        }
        public string assinatura
        {
            get
            {
                return this._assinatura;
            }
            set
            {
                this._assinatura = value;
            }
        }
        public string idparceiro
        {
            get
            {
                return this._idparceiro;
            }
            set
            {
                this._idparceiro = value;
            }
        }
        public long? uidregistro
        {
            get
            {
                return this._uidregistro;
            }
            set
            {
                this._uidregistro = value;
            }
        }
        public string condfinanc
        {
            get
            {
                return this._condfinanc;
            }
            set
            {
                this._condfinanc = value;
            }
        }
        public short? planosuppli
        {
            get
            {
                return this._planosuppli;
            }
            set
            {
                this._planosuppli = value;
            }
        }
        public string pagchequemoradia
        {
            get
            {
                return this._pagchequemoradia;
            }
            set
            {
                this._pagchequemoradia = value;
            }
        }
        public int? numvolume
        {
            get
            {
                return this._numvolume;
            }
            set
            {
                this._numvolume = value;
            }
        }

    }
}
