using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            rbtn_equilatero.Checked = false;
            rbtn_escaleno.Checked = false;
            rbtn_isosceles.Checked = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double A, B, C, AB, AC, BC;

            if (double.TryParse(txt_a.Text, out A) && (double.TryParse(txt_b.Text, out B) && (double.TryParse(txt_c.Text, out C))))
            {
                AB = A - B;
                AC = A - C;
                BC = B - C;

                if (AB < 0)
                {
                    AB = AB * (-1);
                }
                if (AC < 0)
                {
                    AC = AC * (-1);
                }
                if (BC < 0)
                {
                    BC = BC * (-1);
                }

                if ((AB < C) && (C < A + B))
                {
                    if ((AC < B) && (B < A + C))
                    {
                        if ((BC < A) && (A < B + C))
                        {
                            if ((A == B) && (B == C))
                            {
                                MessageBox.Show("Seu Triângulo é Equilátero!");
                                rbtn_equilatero.Checked = true;
                            }
                            else if ((A == B) || (A == C) || (B == C))
                            {
                                MessageBox.Show("Seu Triângulo é Isósceles!");
                                rbtn_isosceles.Checked = true;
                            }
                            else
                            {
                                MessageBox.Show("Seu Triângulo é Escaleno!");
                                rbtn_escaleno.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esses valores não pertencem à um Triângulo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esses valores não pertencem à um Triângulo!");
                    }
                }
                else
                {
                    MessageBox.Show("Esses valores não pertencem à um Triângulo!");
                }
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }
    }
}
