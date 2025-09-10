using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria
{
    public partial class Hell : Form
    {
        public Hell()
        {
            InitializeComponent();
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.Show();
            this.Hide();
        }
    }
}
