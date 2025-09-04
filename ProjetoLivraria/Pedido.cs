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
    public partial class Pedido : Form
    {
        //INSTANCIANDO A CLASSE DE CONEXÂO
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            chkBrutal.Checked = false;
            chkCurso.Checked = false;
            chkFezCurso.Checked = false;
            chkDev.Checked = false;
            chkFaust.Checked = false;
            chkYuri.Checked = false;
            chkMoggador.Checked = false;
            chkLimbus.Checked = false;

            txtValorOpcionais.Clear();
            txtTotal.Clear();
            txtValorLivro.Clear();
            cmbEscolherLivro.SelectedIndex = 0;
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbEscolherLivro.Items.Add("The Wings(Yi Sang) - R$ 122,22");
            cmbEscolherLivro.Items.Add("Goethe's Faust - R$ 101,20");
            cmbEscolherLivro.Items.Add("Don Quixote - R$ 29,90");
            cmbEscolherLivro.Items.Add("Hell Screen(地獄変, Jigokuhen) - R$ 137,00");
            cmbEscolherLivro.Items.Add("The Stranger(Albert Camus) - R$ 84,00");
            cmbEscolherLivro.Items.Add("Dream of the Red Chamber - R$ 109,00");
            cmbEscolherLivro.Items.Add("Wuthering Heights - R$ 57,90");
            cmbEscolherLivro.Items.Add("Moby-Dick - R$ 91,00");
            cmbEscolherLivro.Items.Add("Inferno (Dante) - R$ 72,00");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorLivro = 0;
            double valorOpcao = 0;
            double valorTotal = 0;

            if (cmbEscolherLivro.SelectedIndex == 0)
            {
                valorLivro = 122;
            }
            else if (cmbEscolherLivro.SelectedIndex == 1)
            {
                valorLivro = 101;
            }
            else if (cmbEscolherLivro.SelectedIndex == 2)
            {
                valorLivro = 29;
            }
            else if (cmbEscolherLivro.SelectedIndex == 3)
            {
                valorLivro = 137;
            }
            else if (cmbEscolherLivro.SelectedIndex == 4)
            {
                valorLivro = 84;
            }
            else if (cmbEscolherLivro.SelectedIndex == 5)
            {
                valorLivro = 109;
            }
            else if (cmbEscolherLivro.SelectedIndex == 6)
            {
                valorLivro = 57;
            }
            else if (cmbEscolherLivro.SelectedIndex == 7)
            {
                valorLivro = 91;
            }
            else if (cmbEscolherLivro.SelectedIndex == 8)
            {
                valorLivro = 72;
            }
            if (chkCurso.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkBrutal.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkDev.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkFaust.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkFezCurso.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkLimbus.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkMoggador.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkYuri.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorLivro + valorOpcao;
            txtValorLivro.Text = Convert.ToString(valorLivro);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtTotal.Text = Convert.ToString(valorTotal);
        }
    }
}
