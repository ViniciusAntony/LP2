namespace Atividade3
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_peso_ideal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_homem = new System.Windows.Forms.RadioButton();
            this.rbtn_mulher = new System.Windows.Forms.RadioButton();
            this.lbl_peso_ideal = new System.Windows.Forms.Label();
            this.gbox_dados = new System.Windows.Forms.GroupBox();
            this.gbox_resultado = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_abaixo = new System.Windows.Forms.RadioButton();
            this.rbtn_normal = new System.Windows.Forms.RadioButton();
            this.rbtn_acima = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbox_dados.SuspendLayout();
            this.gbox_resultado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(6, 19);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(70, 25);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(6, 88);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(70, 25);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(6, 53);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(70, 25);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(14, 35);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 3;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(14, 58);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.AutoSize = true;
            this.lbl_situacao.Location = new System.Drawing.Point(14, 53);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(49, 13);
            this.lbl_situacao.TabIndex = 5;
            this.lbl_situacao.Text = "Situação";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(54, 32);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(73, 20);
            this.txt_altura.TabIndex = 6;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(54, 55);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(73, 20);
            this.txt_peso.TabIndex = 7;
            // 
            // txt_peso_ideal
            // 
            this.txt_peso_ideal.Enabled = false;
            this.txt_peso_ideal.Location = new System.Drawing.Point(77, 25);
            this.txt_peso_ideal.Name = "txt_peso_ideal";
            this.txt_peso_ideal.Size = new System.Drawing.Size(50, 20);
            this.txt_peso_ideal.TabIndex = 8;
            this.txt_peso_ideal.TextChanged += new System.EventHandler(this.txt_situacao_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_mulher);
            this.groupBox1.Controls.Add(this.rbtn_homem);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(133, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtn_homem
            // 
            this.rbtn_homem.AutoSize = true;
            this.rbtn_homem.Location = new System.Drawing.Point(6, 19);
            this.rbtn_homem.Name = "rbtn_homem";
            this.rbtn_homem.Size = new System.Drawing.Size(61, 17);
            this.rbtn_homem.TabIndex = 11;
            this.rbtn_homem.TabStop = true;
            this.rbtn_homem.Text = "Homem";
            this.rbtn_homem.UseVisualStyleBackColor = true;
            // 
            // rbtn_mulher
            // 
            this.rbtn_mulher.AutoSize = true;
            this.rbtn_mulher.Location = new System.Drawing.Point(6, 42);
            this.rbtn_mulher.Name = "rbtn_mulher";
            this.rbtn_mulher.Size = new System.Drawing.Size(57, 17);
            this.rbtn_mulher.TabIndex = 12;
            this.rbtn_mulher.TabStop = true;
            this.rbtn_mulher.Text = "Mulher";
            this.rbtn_mulher.UseVisualStyleBackColor = true;
            // 
            // lbl_peso_ideal
            // 
            this.lbl_peso_ideal.AutoSize = true;
            this.lbl_peso_ideal.Location = new System.Drawing.Point(14, 28);
            this.lbl_peso_ideal.Name = "lbl_peso_ideal";
            this.lbl_peso_ideal.Size = new System.Drawing.Size(57, 13);
            this.lbl_peso_ideal.TabIndex = 11;
            this.lbl_peso_ideal.Text = "Peso Ideal";
            // 
            // gbox_dados
            // 
            this.gbox_dados.Controls.Add(this.txt_peso);
            this.gbox_dados.Controls.Add(this.lbl_peso);
            this.gbox_dados.Controls.Add(this.groupBox1);
            this.gbox_dados.Controls.Add(this.txt_altura);
            this.gbox_dados.Controls.Add(this.lbl_altura);
            this.gbox_dados.Location = new System.Drawing.Point(12, 12);
            this.gbox_dados.Name = "gbox_dados";
            this.gbox_dados.Size = new System.Drawing.Size(228, 85);
            this.gbox_dados.TabIndex = 13;
            this.gbox_dados.TabStop = false;
            this.gbox_dados.Text = "Dados";
            // 
            // gbox_resultado
            // 
            this.gbox_resultado.Controls.Add(this.rbtn_acima);
            this.gbox_resultado.Controls.Add(this.rbtn_normal);
            this.gbox_resultado.Controls.Add(this.rbtn_abaixo);
            this.gbox_resultado.Controls.Add(this.lbl_peso_ideal);
            this.gbox_resultado.Controls.Add(this.lbl_situacao);
            this.gbox_resultado.Controls.Add(this.txt_peso_ideal);
            this.gbox_resultado.Location = new System.Drawing.Point(12, 103);
            this.gbox_resultado.Name = "gbox_resultado";
            this.gbox_resultado.Size = new System.Drawing.Size(138, 119);
            this.gbox_resultado.TabIndex = 14;
            this.gbox_resultado.TabStop = false;
            this.gbox_resultado.Text = "Resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpar);
            this.groupBox2.Controls.Add(this.btn_calcular);
            this.groupBox2.Controls.Add(this.btn_fechar);
            this.groupBox2.Location = new System.Drawing.Point(156, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 119);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // rbtn_abaixo
            // 
            this.rbtn_abaixo.AutoSize = true;
            this.rbtn_abaixo.Enabled = false;
            this.rbtn_abaixo.Location = new System.Drawing.Point(77, 51);
            this.rbtn_abaixo.Name = "rbtn_abaixo";
            this.rbtn_abaixo.Size = new System.Drawing.Size(57, 17);
            this.rbtn_abaixo.TabIndex = 12;
            this.rbtn_abaixo.TabStop = true;
            this.rbtn_abaixo.Text = "Abaixo";
            this.rbtn_abaixo.UseVisualStyleBackColor = true;
            // 
            // rbtn_normal
            // 
            this.rbtn_normal.AutoSize = true;
            this.rbtn_normal.Enabled = false;
            this.rbtn_normal.Location = new System.Drawing.Point(77, 74);
            this.rbtn_normal.Name = "rbtn_normal";
            this.rbtn_normal.Size = new System.Drawing.Size(58, 17);
            this.rbtn_normal.TabIndex = 13;
            this.rbtn_normal.TabStop = true;
            this.rbtn_normal.Text = "Normal";
            this.rbtn_normal.UseVisualStyleBackColor = true;
            // 
            // rbtn_acima
            // 
            this.rbtn_acima.AutoSize = true;
            this.rbtn_acima.Enabled = false;
            this.rbtn_acima.Location = new System.Drawing.Point(77, 97);
            this.rbtn_acima.Name = "rbtn_acima";
            this.rbtn_acima.Size = new System.Drawing.Size(54, 17);
            this.rbtn_acima.TabIndex = 14;
            this.rbtn_acima.TabStop = true;
            this.rbtn_acima.Text = "Acima";
            this.rbtn_acima.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbox_resultado);
            this.Controls.Add(this.gbox_dados);
            this.Name = "Form1";
            this.Text = "Cálculo de Peso Ideal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbox_dados.ResumeLayout(false);
            this.gbox_dados.PerformLayout();
            this.gbox_resultado.ResumeLayout(false);
            this.gbox_resultado.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_situacao;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_peso_ideal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_mulher;
        private System.Windows.Forms.RadioButton rbtn_homem;
        private System.Windows.Forms.Label lbl_peso_ideal;
        private System.Windows.Forms.GroupBox gbox_dados;
        private System.Windows.Forms.GroupBox gbox_resultado;
        private System.Windows.Forms.RadioButton rbtn_acima;
        private System.Windows.Forms.RadioButton rbtn_normal;
        private System.Windows.Forms.RadioButton rbtn_abaixo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

