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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpPedido = new System.Windows.Forms.TabPage();
            this.tbpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.pnlCabec.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tbpPedido.SuspendLayout();
            this.tbpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(185, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(163, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // pnlCabec
            // 
            this.pnlCabec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabec.Controls.Add(this.label1);
            this.pnlCabec.Controls.Add(this.lblVTotal);
            this.pnlCabec.Controls.Add(this.txtQtdItens);
            this.pnlCabec.Controls.Add(this.txtVlrTotal);
            this.pnlCabec.Controls.Add(this.lblcpf);
            this.pnlCabec.Controls.Add(this.lblNome);
            this.pnlCabec.Controls.Add(this.txtCpf);
            this.pnlCabec.Controls.Add(this.txtNome);
            this.pnlCabec.Location = new System.Drawing.Point(12, 106);
            this.pnlCabec.Name = "pnlCabec";
            this.pnlCabec.Size = new System.Drawing.Size(647, 139);
            this.pnlCabec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Qtd. Itens:";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.Location = new System.Drawing.Point(26, 97);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(75, 20);
            this.lblVTotal.TabIndex = 16;
            this.lblVTotal.Text = "Vlr. Total:";
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.Location = new System.Drawing.Point(338, 94);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(116, 26);
            this.txtQtdItens.TabIndex = 15;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(106, 94);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Size = new System.Drawing.Size(116, 26);
            this.txtVlrTotal.TabIndex = 14;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(57, 58);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(44, 20);
            this.lblcpf.TabIndex = 12;
            this.lblcpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(106, 52);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(224, 26);
            this.txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(446, 26);
            this.txtNome.TabIndex = 0;
            // 
            // rtbPedGerados
            // 
            this.rtbPedGerados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPedGerados.Location = new System.Drawing.Point(6, 336);
            this.rtbPedGerados.Name = "rtbPedGerados";
            this.rtbPedGerados.Size = new System.Drawing.Size(454, 267);
            this.rtbPedGerados.TabIndex = 4;
            this.rtbPedGerados.Text = "";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 19);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(116, 20);
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
            this.reimprimirToolStripMenuItem.Click += new System.EventHandler(this.reimprimirToolStripMenuItem_Click);
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
            this.lblCliente.Location = new System.Drawing.Point(12, 83);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(113, 20);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Dados Cliente:";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(12, 313);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(136, 20);
            this.lblPedidos.TabIndex = 8;
            this.lblPedidos.Text = "Pedidos Gerados:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(479, 568);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(87, 35);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(572, 568);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 35);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpPedido);
            this.tbcPrincipal.Controls.Add(this.tbpItens);
            this.tbcPrincipal.Location = new System.Drawing.Point(-4, -3);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(686, 697);
            this.tbcPrincipal.TabIndex = 11;
            // 
            // tbpPedido
            // 
            this.tbpPedido.Controls.Add(this.lblCod);
            this.tbpPedido.Controls.Add(this.lblPedidos);
            this.tbpPedido.Controls.Add(this.btnImprimir);
            this.tbpPedido.Controls.Add(this.rtbPedGerados);
            this.tbpPedido.Controls.Add(this.txtCodigo);
            this.tbpPedido.Controls.Add(this.btnGerar);
            this.tbpPedido.Controls.Add(this.btnBuscar);
            this.tbpPedido.Controls.Add(this.pnlCabec);
            this.tbpPedido.Controls.Add(this.lblCliente);
            this.tbpPedido.Location = new System.Drawing.Point(4, 29);
            this.tbpPedido.Name = "tbpPedido";
            this.tbpPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPedido.Size = new System.Drawing.Size(678, 664);
            this.tbpPedido.TabIndex = 0;
            this.tbpPedido.Text = "Pedido";
            this.tbpPedido.UseVisualStyleBackColor = true;
            // 
            // tbpItens
            // 
            this.tbpItens.Controls.Add(this.dgvItens);
            this.tbpItens.Location = new System.Drawing.Point(4, 29);
            this.tbpItens.Name = "tbpItens";
            this.tbpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItens.Size = new System.Drawing.Size(678, 664);
            this.tbpItens.TabIndex = 1;
            this.tbpItens.Text = "Itens";
            this.tbpItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItens.ColumnHeadersHeight = 30;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowTemplate.Height = 28;
            this.dgvItens.Size = new System.Drawing.Size(672, 658);
            this.dgvItens.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 694);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tbcPrincipal);
            this.KeyPreview = true;
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
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpPedido.ResumeLayout(false);
            this.tbpPedido.PerformLayout();
            this.tbpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStripMenuItem limpaTelaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.TextBox txtQtdItens;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpPedido;
        private System.Windows.Forms.TabPage tbpItens;
        private System.Windows.Forms.DataGridView dgvItens;
    }
}