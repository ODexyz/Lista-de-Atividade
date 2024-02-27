namespace ConversordeMoeda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inserir_txt = new System.Windows.Forms.TextBox();
            this.porcombo1 = new System.Windows.Forms.ComboBox();
            this.emcombo2 = new System.Windows.Forms.ComboBox();
            this.display_txt = new System.Windows.Forms.Label();
            this.conv_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converter por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Converter em";
            // 
            // inserir_txt
            // 
            this.inserir_txt.Location = new System.Drawing.Point(107, 100);
            this.inserir_txt.Name = "inserir_txt";
            this.inserir_txt.Size = new System.Drawing.Size(100, 20);
            this.inserir_txt.TabIndex = 3;
            // 
            // porcombo1
            // 
            this.porcombo1.FormattingEnabled = true;
            this.porcombo1.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.porcombo1.Location = new System.Drawing.Point(107, 142);
            this.porcombo1.Name = "porcombo1";
            this.porcombo1.Size = new System.Drawing.Size(121, 21);
            this.porcombo1.TabIndex = 4;
            // 
            // emcombo2
            // 
            this.emcombo2.FormattingEnabled = true;
            this.emcombo2.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.emcombo2.Location = new System.Drawing.Point(107, 190);
            this.emcombo2.Name = "emcombo2";
            this.emcombo2.Size = new System.Drawing.Size(121, 21);
            this.emcombo2.TabIndex = 5;
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(50, 235);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(88, 13);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Valor Convertido:";
            // 
            // conv_btn
            // 
            this.conv_btn.Location = new System.Drawing.Point(226, 97);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(75, 23);
            this.conv_btn.TabIndex = 7;
            this.conv_btn.Text = "Convert";
            this.conv_btn.UseVisualStyleBackColor = true;
            this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 360);
            this.Controls.Add(this.conv_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.emcombo2);
            this.Controls.Add(this.porcombo1);
            this.Controls.Add(this.inserir_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inserir_txt;
        private System.Windows.Forms.ComboBox porcombo1;
        private System.Windows.Forms.ComboBox emcombo2;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button conv_btn;
    }
}

