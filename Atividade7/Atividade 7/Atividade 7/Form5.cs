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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double produçao, salario, gratificacao, salarioBruto, prodA, prodB, prodC, prodD;

            salario = Convert.ToDouble(textBox5.Text);
            produçao = Convert.ToDouble(textBox4.Text);
            gratificacao = Convert.ToDouble(textBox6.Text);

            if(produçao >= 100)
            {
                prodB = 1;
            }
            else
            {
                prodB = 0;
            }
            if(produçao >= 120)
            {
                prodC = 1;
            }
            else
            {
                prodC = 0;
            }
            if(produçao >= 150)
            {
                prodD = 1;
            }
            else
            {
                prodD = 0;
            }

            salarioBruto = salario + salario * (0.05 * prodB + 0.1 * prodC + 0.1 * prodD) + gratificacao;

            if(salarioBruto > 7000)
            {
                if(prodD >= 150 && gratificacao > 0)
                {
                    salarioBruto = salarioBruto;
                }
                else
                {
                    salarioBruto = 7000;
                }
            }

            textBox7.Text = Convert.ToString(salarioBruto);
        }
    }
}
