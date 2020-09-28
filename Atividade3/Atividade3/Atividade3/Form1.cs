using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_situacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_altura.Clear();
            txt_peso.Clear();
            rbtn_homem.Checked = false;
            rbtn_mulher.Checked = false;
            txt_peso_ideal.Clear();
            rbtn_abaixo.Checked = false;
            rbtn_acima.Checked = false;
            rbtn_normal.Checked = false;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double Altura, Peso, PesoIdeal;

            if (rbtn_homem.Checked == true)
            {
                if (double.TryParse(txt_altura.Text, out Altura) && (double.TryParse(txt_peso.Text, out Peso)))
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    txt_peso_ideal.Text = PesoIdeal.ToString();

                    if (PesoIdeal > Peso)
                    {
                        rbtn_abaixo.Checked = true;
                    }
                    else if (PesoIdeal == Peso)
                    {
                        rbtn_normal.Checked = true;
                    }
                    else if (PesoIdeal < Peso)
                    {
                        rbtn_acima.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }
            }
            else if (rbtn_mulher.Checked == true)
            {
                if (double.TryParse(txt_altura.Text, out Altura) && (double.TryParse(txt_peso.Text, out Peso)))
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                    txt_peso_ideal.Text = PesoIdeal.ToString();

                    if (PesoIdeal > Peso)
                    {
                        rbtn_abaixo.Checked = true;
                    }
                    else if (PesoIdeal == Peso)
                    {
                        rbtn_normal.Checked = true;
                    }
                    else if (PesoIdeal < Peso)
                    {
                        rbtn_acima.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }
            }
            else
            {
                MessageBox.Show("Selecione o Sexo!");
            }
        }
    }
}