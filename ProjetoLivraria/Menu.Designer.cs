namespace ProjetoLivraria
{
    partial class Menu
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
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(292, 76);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(198, 79);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "IR PARA LOJA";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(292, 222);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(198, 79);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.Text = "IR PARA O PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnLista);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPedido;
    }
}