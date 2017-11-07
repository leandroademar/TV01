using System;
using DAL;
using Modelo;
using BLL;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace TV01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(e.KeyCode == Keys.Escape)
            {
                LimpaTela();
            }
        }

        private void limpaTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txtCodigo != null)
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
                   
                }
            }
            
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + " \n " + "Verificar o Pedido de Digitado.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erro: " + ex.Message +" \n " + ex.StackTrace);
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message + " \n " + erros.StackTrace);
            }
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo_Leave(sender, e);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            BLLPCVENDACONSUM bllpcvc = new BLLPCVENDACONSUM(cx);
            ModeloPCVENDACONSUM modelopcvc = bllpcvc.CarregaPCVENDACONSUM(Convert.ToInt64(txtCodigo.Text));

            BLLPCPEDC bllpcpc = new BLLPCPEDC(cx);
            ModeloPCPEDC modelopcpc = bllpcpc.CarregaPCPEDC(Convert.ToInt64(txtCodigo.Text));

            BLLPCPEDI bllpcpi = new BLLPCPEDI(cx);
            ModeloPCPEDI modelopcpi = bllpcpi.CarregaPCPEDI(Convert.ToInt64(txtCodigo.Text));

            BLLVAR bllvar = new BLLVAR(cx);
            ModeloVAR modelovar = bllvar.CarregaNewNumPed(Convert.ToInt32(modelopcpc.codusur));
            bllvar.AlterarNW(modelovar);

            modelopcpc.numped = modelovar.newnumped;
            modelopcpi.numped = modelovar.newnumped;
            modelopcpc.condvenda = 1;
            
            bllpcpc.Incluir(modelopcpc);
            for (int i = 0; i < modelopcpc.numitens; i++)
            {

                bllpcpi.Incluir(modelopcpi);
            }
           
            


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
