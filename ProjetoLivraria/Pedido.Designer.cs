namespace ProjetoLivraria
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.txtValorLivro = new System.Windows.Forms.TextBox();
            this.lblValorLivro = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.cmbEscolherLivro = new System.Windows.Forms.ComboBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpRecomendados = new System.Windows.Forms.GroupBox();
            this.chkLimbus = new System.Windows.Forms.CheckBox();
            this.chkFezCurso = new System.Windows.Forms.CheckBox();
            this.chkCurso = new System.Windows.Forms.CheckBox();
            this.chkFaust = new System.Windows.Forms.CheckBox();
            this.chkYuri = new System.Windows.Forms.CheckBox();
            this.chkBrutal = new System.Windows.Forms.CheckBox();
            this.chkMoggador = new System.Windows.Forms.CheckBox();
            this.chkDev = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpRecomendados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.Location = new System.Drawing.Point(366, 161);
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.ReadOnly = true;
            this.txtValorLivro.Size = new System.Drawing.Size(100, 20);
            this.txtValorLivro.TabIndex = 0;
            this.txtValorLivro.TabStop = false;
            // 
            // lblValorLivro
            // 
            this.lblValorLivro.AutoSize = true;
            this.lblValorLivro.Location = new System.Drawing.Point(363, 124);
            this.lblValorLivro.Name = "lblValorLivro";
            this.lblValorLivro.Size = new System.Drawing.Size(78, 13);
            this.lblValorLivro.TabIndex = 1;
            this.lblValorLivro.Text = "VALOR LIVRO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(511, 124);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(104, 13);
            this.lblValorOpcionais.TabIndex = 2;
            this.lblValorOpcionais.Text = "VALOR OPCIONAIS";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(514, 161);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.ReadOnly = true;
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 3;
            this.txtValorOpcionais.TabStop = false;
            // 
            // cmbEscolherLivro
            // 
            this.cmbEscolherLivro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolherLivro.FormattingEnabled = true;
            this.cmbEscolherLivro.Location = new System.Drawing.Point(61, 78);
            this.cmbEscolherLivro.Name = "cmbEscolherLivro";
            this.cmbEscolherLivro.Size = new System.Drawing.Size(254, 24);
            this.cmbEscolherLivro.TabIndex = 4;
            this.cmbEscolherLivro.TabStop = false;
            this.cmbEscolherLivro.Text = "ESCOLHA ALGUM LIVRO";
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(352, 315);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(399, 278);
            this.dgvPedido.TabIndex = 5;
            this.dgvPedido.TabStop = false;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(667, 124);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "VALOR A PAGAR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(349, 242);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(562, 242);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(670, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(404, 242);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(637, 239);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 11;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(349, 614);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 34);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(450, 614);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 34);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(551, 614);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 34);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(656, 614);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 34);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpRecomendados
            // 
            this.grpRecomendados.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grpRecomendados.Controls.Add(this.chkLimbus);
            this.grpRecomendados.Controls.Add(this.chkFezCurso);
            this.grpRecomendados.Controls.Add(this.chkCurso);
            this.grpRecomendados.Controls.Add(this.chkFaust);
            this.grpRecomendados.Controls.Add(this.chkYuri);
            this.grpRecomendados.Controls.Add(this.chkBrutal);
            this.grpRecomendados.Controls.Add(this.chkMoggador);
            this.grpRecomendados.Controls.Add(this.chkDev);
            this.grpRecomendados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecomendados.Location = new System.Drawing.Point(61, 168);
            this.grpRecomendados.Name = "grpRecomendados";
            this.grpRecomendados.Size = new System.Drawing.Size(254, 359);
            this.grpRecomendados.TabIndex = 16;
            this.grpRecomendados.TabStop = false;
            this.grpRecomendados.Text = "RECOMENDAÇÃO";
            this.grpRecomendados.Enter += new System.EventHandler(this.grpRecomendados_Enter);
            // 
            // chkLimbus
            // 
            this.chkLimbus.AutoSize = true;
            this.chkLimbus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLimbus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLimbus.Location = new System.Drawing.Point(6, 227);
            this.chkLimbus.Name = "chkLimbus";
            this.chkLimbus.Size = new System.Drawing.Size(222, 25);
            this.chkLimbus.TabIndex = 7;
            this.chkLimbus.TabStop = false;
            this.chkLimbus.Text = "Project Moon Mentioned";
            this.chkLimbus.UseVisualStyleBackColor = true;
            // 
            // chkFezCurso
            // 
            this.chkFezCurso.AutoSize = true;
            this.chkFezCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFezCurso.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFezCurso.Location = new System.Drawing.Point(6, 307);
            this.chkFezCurso.Name = "chkFezCurso";
            this.chkFezCurso.Size = new System.Drawing.Size(132, 25);
            this.chkFezCurso.TabIndex = 6;
            this.chkFezCurso.TabStop = false;
            this.chkFezCurso.Text = "Eu fiz o curso";
            this.chkFezCurso.UseVisualStyleBackColor = true;
            // 
            // chkCurso
            // 
            this.chkCurso.AutoSize = true;
            this.chkCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCurso.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurso.Location = new System.Drawing.Point(6, 267);
            this.chkCurso.Name = "chkCurso";
            this.chkCurso.Size = new System.Drawing.Size(151, 25);
            this.chkCurso.TabIndex = 5;
            this.chkCurso.TabStop = false;
            this.chkCurso.Text = "Compre o curso";
            this.chkCurso.UseVisualStyleBackColor = true;
            // 
            // chkFaust
            // 
            this.chkFaust.AutoSize = true;
            this.chkFaust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFaust.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFaust.Location = new System.Drawing.Point(6, 187);
            this.chkFaust.Name = "chkFaust";
            this.chkFaust.Size = new System.Drawing.Size(163, 25);
            this.chkFaust.TabIndex = 4;
            this.chkFaust.TabStop = false;
            this.chkFaust.Text = "Faust my Beloved";
            this.chkFaust.UseVisualStyleBackColor = true;
            // 
            // chkYuri
            // 
            this.chkYuri.AutoSize = true;
            this.chkYuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkYuri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYuri.Location = new System.Drawing.Point(6, 147);
            this.chkYuri.Name = "chkYuri";
            this.chkYuri.Size = new System.Drawing.Size(248, 25);
            this.chkYuri.TabIndex = 3;
            this.chkYuri.TabStop = false;
            this.chkYuri.Text = "Yuri deserves a Good Ending";
            this.chkYuri.UseVisualStyleBackColor = true;
            // 
            // chkBrutal
            // 
            this.chkBrutal.AutoSize = true;
            this.chkBrutal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBrutal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrutal.Location = new System.Drawing.Point(6, 106);
            this.chkBrutal.Name = "chkBrutal";
            this.chkBrutal.Size = new System.Drawing.Size(74, 25);
            this.chkBrutal.TabIndex = 2;
            this.chkBrutal.TabStop = false;
            this.chkBrutal.Text = "Brutal";
            this.chkBrutal.UseVisualStyleBackColor = true;
            // 
            // chkMoggador
            // 
            this.chkMoggador.AutoSize = true;
            this.chkMoggador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMoggador.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMoggador.Location = new System.Drawing.Point(6, 66);
            this.chkMoggador.Name = "chkMoggador";
            this.chkMoggador.Size = new System.Drawing.Size(230, 25);
            this.chkMoggador.TabIndex = 1;
            this.chkMoggador.TabStop = false;
            this.chkMoggador.Text = "Moggando todos os Betas";
            this.chkMoggador.UseVisualStyleBackColor = true;
            // 
            // chkDev
            // 
            this.chkDev.AutoSize = true;
            this.chkDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDev.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDev.Location = new System.Drawing.Point(6, 32);
            this.chkDev.Name = "chkDev";
            this.chkDev.Size = new System.Drawing.Size(157, 25);
            this.chkDev.TabIndex = 0;
            this.chkDev.TabStop = false;
            this.chkDev.Text = "Se torne um Dev";
            this.chkDev.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "FAÇA SEU PEDIDO";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRecomendados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbEscolherLivro);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorLivro);
            this.Controls.Add(this.txtValorLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpRecomendados.ResumeLayout(false);
            this.grpRecomendados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorLivro;
        private System.Windows.Forms.Label lblValorLivro;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.ComboBox cmbEscolherLivro;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grpRecomendados;
        private System.Windows.Forms.CheckBox chkMoggador;
        private System.Windows.Forms.CheckBox chkDev;
        private System.Windows.Forms.CheckBox chkBrutal;
        private System.Windows.Forms.CheckBox chkYuri;
        private System.Windows.Forms.CheckBox chkFezCurso;
        private System.Windows.Forms.CheckBox chkCurso;
        private System.Windows.Forms.CheckBox chkFaust;
        private System.Windows.Forms.CheckBox chkLimbus;
        private System.Windows.Forms.Label label1;
    }
}