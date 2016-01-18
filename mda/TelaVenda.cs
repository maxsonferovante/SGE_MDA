using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Data.SQLite;

namespace mda
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }
        private void TelaVenda_Load(object sender, EventArgs e)
        {
            tBDataVenda.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            tBHoraVenda.Text = DateTime.Now.ToString("HH:mm").ToString();

            /*Carregando nome dos funcionários aparti de um arquivo XML nomeado de "Funcionarios."*/
            XmlDocument doc = new XmlDocument(); 
            doc.Load("funcionarios.xml");
            XmlNodeList funcionariosList = doc["funcionarios"].SelectNodes("funcionario");
            foreach (XmlNode funcionario in funcionariosList)
            {
                cbFuncionario.Items.Add(funcionario.InnerText.ToString());
            }
            /*Carregando lista de produtos no DataGrid TabelaItems*/
            using(SQLiteConnection cnn = new SQLiteConnection ("data source =mda.bd"))
            {
                cnn.Open();
                String Query = "select *from produtos where quantidade > 0";
                using (SQLiteCommand command = new SQLiteCommand(Query, cnn))
                {
                   ////////////////s
                }
            }
        }
        private void TelaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult op = MessageBox.Show("Deseja realmente cancelar a nova venda ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (op == DialogResult.No);
        }

      
    }
}
