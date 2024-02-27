namespace CalcularIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbPeso = new Label();
            lbAltura = new Label();
            txbPeso = new TextBox();
            TxbAltura = new TextBox();
            btnCalcular = new Button();
            lbResultado = new Label();
            lbImc = new Label();
            lbClassificacao = new Label();
            SuspendLayout();
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(45, 51);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 0;
            lbPeso.Text = "Peso";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(45, 83);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 1;
            lbAltura.Text = "Altura";
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(111, 48);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(100, 23);
            txbPeso.TabIndex = 2;
            // 
            // TxbAltura
            // 
            TxbAltura.Location = new Point(111, 80);
            TxbAltura.Name = "TxbAltura";
            TxbAltura.Size = new Size(100, 23);
            TxbAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(111, 139);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CalcularIMC";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(127, 181);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado";
            // 
            // lbImc
            // 
            lbImc.AutoSize = true;
            lbImc.Location = new Point(127, 208);
            lbImc.Name = "lbImc";
            lbImc.Size = new Size(29, 15);
            lbImc.TabIndex = 6;
            lbImc.Text = "IMC";
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(127, 232);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(75, 15);
            lbClassificacao.TabIndex = 7;
            lbClassificacao.Text = "Classificação";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(lbClassificacao);
            Controls.Add(lbImc);
            Controls.Add(lbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(TxbAltura);
            Controls.Add(txbPeso);
            Controls.Add(lbAltura);
            Controls.Add(lbPeso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeso;
        private Label lbAltura;
        private TextBox txbPeso;
        private TextBox TxbAltura;
        private Button btnCalcular;
        private Label lbResultado;
        private Label lbImc;
        private Label lbClassificacao;
    }
}
