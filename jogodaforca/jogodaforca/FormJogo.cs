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
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        string palavra_secreta = "";
        string letrasTentadas = "";

       


        //private string SortearPalavra()
        //{
            //List<string> palavras = new List<string> { "csharp", "python", "ruby", "php", "javascript" };

            //Random rnd = new Random();
            //int indiceSorteado = rnd.Next(0, palavras.Count);

            //string palavraSorteada = palavras[indiceSorteado];

            //return palavraSorteada;

        //}

        private string SortearPalavra()
        {
            string conexaoString = "server=localhost;user=root;database=db_jogoforca;port=3306;password=";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string scriptSQL = "SELECT palavra FROM tb_palavras";

                using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                {
                    conexao.Open();
                    List<string> palavrasBanco = new List<string>();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string palavra = reader.GetString(0);
                            palavrasBanco.Add(palavra);
                        }
                    }

                    conexao.Close();

                    Random rnd = new Random();
                    int indiceSorteado = rnd.Next(0, palavrasBanco.Count);

                    return palavrasBanco[indiceSorteado];
                }
            }

            
        }

        private string VerificarPalavra(char[] palavra, char[] letraTentadas)
        {
            string palavra_escondida = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                bool letraAcertada = false;
                for (int j = 0; j < letraTentadas.Length; j++)
                {
                    if (palavra[i] == letraTentadas[j])
                    {
                        palavra_escondida += palavra[i];
                        letraAcertada = true;
                    }
                }

                if (!letraAcertada)
                {
                    palavra_escondida += " _";
                }
            }
            return palavra_escondida;
        }

        private char[] SepararLetraPalavra(string palavra)
        {
            char[] letrasPalavra = new char[palavra.Length];

            letrasPalavra = palavra.ToCharArray();

            return letrasPalavra;
        }


        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {
            string letra = txbTentativa.Text.ToLower();

            bool letraRepetida = false;
            for (int i = 0; i < letrasTentadas.Length; i++)

            {
                letraRepetida = false;
                if (letrasTentadas[i].ToString() == letra)
                {
                    MessageBox.Show("essa letra ja foi jogada, tente novamente!!!");
                    letraRepetida = true;
                }
            }
                int verificarSeGanhou = 0;

                if (!letraRepetida)
                {
                    letrasTentadas += letra;
                    char[] letrasDaPalavra = SepararLetraPalavra(palavra_secreta);
                    string palavra_exibicao = VerificarPalavra(letrasDaPalavra, letrasTentadas.ToCharArray());

                    lbPalavraSecreta.Text = palavra_exibicao;

                    verificarSeGanhou = 0;

            for (int i = 0; 1 < palavra_exibicao.Length; i++)
            {

                if (palavra_exibicao[i] == '_')
                {
                    verificarSeGanhou++;
                }
            }

        }

                if (verificarSeGanhou == 0)
                {
                    MessageBox.Show("Você ganhou!!!");
                    this.Close();
                }

                txbTentativa.Text = "";
            
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            palavra_secreta = SortearPalavra();
            lbPalavraSecreta.Text = palavra_secreta;
        }
    }
}
