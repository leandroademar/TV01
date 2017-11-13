namespace TV01
{
    partial class frmMapa
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
            this.dgvMapa = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpxTipo = new System.Windows.Forms.GroupBox();
            this.rbtDanfe = new System.Windows.Forms.RadioButton();
            this.rbtCupom = new System.Windows.Forms.RadioButton();
            this.rbtPedidos = new System.Windows.Forms.RadioButton();
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblPedIni = new System.Windows.Forms.Label();
            this.txtPedFim = new System.Windows.Forms.TextBox();
            this.txtPedIni = new System.Windows.Forms.TextBox();
            this.gbxCupom = new System.Windows.Forms.GroupBox();
            this.txtCupomFim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.gbxDanfe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDanfe = new System.Windows.Forms.Label();
            this.txtDanfe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).BeginInit();
            this.gpxTipo.SuspendLayout();
            this.gbxPedido.SuspendLayout();
            this.gbxCupom.SuspendLayout();
            this.gbxDanfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMapa
            // 
            this.dgvMapa.AllowUserToAddRows = false;
            this.dgvMapa.AllowUserToDeleteRows = false;
            this.dgvMapa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMapa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMapa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMapa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvMapa.Location = new System.Drawing.Point(221, 8);
            this.dgvMapa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMapa.Name = "dgvMapa";
            this.dgvMapa.ReadOnly = true;
            this.dgvMapa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMapa.RowHeadersVisible = false;
            this.dgvMapa.RowTemplate.Height = 28;
            this.dgvMapa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMapa.Size = new System.Drawing.Size(398, 61);
            this.dgvMapa.TabIndex = 0;
            this.dgvMapa.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Location = new System.Drawing.Point(221, 165);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "F6 - Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Location = new System.Drawing.Point(297, 165);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Esc - Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpxTipo
            // 
            this.gpxTipo.Controls.Add(this.rbtDanfe);
            this.gpxTipo.Controls.Add(this.rbtCupom);
            this.gpxTipo.Controls.Add(this.rbtPedidos);
            this.gpxTipo.Location = new System.Drawing.Point(8, 8);
            this.gpxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.gpxTipo.Name = "gpxTipo";
            this.gpxTipo.Padding = new System.Windows.Forms.Padding(2);
            this.gpxTipo.Size = new System.Drawing.Size(131, 44);
            this.gpxTipo.TabIndex = 3;
            this.gpxTipo.TabStop = false;
            this.gpxTipo.Text = "Tipo de Mapa";
            // 
            // rbtDanfe
            // 
            this.rbtDanfe.AutoSize = true;
            this.rbtDanfe.Location = new System.Drawing.Point(137, 16);
            this.rbtDanfe.Margin = new System.Windows.Forms.Padding(2);
            this.rbtDanfe.Name = "rbtDanfe";
            this.rbtDanfe.Size = new System.Drawing.Size(55, 20);
            this.rbtDanfe.TabIndex = 6;
            this.rbtDanfe.TabStop = true;
            this.rbtDanfe.Text = "NF-e";
            this.rbtDanfe.UseVisualStyleBackColor = true;
            this.rbtDanfe.Visible = false;
            this.rbtDanfe.CheckedChanged += new System.EventHandler(this.rbtDanfe_CheckedChanged);
            // 
            // rbtCupom
            // 
            this.rbtCupom.AutoSize = true;
            this.rbtCupom.Location = new System.Drawing.Point(69, 16);
            this.rbtCupom.Margin = new System.Windows.Forms.Padding(2);
            this.rbtCupom.Name = "rbtCupom";
            this.rbtCupom.Size = new System.Drawing.Size(65, 20);
            this.rbtCupom.TabIndex = 5;
            this.rbtCupom.TabStop = true;
            this.rbtCupom.Text = "Cupom";
            this.rbtCupom.UseVisualStyleBackColor = true;
            this.rbtCupom.CheckedChanged += new System.EventHandler(this.rbtCupom_CheckedChanged);
            // 
            // rbtPedidos
            // 
            this.rbtPedidos.AutoSize = true;
            this.rbtPedidos.Location = new System.Drawing.Point(4, 16);
            this.rbtPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPedidos.Name = "rbtPedidos";
            this.rbtPedidos.Size = new System.Drawing.Size(70, 20);
            this.rbtPedidos.TabIndex = 4;
            this.rbtPedidos.TabStop = true;
            this.rbtPedidos.Text = "Pedidos";
            this.rbtPedidos.UseVisualStyleBackColor = true;
            this.rbtPedidos.CheckedChanged += new System.EventHandler(this.rbtPedidos_CheckedChanged);
            // 
            // gbxPedido
            // 
            this.gbxPedido.Controls.Add(this.lblFinal);
            this.gbxPedido.Controls.Add(this.lblPedIni);
            this.gbxPedido.Controls.Add(this.txtPedFim);
            this.gbxPedido.Controls.Add(this.txtPedIni);
            this.gbxPedido.Location = new System.Drawing.Point(8, 55);
            this.gbxPedido.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPedido.Size = new System.Drawing.Size(183, 65);
            this.gbxPedido.TabIndex = 4;
            this.gbxPedido.TabStop = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(9, 39);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(57, 13);
            this.lblFinal.TabIndex = 7;
            this.lblFinal.Text = "Ped. Final:";
            // 
            // lblPedIni
            // 
            this.lblPedIni.AutoSize = true;
            this.lblPedIni.Location = new System.Drawing.Point(5, 18);
            this.lblPedIni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedIni.Name = "lblPedIni";
            this.lblPedIni.Size = new System.Drawing.Size(62, 13);
            this.lblPedIni.TabIndex = 5;
            this.lblPedIni.Text = "Ped. Inicial:";
            // 
            // txtPedFim
            // 
            this.txtPedFim.Location = new System.Drawing.Point(69, 37);
            this.txtPedFim.Margin = new System.Windows.Forms.Padding(2);
            this.txtPedFim.Name = "txtPedFim";
            this.txtPedFim.Size = new System.Drawing.Size(96, 20);
            this.txtPedFim.TabIndex = 6;
            // 
            // txtPedIni
            // 
            this.txtPedIni.Location = new System.Drawing.Point(69, 16);
            this.txtPedIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtPedIni.Name = "txtPedIni";
            this.txtPedIni.Size = new System.Drawing.Size(96, 20);
            this.txtPedIni.TabIndex = 5;
            // 
            // gbxCupom
            // 
            this.gbxCupom.Controls.Add(this.txtCupomFim);
            this.gbxCupom.Controls.Add(this.label2);
            this.gbxCupom.Controls.Add(this.txtCupom);
            this.gbxCupom.Location = new System.Drawing.Point(8, 55);
            this.gbxCupom.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCupom.Name = "gbxCupom";
            this.gbxCupom.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCupom.Size = new System.Drawing.Size(187, 65);
            this.gbxCupom.TabIndex = 8;
            this.gbxCupom.TabStop = false;
            // 
            // txtCupomFim
            // 
            this.txtCupomFim.Location = new System.Drawing.Point(69, 40);
            this.txtCupomFim.Margin = new System.Windows.Forms.Padding(2);
            this.txtCupomFim.Name = "txtCupomFim";
            this.txtCupomFim.Size = new System.Drawing.Size(96, 20);
            this.txtCupomFim.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cupom :";
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(69, 16);
            this.txtCupom.Margin = new System.Windows.Forms.Padding(2);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(96, 20);
            this.txtCupom.TabIndex = 5;
            // 
            // gbxDanfe
            // 
            this.gbxDanfe.Controls.Add(this.label1);
            this.gbxDanfe.Controls.Add(this.textBox1);
            this.gbxDanfe.Controls.Add(this.lblDanfe);
            this.gbxDanfe.Controls.Add(this.txtDanfe);
            this.gbxDanfe.Location = new System.Drawing.Point(341, 55);
            this.gbxDanfe.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDanfe.Name = "gbxDanfe";
            this.gbxDanfe.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDanfe.Size = new System.Drawing.Size(187, 83);
            this.gbxDanfe.TabIndex = 9;
            this.gbxDanfe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NF-e :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblDanfe
            // 
            this.lblDanfe.AutoSize = true;
            this.lblDanfe.Location = new System.Drawing.Point(30, 18);
            this.lblDanfe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanfe.Name = "lblDanfe";
            this.lblDanfe.Size = new System.Drawing.Size(36, 13);
            this.lblDanfe.TabIndex = 5;
            this.lblDanfe.Text = "NF-e :";
            // 
            // txtDanfe
            // 
            this.txtDanfe.Location = new System.Drawing.Point(69, 16);
            this.txtDanfe.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanfe.Name = "txtDanfe";
            this.txtDanfe.Size = new System.Drawing.Size(96, 20);
            this.txtDanfe.TabIndex = 5;
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 205);
            this.ControlBox = false;
            this.Controls.Add(this.gbxDanfe);
            this.Controls.Add(this.gbxCupom);
            this.Controls.Add(this.gbxPedido);
            this.Controls.Add(this.gpxTipo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvMapa);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Mapa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMapa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMapa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapa)).EndInit();
            this.gpxTipo.ResumeLayout(false);
            this.gpxTipo.PerformLayout();
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            this.gbxCupom.ResumeLayout(false);
            this.gbxCupom.PerformLayout();
            this.gbxDanfe.ResumeLayout(false);
            this.gbxDanfe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMapa;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpxTipo;
        private System.Windows.Forms.RadioButton rbtDanfe;
        private System.Windows.Forms.RadioButton rbtCupom;
        private System.Windows.Forms.RadioButton rbtPedidos;
        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblPedIni;
        private System.Windows.Forms.TextBox txtPedFim;
        private System.Windows.Forms.TextBox txtPedIni;
        private System.Windows.Forms.GroupBox gbxCupom;
        private System.Windows.Forms.GroupBox gbxDanfe;
        private System.Windows.Forms.Label lblDanfe;
        private System.Windows.Forms.TextBox txtDanfe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCupom;
        private System.Windows.Forms.TextBox txtCupomFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}