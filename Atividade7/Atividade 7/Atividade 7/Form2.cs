using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var i = 0; i < richTextBox1.Text.Length; i++)
            {
                if (char.IsWhiteSpace(richTextBox1.Text[i]))
                {
                    cont++;
                }
            }

            MessageBox.Show("O número de espaços é: " + cont);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var i = 0; i < richTextBox1.Text.Length; i++)
            {
                if ((richTextBox1.Text[i]) == 'r' || (richTextBox1.Text[i]) == 'R')
                {
                    cont++;
                }
            }
            MessageBox.Show("O número de R's é: " + cont);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string letra = "";
            for(var i = 0; i < richTextBox1.Text.Length; i++)
            {
                if((richTextBox1.Text.Substring(i, 1) != "") && (richTextBox1.Text.Substring(i, 1) == letra))
                {
                    cont++;
                }
                letra = richTextBox1.Text.Substring(i, 1);
            }
            MessageBox.Show("O número de pares é: " + cont.ToString());
        }
    }
}
