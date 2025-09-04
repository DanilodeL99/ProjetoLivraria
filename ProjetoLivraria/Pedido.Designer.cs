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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.lblValorLivro.Size = new System.Drawing.Size(104, 13);
            this.lblValorLivro.TabIndex = 1;
            this.lblValorLivro.Text = "VALOR OPCIONAIS";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(553, 46);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(104, 13);
            this.lblValorOpcionais.TabIndex = 2;
            this.lblValorOpcionais.Text = "VALOR OPCIONAIS";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(546, 83);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 3;
            // 
            // cmbEscolherLivro
            // 
            this.cmbEscolherLivro.FormattingEnabled = true;
            this.cmbEscolherLivro.Location = new System.Drawing.Point(61, 46);
            this.cmbEscolherLivro.Name = "cmbEscolherLivro";
            this.cmbEscolherLivro.Size = new System.Drawing.Size(183, 21);
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
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(695, 46);
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
            this.txtTotal.Location = new System.Drawing.Point(688, 83);
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
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(344, 404);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 34);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 404);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 34);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(546, 404);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 34);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(651, 404);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 34);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // grpRecomendados
            // 
            this.grpRecomendados.Controls.Add(this.checkBox2);
            this.grpRecomendados.Controls.Add(this.checkBox1);
            this.grpRecomendados.Location = new System.Drawing.Point(61, 215);
            this.grpRecomendados.Name = "grpRecomendados";
            this.grpRecomendados.Size = new System.Drawing.Size(200, 168);
            this.grpRecomendados.TabIndex = 16;
            this.grpRecomendados.TabStop = false;
            this.grpRecomendados.Text = "RECOMENDAÇÃO";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}