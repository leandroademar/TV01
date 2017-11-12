using BLL;
using DAL;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TV01
{
    public partial class frmMapa : Form
    {
        public long pedidoi;
        public long pedidof;
        public Font printFont;
        public StreamReader streamToPrint;

        public frmMapa()
        {
            InitializeComponent();
        }

        int numcaixa = 0;
        int tipoimp = 0;


        private void frmMapa_Load(object sender, EventArgs e)
        {

            StreamReader caixa = new StreamReader("Caixa.txt");
            numcaixa = Convert.ToInt32(caixa.ReadLine());
            caixa.Close();
            gbxCupom.Visible = false;
            gbxDanfe.Visible = false;
            gbxPedido.Visible = false;
            txtPedIni.Text = pedidoi.ToString();
            txtPedFim.Text = pedidof.ToString();
        }

        private void rbtPedidos_CheckedChanged(object sender, EventArgs e)
        {
            gbxCupom.Visible = false;
            gbxDanfe.Visible = false;
            gbxPedido.Visible = true;
            tipoimp = 1;
        }

        private void rbtCupom_CheckedChanged(object sender, EventArgs e)
        {
            gbxCupom.Visible = true;
            gbxDanfe.Visible = false;
            gbxPedido.Visible = false;
            tipoimp = 2;
        }

        private void rbtDanfe_CheckedChanged(object sender, EventArgs e)
        {
            gbxPedido.Visible = false;
            gbxCupom.Visible = false;
            gbxDanfe.Visible = true;

            tipoimp = 2;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
        public void GravaMapa()
        {

            decimal totaldgv = 0;
            for (int it = 0; it < dgvMapa.RowCount; it++)
            {
                totaldgv = totaldgv + Convert.ToDecimal(dgvMapa.Rows[it].Cells["VLTOTAL"].Value);
            }

            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("MAPA.txt", false);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("                 MAPA DE SEPARAÇÃO        ");
            STW_Arquivo.WriteLine("");
            if (tipoimp == 1)
            {
                STW_Arquivo.WriteLine("Código...: " + txtPedIni.Text.ToString() + " a " + txtPedFim.Text.ToString());
            }
            else
            {
                STW_Arquivo.WriteLine("Código...: " + txtCupom.Text.ToString());
            }
            STW_Arquivo.WriteLine("Cliente..: " + dgvMapa.Rows[1].Cells["CLIENTE"].Value.ToString().Trim());
            STW_Arquivo.WriteLine("Total....: R$ " + totaldgv.ToString());
            STW_Arquivo.WriteLine("Hora.....: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            STW_Arquivo.WriteLine("Caixa....: " + dgvMapa.Rows[1].Cells["CAIXA"].Value.ToString().Trim());
            STW_Arquivo.WriteLine("Atend....: " + dgvMapa.Rows[1].Cells["RECEPCAO"].Value.ToString().Trim());
            STW_Arquivo.WriteLine("---------------------------------------------------------------------------");
            STW_Arquivo.WriteLine("                  PRODUTOS        ");
            STW_Arquivo.WriteLine("");
            for (int i = 0; i < dgvMapa.RowCount; i++)
            {
                STW_Arquivo.WriteLine(dgvMapa.Rows[i].Cells["DESCRICAO"].Value.ToString().Trim());
                STW_Arquivo.WriteLine(" Quant.: " + dgvMapa.Rows[i].Cells["QTCOMP"].Value.ToString().Trim() +
                                       "Emb.:" + dgvMapa.Rows[i].Cells["EMBALAGEM"].Value.ToString().Trim() +
                                       " Vlr Unit: R$ " + dgvMapa.Rows[i].Cells["VALCOMP"].Value.ToString().Trim() +
                                       " Total: R$" + dgvMapa.Rows[i].Cells["VLTOTAL"].Value.ToString().Trim());
                STW_Arquivo.WriteLine("");
            }
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("COMPROVANTE SEM VALOR FISCAL");
            STW_Arquivo.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMAPA bllmapa = new BLLMAPA(cx);
                dgvMapa.DataSource = bllmapa.Localizar(Convert.ToInt64(txtPedIni.Text), Convert.ToInt64(txtPedFim.Text), tipoimp, numcaixa);
                GravaMapa();
                spoolrec("MAPA.txt");
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }
        }
    }
}
