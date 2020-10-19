namespace Atividade_6
{
    partial class FRM_EXERCICIO4
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.rch_txtbox_1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 127);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(94, 64);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Quantidade de Números";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(212, 127);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(94, 64);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "Posição Primeiro Espaço em Branco";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(112, 127);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(94, 64);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "Quantidade de Letras";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // rch_txtbox_1
            // 
            this.rch_txtbox_1.Location = new System.Drawing.Point(12, 12);
            this.rch_txtbox_1.Name = "rch_txtbox_1";
            this.rch_txtbox_1.Size = new System.Drawing.Size(294, 96);
            this.rch_txtbox_1.TabIndex = 4;
            this.rch_txtbox_1.Text = "";
            // 
            // FRM_EXERCICIO4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 201);
            this.Controls.Add(this.rch_txtbox_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_1);
            this.Name = "FRM_EXERCICIO4";
            this.Text = "FRM_EXERCICIO4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.RichTextBox rch_txtbox_1;
    }
}