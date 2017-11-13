using System;
using DAL;
using Modelo;
using BLL;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;

namespace TV01
{
    public partial class frmPrincipal : Form
    {
        public Font printFont;
        public StreamReader streamToPrint;
        public long[] pedidos = new long[2];
        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMapa f = new frmMapa();
            f.pedidoi = pedidos[0];
            f.pedidof = pedidos[1];
            f.Show();
        }

        private void conexãoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            f.Show();
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtVlrTotal.Clear();
            txtQtdItens.Clear();
            rtbPedGerados.Clear();
            txtNome.ReadOnly = true;
            txtVlrTotal.ReadOnly = true;
            txtQtdItens.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtCodigo.Focus();
            btnGerar.Visible = false;
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimpaTela();
            }
            if (e.KeyCode == Keys.F5)
            {
                frmMapa f = new frmMapa();
                f.pedidoi = pedidos[0];
                f.pedidof = pedidos[1];
                f.Show();
            }
            if (e.KeyCode == Keys.Enter && (txtCodigo.Text != ""))
            {
                btnBuscar.Focus();
            }


        }

        private void limpaTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            LimpaTela();

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != null && txtVlrTotal.Text != "0")
                {
                    
                    rtbPedGerados.Clear();
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                    ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));
                    
                    dgvItens.DataSource = bllpcpi.Localizar(Convert.ToInt64(txtCodigo.Text));
                    if(dgvItens.RowCount > 0)
                    {
                        ModeloPCPEDI mitens = new ModeloPCPEDI();
                        BLLPCPEDI bitens = new BLLPCPEDI(cx);

                        for (int i =0; i < dgvItens.RowCount; i++)
                        {
                            mitens.numped = Convert.ToInt64(txtCodigo.Text);
                            mitens.codprod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                            mitens.codauxiliar = Convert.ToInt64((dgvItens.Rows[i].Cells[1].Value.ToString()));
                            mitens.qt = Convert.ToDecimal(dgvItens.Rows[i].Cells[2].Value);
                            mitens.qtunitemb = Convert.ToDecimal(dgvItens.Rows[i].Cells[3].Value);
                            mitens.pvenda = Convert.ToDecimal(dgvItens.Rows[i].Cells[4].Value);
                            bitens.IncluirDUP(mitens);
                        }

                    }
                    
                    txtNome.Text = modelopcvc.cliente.ToString();
                    txtCpf.Text = modelopcvc.cgcent.ToString();
                    txtVlrTotal.Text = modelopcpc.vltotal.ToString();
                    txtQtdItens.Text = modelopcpc.numitens.ToString();
                    btnBuscar.Focus();
                }
                if(txtCodigo == null)
                {

                }
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + " \n " + "Verificar o Pedido de Digitado.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }

        }
        public void AtualizaDGVItens()
        {

            dgvItens.Columns[0].HeaderText = "Código Produto";
            dgvItens.Columns[0].DisplayIndex = 0;
            dgvItens.Columns[1].HeaderText = "Quantidade";
            dgvItens.Columns[1].DisplayIndex = 1;
            dgvItens.Columns[2].HeaderText = "Preço Unit.";
            dgvItens.Columns[2].DisplayIndex = 2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //txtCodigo_Leave(sender, e);
            if (dgvItens.RowCount > 0)
            {
                btnGerar.Visible = true;
                btnGerar.Focus();
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPCPEDC bllpcpcold = new BLLPCPEDC(cx);
                ModeloPCPEDC modelopcpcold = bllpcpcold.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));

                decimal? vltotalrest = modelopcpcold.vltotal;
                modelopcpcold.numpedold = Convert.ToInt64(txtCodigo.Text);
                int ped = 0;
                decimal? totalgeralped = 0;
                string qtit = txtQtdItens.Text;

                do
                {
                    ped = ped + 1;
                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));

                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));

                    modelopcpc.numpedold = Convert.ToInt64(txtCodigo.Text);

                    BLLVAR bllvar = new BLLVAR(cx);
                    ModeloVAR modelovar = bllvar.CarregaNewNumPed(Convert.ToInt64(modelopcpc.codusur));
                    bllvar.AlterarNW(modelovar);
                    BLLCARREG bllpccr = new BLLCARREG(cx);
                    ModeloPCCARREG modelopccr = bllpccr.CarregaNewNumPed();

                    modelopcpc.numcar = modelopccr.numcar;
                    modelopcpc.numped = modelovar.newnumped;
                    modelopcvc.numped = modelovar.newnumped;
                    modelopcpc.condvenda = 1;

                    if (ped == 1)
                    {
                        pedidos[0] = modelopcpc.numped;
                     
                    }
                    pedidos[1] = modelopcpc.numped;

                    int it = 0;
                    decimal vltotal = 0;
                    decimal vltabela = 0;
                    decimal vlcustoreal = 0;
                    decimal vlcustofin = 0;
                    decimal vlatend = 0;
                    decimal? vlcustorep = 0;
                    decimal? vlcustocont = 0;
                    decimal? qtrest = 0;
                    decimal VlrTotalVend = 0;

                    int contped = 0;
                    int itens = 0;

                    do
                    {
                        BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                        ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));
                        dgvItens.DataSource = bllpcpi.Localizar(Convert.ToInt64(txtCodigo.Text));
                        modelopcpi.oldnumped = Convert.ToInt64(txtCodigo.Text);
                        modelopcpi.numped = modelovar.newnumped;
                        modelopcpi.numseqori = modelopcpi.numseq;
                        modelopcpi.numcar = modelopccr.numcar;

                        if (modelopcpi.codprod != 0)
                        {
                            bllpcpi.IncluirQT(modelopcpi);
                            
                        }

                        modelopcpi.codauxiliar = modelopcpi.codauxiliarunit;
                        modelopcpi.qtunitcx = modelopcpi.qtunitcxunit;
                        modelopcpi.qtunitemb = Convert.ToDecimal(modelopcpi.qtunitcxunit);

                        decimal QtRestprod = 0;
                        decimal QtAnt = 0;
                        decimal VlrProd = 0;
                        decimal QtProd = 0;
                        decimal pvltabela = 0;
                        decimal pvlcustoreal = 0;
                        decimal pvlcustofin = 0;
                        decimal pvlatend = 0;
                        decimal? pvlcustorep = 0;
                        decimal? pvlcustocont = 0;

                        QtAnt = modelopcpi.qt;
                        modelopcpc.numitens = Convert.ToInt16(itens + 1);

                        for (decimal ii = 0; ii < QtAnt; ii++)
                        {
                            if (modelopcpi.fracao == "N")
                            {
                                VlrProd = VlrProd + modelopcpi.pvenda;
                                QtProd = QtProd + 1;
                                QtRestprod = QtAnt - QtProd;
                                pvltabela = pvltabela + (modelopcpi.ptabela );
                                pvlcustoreal = pvlcustoreal + (modelopcpi.vlcustoreal );
                                pvlcustofin = pvlcustofin + (modelopcpi.vlcustofin );
                                pvlatend = pvlatend + (modelopcpi.pvenda );
                                pvlcustorep = pvlcustorep + (modelopcpi.vlcustorep );
                                pvlcustocont = pvlcustocont + (modelopcpi.vlcustocont );
                                VlrTotalVend = VlrTotalVend + (modelopcpi.pvenda );

                                if (VlrTotalVend > 185)
                                {
                                    contped = 1;
                                    break;

                                }
                            }else
                            {
                                VlrProd = VlrProd + (modelopcpi.pvenda/10);
                                QtProd = QtProd + 0.10m;
                                QtRestprod = QtAnt - QtProd;
                                pvltabela = pvltabela + (modelopcpi.ptabela/10);
                                pvlcustoreal = pvlcustoreal + (modelopcpi.vlcustoreal/10);
                                pvlcustofin = pvlcustofin + (modelopcpi.vlcustofin/10);
                                pvlatend = pvlatend + (modelopcpi.pvenda/10);
                                pvlcustorep = pvlcustorep + (modelopcpi.vlcustorep / 10);
                                pvlcustocont = pvlcustocont + (modelopcpi.vlcustocont / 10);
                                VlrTotalVend = VlrTotalVend + (modelopcpi.pvenda / 10);

                                if (VlrTotalVend > 190)
                                {
                                    contped = 1;
                                    break;

                                }
                                ii = ii - 0.90m;
                            }
                        }

                        modelopcpi.numseq = it + 1;
                        modelopcpi.qt = QtProd;

                        if (modelopcpi.codprod != 0)
                        {

                            bllpcpi.Incluir(modelopcpi);

                        }

                        it++;
                        itens++;

                        vltotal = vltotal + VlrProd;
                        vltabela = vltabela + pvltabela;
                        vlcustoreal = vlcustoreal + pvlcustoreal;
                        vlcustofin = vlcustofin + pvlcustofin;
                        vlatend = vlatend + pvlatend;
                        vlcustorep = vlcustorep + pvlcustorep;
                        vlcustocont = vlcustocont + pvlcustocont;

                        modelopcpi.qtrest = QtAnt - QtProd;
                        qtrest = modelopcpi.qtrest;

                        if (modelopcpi.codprod != 0)
                        {
                            bllpcpi.AlterarQT(modelopcpi);
                        }
                        dgvItens.DataSource = bllpcpi.Localizar(Convert.ToInt64(txtCodigo.Text));

                    } while (vltotal < 200 && dgvItens.RowCount > 0 && contped == 0);

                    vltotalrest = vltotalrest - vltotal;

                    modelopcpc.vltotal = vltotal;
                    modelopcpc.vltabela = vltabela;
                    modelopcpc.vlatend = vlatend;
                    modelopcpc.vlcustocont = Convert.ToDouble(vlcustocont);
                    modelopcpc.vlcustorep = Convert.ToDouble(vlcustorep);
                    modelopcpc.vlcustofin = Convert.ToDouble(vlcustofin);
                    modelopcpc.vlcustoreal = Convert.ToDouble(vlcustoreal);

                    if (modelopcpc.vltotal != 0)
                    {
                        modelopccr.codfuncmon = modelopcpc.codusur;
                        modelopccr.vltotal = Convert.ToDouble(modelopcpc.vltotal);
                        bllpccr.Incluir(modelopccr);
                        bllpcpc.Incluir(modelopcpc);
                        
                        bllpcvc.Incluir(modelopcvc);
                        totalgeralped = totalgeralped + modelopcpc.vltotal;
                        string texto = "Pedido Cód: " + modelopcpc.numped.ToString() + " - Valor R$: " + Math.Round(Convert.ToDecimal(modelopcpc.vltotal),2).ToString() + ";"+"\n";
                        rtbPedGerados.Text = rtbPedGerados.Text + "\n" + texto;
                    }
                    
                } while (vltotalrest > 0);
                rtbPedGerados.Text = rtbPedGerados.Text + "\n" + "\n" +" Pedidos/Itens: " + ped.ToString()+"/" + qtit + " Valor Total R$" + Math.Round(Convert.ToDecimal(totalgeralped),2).ToString();

                clsArquivo LCLS_ArquivoTxt = new clsArquivo();
                LCLS_ArquivoTxt.FU_Gravar(rtbPedGerados.Text);
                if (rtbPedGerados.Text != null)
                {
                    spoolrec("PEDIDOS.TXT");
                }
                BLLPCPEDC bllpcpold = new BLLPCPEDC(cx);
                ModeloPCPEDC modelopcpold = bllpcpold.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));
                modelopcpold.vltotal = 0;
                modelopcpold.numped = Convert.ToInt64(txtCodigo.Text);
                bllpcpold.AlterarVT(modelopcpold);
                txtVlrTotal.Text = "0";
                btnGerar.Visible = false;
                txtCodigo.Focus();
                LimpaTela();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        public void spoolrec(string documento)
        {

            try
            {
                streamToPrint = new StreamReader
                (documento, false);
                printFont = new Font("Arial", 9);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler
                (this.pd_PrintPage);
                //PrintController pc = new PrintControllerWithStatusDialog(pd.PrintController);
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                pd.Print();
                streamToPrint.Close();
                pd.Dispose();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 2;
            float topMargin = 1;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void reimprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spoolrec("PEDIDOS.TXT");
        }

        private void reverterPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
