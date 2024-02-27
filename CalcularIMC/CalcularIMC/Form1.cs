namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txbPeso.Text);
            double altura = Convert.ToDouble(TxbAltura.Text);

            double imc = peso / (altura * altura);

            lbImc.Text = imc.ToString("F2");

            string classificacao = string.Empty;

            if (imc < 16.9)
                classificacao = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                classificacao = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                classificacao = "Peso Normal";
            else if (imc >= 25 && imc <= 29.9)
                classificacao = "Acima do peso";
            else if (imc >= 30 && imc <= 34.9)
                classificacao = "Obesidade grau 1";
            else if (imc >= 35 && imc <= 40)
                classificacao = "Obesidade grau 2";
            else if (imc > 40)
                classificacao = "Obesidade grau 3";

            lbClassificacao.Text = classificacao;
        }
    }
}
