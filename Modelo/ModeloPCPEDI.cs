using System;

namespace Modelo
{
    public class ModeloPCPEDI
    {
        public ModeloPCPEDI()
        {
            this.devolucaocarcaca = "";
        }

        private int _codprod;
        private decimal _qt;
        private decimal _pvenda;
        private long _numped;
        private DateTime _data;
        private int _codcli;
        private short _codusur;
        private int? _numcar;
        private string _posicao;
        private decimal _st;
        private decimal _vlcustoreal;
        private decimal _vlcustofin;
        private decimal _ptabela;
        private double _percom;
        private decimal _perdesc;
        private decimal? _qtfalta;
        private decimal? _numseq;
        private double? _vldesccustocmv;
        private decimal? _vlcustocont;
        private decimal? _vlcustorep;
        private decimal? _vldescsuframa;
        private short? _codst;
        private decimal? _vldescfin;
        private decimal? _pvendabase;
        private decimal? _vlipi;
        private double? _percipi;
        private decimal? _poriginal;
        private double? _iva;
        private double? _pauta;
        private double? _aliqicms1;
        private double? _aliqicms2;
        private decimal? _stclientegnre;
        private double? _percbasered;
        private double? _percbaseredst;
        private double? _percbaseredstfonte;
        private double? _perfretecmv;
        private decimal? _custofinest;
        private double? _perciss;
        private decimal? _vliss;
        private string _complemento;
        private decimal? _pbaserca;
        private decimal? _vlverbacmv;
        private int? _numverbarebcmv;
        private string _brinde;
        private decimal? _baseicst;
        private double? _qtcx;
        private double? _qtpecas;
        private string _letracomiss;
        private decimal? _codauxiliar;
        private double? _txvenda;
        private double? _codicmtab;
        private double? _perdesccusto;
        private string _codfilialretira;
        private long? _eancodprod;
        private decimal? _vldescicmisencao;
        private float? _perdescisentoicms;
        private decimal? _vlverbacmvcli;
        private decimal? _pvenda1;
        private string _tipoentrega;
        private string _geragnreCnpjcliente;
        private double? _percdifaliquotas;
        private decimal? _basedifaliquotas;
        private decimal? _vldifaliquotas;
        private double? _perdescpolitica;
        private decimal? _pvendaanterior;
        private string _proddescricaocontrato;
        private string _politicaprioritaria;
        private string _truncaritem;
        private decimal? _qtunitemb;
        private int? _rotinalanc;
        private double? _qtunitcx;
        private double? _percdescpis;
        private decimal? _vldescreducaopis;
        private double? _percdesccofins;
        private decimal? _vldescreducaocofins;
        private double? _percom2;
        private double? _percom3;
        private double? _percom4;
        private int? _coddesconto;
        private decimal? _vldescpissuframa;
        private decimal? _vlredpvendasimplesna;
        private decimal? _vlredcmvsimplesnac;
        private int? _codcontrato;
        private decimal? _vlrepasse;
        private double? _perbonific;
        private decimal? _vlbonific;
        private double? _perdesccom;
        private decimal? _vldesccom;
        private decimal? _vloutros;
        private decimal? _descprecofab;
        private decimal? _precomaxconsum;
        private decimal? _qtlitragem;
        private int? _rotinalancbrinde;
        private decimal? _percdescabatimento;
        private decimal? _vldescabatimento;
        private decimal? _pbonific;
        private string _bonific;
        private int? _numitemped;
        private decimal? _perdescpauta;
        private string _origemst;
        private string _codformula;
        private string _codbase;
        private string _siglaqualidade;
        private string _alternativo;
        private double? _volumedesejado;
        private short? _qtdiasentregaitem;
        private string _numerorecopi;
        private string _usaunidademaster;
        private long? _codcombo;
        private int? _numseqitemcontrato;
        private decimal? _percredaliqipi;
        private int? _numseqcestabasica;
        private int? _codprodcesta;
        private int? _coddescontobaserca;
        private decimal? _aliqfcp;
        private decimal? _aliqinternadest;
        private decimal? _vlfcppart;
        private decimal? _vlicmspartdest;
        private decimal? _vlicmspart;
        private float? _percprovpart;
        private decimal? _vlicmsdifaliqpart;
        private float? _percbaseredpart;
        private decimal? _vlicmspartrem;
        private decimal? _aliqinterorigpart;
        private decimal? _vlbasepartdest;
        private decimal? _vlipiptabela;
        private decimal? _vlipipbaserca;
        private decimal? _stptabela;
        private decimal? _stpbaserca;
        private decimal? _vlicmspartptabela;
        private decimal? _vlicmspartpbaserca;
        private string _unidade;
        private int? _coddescontosimulador;
        private short? _codfigvendatriangular;
        private int? _codfiscal;
        private string _sittribut;
        private decimal? _ptabelafabricazfm;
        private string _origmerctrib;
        private decimal? _vldesccarcaca;
        private string _devolucaocarcaca;
        public int codprod
        {
            get
            {
                return this._codprod;
            }
            set
            {
                this._codprod = value;
            }
        }
        public decimal qt
        {
            get
            {
                return this._qt;
            }
            set
            {
                this._qt = value;
            }
        }
        public decimal pvenda
        {
            get
            {
                return this._pvenda;
            }
            set
            {
                this._pvenda = value;
            }
        }
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
        public decimal st
        {
            get
            {
                return this._st;
            }
            set
            {
                this._st = value;
            }
        }
        public decimal vlcustoreal
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
        public decimal vlcustofin
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
        public decimal ptabela
        {
            get
            {
                return this._ptabela;
            }
            set
            {
                this._ptabela = value;
            }
        }
        public double percom
        {
            get
            {
                return this._percom;
            }
            set
            {
                this._percom = value;
            }
        }
        public decimal perdesc
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
        public decimal? qtfalta
        {
            get
            {
                return this._qtfalta;
            }
            set
            {
                this._qtfalta = value;
            }
        }
        public decimal? numseq
        {
            get
            {
                return this._numseq;
            }
            set
            {
                this._numseq = value;
            }
        }
        public double? vldesccustocmv
        {
            get
            {
                return this._vldesccustocmv;
            }
            set
            {
                this._vldesccustocmv = value;
            }
        }
        public decimal? vlcustocont
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
        public decimal? vlcustorep
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
        public decimal? vldescsuframa
        {
            get
            {
                return this._vldescsuframa;
            }
            set
            {
                this._vldescsuframa = value;
            }
        }
        public short? codst
        {
            get
            {
                return this._codst;
            }
            set
            {
                this._codst = value;
            }
        }
        public decimal? vldescfin
        {
            get
            {
                return this._vldescfin;
            }
            set
            {
                this._vldescfin = value;
            }
        }
        public decimal? pvendabase
        {
            get
            {
                return this._pvendabase;
            }
            set
            {
                this._pvendabase = value;
            }
        }
        public decimal? vlipi
        {
            get
            {
                return this._vlipi;
            }
            set
            {
                this._vlipi = value;
            }
        }
        public double? percipi
        {
            get
            {
                return this._percipi;
            }
            set
            {
                this._percipi = value;
            }
        }
        public decimal? poriginal
        {
            get
            {
                return this._poriginal;
            }
            set
            {
                this._poriginal = value;
            }
        }
        public double? iva
        {
            get
            {
                return this._iva;
            }
            set
            {
                this._iva = value;
            }
        }
        public double? pauta
        {
            get
            {
                return this._pauta;
            }
            set
            {
                this._pauta = value;
            }
        }
        public double? aliqicms1
        {
            get
            {
                return this._aliqicms1;
            }
            set
            {
                this._aliqicms1 = value;
            }
        }
        public double? aliqicms2
        {
            get
            {
                return this._aliqicms2;
            }
            set
            {
                this._aliqicms2 = value;
            }
        }
        public decimal? stclientegnre
        {
            get
            {
                return this._stclientegnre;
            }
            set
            {
                this._stclientegnre = value;
            }
        }
        public double? percbasered
        {
            get
            {
                return this._percbasered;
            }
            set
            {
                this._percbasered = value;
            }
        }
        public double? percbaseredst
        {
            get
            {
                return this._percbaseredst;
            }
            set
            {
                this._percbaseredst = value;
            }
        }
        public double? percbaseredstfonte
        {
            get
            {
                return this._percbaseredstfonte;
            }
            set
            {
                this._percbaseredstfonte = value;
            }
        }
        public double? perfretecmv
        {
            get
            {
                return this._perfretecmv;
            }
            set
            {
                this._perfretecmv = value;
            }
        }
        public decimal? custofinest
        {
            get
            {
                return this._custofinest;
            }
            set
            {
                this._custofinest = value;
            }
        }
        public double? perciss
        {
            get
            {
                return this._perciss;
            }
            set
            {
                this._perciss = value;
            }
        }
        public decimal? vliss
        {
            get
            {
                return this._vliss;
            }
            set
            {
                this._vliss = value;
            }
        }
        public string complemento
        {
            get
            {
                return this._complemento;
            }
            set
            {
                this._complemento = value;
            }
        }
        public decimal? pbaserca
        {
            get
            {
                return this._pbaserca;
            }
            set
            {
                this._pbaserca = value;
            }
        }
        public decimal? vlverbacmv
        {
            get
            {
                return this._vlverbacmv;
            }
            set
            {
                this._vlverbacmv = value;
            }
        }
        public int? numverbarebcmv
        {
            get
            {
                return this._numverbarebcmv;
            }
            set
            {
                this._numverbarebcmv = value;
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
        public decimal? baseicst
        {
            get
            {
                return this._baseicst;
            }
            set
            {
                this._baseicst = value;
            }
        }
        public double? qtcx
        {
            get
            {
                return this._qtcx;
            }
            set
            {
                this._qtcx = value;
            }
        }
        public double? qtpecas
        {
            get
            {
                return this._qtpecas;
            }
            set
            {
                this._qtpecas = value;
            }
        }
        public string letracomiss
        {
            get
            {
                return this._letracomiss;
            }
            set
            {
                this._letracomiss = value;
            }
        }
        public decimal? codauxiliar
        {
            get
            {
                return this._codauxiliar;
            }
            set
            {
                this._codauxiliar = value;
            }
        }
        public double? txvenda
        {
            get
            {
                return this._txvenda;
            }
            set
            {
                this._txvenda = value;
            }
        }
        public double? codicmtab
        {
            get
            {
                return this._codicmtab;
            }
            set
            {
                this._codicmtab = value;
            }
        }
        public double? perdesccusto
        {
            get
            {
                return this._perdesccusto;
            }
            set
            {
                this._perdesccusto = value;
            }
        }
        public string codfilialretira
        {
            get
            {
                return this._codfilialretira;
            }
            set
            {
                this._codfilialretira = value;
            }
        }
        public long? eancodprod
        {
            get
            {
                return this._eancodprod;
            }
            set
            {
                this._eancodprod = value;
            }
        }
        public decimal? vldescicmisencao
        {
            get
            {
                return this._vldescicmisencao;
            }
            set
            {
                this._vldescicmisencao = value;
            }
        }
        public float? perdescisentoicms
        {
            get
            {
                return this._perdescisentoicms;
            }
            set
            {
                this._perdescisentoicms = value;
            }
        }
        public decimal? vlverbacmvcli
        {
            get
            {
                return this._vlverbacmvcli;
            }
            set
            {
                this._vlverbacmvcli = value;
            }
        }
        public decimal? pvenda1
        {
            get
            {
                return this._pvenda1;
            }
            set
            {
                this._pvenda1 = value;
            }
        }
        public string tipoentrega
        {
            get
            {
                return this._tipoentrega;
            }
            set
            {
                this._tipoentrega = value;
            }
        }
        public string geragnreCnpjcliente
        {
            get
            {
                return this._geragnreCnpjcliente;
            }
            set
            {
                this._geragnreCnpjcliente = value;
            }
        }
        public double? percdifaliquotas
        {
            get
            {
                return this._percdifaliquotas;
            }
            set
            {
                this._percdifaliquotas = value;
            }
        }
        public decimal? basedifaliquotas
        {
            get
            {
                return this._basedifaliquotas;
            }
            set
            {
                this._basedifaliquotas = value;
            }
        }
        public decimal? vldifaliquotas
        {
            get
            {
                return this._vldifaliquotas;
            }
            set
            {
                this._vldifaliquotas = value;
            }
        }
        public double? perdescpolitica
        {
            get
            {
                return this._perdescpolitica;
            }
            set
            {
                this._perdescpolitica = value;
            }
        }
        public decimal? pvendaanterior
        {
            get
            {
                return this._pvendaanterior;
            }
            set
            {
                this._pvendaanterior = value;
            }
        }
        public string proddescricaocontrato
        {
            get
            {
                return this._proddescricaocontrato;
            }
            set
            {
                this._proddescricaocontrato = value;
            }
        }
        public string politicaprioritaria
        {
            get
            {
                return this._politicaprioritaria;
            }
            set
            {
                this._politicaprioritaria = value;
            }
        }
        public string truncaritem
        {
            get
            {
                return this._truncaritem;
            }
            set
            {
                this._truncaritem = value;
            }
        }
        public decimal? qtunitemb
        {
            get
            {
                return this._qtunitemb;
            }
            set
            {
                this._qtunitemb = value;
            }
        }
        public int? rotinalanc
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
        public double? qtunitcx
        {
            get
            {
                return this._qtunitcx;
            }
            set
            {
                this._qtunitcx = value;
            }
        }
        public double? percdescpis
        {
            get
            {
                return this._percdescpis;
            }
            set
            {
                this._percdescpis = value;
            }
        }
        public decimal? vldescreducaopis
        {
            get
            {
                return this._vldescreducaopis;
            }
            set
            {
                this._vldescreducaopis = value;
            }
        }
        public double? percdesccofins
        {
            get
            {
                return this._percdesccofins;
            }
            set
            {
                this._percdesccofins = value;
            }
        }
        public decimal? vldescreducaocofins
        {
            get
            {
                return this._vldescreducaocofins;
            }
            set
            {
                this._vldescreducaocofins = value;
            }
        }
        public double? percom2
        {
            get
            {
                return this._percom2;
            }
            set
            {
                this._percom2 = value;
            }
        }
        public double? percom3
        {
            get
            {
                return this._percom3;
            }
            set
            {
                this._percom3 = value;
            }
        }
        public double? percom4
        {
            get
            {
                return this._percom4;
            }
            set
            {
                this._percom4 = value;
            }
        }
        public int? coddesconto
        {
            get
            {
                return this._coddesconto;
            }
            set
            {
                this._coddesconto = value;
            }
        }
        public decimal? vldescpissuframa
        {
            get
            {
                return this._vldescpissuframa;
            }
            set
            {
                this._vldescpissuframa = value;
            }
        }
        public decimal? vlredpvendasimplesna
        {
            get
            {
                return this._vlredpvendasimplesna;
            }
            set
            {
                this._vlredpvendasimplesna = value;
            }
        }
        public decimal? vlredcmvsimplesnac
        {
            get
            {
                return this._vlredcmvsimplesnac;
            }
            set
            {
                this._vlredcmvsimplesnac = value;
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
        public decimal? vlrepasse
        {
            get
            {
                return this._vlrepasse;
            }
            set
            {
                this._vlrepasse = value;
            }
        }
        public double? perbonific
        {
            get
            {
                return this._perbonific;
            }
            set
            {
                this._perbonific = value;
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
        public double? perdesccom
        {
            get
            {
                return this._perdesccom;
            }
            set
            {
                this._perdesccom = value;
            }
        }
        public decimal? vldesccom
        {
            get
            {
                return this._vldesccom;
            }
            set
            {
                this._vldesccom = value;
            }
        }
        public decimal? vloutros
        {
            get
            {
                return this._vloutros;
            }
            set
            {
                this._vloutros = value;
            }
        }
        public decimal? descprecofab
        {
            get
            {
                return this._descprecofab;
            }
            set
            {
                this._descprecofab = value;
            }
        }
        public decimal? precomaxconsum
        {
            get
            {
                return this._precomaxconsum;
            }
            set
            {
                this._precomaxconsum = value;
            }
        }
        public decimal? qtlitragem
        {
            get
            {
                return this._qtlitragem;
            }
            set
            {
                this._qtlitragem = value;
            }
        }
        public int? rotinalancbrinde
        {
            get
            {
                return this._rotinalancbrinde;
            }
            set
            {
                this._rotinalancbrinde = value;
            }
        }
        public decimal? percdescabatimento
        {
            get
            {
                return this._percdescabatimento;
            }
            set
            {
                this._percdescabatimento = value;
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
        public decimal? pbonific
        {
            get
            {
                return this._pbonific;
            }
            set
            {
                this._pbonific = value;
            }
        }
        public string bonific
        {
            get
            {
                return this._bonific;
            }
            set
            {
                this._bonific = value;
            }
        }
        public int? numitemped
        {
            get
            {
                return this._numitemped;
            }
            set
            {
                this._numitemped = value;
            }
        }
        public decimal? perdescpauta
        {
            get
            {
                return this._perdescpauta;
            }
            set
            {
                this._perdescpauta = value;
            }
        }
        public string origemst
        {
            get
            {
                return this._origemst;
            }
            set
            {
                this._origemst = value;
            }
        }
        public string codformula
        {
            get
            {
                return this._codformula;
            }
            set
            {
                this._codformula = value;
            }
        }
        public string codbase
        {
            get
            {
                return this._codbase;
            }
            set
            {
                this._codbase = value;
            }
        }
        public string siglaqualidade
        {
            get
            {
                return this._siglaqualidade;
            }
            set
            {
                this._siglaqualidade = value;
            }
        }
        public string alternativo
        {
            get
            {
                return this._alternativo;
            }
            set
            {
                this._alternativo = value;
            }
        }
        public double? volumedesejado
        {
            get
            {
                return this._volumedesejado;
            }
            set
            {
                this._volumedesejado = value;
            }
        }
        public short? qtdiasentregaitem
        {
            get
            {
                return this._qtdiasentregaitem;
            }
            set
            {
                this._qtdiasentregaitem = value;
            }
        }
        public string numerorecopi
        {
            get
            {
                return this._numerorecopi;
            }
            set
            {
                this._numerorecopi = value;
            }
        }
        public string usaunidademaster
        {
            get
            {
                return this._usaunidademaster;
            }
            set
            {
                this._usaunidademaster = value;
            }
        }
        public long? codcombo
        {
            get
            {
                return this._codcombo;
            }
            set
            {
                this._codcombo = value;
            }
        }
        public int? numseqitemcontrato
        {
            get
            {
                return this._numseqitemcontrato;
            }
            set
            {
                this._numseqitemcontrato = value;
            }
        }
        public decimal? percredaliqipi
        {
            get
            {
                return this._percredaliqipi;
            }
            set
            {
                this._percredaliqipi = value;
            }
        }
        public int? numseqcestabasica
        {
            get
            {
                return this._numseqcestabasica;
            }
            set
            {
                this._numseqcestabasica = value;
            }
        }
        public int? codprodcesta
        {
            get
            {
                return this._codprodcesta;
            }
            set
            {
                this._codprodcesta = value;
            }
        }
        public int? coddescontobaserca
        {
            get
            {
                return this._coddescontobaserca;
            }
            set
            {
                this._coddescontobaserca = value;
            }
        }
        public decimal? aliqfcp
        {
            get
            {
                return this._aliqfcp;
            }
            set
            {
                this._aliqfcp = value;
            }
        }
        public decimal? aliqinternadest
        {
            get
            {
                return this._aliqinternadest;
            }
            set
            {
                this._aliqinternadest = value;
            }
        }
        public decimal? vlfcppart
        {
            get
            {
                return this._vlfcppart;
            }
            set
            {
                this._vlfcppart = value;
            }
        }
        public decimal? vlicmspartdest
        {
            get
            {
                return this._vlicmspartdest;
            }
            set
            {
                this._vlicmspartdest = value;
            }
        }
        public decimal? vlicmspart
        {
            get
            {
                return this._vlicmspart;
            }
            set
            {
                this._vlicmspart = value;
            }
        }
        public float? percprovpart
        {
            get
            {
                return this._percprovpart;
            }
            set
            {
                this._percprovpart = value;
            }
        }
        public decimal? vlicmsdifaliqpart
        {
            get
            {
                return this._vlicmsdifaliqpart;
            }
            set
            {
                this._vlicmsdifaliqpart = value;
            }
        }
        public float? percbaseredpart
        {
            get
            {
                return this._percbaseredpart;
            }
            set
            {
                this._percbaseredpart = value;
            }
        }
        public decimal? vlicmspartrem
        {
            get
            {
                return this._vlicmspartrem;
            }
            set
            {
                this._vlicmspartrem = value;
            }
        }
        public decimal? aliqinterorigpart
        {
            get
            {
                return this._aliqinterorigpart;
            }
            set
            {
                this._aliqinterorigpart = value;
            }
        }
        public decimal? vlbasepartdest
        {
            get
            {
                return this._vlbasepartdest;
            }
            set
            {
                this._vlbasepartdest = value;
            }
        }
        public decimal? vlipiptabela
        {
            get
            {
                return this._vlipiptabela;
            }
            set
            {
                this._vlipiptabela = value;
            }
        }
        public decimal? vlipipbaserca
        {
            get
            {
                return this._vlipipbaserca;
            }
            set
            {
                this._vlipipbaserca = value;
            }
        }
        public decimal? stptabela
        {
            get
            {
                return this._stptabela;
            }
            set
            {
                this._stptabela = value;
            }
        }
        public decimal? stpbaserca
        {
            get
            {
                return this._stpbaserca;
            }
            set
            {
                this._stpbaserca = value;
            }
        }
        public decimal? vlicmspartptabela
        {
            get
            {
                return this._vlicmspartptabela;
            }
            set
            {
                this._vlicmspartptabela = value;
            }
        }
        public decimal? vlicmspartpbaserca
        {
            get
            {
                return this._vlicmspartpbaserca;
            }
            set
            {
                this._vlicmspartpbaserca = value;
            }
        }
        public string unidade
        {
            get
            {
                return this._unidade;
            }
            set
            {
                this._unidade = value;
            }
        }
        public int? coddescontosimulador
        {
            get
            {
                return this._coddescontosimulador;
            }
            set
            {
                this._coddescontosimulador = value;
            }
        }
        public short? codfigvendatriangular
        {
            get
            {
                return this._codfigvendatriangular;
            }
            set
            {
                this._codfigvendatriangular = value;
            }
        }
        public int? codfiscal
        {
            get
            {
                return this._codfiscal;
            }
            set
            {
                this._codfiscal = value;
            }
        }
        public string sittribut
        {
            get
            {
                return this._sittribut;
            }
            set
            {
                this._sittribut = value;
            }
        }
        public decimal? ptabelafabricazfm
        {
            get
            {
                return this._ptabelafabricazfm;
            }
            set
            {
                this._ptabelafabricazfm = value;
            }
        }
        public string origmerctrib
        {
            get
            {
                return this._origmerctrib;
            }
            set
            {
                this._origmerctrib = value;
            }
        }
        public decimal? vldesccarcaca
        {
            get
            {
                return this._vldesccarcaca;
            }
            set
            {
                this._vldesccarcaca = value;
            }
        }
        public string devolucaocarcaca
        {
            get
            {
                return this._devolucaocarcaca;
            }
            set
            {
                this._devolucaocarcaca = value;
            }
        }

    }
}
