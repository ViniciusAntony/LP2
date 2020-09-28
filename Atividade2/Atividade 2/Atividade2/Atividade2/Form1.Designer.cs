namespace Atividade2
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(12, 44);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(53, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Número 1";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(12, 70);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(53, 13);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Número 2";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(12, 96);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(71, 41);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(79, 20);
            this.txt_1.TabIndex = 4;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(71, 67);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(79, 20);
            this.txt_2.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Location = new System.Drawing.Point(71, 93);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(79, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(166, 41);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 43);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(166, 87);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 30);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(12, 127);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(30, 30);
            this.btn_soma.TabIndex = 9;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(84, 127);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(30, 30);
            this.btn_multiplicacao.TabIndex = 10;
            this.btn_multiplicacao.Text = "*";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(120, 127);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(30, 30);
            this.btn_divisao.TabIndex = 11;
            this.btn_divisao.Text = "/";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(48, 127);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(30, 30);
            this.btn_subtracao.TabIndex = 12;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 162);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_subtracao;
    }
}

