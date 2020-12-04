namespace PF_0030482011029
{
    partial class frmCidade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCidade));
            this.bnvCidade = new System.Windows.Forms.BindingNavigator(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCidade = new System.Windows.Forms.TabControl();
            this.tbpDados = new System.Windows.Forms.TabPage();
            this.tbpDetalhes = new System.Windows.Forms.TabPage();
            this.dgvCidade = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnvCidade)).BeginInit();
            this.bnvCidade.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbCidade.SuspendLayout();
            this.tbpDados.SuspendLayout();
            this.tbpDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // bnvCidade
            // 
            this.bnvCidade.AddNewItem = null;
            this.bnvCidade.CountItem = null;
            this.bnvCidade.DeleteItem = null;
            this.bnvCidade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvCidade.Location = new System.Drawing.Point(0, 0);
            this.bnvCidade.MoveFirstItem = null;
            this.bnvCidade.MoveLastItem = null;
            this.bnvCidade.MoveNextItem = null;
            this.bnvCidade.MovePreviousItem = null;
            this.bnvCidade.Name = "bnvCidade";
            this.bnvCidade.PositionItem = null;
            this.bnvCidade.Size = new System.Drawing.Size(284, 25);
            this.bnvCidade.TabIndex = 0;
            this.bnvCidade.Text = "bindingNavigator1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 196);
            this.panel1.TabIndex = 1;
            // 
            // tbCidade
            // 
            this.tbCidade.Controls.Add(this.tbpDados);
            this.tbCidade.Controls.Add(this.tbpDetalhes);
            this.tbCidade.Location = new System.Drawing.Point(4, 4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.SelectedIndex = 0;
            this.tbCidade.Size = new System.Drawing.Size(254, 186);
            this.tbCidade.TabIndex = 0;
            // 
            // tbpDados
            // 
            this.tbpDados.Controls.Add(this.dgvCidade);
            this.tbpDados.Location = new System.Drawing.Point(4, 22);
            this.tbpDados.Name = "tbpDados";
            this.tbpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDados.Size = new System.Drawing.Size(246, 160);
            this.tbpDados.TabIndex = 0;
            this.tbpDados.Text = "Dados";
            this.tbpDados.UseVisualStyleBackColor = true;
            // 
            // tbpDetalhes
            // 
            this.tbpDetalhes.Controls.Add(this.cbxUF);
            this.tbpDetalhes.Controls.Add(this.txtNome);
            this.tbpDetalhes.Controls.Add(this.txtID);
            this.tbpDetalhes.Controls.Add(this.lblUF);
            this.tbpDetalhes.Controls.Add(this.lblID);
            this.tbpDetalhes.Controls.Add(this.lblNome);
            this.tbpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalhes.Name = "tbpDetalhes";
            this.tbpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalhes.Size = new System.Drawing.Size(246, 160);
            this.tbpDetalhes.TabIndex = 1;
            this.tbpDetalhes.Text = "Detalhes";
            this.tbpDetalhes.UseVisualStyleBackColor = true;
            // 
            // dgvCidade
            // 
            this.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidade.Location = new System.Drawing.Point(6, 6);
            this.dgvCidade.Name = "dgvCidade";
            this.dgvCidade.Size = new System.Drawing.Size(230, 143);
            this.dgvCidade.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 22);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(46, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(6, 78);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(43, 13);
            this.lblUF.TabIndex = 2;
            this.lblUF.Text = "Estado:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(33, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(44, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // cbxUF
            // 
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.Enabled = false;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP"});
            this.cbxUF.Location = new System.Drawing.Point(55, 75);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(89, 21);
            this.cbxUF.Sorted = true;
            this.cbxUF.TabIndex = 5;
            // 
            // frmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnvCidade);
            this.Name = "frmCidade";
            this.Text = "Gerenciamento de Cidade";
            this.Load += new System.EventHandler(this.frmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvCidade)).EndInit();
            this.bnvCidade.ResumeLayout(false);
            this.bnvCidade.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tbCidade.ResumeLayout(false);
            this.tbpDados.ResumeLayout(false);
            this.tbpDetalhes.ResumeLayout(false);
            this.tbpDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvCidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbCidade;
        private System.Windows.Forms.TabPage tbpDados;
        private System.Windows.Forms.DataGridView dgvCidade;
        private System.Windows.Forms.TabPage tbpDetalhes;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
    }
}