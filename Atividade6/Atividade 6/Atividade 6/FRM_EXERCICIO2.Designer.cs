namespace Atividade_6
{
    partial class FRM_EXERCICIO2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_palavra_1 = new System.Windows.Forms.Label();
            this.lbl_palavra_2 = new System.Windows.Forms.Label();
            this.txt_palavra_1 = new System.Windows.Forms.TextBox();
            this.txt_palavra_2 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_palavra_1
            // 
            this.lbl_palavra_1.AutoSize = true;
            this.lbl_palavra_1.Location = new System.Drawing.Point(12, 34);
            this.lbl_palavra_1.Name = "lbl_palavra_1";
            this.lbl_palavra_1.Size = new System.Drawing.Size(55, 13);
            this.lbl_palavra_1.TabIndex = 0;
            this.lbl_palavra_1.Text = "Palavra 1:";
            // 
            // lbl_palavra_2
            // 
            this.lbl_palavra_2.AutoSize = true;
            this.lbl_palavra_2.Location = new System.Drawing.Point(12, 60);
            this.lbl_palavra_2.Name = "lbl_palavra_2";
            this.lbl_palavra_2.Size = new System.Drawing.Size(55, 13);
            this.lbl_palavra_2.TabIndex = 1;
            this.lbl_palavra_2.Text = "Palavra 2:";
            // 
            // txt_palavra_1
            // 
            this.txt_palavra_1.Location = new System.Drawing.Point(89, 31);
            this.txt_palavra_1.Name = "txt_palavra_1";
            this.txt_palavra_1.Size = new System.Drawing.Size(100, 20);
            this.txt_palavra_1.TabIndex = 2;
            // 
            // txt_palavra_2
            // 
            this.txt_palavra_2.Location = new System.Drawing.Point(89, 57);
            this.txt_palavra_2.Name = "txt_palavra_2";
            this.txt_palavra_2.Size = new System.Drawing.Size(100, 20);
            this.txt_palavra_2.TabIndex = 3;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(47, 94);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(111, 38);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "Testa se são IGUAIS";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(47, 138);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(111, 38);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "Insere PRIMEIRO no meio SEGUNDO";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(47, 182);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(111, 38);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "Insere Asterisco";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // FRM_EXERCICIO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 231);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_palavra_2);
            this.Controls.Add(this.txt_palavra_1);
            this.Controls.Add(this.lbl_palavra_2);
            this.Controls.Add(this.lbl_palavra_1);
            this.Name = "FRM_EXERCICIO2";
            this.Text = "Exercício 2";
            this.Load += new System.EventHandler(this.FRM_EXERCICIO2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_palavra_1;
        private System.Windows.Forms.Label lbl_palavra_2;
        private System.Windows.Forms.TextBox txt_palavra_1;
        private System.Windows.Forms.TextBox txt_palavra_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
    }
}