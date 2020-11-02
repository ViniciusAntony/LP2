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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorN, valorH = 0;
            
            valorN = Convert.ToDouble(textBox1.Text);
            
            for(var i = valorN; i > 0; i--)
            {
                valorH += 1 / i;
            }
            MessageBox.Show("O valor de H é: " + valorH);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
