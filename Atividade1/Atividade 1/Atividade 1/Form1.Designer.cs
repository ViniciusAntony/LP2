namespace Atividade_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Raio = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.txt_Raio = new System.Windows.Forms.TextBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Volume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(17, 70);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_Altura.TabIndex = 1;
            this.lbl_Altura.Text = "Altura";
            // 
            // lbl_Raio
            // 
            this.lbl_Raio.AutoSize = true;
            this.lbl_Raio.Location = new System.Drawing.Point(17, 44);
            this.lbl_Raio.Name = "lbl_Raio";
            this.lbl_Raio.Size = new System.Drawing.Size(29, 13);
            this.lbl_Raio.TabIndex = 2;
            this.lbl_Raio.Text = "Raio";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Location = new System.Drawing.Point(17, 96);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(42, 13);
            this.lbl_Volume.TabIndex = 3;
            this.lbl_Volume.Text = "Volume";
            // 
            // txt_Raio
            // 
            this.txt_Raio.Location = new System.Drawing.Point(79, 41);
            this.txt_Raio.Name = "txt_Raio";
            this.txt_Raio.Size = new System.Drawing.Size(100, 20);
            this.txt_Raio.TabIndex = 1;
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(79, 67);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(100, 20);
            this.txt_Altura.TabIndex = 2;
            // 
            // txt_Volume
            // 
            this.txt_Volume.Enabled = false;
            this.txt_Volume.Location = new System.Drawing.Point(79, 93);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(100, 20);
            this.txt_Volume.TabIndex = 6;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(104, 133);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(104, 162);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 5;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(20, 133);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(78, 52);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 193);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.txt_Raio);
            this.Controls.Add(this.lbl_Volume);
            this.Controls.Add(this.lbl_Raio);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Raio;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.TextBox txt_Raio;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

