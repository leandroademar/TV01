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

        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

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
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimpaTela();
            }
            if (e.KeyCode == Keys.Enter && (txtCodigo.Text != ""))
            {
                btnGerar_Click(sender, e);
                txtCodigo.Focus();
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
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                    ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));
                    dgvItens.DataSource = bllpcpi.Localizar(Convert.ToInt64(txtCodigo.Text));
                    // this.AtualizaDGVItens();
                    txtNome.Text = modelopcvc.cliente.ToString();
                    txtCpf.Text = modelopcvc.cgcent.ToString();
                    txtVlrTotal.Text = modelopcpc.vltotal.ToString();
                    txtQtdItens.Text = modelopcpc.numitens.ToString();
                    btnGerar.Focus();
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
            txtCodigo_Leave(sender, e);
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

                do
                {

                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));

                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));


                    modelopcpc.numpedold = Convert.ToInt64(txtCodigo.Text);

                    BLLVAR bllvar = new BLLVAR(cx);
                    ModeloVAR modelovar = bllvar.CarregaNewNumPed(Convert.ToInt64(modelopcpc.codusur));
                    bllvar.AlterarNW(modelovar);

                    modelopcpc.numped = modelovar.newnumped;

                    modelopcvc.numped = modelovar.newnumped;
                    modelopcpc.condvenda = 1;




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


                    do
                    {
                        BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                        ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));
                        dgvItens.DataSource = bllpcpi.Localizar(Convert.ToInt64(txtCodigo.Text));
                        modelopcpi.oldnumped = Convert.ToInt64(txtCodigo.Text);
                        modelopcpi.numped = modelovar.newnumped;
                        modelopcpi.numseqori = modelopcpi.numseq;


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

                        for (int ii = 0; ii < QtAnt; ii++)
                        {
                            VlrProd = VlrProd + modelopcpi.pvenda;
                            QtProd = QtProd + 1;
                            pvltabela = pvltabela + modelopcpi.ptabela;
                            pvlcustoreal = pvlcustoreal + modelopcpi.vlcustoreal;
                            pvlcustofin = pvlcustofin + modelopcpi.vlcustofin;
                            pvlatend = vlatend + modelopcpi.pvenda;
                            pvlcustorep = vlcustorep + modelopcpi.vlcustorep;
                            pvlcustocont = vlcustocont + modelopcpi.vlcustocont;
                            VlrTotalVend = VlrTotalVend + modelopcpi.pvenda;

                            if (VlrProd > 170 && VlrProd < 190 | VlrTotalVend > 190) 
                            {
                                break;
                            }
                        }

                        modelopcpi.numseq = it + 1;
                        modelopcpi.qt = QtProd;

                        if (modelopcpi.codprod != 0)
                        {
                            bllpcpi.Incluir(modelopcpi);
                        }

                        it++;

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


                    } while (vltotal < 200 && dgvItens.RowCount > 0);

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
                        bllpcpc.Incluir(modelopcpc);
                        
                        bllpcvc.Incluir(modelopcvc);
                        string texto = "Pedido Cód: " + modelopcpc.numped.ToString() + " - Valor R$: " + modelopcpc.vltotal.ToString() + ";";
                        rtbPedGerados.Text = rtbPedGerados.Text + "\n" + texto;
                    }
                    
                } while (vltotalrest > 0);

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
                txtCodigo.Focus();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
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
                printFont = new Font("Arial", 10);
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
    }
}
