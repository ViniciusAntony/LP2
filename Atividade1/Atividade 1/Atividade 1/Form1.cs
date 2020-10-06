using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Raio.Clear();
            txt_Altura.Clear();
            txt_Volume.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Altura, Raio;

            if (double.TryParse(txt_Raio.Text, out Raio) && (double.TryParse(txt_Altura.Text, out Altura)))
            {
                double Volume;

                Volume = Math.PI * Math.Pow(Raio, 2) * Raio;

                txt_Volume.Text = Volume.ToString("N2");
            }
        }
    }
}
