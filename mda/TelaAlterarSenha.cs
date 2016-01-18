using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace mda
{
    public partial class TelaAlterarSenha : Form
    {
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((txtSenha.Text == "") || (txtNova1.Text == "") || (txtNova2.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!", "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtNova1.Text != txtNova2.Text)
                {
                    MessageBox.Show("Senhas não conferem!", "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SQLiteConnection cnn = new SQLiteConnection("data source=mda.bd"))
                    {
                        cnn.Open();
                        string teste = "SELECT * FROM usuario where senha like '" + TelaLogin.CalculateMD5Hash(txtSenha.Text + txtSenha.Text) + "'";
                        using (SQLiteCommand login = new SQLiteCommand(teste, cnn))
                        {
                            using (SQLiteDataReader readerLogin = login.ExecuteReader())
                            {
                                if (readerLogin.HasRows == true)
                                {
                                    using (SQLiteCommand alteracao = new SQLiteCommand(cnn))
                                    {
                                        alteracao.CommandText = "UPDATE usuario SET senha = '" + TelaLogin.CalculateMD5Hash(txtNova1.Text + txtNova1.Text) + "' where senha like '" + TelaLogin.CalculateMD5Hash(txtSenha.Text + txtSenha.Text) + "'";
                                        alteracao.ExecuteNonQuery();
                                        MessageBox.Show("Senha alterada com sucesso!", "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Senhas não conferem!", "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        cnn.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       
    }
}
