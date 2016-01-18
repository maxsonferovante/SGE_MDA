using System.Windows.Forms;
using System;

namespace mda
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            LbDataHora.Text = DateTime.Now.ToString("dddd, dd") + " de " + DateTime.Now.ToString("MMMM") + " de " + DateTime.Now.ToString("yyyy. HH:mm");
        }

        //Fechar e matar o form oculto anterior
        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult op = MessageBox.Show("Deseja realmente sair do programa ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (op == DialogResult.No);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbDataHora.Text = DateTime.Now.ToString("dddd, dd") + " de " + DateTime.Now.ToString("MMMM") + " de " + DateTime.Now.ToString("yyyy. HH:mm");
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVenda telavenda = new TelaVenda();
            telavenda.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsulta telaconsulta = new TelaConsulta();
            telaconsulta.ShowDialog();
        }

        private void inserirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInserirProduto InserirProduto = new TelaInserirProduto();
            InserirProduto.ShowDialog();
        }

       
    }
}
