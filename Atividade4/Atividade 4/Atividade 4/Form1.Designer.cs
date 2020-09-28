namespace Atividade_4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.gbox_dados = new System.Windows.Forms.GroupBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_equilatero = new System.Windows.Forms.RadioButton();
            this.rbtn_isosceles = new System.Windows.Forms.RadioButton();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.rbtn_escaleno = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.gbox_dados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_fechar);
            this.groupBox2.Controls.Add(this.btn_calcular);
            this.groupBox2.Controls.Add(this.btn_limpar);
            this.groupBox2.Location = new System.Drawing.Point(153, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(6, 45);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(70, 20);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(6, 19);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(70, 20);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(6, 71);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(70, 20);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // gbox_dados
            // 
            this.gbox_dados.Controls.Add(this.lbl_c);
            this.gbox_dados.Controls.Add(this.txt_c);
            this.gbox_dados.Controls.Add(this.txt_b);
            this.gbox_dados.Controls.Add(this.lbl_b);
            this.gbox_dados.Controls.Add(this.txt_a);
            this.gbox_dados.Controls.Add(this.lbl_a);
            this.gbox_dados.Location = new System.Drawing.Point(12, 12);
            this.gbox_dados.Name = "gbox_dados";
            this.gbox_dados.Size = new System.Drawing.Size(135, 100);
            this.gbox_dados.TabIndex = 16;
            this.gbox_dados.TabStop = false;
            this.gbox_dados.Text = "Dados";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(54, 45);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(73, 20);
            this.txt_b.TabIndex = 7;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(7, 48);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(41, 13);
            this.lbl_b.TabIndex = 4;
            this.lbl_b.Text = "Lado B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_escaleno);
            this.groupBox1.Controls.Add(this.rbtn_equilatero);
            this.groupBox1.Controls.Add(this.rbtn_isosceles);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(244, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resposta";
            // 
            // rbtn_equilatero
            // 
            this.rbtn_equilatero.AutoSize = true;
            this.rbtn_equilatero.Enabled = false;
            this.rbtn_equilatero.Location = new System.Drawing.Point(6, 48);
            this.rbtn_equilatero.Name = "rbtn_equilatero";
            this.rbtn_equilatero.Size = new System.Drawing.Size(72, 17);
            this.rbtn_equilatero.TabIndex = 12;
            this.rbtn_equilatero.TabStop = true;
            this.rbtn_equilatero.Text = "Equilátero";
            this.rbtn_equilatero.UseVisualStyleBackColor = true;
            // 
            // rbtn_isosceles
            // 
            this.rbtn_isosceles.AutoSize = true;
            this.rbtn_isosceles.Enabled = false;
            this.rbtn_isosceles.Location = new System.Drawing.Point(6, 22);
            this.rbtn_isosceles.Name = "rbtn_isosceles";
            this.rbtn_isosceles.Size = new System.Drawing.Size(69, 17);
            this.rbtn_isosceles.TabIndex = 11;
            this.rbtn_isosceles.TabStop = true;
            this.rbtn_isosceles.Text = "Isósceles";
            this.rbtn_isosceles.UseVisualStyleBackColor = true;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(54, 19);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(73, 20);
            this.txt_a.TabIndex = 6;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(7, 22);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(41, 13);
            this.lbl_a.TabIndex = 3;
            this.lbl_a.Text = "Lado A";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(54, 71);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(73, 20);
            this.txt_c.TabIndex = 18;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(7, 74);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(41, 13);
            this.lbl_c.TabIndex = 18;
            this.lbl_c.Text = "Lado C";
            // 
            // rbtn_escaleno
            // 
            this.rbtn_escaleno.AutoSize = true;
            this.rbtn_escaleno.Enabled = false;
            this.rbtn_escaleno.Location = new System.Drawing.Point(6, 74);
            this.rbtn_escaleno.Name = "rbtn_escaleno";
            this.rbtn_escaleno.Size = new System.Drawing.Size(69, 17);
            this.rbtn_escaleno.TabIndex = 18;
            this.rbtn_escaleno.TabStop = true;
            this.rbtn_escaleno.Text = "Escaleno";
            this.rbtn_escaleno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 118);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox_dados);
            this.Name = "Form1";
            this.Text = "Verificação de Triângulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.gbox_dados.ResumeLayout(false);
            this.gbox_dados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox gbox_dados;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_equilatero;
        private System.Windows.Forms.RadioButton rbtn_isosceles;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.RadioButton rbtn_escaleno;
    }
}

