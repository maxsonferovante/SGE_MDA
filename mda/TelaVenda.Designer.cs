namespace mda
{
    partial class TelaVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNumeroVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBDataVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBHoraVenda = new System.Windows.Forms.TextBox();
            this.dGTabelaItems = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cBListaProdutos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mTBQuantDesejada = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBQuantEstoque = new System.Windows.Forms.TextBox();
            this.bttnIncluir = new System.Windows.Forms.Button();
            this.bttnSalvarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGTabelaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(16, 54);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(172, 21);
            this.cbFuncionario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº";
            // 
            // tBNumeroVenda
            // 
            this.tBNumeroVenda.Enabled = false;
            this.tBNumeroVenda.Location = new System.Drawing.Point(38, 7);
            this.tBNumeroVenda.Name = "tBNumeroVenda";
            this.tBNumeroVenda.Size = new System.Drawing.Size(80, 20);
            this.tBNumeroVenda.TabIndex = 0;
            this.tBNumeroVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data da Compra:";
            // 
            // tBDataVenda
            // 
            this.tBDataVenda.Enabled = false;
            this.tBDataVenda.Location = new System.Drawing.Point(240, 7);
            this.tBDataVenda.Name = "tBDataVenda";
            this.tBDataVenda.Size = new System.Drawing.Size(80, 20);
            this.tBDataVenda.TabIndex = 1;
            this.tBDataVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora da Compra:";
            // 
            // tBHoraVenda
            // 
            this.tBHoraVenda.Enabled = false;
            this.tBHoraVenda.Location = new System.Drawing.Point(434, 7);
            this.tBHoraVenda.Name = "tBHoraVenda";
            this.tBHoraVenda.Size = new System.Drawing.Size(80, 20);
            this.tBHoraVenda.TabIndex = 2;
            this.tBHoraVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dGTabelaItems
            // 
            this.dGTabelaItems.AllowUserToAddRows = false;
            this.dGTabelaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGTabelaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.codigo,
            this.quantidade,
            this.preco,
            this.subpreco});
            this.dGTabelaItems.Location = new System.Drawing.Point(16, 91);
            this.dGTabelaItems.Name = "dGTabelaItems";
            this.dGTabelaItems.Size = new System.Drawing.Size(543, 150);
            this.dGTabelaItems.TabIndex = 5;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // subpreco
            // 
            this.subpreco.HeaderText = "Sub-Preço";
            this.subpreco.Name = "subpreco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista de Produtos: ";
            // 
            // cBListaProdutos
            // 
            this.cBListaProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBListaProdutos.FormattingEnabled = true;
            this.cBListaProdutos.Location = new System.Drawing.Point(16, 270);
            this.cBListaProdutos.Name = "cBListaProdutos";
            this.cBListaProdutos.Size = new System.Drawing.Size(205, 21);
            this.cBListaProdutos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade Desejada:";
            // 
            // mTBQuantDesejada
            // 
            this.mTBQuantDesejada.Location = new System.Drawing.Point(240, 270);
            this.mTBQuantDesejada.Mask = "00000";
            this.mTBQuantDesejada.Name = "mTBQuantDesejada";
            this.mTBQuantDesejada.Size = new System.Drawing.Size(100, 20);
            this.mTBQuantDesejada.TabIndex = 7;
            this.mTBQuantDesejada.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidade em Estoque:";
            // 
            // tBQuantEstoque
            // 
            this.tBQuantEstoque.Location = new System.Drawing.Point(372, 270);
            this.tBQuantEstoque.Name = "tBQuantEstoque";
            this.tBQuantEstoque.Size = new System.Drawing.Size(112, 20);
            this.tBQuantEstoque.TabIndex = 8;
            this.tBQuantEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnIncluir
            // 
            this.bttnIncluir.Location = new System.Drawing.Point(499, 255);
            this.bttnIncluir.Name = "bttnIncluir";
            this.bttnIncluir.Size = new System.Drawing.Size(60, 38);
            this.bttnIncluir.TabIndex = 9;
            this.bttnIncluir.Text = "Incluir";
            this.bttnIncluir.UseVisualStyleBackColor = true;
            // 
            // bttnSalvarVenda
            // 
            this.bttnSalvarVenda.Location = new System.Drawing.Point(16, 397);
            this.bttnSalvarVenda.Name = "bttnSalvarVenda";
            this.bttnSalvarVenda.Size = new System.Drawing.Size(69, 30);
            this.bttnSalvarVenda.TabIndex = 16;
            this.bttnSalvarVenda.Text = "Salvar";
            this.bttnSalvarVenda.UseVisualStyleBackColor = true;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 442);
            this.Controls.Add(this.bttnSalvarVenda);
            this.Controls.Add(this.bttnIncluir);
            this.Controls.Add(this.tBQuantEstoque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTBQuantDesejada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBListaProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGTabelaItems);
            this.Controls.Add(this.tBHoraVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBDataVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBNumeroVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaVenda_FormClosing);
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGTabelaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNumeroVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBDataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBHoraVenda;
        private System.Windows.Forms.DataGridView dGTabelaItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBListaProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mTBQuantDesejada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBQuantEstoque;
        private System.Windows.Forms.Button bttnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn subpreco;
        private System.Windows.Forms.Button bttnSalvarVenda;
    }
}