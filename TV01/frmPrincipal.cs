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
                btnGerar.Focus();
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
                if (txtCodigo.Text != null)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));
                    BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                    ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));

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

                decimal? vltotalgeral = modelopcpcold.vltotal;
                decimal? vltotalrest = vltotalgeral;
                modelopcpcold.numpedold = Convert.ToInt64(txtCodigo.Text);

                do
                {

                    BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
                    ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));

                    BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
                    ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));

                    BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
                    ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));

                    modelopcpi.oldnumped = Convert.ToInt64(txtCodigo.Text);
                    modelopcpc.numpedold = Convert.ToInt64(txtCodigo.Text);

                    BLLVAR bllvar = new BLLVAR(cx);
                    ModeloVAR modelovar = bllvar.CarregaNewNumPed(Convert.ToInt32(modelopcpc.codusur));
                    bllvar.AlterarNW(modelovar);

                    modelopcpc.numped = modelovar.newnumped;
                    modelopcpi.numped = modelovar.newnumped;
                    modelopcpc.condvenda = 1;

                    bllpcpc.Incluir(modelopcpc);

                    decimal numqt = modelopcpi.qt;
                    int it = 0;
                    decimal vltotal = 0;
                    decimal vltabela = 0;
                    decimal vlcustoreal = 0;
                    decimal vlcustofin = 0;
                    decimal vlatend = 0;
                    decimal? vlcustorep = 0;
                    decimal? vlcustocont = 0;

                    modelopcpi.qtrest = 0;
                    modelopcpi.numseqori = modelopcpi.numseq;


                    for (decimal i = 0; i < numqt && vltotal < 190; i++)
                    {

                        modelopcpi.numseq = it + 1;
                        modelopcpi.qt = 1;
                        modelopcpi.volumedesejado = modelopcpi.qtunitcx;
                        modelopcpi.qtunitcx = 1;
                        modelopcpi.qtunitemb = 1;
                        bllpcpi.Incluir(modelopcpi);

                        it = it + 1;

                        vltotal = vltotal + modelopcpi.pvenda;
                        vltabela = vltabela + modelopcpi.ptabela;
                        vlcustoreal = vlcustoreal + modelopcpi.vlcustoreal;
                        vlcustofin = vlcustofin + modelopcpi.vlcustofin;
                        vlatend = vlatend + modelopcpi.pvenda;
                        vlcustorep = vlcustorep + modelopcpi.vlcustorep;
                        vlcustocont = vlcustocont + modelopcpi.vlcustocont;

                    }


                    modelopcpi.qtrest = numqt - it;
                    bllpcpi.AlterarQT(modelopcpi);

                    modelopcpc.vltotal = vltotal;
                    modelopcpc.vltabela = vltabela;
                    modelopcpc.vlatend = vlatend;
                    modelopcpc.vlcustocont = Convert.ToDouble(vlcustocont);
                    modelopcpc.vlcustorep = Convert.ToDouble(vlcustorep);
                    modelopcpc.vlcustofin = Convert.ToDouble(vlcustofin);
                    modelopcpc.vlcustoreal = Convert.ToDouble(vlcustoreal);
                    bllpcpc.AlterarPC(modelopcpc);
                    vltotalrest = vltotalrest - vltotal;

                    string texto = "Pedido Cód: " + modelopcpc.numped.ToString() + " - Valor R$: " + modelopcpc.vltotal.ToString() + ";";
                    rtbPedGerados.Text = rtbPedGerados.Text + "\n" + texto;

                } while (vltotalrest > 0);
                //fim do loop de cabeçalho
                clsArquivo LCLS_ArquivoTxt = new clsArquivo();
                LCLS_ArquivoTxt.FU_Gravar(rtbPedGerados.Text);
                spoolrec("PEDIDOS.TXT");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
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
