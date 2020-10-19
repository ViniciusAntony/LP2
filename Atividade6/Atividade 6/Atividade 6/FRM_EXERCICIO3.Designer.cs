namespace Atividade_6
{
    partial class FRM_EXERCICIO3
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
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_palavra_2 = new System.Windows.Forms.TextBox();
            this.txt_palavra_1 = new System.Windows.Forms.TextBox();
            this.lbl_palavra_2 = new System.Windows.Forms.Label();
            this.lbl_palavra_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(50, 172);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(111, 38);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "Inverter Palavra";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(50, 128);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(111, 38);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "Remover (Replace)";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(50, 84);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(111, 38);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "Remover Primeiro do Segundo";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // txt_palavra_2
            // 
            this.txt_palavra_2.Location = new System.Drawing.Point(92, 47);
            this.txt_palavra_2.Name = "txt_palavra_2";
            this.txt_palavra_2.Size = new System.Drawing.Size(100, 20);
            this.txt_palavra_2.TabIndex = 10;
            // 
            // txt_palavra_1
            // 
            this.txt_palavra_1.Location = new System.Drawing.Point(92, 21);
            this.txt_palavra_1.Name = "txt_palavra_1";
            this.txt_palavra_1.Size = new System.Drawing.Size(100, 20);
            this.txt_palavra_1.TabIndex = 9;
            // 
            // lbl_palavra_2
            // 
            this.lbl_palavra_2.AutoSize = true;
            this.lbl_palavra_2.Location = new System.Drawing.Point(15, 50);
            this.lbl_palavra_2.Name = "lbl_palavra_2";
            this.lbl_palavra_2.Size = new System.Drawing.Size(55, 13);
            this.lbl_palavra_2.TabIndex = 8;
            this.lbl_palavra_2.Text = "Palavra 2:";
            // 
            // lbl_palavra_1
            // 
            this.lbl_palavra_1.AutoSize = true;
            this.lbl_palavra_1.Location = new System.Drawing.Point(15, 24);
            this.lbl_palavra_1.Name = "lbl_palavra_1";
            this.lbl_palavra_1.Size = new System.Drawing.Size(55, 13);
            this.lbl_palavra_1.TabIndex = 7;
            this.lbl_palavra_1.Text = "Palavra 1:";
            // 
            // FRM_EXERCICIO3
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
            this.Name = "FRM_EXERCICIO3";
            this.Text = "FRM_EXERCICIO3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt_palavra_2;
        private System.Windows.Forms.TextBox txt_palavra_1;
        private System.Windows.Forms.Label lbl_palavra_2;
        private System.Windows.Forms.Label lbl_palavra_1;
    }
}