namespace DreamGame
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvJogos = new System.Windows.Forms.DataGridView();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDev = new System.Windows.Forms.TextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.maskedTextBoxTamanho = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBoxAvaliacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJogos
            // 
            this.dgvJogos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogos.Location = new System.Drawing.Point(83, 12);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.Size = new System.Drawing.Size(240, 352);
            this.dgvJogos.TabIndex = 0;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisa.Location = new System.Drawing.Point(101, 385);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(92, 43);
            this.buttonPesquisa.TabIndex = 1;
            this.buttonPesquisa.Text = "Pesquisar Jogo";
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.Location = new System.Drawing.Point(209, 385);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(92, 43);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir Jogo";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(432, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(433, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avaliação (1-5)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(433, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(433, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(433, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(433, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desenvolvedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(433, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gênero";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.Pink;
            this.textBoxTitulo.Location = new System.Drawing.Point(491, 27);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(140, 20);
            this.textBoxTitulo.TabIndex = 10;
            // 
            // textBoxDev
            // 
            this.textBoxDev.BackColor = System.Drawing.Color.Pink;
            this.textBoxDev.Location = new System.Drawing.Point(555, 314);
            this.textBoxDev.Name = "textBoxDev";
            this.textBoxDev.Size = new System.Drawing.Size(140, 20);
            this.textBoxDev.TabIndex = 11;
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.BackColor = System.Drawing.Color.Pink;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Simulação",
            "Terror",
            "Estrategia",
            "RPG",
            "Corrida"});
            this.comboBoxGen.Location = new System.Drawing.Point(503, 343);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(97, 21);
            this.comboBoxGen.TabIndex = 12;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.BackColor = System.Drawing.Color.Pink;
            this.richTextBoxDesc.Location = new System.Drawing.Point(436, 138);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(259, 131);
            this.richTextBoxDesc.TabIndex = 13;
            this.richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxTamanho
            // 
            this.maskedTextBoxTamanho.BackColor = System.Drawing.Color.Pink;
            this.maskedTextBoxTamanho.Location = new System.Drawing.Point(516, 89);
            this.maskedTextBoxTamanho.Mask = "00,00 GB";
            this.maskedTextBoxTamanho.Name = "maskedTextBoxTamanho";
            this.maskedTextBoxTamanho.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBoxTamanho.TabIndex = 15;
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.BackColor = System.Drawing.Color.Pink;
            this.maskedTextBoxValor.Location = new System.Drawing.Point(482, 282);
            this.maskedTextBoxValor.Mask = "$ 000,000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBoxValor.TabIndex = 16;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.HotPink;
            this.buttonCadastrar.Location = new System.Drawing.Point(461, 385);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 43);
            this.buttonCadastrar.TabIndex = 17;
            this.buttonCadastrar.Text = "Cadastrar Jogo";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.HotPink;
            this.buttonLimpar.Location = new System.Drawing.Point(566, 385);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(111, 43);
            this.buttonLimpar.TabIndex = 18;
            this.buttonLimpar.Text = "Limpar Campos";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // comboBoxAvaliacao
            // 
            this.comboBoxAvaliacao.BackColor = System.Drawing.Color.Pink;
            this.comboBoxAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvaliacao.FormattingEnabled = true;
            this.comboBoxAvaliacao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxAvaliacao.Location = new System.Drawing.Point(553, 55);
            this.comboBoxAvaliacao.Name = "comboBoxAvaliacao";
            this.comboBoxAvaliacao.Size = new System.Drawing.Size(47, 28);
            this.comboBoxAvaliacao.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAvaliacao);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.maskedTextBoxTamanho);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.textBoxDev);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.dgvJogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dream Game (Cadastro e Gerenciamento de Jogos)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogos;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDev;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTamanho;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBoxAvaliacao;
    }
}

