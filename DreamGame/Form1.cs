using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string conexaoString = "Server=localhost; Port=3306; Database=db_dreamgame; Uid=root; Pwd=;";

            //Defina a insert de registro no DB

            string query = "INSERT INTO tb_jogos (Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero) VALUES (@Titulo, @Avaliacao, @Tamanho, @Descricao, @Valor, @Desenvolvedor, @Genero)";

            //Crie uma conexão com o DB

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@Avaliacao", comboBoxAvaliacao.Text);
                        comando.Parameters.AddWithValue("@Tamanho", maskedTextBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@Descricao", richTextBoxDesc.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", textBoxDev.Text);
                        comando.Parameters.AddWithValue("@Genero", comboBoxGen.Text);

                        // Executa o comando inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Informações do jogo inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro
                    MessageBox.Show("Erro: " + ex.Message);

                }

            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            comboBoxAvaliacao.Text = "";
            maskedTextBoxTamanho.Text = "";
            richTextBoxDesc.Text = "";
            maskedTextBoxValor.Text = "";
            textBoxDev.Text = "";
            comboBoxGen.Text = "";
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string connectionString = "Server=localhost; Port=3306; Database=db_dreamgame; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes
                    string listagem = "SELECT Id_Jogo, Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero FROM tb_jogos";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosJogos = new DataTable();
                        dadosJogos.Load(reader);

                        //Atribui a tabela
                        dgvJogos.DataSource = dadosJogos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os jogos: " + ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dgvJogos.SelectedRows.Count > 0)
            {
                // Pega ID do cliente da linha selecionada
                int jogoID = Convert.ToInt32(dgvJogos.SelectedRows[0].Cells["Id_Jogo"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse jogo da lista? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Defina sua string de conexão com o bank
                    string connectionString = "Server=localhost; Port=3306; Database=db_dreamgame; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_jogos WHERE Id_Jogo = @Id_Jogo";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Jogo", jogoID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Jogo excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o jogo");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, selecione um dos jogos para excluir da lista");
                }
            }
        }
    }
}
