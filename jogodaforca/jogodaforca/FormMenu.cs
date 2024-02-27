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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private string SortearPalavra()
        {
            List<string> palavras = new List<string> { "csharp", "python", "ruby", "php", "javascript" };

            Random rnd = new Random();
            int indiceSorteado = rnd.Next(0, palavras.Count);


            string palavraSorteada = palavras[indiceSorteado];

            return palavraSorteada;
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form FormJogo = new FormJogo();

            FormJogo.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form FormCadastro = new FormCadastro();

            FormCadastro.ShowDialog();
        }
    }
}
