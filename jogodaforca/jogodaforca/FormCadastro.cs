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

namespace jogodaforca
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            string conexaoString = "server=localhost;user=root;database=db_jogoforca;port=3306;password=";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string scriptSQL = "SELECT id, palavra FROM tb_palavras";

                using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                {
                    conexao.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string palavra = reader.GetString(1);

                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + palavra);
                            listViewCadastro.Items.Add(lista);
                        }
                    }

                    conexao.Close();
                }
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            listViewCadastro.View = View.Details;
            listViewCadastro.Columns.Add("palavras", 255);

            CarregarDados();
        }

        private void CadastrarDados(string palavra)
        {
            string conexaoString = "server=localhost;user=root;database=db_jogoforca;port=3306;password=";
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUES (@valorPalavra)";

                    using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                    {
                        conexao.Open();

                        command.Parameters.AddWithValue("@valorPalavra", palavra);

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Palavra Cadastrada com sucesso !!!");
                        }

                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string palavraEscolhida = txbCadastro.Text;

            if (palavraEscolhida.Trim() != "")
            {
                CadastrarDados(palavraEscolhida);
            }

            txbCadastro.Text = "";
            listViewCadastro.Items.Clear();
            CarregarDados();

        }
    }
}
