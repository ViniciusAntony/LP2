using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_5
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

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_salario.Clear();
            txt_filhos.Clear();
            rbtn_masculino.Checked = false;
            rbtn_feminino.Checked = false;
            rbtn_casado.Checked = false;

            txt_aliquota_inss.Clear();
            txt_aliquota_irpf.Clear();
            txt_desconto_inss.Clear();
            txt_desconto_irpf.Clear();
            txt_salario_familia.Clear();
            txt_salario_liquido.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double Salario_Bruto, Salario_Liquido, Aliquota_INSS, Aliquota_IRPF, Desconto_INSS, Desconto_IRPF, Numero_Filho, Salario_Familia;

            if (double.TryParse(txt_salario.Text, out Salario_Bruto) && (double.TryParse(txt_filhos.Text, out Numero_Filho)))
            {
                if (Salario_Bruto <= 800.47)
                {

                    Aliquota_INSS = 7.65;
                }
                else if (Salario_Bruto >= 800.48 && Salario_Bruto <= 1050)
                {
                    Aliquota_INSS = 8.65;
                }
                else if (Salario_Bruto >= 1050.01 && Salario_Bruto <= 1400.77)
                {
                    Aliquota_INSS = 9.00;
                }
                else if (Salario_Bruto >= 1400.78 && Salario_Bruto <= 2801.56)
                {
                    Aliquota_INSS = 11.00;
                }
                else if (Salario_Bruto > 2801.56)
                {
                    Aliquota_INSS = 0.00;
                    Desconto_INSS = 308.17;
                }
                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }

                if (Salario_Bruto <= 1257.12)
                {
                    Aliquota_IRPF = 0.00;
                }
                else if (Salario_Bruto >= 1257.13 && Salario_Bruto <= 2512.08)
                {
                    Aliquota_IRPF = 15.00;
                }
                else if (Salario_Bruto > 2512.08)
                {
                    Aliquota_IRPF = 27.50;
                }
                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }

                if (Salario_Bruto <= 435.52)
                {
                    Salario_Familia = 22.33 * Numero_Filho;
                }
                else if (Salario_Bruto >= 435.53 && Salario_Bruto <= 654.61)
                {
                    Salario_Familia = 15.74 * Numero_Filho;
                }
                else if (Salario_Bruto > 654.61)
                {
                    Salario_Familia = 0.00;
                }
                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }

                txt_aliquota_inss.Text = Convert.ToString(Aliquota_INSS);
                Desconto_INSS = Aliquota_INSS / 100 * Salario_Bruto;
                txt_desconto_inss.Text = Convert.ToString(Desconto_INSS);

                txt_aliquota_irpf.Text = Convert.ToString(Aliquota_IRPF);
                Desconto_IRPF = Aliquota_IRPF / 100 * Salario_Bruto;
                txt_desconto_irpf.Text = Convert.ToString(Desconto_IRPF);

                Salario_Liquido = Salario_Bruto - Desconto_INSS - Desconto_IRPF - Salario_Familia;
                txt_salario_liquido.Text = Convert.ToString(Salario_Liquido);
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }
    }
}
