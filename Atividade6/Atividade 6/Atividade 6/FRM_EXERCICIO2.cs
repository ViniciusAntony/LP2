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
    public partial class FRM_EXERCICIO2 : Form
    {
        public FRM_EXERCICIO2()
        {
            InitializeComponent();
        }

        private void FRM_EXERCICIO2_Load(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            int meio = txt_palavra_1.Text.Length / 2;
            txt_palavra_2.Text = txt_palavra_1.Text.Insert(meio, "*");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int meio = txt_palavra_2.Text.Length / 2;

            txt_palavra_2.Text = txt_palavra_2.Text.Substring(0, meio) + txt_palavra_1.Text +
                                 txt_palavra_2.Text.Substring(meio, txt_palavra_2.Text.Length - meio);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (String.Compare(txt_palavra_1.Text, txt_palavra_2.Text, true) == 0)
            {
                MessageBox.Show("São Iguais!");
            }
            else
            {
                MessageBox.Show("Não São Iguais!");
            }
               
        }
    }
}
