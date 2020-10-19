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
    public partial class FRM_EXERCICIO4 : Form
    {
        public FRM_EXERCICIO4()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var i = 0; i < rch_txtbox_1.Text.Length; i++)
            {
                if (char.IsNumber(rch_txtbox_1.Text[i]))
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Quantidade de Números: " + contador);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var i = 0; i < rch_txtbox_1.Text.Length; i++)
            {
                if (char.IsNumber(rch_txtbox_1.Text[i]))
                {
                }
                else
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Quantidade de Letras: " + contador);
        }
    }
}
