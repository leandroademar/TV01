﻿namespace TV01
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlCabec = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVTotal = new System.Windows.Forms.Label();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.ckbAlterar = new System.Windows.Forms.CheckBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rtbPedGerados = new System.Windows.Forms.RichTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conexãoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpaTelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlCabec.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(121, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(8, 44);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // pnlCabec
            // 
            this.pnlCabec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabec.Controls.Add(this.label1);
            this.pnlCabec.Controls.Add(this.lblVTotal);
            this.pnlCabec.Controls.Add(this.txtQtdItens);
            this.pnlCabec.Controls.Add(this.txtVlrTotal);
            this.pnlCabec.Controls.Add(this.ckbAlterar);
            this.pnlCabec.Controls.Add(this.lblcpf);
            this.pnlCabec.Controls.Add(this.lblNome);
            this.pnlCabec.Controls.Add(this.txtCpf);
            this.pnlCabec.Controls.Add(this.txtNome);
            this.pnlCabec.Location = new System.Drawing.Point(8, 86);
            this.pnlCabec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCabec.Name = "pnlCabec";
            this.pnlCabec.Size = new System.Drawing.Size(432, 91);
            this.pnlCabec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Qtd. Itens:";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.Location = new System.Drawing.Point(17, 63);
            this.lblVTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(52, 13);
            this.lblVTotal.TabIndex = 16;
            this.lblVTotal.Text = "Vlr. Total:";
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.Location = new System.Drawing.Point(225, 61);
            this.txtQtdItens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(79, 20);
            this.txtQtdItens.TabIndex = 15;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(71, 61);
            this.txtVlrTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Size = new System.Drawing.Size(79, 20);
            this.txtVlrTotal.TabIndex = 14;
            // 
            // ckbAlterar
            // 
            this.ckbAlterar.AutoSize = true;
            this.ckbAlterar.Location = new System.Drawing.Point(305, 36);
            this.ckbAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbAlterar.Name = "ckbAlterar";
            this.ckbAlterar.Size = new System.Drawing.Size(72, 21);
            this.ckbAlterar.TabIndex = 13;
            this.ckbAlterar.Text = "Alterar ?";
            this.ckbAlterar.UseVisualStyleBackColor = true;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(38, 38);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 12;
            this.lblcpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 10);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(71, 34);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(151, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 8);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 0;
            // 
            // rtbPedGerados
            // 
            this.rtbPedGerados.Location = new System.Drawing.Point(8, 235);
            this.rtbPedGerados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbPedGerados.Name = "rtbPedGerados";
            this.rtbPedGerados.Size = new System.Drawing.Size(304, 175);
            this.rtbPedGerados.TabIndex = 4;
            this.rtbPedGerados.Text = "";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(8, 29);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(79, 13);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Código Pedido:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexãoBancoDeDadosToolStripMenuItem,
            this.reimprimirToolStripMenuItem,
            this.limpaTelaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 94);
            // 
            // conexãoBancoDeDadosToolStripMenuItem
            // 
            this.conexãoBancoDeDadosToolStripMenuItem.Name = "conexãoBancoDeDadosToolStripMenuItem";
            this.conexãoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.conexãoBancoDeDadosToolStripMenuItem.Text = "Configurar Conexão";
            this.conexãoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.conexãoBancoDeDadosToolStripMenuItem_Click);
            // 
            // reimprimirToolStripMenuItem
            // 
            this.reimprimirToolStripMenuItem.Name = "reimprimirToolStripMenuItem";
            this.reimprimirToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.reimprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // limpaTelaToolStripMenuItem
            // 
            this.limpaTelaToolStripMenuItem.Name = "limpaTelaToolStripMenuItem";
            this.limpaTelaToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.limpaTelaToolStripMenuItem.Text = "Limpa Tela";
            this.limpaTelaToolStripMenuItem.Click += new System.EventHandler(this.limpaTelaToolStripMenuItem_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(8, 71);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Dados Cliente:";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(8, 220);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(91, 13);
            this.lblPedidos.TabIndex = 8;
            this.lblPedidos.Text = "Pedidos Gerados:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(319, 386);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(58, 23);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(381, 386);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 416);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.rtbPedGerados);
            this.Controls.Add(this.pnlCabec);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pré-Venda";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.pnlCabec.ResumeLayout(false);
            this.pnlCabec.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel pnlCabec;
        private System.Windows.Forms.RichTextBox rtbPedGerados;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conexãoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimprimirToolStripMenuItem;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox ckbAlterar;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStripMenuItem limpaTelaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.TextBox txtQtdItens;
        private System.Windows.Forms.TextBox txtVlrTotal;
    }
}