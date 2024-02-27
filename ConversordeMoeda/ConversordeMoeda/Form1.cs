using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordeMoeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(inserir_txt.Text);
            if(porcombo1.SelectedItem=="Rupees" && emcombo2.SelectedItem=="Dollar")
            {
                int conver = i / 103;
                display_txt.Text = "Valor Convertido:" + conver+"\t $";
            }
            if (porcombo1.SelectedItem == "Rupees" && emcombo2.SelectedItem == "Euro")
            {
                int conver = i / 115;
                display_txt.Text = "Valor Convertido:" + conver + "\t Euro";
            }
            if (porcombo1.SelectedItem == "Euro" && emcombo2.SelectedItem == "Rupees")
            {
                int conver = i * 115;
                display_txt.Text = "Valor Convertido: " + conver + "\t RS/=";
            }
        }
    }
}
