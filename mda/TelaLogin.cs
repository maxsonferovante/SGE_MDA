using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace mda
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            //Arquivos temporários
            if (Directory.Exists("temp"))
            {
                Directory.Delete("temp", true);
                Directory.CreateDirectory("temp");
            }
            else
            {
                Directory.CreateDirectory("temp");
            }
            //Nome do arquivo do backup do dia.
            string autobackupArquivo = "Backup\\mda_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bd";
            //Verifica se o banco de dados existe
            if (File.Exists("mda.bd") == true)
            {
                //Verificar se o backup do dia existe
                if (File.Exists(autobackupArquivo))
                {
                    //Apagar backups antigos. Serão armazenados somente arquivos para uma semana.
                    ApagaBackupAntigo();
                }
                //Caso o backup do dia não exista...
                else
                {
                    //Verificar se já foi feito algum backup na vida
                    if (Directory.Exists("Backup"))
                    {
                        //Se sim, o backup do dia não foi feito, e será feito neste momento.
                        File.Copy("mda.bd", autobackupArquivo);
                        ApagaBackupAntigo();
                    }
                    //Se nunca nunca foi feito...
                    else
                    {
                        //...criar a pasta de backups e salvar o backup do dia.
                        Directory.CreateDirectory("Backup");
                        File.Copy("mda.bd", autobackupArquivo);
                    }
                }
                //Caso o backup manual teha sido feito...
                while (GetDifferenceDays() >15)
                {
                    MessageBox.Show("Para utilizar o programa, faça um backup agora!", "Alerta de backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveFileDialog dialogSalvarBackupObrigatorio = new SaveFileDialog();
                    dialogSalvarBackupObrigatorio.Title = "mda - Salvar cópia de segurança obrigatória...";
                    dialogSalvarBackupObrigatorio.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                    dialogSalvarBackupObrigatorio.Filter = "Banco de dados do mda (*.bd)|*.bd";


                    //Nome do arquivo padrão: mda_dd-MM-yyyy.bd
                    dialogSalvarBackupObrigatorio.FileName = "mda_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bd";
                    DialogResult resultado = dialogSalvarBackupObrigatorio.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        System.IO.File.Copy("mda.bd", dialogSalvarBackupObrigatorio.FileName, true);
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updataDate();
                    }
                }
                InitializeComponent();
            }
            else
            {
                //Criação de um banco de dados vazio.
                MessageBox.Show("Banco de dados não encontrado!", "Erro fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (SQLiteConnection cnn = new SQLiteConnection("data source=mda.bd"))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "CREATE  TABLE \"main\".\"produtos\" (\"numero\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , \"nome\" TEXT, \"codigo\" TEXT, \"quantidade\" TEXT, \"preco-compra\" TEXT, \"preco-venda\" TEXT)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE \"usuario\" (\"senha\" TEXT NOT NULL )";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE  TABLE \"backup\" (\"data\" TEXT NOT NULL )";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "INSERT INTO \"usuario\" VALUES (\"372963e2e608aa28e2a5198308e7d276\");";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "INSERT INTO \"backup\" VALUES (\"" + DateTime.Now.ToString("dd/MM/yyyy") + "\");";
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                MessageBox.Show("Um banco de dados vazio foi criado. Reinicie o programa.", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }

        //Número máximo de tentativas de login
        public int tentativas = 3;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            if (senha == "")
            {
                MessageBox.Show("Digite a senha!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Buscar no banco de dados pelo login e senha.
                using (SQLiteConnection cnn = new SQLiteConnection("data source=mda.bd"))
                {
                    cnn.Open();
                    string sql = "SELECT * FROM usuario where senha like '" + CalculateMD5Hash(senha + senha) + "'";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, cnn))
                    {
                        using (SQLiteDataReader readerLogin = cmd.ExecuteReader())
                        {
                            //Se encontrou resultados para a senha informada, o login foi realizado com sucesso.
                            if (readerLogin.HasRows == true)
                            {
                                TelaPrincipal principal = new TelaPrincipal();
                                principal.Show();
                                //TODO: Fechar o form de verdade. Que covardia escondê-lo.
                                this.Hide();
                            }
                            else
                            {
                                //...mostrar erro e gastar tentativa enquanto houverem tentativas...
                                while (tentativas > 0)
                                {
                                    MessageBox.Show("Verifique se os dados digitados estão corretos.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    tentativas--;
                                    break;
                                }
                                //...então fechar o programa.
                                if (tentativas == 0)
                                {
                                    MessageBox.Show("Número de tentativas excedido.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                        }
                    }
                    cnn.Close();
                }
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha AlterarSenha = new TelaAlterarSenha();
           AlterarSenha.ShowDialog();
        }

        public void ApagaBackupAntigo()
        {
            File.Delete("Backup\\mda_" + DateTime.Now.AddDays(-7).ToString("dd-MM-yyyy") + ".bd");
            File.Delete("Backup\\mda_" + DateTime.Now.AddDays(-8).ToString("dd-MM-yyyy") + ".bd");
            File.Delete("Backup\\mda_" + DateTime.Now.AddDays(-9).ToString("dd-MM-yyyy") + ".bd");
        }

        //Cálculo de hash MD5
        //Copiado de http://blogs.msdn.com/b/csharpfaq/archive/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string_3f00_.aspx
        public static string CalculateMD5Hash(string input)
        {
            //Passo 1: Calcular MD5 da entrada
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            //Passo 2: Converter de byte array para string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                //Letras minúsculas
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        //Coisa feia que deve estar escodida em uma método no fim do documento, mas nos trás a última data em que foi realizado no backup manual.
        public double GetDifferenceDays()
        {
            double dias;
            using (SQLiteConnection cnn = new SQLiteConnection("data source=mda.bd "))
            {
                cnn.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM backup ", cnn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        string ultimadata = reader["data"].ToString();
                        TimeSpan direfencia = DateTime.Now - Convert.ToDateTime(ultimadata);
                        dias = direfencia.TotalDays;
                    }
                }
                cnn.Close();
            }
            return dias;
        }
        //Mais uma coisa feia: essa faz a atualização da data do backup manual.
        public void updataDate()
        {
            using (SQLiteConnection cnn = new SQLiteConnection("data source = mda.bd"))
            {
                cnn.Open();
                using (SQLiteCommand command = new SQLiteCommand(cnn))
                {
                    command.CommandText = " UPDATE backup SET data = '" + DateTime.Now.ToString("dd-MM-yyyy") + "' where rowid = 1";
                    command.ExecuteNonQuery();
                }
                cnn.Close();
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnEntrar;
        }
     }
}
