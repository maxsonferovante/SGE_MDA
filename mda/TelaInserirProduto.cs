using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mda
{
    public partial class TelaInserirProduto : Form
    {
        public bool atualizacao = false;
        public TelaInserirProduto()
        {

            InitializeComponent();
        }

        private void TelaInserirProduto_Load(object sender, EventArgs e)
        {
            if (atualizacao) 
            {
                this.Name = "Atualizando Produto";
                bttInserir.Text = "Atualizar";
            }
        }


        private void txtPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCompra);
        }
        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Copiada: https://www.youtube.com/watch?v=mqwhgCSOTdA
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {
            }
        }

    
    } 
}
