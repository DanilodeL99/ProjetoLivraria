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
            this.btnSair = new System.Windows.Forms.Button();
            this.grpRecomendados = new System.Windows.Forms.GroupBox();
            this.chkMoggador = new System.Windows.Forms.CheckBox();
            this.chkDev = new System.Windows.Forms.CheckBox();
            this.chkBrutal = new System.Windows.Forms.CheckBox();
            this.chkYuri = new System.Windows.Forms.CheckBox();
            this.chkFaust = new System.Windows.Forms.CheckBox();
            this.chkCurso = new System.Windows.Forms.CheckBox();
            this.chkFezCurso = new System.Windows.Forms.CheckBox();
            this.chkLimbus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpRecomendados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.Location = new System.Drawing.Point(347, 83);
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.Size = new System.Drawing.Size(100, 20);
            this.txtValorLivro.TabIndex = 0;
            // 
            // lblValorLivro
            // 
            this.lblValorLivro.AutoSize = true;
            this.lblValorLivro.Location = new System.Drawing.Point(344, 46);
            this.lblValorLivro.Name = "lblValorLivro";
            this.lblValorLivro.Size = new System.Drawing.Size(78, 13);
            this.lblValorLivro.TabIndex = 1;
            this.lblValorLivro.Text = "VALOR LIVRO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(492, 46);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(104, 13);
            this.lblValorOpcionais.TabIndex = 2;
            this.lblValorOpcionais.Text = "VALOR OPCIONAIS";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(495, 83);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 3;
            // 
            // cmbEscolherLivro
            // 
            this.cmbEscolherLivro.FormattingEnabled = true;
            this.cmbEscolherLivro.Location = new System.Drawing.Point(61, 46);
            this.cmbEscolherLivro.Name = "cmbEscolherLivro";
            this.cmbEscolherLivro.Size = new System.Drawing.Size(254, 21);
            this.cmbEscolherLivro.TabIndex = 4;
            this.cmbEscolherLivro.Text = "ESCOLHA ALGUM LIVRO";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(347, 215);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(399, 168);
            this.dgvPedido.TabIndex = 5;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(648, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "VALOR A PAGAR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(330, 164);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(543, 164);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(651, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(385, 164);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(618, 161);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 11;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(344, 404);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 34);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 404);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 34);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(546, 404);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 34);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(651, 404);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 34);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpRecomendados
            // 
            this.grpRecomendados.Controls.Add(this.chkLimbus);
            this.grpRecomendados.Controls.Add(this.chkFezCurso);
            this.grpRecomendados.Controls.Add(this.chkCurso);
            this.grpRecomendados.Controls.Add(this.chkFaust);
            this.grpRecomendados.Controls.Add(this.chkYuri);
            this.grpRecomendados.Controls.Add(this.chkBrutal);
            this.grpRecomendados.Controls.Add(this.chkMoggador);
            this.grpRecomendados.Controls.Add(this.chkDev);
            this.grpRecomendados.Location = new System.Drawing.Point(61, 215);
            this.grpRecomendados.Name = "grpRecomendados";
            this.grpRecomendados.Size = new System.Drawing.Size(200, 203);
            this.grpRecomendados.TabIndex = 16;
            this.grpRecomendados.TabStop = false;
            this.grpRecomendados.Text = "RECOMENDAÇÃO";
            this.grpRecomendados.Enter += new System.EventHandler(this.grpRecomendados_Enter);
            // 
            // chkMoggador
            // 
            this.chkMoggador.AutoSize = true;
            this.chkMoggador.Location = new System.Drawing.Point(6, 42);
            this.chkMoggador.Name = "chkMoggador";
            this.chkMoggador.Size = new System.Drawing.Size(150, 17);
            this.chkMoggador.TabIndex = 1;
            this.chkMoggador.Text = "Moggando todos os Betas";
            this.chkMoggador.UseVisualStyleBackColor = true;
            // 
            // chkDev
            // 
            this.chkDev.AutoSize = true;
            this.chkDev.Location = new System.Drawing.Point(6, 19);
            this.chkDev.Name = "chkDev";
            this.chkDev.Size = new System.Drawing.Size(106, 17);
            this.chkDev.TabIndex = 0;
            this.chkDev.Text = "Se torne um Dev";
            this.chkDev.UseVisualStyleBackColor = true;
            // 
            // chkBrutal
            // 
            this.chkBrutal.AutoSize = true;
            this.chkBrutal.Location = new System.Drawing.Point(6, 65);
            this.chkBrutal.Name = "chkBrutal";
            this.chkBrutal.Size = new System.Drawing.Size(53, 17);
            this.chkBrutal.TabIndex = 2;
            this.chkBrutal.Text = "Brutal";
            this.chkBrutal.UseVisualStyleBackColor = true;
            // 
            // chkYuri
            // 
            this.chkYuri.AutoSize = true;
            this.chkYuri.Location = new System.Drawing.Point(6, 88);
            this.chkYuri.Name = "chkYuri";
            this.chkYuri.Size = new System.Drawing.Size(164, 17);
            this.chkYuri.TabIndex = 3;
            this.chkYuri.Text = "Yuri deserves a Good Ending";
            this.chkYuri.UseVisualStyleBackColor = true;
            // 
            // chkFaust
            // 
            this.chkFaust.AutoSize = true;
            this.chkFaust.Location = new System.Drawing.Point(6, 111);
            this.chkFaust.Name = "chkFaust";
            this.chkFaust.Size = new System.Drawing.Size(110, 17);
            this.chkFaust.TabIndex = 4;
            this.chkFaust.Text = "Faust my Beloved";
            this.chkFaust.UseVisualStyleBackColor = true;
            // 
            // chkCurso
            // 
            this.chkCurso.AutoSize = true;
            this.chkCurso.Location = new System.Drawing.Point(6, 157);
            this.chkCurso.Name = "chkCurso";
            this.chkCurso.Size = new System.Drawing.Size(100, 17);
            this.chkCurso.TabIndex = 5;
            this.chkCurso.Text = "Compre o curso";
            this.chkCurso.UseVisualStyleBackColor = true;
            // 
            // chkFezCurso
            // 
            this.chkFezCurso.AutoSize = true;
            this.chkFezCurso.Location = new System.Drawing.Point(6, 180);
            this.chkFezCurso.Name = "chkFezCurso";
            this.chkFezCurso.Size = new System.Drawing.Size(90, 17);
            this.chkFezCurso.TabIndex = 6;
            this.chkFezCurso.Text = "Eu fiz o curso";
            this.chkFezCurso.UseVisualStyleBackColor = true;
            // 
            // chkLimbus
            // 
            this.chkLimbus.AutoSize = true;
            this.chkLimbus.Location = new System.Drawing.Point(6, 134);
            this.chkLimbus.Name = "chkLimbus";
            this.chkLimbus.Size = new System.Drawing.Size(159, 17);
            this.chkLimbus.TabIndex = 7;
            this.chkLimbus.Text = "Limbus Company Mentioned";
            this.chkLimbus.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRecomendados);
            this.Controls.Add(this.btnSair);
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
            this.Name = "Pedido";
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
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpRecomendados;
        private System.Windows.Forms.CheckBox chkMoggador;
        private System.Windows.Forms.CheckBox chkDev;
        private System.Windows.Forms.CheckBox chkBrutal;
        private System.Windows.Forms.CheckBox chkYuri;
        private System.Windows.Forms.CheckBox chkFezCurso;
        private System.Windows.Forms.CheckBox chkCurso;
        private System.Windows.Forms.CheckBox chkFaust;
        private System.Windows.Forms.CheckBox chkLimbus;
    }
}