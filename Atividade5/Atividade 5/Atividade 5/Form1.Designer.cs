namespace Atividade_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_filhos = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.txt_filhos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_feminino = new System.Windows.Forms.RadioButton();
            this.rbtn_casado = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_aliquota_inss = new System.Windows.Forms.Label();
            this.lbl_aliquota_irpf = new System.Windows.Forms.Label();
            this.lbl_desconto_irpf = new System.Windows.Forms.Label();
            this.lbl_desconto_inss = new System.Windows.Forms.Label();
            this.lbl_salario_familia = new System.Windows.Forms.Label();
            this.lbl_salario_liquido = new System.Windows.Forms.Label();
            this.txt_salario_liquido = new System.Windows.Forms.TextBox();
            this.txt_aliquota_inss = new System.Windows.Forms.TextBox();
            this.txt_salario_familia = new System.Windows.Forms.TextBox();
            this.txt_desconto_irpf = new System.Windows.Forms.TextBox();
            this.txt_aliquota_irpf = new System.Windows.Forms.TextBox();
            this.txt_desconto_inss = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.rbtn_casado);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_filhos);
            this.groupBox1.Controls.Add(this.txt_salario);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_filhos);
            this.groupBox1.Controls.Add(this.lbl_salario);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(7, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(7, 46);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(70, 13);
            this.lbl_salario.TabIndex = 1;
            this.lbl_salario.Text = "Salário Bruto:";
            // 
            // lbl_filhos
            // 
            this.lbl_filhos.AutoSize = true;
            this.lbl_filhos.Location = new System.Drawing.Point(7, 72);
            this.lbl_filhos.Name = "lbl_filhos";
            this.lbl_filhos.Size = new System.Drawing.Size(92, 13);
            this.lbl_filhos.TabIndex = 2;
            this.lbl_filhos.Text = "Número de Filhos:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(51, 17);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(138, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(83, 43);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(106, 20);
            this.txt_salario.TabIndex = 4;
            // 
            // txt_filhos
            // 
            this.txt_filhos.Location = new System.Drawing.Point(104, 69);
            this.txt_filhos.Name = "txt_filhos";
            this.txt_filhos.Size = new System.Drawing.Size(85, 20);
            this.txt_filhos.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_feminino);
            this.groupBox2.Controls.Add(this.rbtn_masculino);
            this.groupBox2.Location = new System.Drawing.Point(215, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 45);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(7, 20);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(34, 17);
            this.rbtn_masculino.TabIndex = 0;
            this.rbtn_masculino.TabStop = true;
            this.rbtn_masculino.Text = "M";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // rbtn_feminino
            // 
            this.rbtn_feminino.AutoSize = true;
            this.rbtn_feminino.Location = new System.Drawing.Point(47, 20);
            this.rbtn_feminino.Name = "rbtn_feminino";
            this.rbtn_feminino.Size = new System.Drawing.Size(31, 17);
            this.rbtn_feminino.TabIndex = 1;
            this.rbtn_feminino.TabStop = true;
            this.rbtn_feminino.Text = "F";
            this.rbtn_feminino.UseVisualStyleBackColor = true;
            // 
            // rbtn_casado
            // 
            this.rbtn_casado.AutoSize = true;
            this.rbtn_casado.Location = new System.Drawing.Point(222, 70);
            this.rbtn_casado.Name = "rbtn_casado";
            this.rbtn_casado.Size = new System.Drawing.Size(61, 17);
            this.rbtn_casado.TabIndex = 7;
            this.rbtn_casado.TabStop = true;
            this.rbtn_casado.Text = "Casado";
            this.rbtn_casado.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_desconto_inss);
            this.groupBox3.Controls.Add(this.txt_aliquota_irpf);
            this.groupBox3.Controls.Add(this.txt_desconto_irpf);
            this.groupBox3.Controls.Add(this.txt_salario_familia);
            this.groupBox3.Controls.Add(this.txt_aliquota_inss);
            this.groupBox3.Controls.Add(this.txt_salario_liquido);
            this.groupBox3.Controls.Add(this.lbl_salario_liquido);
            this.groupBox3.Controls.Add(this.lbl_salario_familia);
            this.groupBox3.Controls.Add(this.lbl_desconto_inss);
            this.groupBox3.Controls.Add(this.lbl_desconto_irpf);
            this.groupBox3.Controls.Add(this.lbl_aliquota_irpf);
            this.groupBox3.Controls.Add(this.lbl_aliquota_inss);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 111);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cálculo";
            // 
            // lbl_aliquota_inss
            // 
            this.lbl_aliquota_inss.AutoSize = true;
            this.lbl_aliquota_inss.Location = new System.Drawing.Point(6, 22);
            this.lbl_aliquota_inss.Name = "lbl_aliquota_inss";
            this.lbl_aliquota_inss.Size = new System.Drawing.Size(76, 13);
            this.lbl_aliquota_inss.TabIndex = 0;
            this.lbl_aliquota_inss.Text = "Aliquota INSS:";
            // 
            // lbl_aliquota_irpf
            // 
            this.lbl_aliquota_irpf.AutoSize = true;
            this.lbl_aliquota_irpf.Location = new System.Drawing.Point(157, 22);
            this.lbl_aliquota_irpf.Name = "lbl_aliquota_irpf";
            this.lbl_aliquota_irpf.Size = new System.Drawing.Size(75, 13);
            this.lbl_aliquota_irpf.TabIndex = 1;
            this.lbl_aliquota_irpf.Text = "Aliquota IRPF:";
            // 
            // lbl_desconto_irpf
            // 
            this.lbl_desconto_irpf.AutoSize = true;
            this.lbl_desconto_irpf.Location = new System.Drawing.Point(157, 48);
            this.lbl_desconto_irpf.Name = "lbl_desconto_irpf";
            this.lbl_desconto_irpf.Size = new System.Drawing.Size(83, 13);
            this.lbl_desconto_irpf.TabIndex = 2;
            this.lbl_desconto_irpf.Text = "Desconto IRPF:";
            // 
            // lbl_desconto_inss
            // 
            this.lbl_desconto_inss.AutoSize = true;
            this.lbl_desconto_inss.Location = new System.Drawing.Point(6, 48);
            this.lbl_desconto_inss.Name = "lbl_desconto_inss";
            this.lbl_desconto_inss.Size = new System.Drawing.Size(84, 13);
            this.lbl_desconto_inss.TabIndex = 3;
            this.lbl_desconto_inss.Text = "Desconto INSS:";
            // 
            // lbl_salario_familia
            // 
            this.lbl_salario_familia.AutoSize = true;
            this.lbl_salario_familia.Location = new System.Drawing.Point(6, 84);
            this.lbl_salario_familia.Name = "lbl_salario_familia";
            this.lbl_salario_familia.Size = new System.Drawing.Size(79, 13);
            this.lbl_salario_familia.TabIndex = 4;
            this.lbl_salario_familia.Text = "Salário Família:";
            // 
            // lbl_salario_liquido
            // 
            this.lbl_salario_liquido.AutoSize = true;
            this.lbl_salario_liquido.Location = new System.Drawing.Point(157, 84);
            this.lbl_salario_liquido.Name = "lbl_salario_liquido";
            this.lbl_salario_liquido.Size = new System.Drawing.Size(81, 13);
            this.lbl_salario_liquido.TabIndex = 5;
            this.lbl_salario_liquido.Text = "Salário Líquido:";
            // 
            // txt_salario_liquido
            // 
            this.txt_salario_liquido.Location = new System.Drawing.Point(239, 81);
            this.txt_salario_liquido.Name = "txt_salario_liquido";
            this.txt_salario_liquido.Size = new System.Drawing.Size(63, 20);
            this.txt_salario_liquido.TabIndex = 6;
            // 
            // txt_aliquota_inss
            // 
            this.txt_aliquota_inss.Location = new System.Drawing.Point(82, 19);
            this.txt_aliquota_inss.Name = "txt_aliquota_inss";
            this.txt_aliquota_inss.Size = new System.Drawing.Size(69, 20);
            this.txt_aliquota_inss.TabIndex = 7;
            // 
            // txt_salario_familia
            // 
            this.txt_salario_familia.Location = new System.Drawing.Point(86, 81);
            this.txt_salario_familia.Name = "txt_salario_familia";
            this.txt_salario_familia.Size = new System.Drawing.Size(65, 20);
            this.txt_salario_familia.TabIndex = 8;
            // 
            // txt_desconto_irpf
            // 
            this.txt_desconto_irpf.Location = new System.Drawing.Point(241, 45);
            this.txt_desconto_irpf.Name = "txt_desconto_irpf";
            this.txt_desconto_irpf.Size = new System.Drawing.Size(61, 20);
            this.txt_desconto_irpf.TabIndex = 9;
            // 
            // txt_aliquota_irpf
            // 
            this.txt_aliquota_irpf.Location = new System.Drawing.Point(233, 19);
            this.txt_aliquota_irpf.Name = "txt_aliquota_irpf";
            this.txt_aliquota_irpf.Size = new System.Drawing.Size(69, 20);
            this.txt_aliquota_irpf.TabIndex = 10;
            // 
            // txt_desconto_inss
            // 
            this.txt_desconto_inss.Location = new System.Drawing.Point(91, 45);
            this.txt_desconto_inss.Name = "txt_desconto_inss";
            this.txt_desconto_inss.Size = new System.Drawing.Size(60, 20);
            this.txt_desconto_inss.TabIndex = 11;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(161, 105);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(72, 27);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(80, 105);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(72, 27);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 274);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_filhos;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_filhos;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_feminino;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.RadioButton rbtn_casado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_salario_liquido;
        private System.Windows.Forms.Label lbl_salario_familia;
        private System.Windows.Forms.Label lbl_desconto_inss;
        private System.Windows.Forms.Label lbl_desconto_irpf;
        private System.Windows.Forms.Label lbl_aliquota_irpf;
        private System.Windows.Forms.Label lbl_aliquota_inss;
        private System.Windows.Forms.TextBox txt_desconto_inss;
        private System.Windows.Forms.TextBox txt_aliquota_irpf;
        private System.Windows.Forms.TextBox txt_desconto_irpf;
        private System.Windows.Forms.TextBox txt_salario_familia;
        private System.Windows.Forms.TextBox txt_aliquota_inss;
        private System.Windows.Forms.TextBox txt_salario_liquido;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_calcular;
    }
}

