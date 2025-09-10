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
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void lblMoby_Click(object sender, EventArgs e)
        {

        }

        private void pbWings_Click(object sender, EventArgs e)
        {
            Yisang wings = new Yisang();
            wings.Show();
            this.Hide();
        }

        private void pbHell_Click(object sender, EventArgs e)
        {
            Hell hell = new Hell();
            hell.Show();
            this.Hide();
        }
    }
}
