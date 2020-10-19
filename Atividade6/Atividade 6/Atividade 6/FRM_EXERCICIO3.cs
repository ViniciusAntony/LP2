using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class FRM_EXERCICIO3 : Form
    {
        public FRM_EXERCICIO3()
        {
            InitializeComponent();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_palavra_2.Text = txt_palavra_2.Text.Replace(txt_palavra_1.Text, "");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int posicao = txt_palavra_2.Text.IndexOf(txt_palavra_1.Text);

            while (posicao >= 0)
            {
                txt_palavra_2.Text = txt_palavra_2.Text.Substring(0, posicao) +
                    txt_palavra_2.Text.Substring(posicao + txt_palavra_1.Text.Length,
                    txt_palavra_2.Text.Length - txt_palavra_1.Text.Length - posicao);

                posicao = txt_palavra_2.Text.IndexOf(txt_palavra_1.Text);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            char[] auxiliar = txt_palavra_1.Text.ToCharArray();

            Array.Reverse(auxiliar);

            foreach (char c in auxiliar)
                txt_palavra_2.Text += c;
        }
    }
}
