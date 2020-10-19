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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FRM_EXERCICIO2"];

            if (fc != null)
                Close();

            FRM_EXERCICIO2 FRM_EXERCICIO2_NEW = new FRM_EXERCICIO2();
            FRM_EXERCICIO2_NEW.MdiParent = this;
            FRM_EXERCICIO2_NEW.WindowState = FormWindowState.Maximized;
            FRM_EXERCICIO2_NEW.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form fc = Application.OpenForms["FRM_EXERCICIO3"];

                if (fc != null)
                    Close();

                FRM_EXERCICIO3 FRM_EXERCICIO3_NEW = new FRM_EXERCICIO3();
                FRM_EXERCICIO3_NEW.MdiParent = this;
                FRM_EXERCICIO3_NEW.WindowState = FormWindowState.Maximized;
                FRM_EXERCICIO3_NEW.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form fc = Application.OpenForms["FRM_EXERCICIO4"];

                if (fc != null)
                    Close();

                FRM_EXERCICIO4 FRM_EXERCICIO4_NEW = new FRM_EXERCICIO4();
                FRM_EXERCICIO4_NEW.MdiParent = this;
                FRM_EXERCICIO4_NEW.WindowState = FormWindowState.Maximized;
                FRM_EXERCICIO4_NEW.Show();
            }
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form fc = Application.OpenForms["FRM_EXERCICIO5"];

                if (fc != null)
                    Close();

                FRM_EXERCICIO5 FRM_EXERCICIO5_NEW = new FRM_EXERCICIO5();
                FRM_EXERCICIO5_NEW.MdiParent = this;
                FRM_EXERCICIO5_NEW.WindowState = FormWindowState.Maximized;
                FRM_EXERCICIO5_NEW.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
