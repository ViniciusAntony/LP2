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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(" ", "");

            richTextBox1.Text = richTextBox1.Text.ToUpper();

            string s = richTextBox1.Text;

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";

            foreach (char c in arr)
            {
                s = s + c.ToString();
            }

            if (richTextBox1.Text == s)
            {
                MessageBox.Show("É um palíndromo");

            }
            else
            {
                MessageBox.Show("Não é um palíndromo");
            }
        }

    }
    

}
