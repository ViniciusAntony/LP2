using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
            txt_2.Clear();
            txt_resultado.Clear();
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_1.Text, out Num1) && (double.TryParse(txt_2.Text, out Num2)))
            {
                Resultado = Num1 - Num2;
                txt_resultado.Text = Resultado.ToString();
            }
            else
            {
                MessageBox.Show("Somente Números!");
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_1.Text, out Num1) && (double.TryParse(txt_2.Text, out Num2)))
            {
                Resultado = Num1 * Num2;
                txt_resultado.Text = Resultado.ToString();
            }
            else
            {
                MessageBox.Show("Somente Números!");
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_1.Text, out Num1) && (double.TryParse(txt_2.Text, out Num2)))
            {
                if (Num2 != 0)
                {
                    Resultado = Num1 / Num2;
                    txt_resultado.Text = Resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Não Existe Divisão por 0!");
                }
            }
            else
            {
                MessageBox.Show("Somente Números!");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_1.Text, out Num1) && (double.TryParse(txt_2.Text, out Num2)))
            {
                Resultado = Num1 + Num2;
                txt_resultado.Text = Resultado.ToString();
            }
            else
            {
                MessageBox.Show("Somente Números!");
            }
        }
    }
}