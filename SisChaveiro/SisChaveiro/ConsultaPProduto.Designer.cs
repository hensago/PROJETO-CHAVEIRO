namespace SisChaveiro
{
    partial class ConsultaPProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPProduto));
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.rbtnTudo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnModelo = new System.Windows.Forms.RadioButton();
            this.rbtnNF = new System.Windows.Forms.RadioButton();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.data3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(129, 171);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(188, 25);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // data2
            // 
            this.data2.AllowUserToAddRows = false;
            this.data2.AllowUserToDeleteRows = false;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Location = new System.Drawing.Point(129, 355);
            this.data2.Name = "data2";
            this.data2.ReadOnly = true;
            this.data2.Size = new System.Drawing.Size(810, 102);
            this.data2.TabIndex = 47;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(784, 592);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 44);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(355, 171);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(224, 25);
            this.txtNF.TabIndex = 2;
            this.txtNF.TextChanged += new System.EventHandler(this.txtNF_TextChanged);
            // 
            // rbtnTudo
            // 
            this.rbtnTudo.AutoSize = true;
            this.rbtnTudo.Location = new System.Drawing.Point(469, 105);
            this.rbtnTudo.Name = "rbtnTudo";
            this.rbtnTudo.Size = new System.Drawing.Size(61, 24);
            this.rbtnTudo.TabIndex = 1;
            this.rbtnTudo.TabStop = true;
            this.rbtnTudo.Text = "Tudo";
            this.rbtnTudo.UseVisualStyleBackColor = true;
            this.rbtnTudo.CheckedChanged += new System.EventHandler(this.rbtnTudo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Por favor selecione o metodo de consulta";
            // 
            // rbtnModelo
            // 
            this.rbtnModelo.AutoSize = true;
            this.rbtnModelo.Location = new System.Drawing.Point(129, 141);
            this.rbtnModelo.Name = "rbtnModelo";
            this.rbtnModelo.Size = new System.Drawing.Size(172, 24);
            this.rbtnModelo.TabIndex = 1;
            this.rbtnModelo.TabStop = true;
            this.rbtnModelo.Text = "Modelo do produto";
            this.rbtnModelo.UseVisualStyleBackColor = true;
            this.rbtnModelo.CheckedChanged += new System.EventHandler(this.rbtnModelo_CheckedChanged);
            // 
            // rbtnNF
            // 
            this.rbtnNF.AutoSize = true;
            this.rbtnNF.Location = new System.Drawing.Point(355, 141);
            this.rbtnNF.Name = "rbtnNF";
            this.rbtnNF.Size = new System.Drawing.Size(175, 24);
            this.rbtnNF.TabIndex = 1;
            this.rbtnNF.TabStop = true;
            this.rbtnNF.Text = "Nome do Funcioário";
            this.rbtnNF.UseVisualStyleBackColor = true;
            this.rbtnNF.CheckedChanged += new System.EventHandler(this.rbtnNF_CheckedChanged);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(129, 226);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(810, 102);
            this.data1.TabIndex = 61;
            // 
            // data3
            // 
            this.data3.AllowUserToAddRows = false;
            this.data3.AllowUserToDeleteRows = false;
            this.data3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data3.Location = new System.Drawing.Point(129, 484);
            this.data3.Name = "data3";
            this.data3.ReadOnly = true;
            this.data3.Size = new System.Drawing.Size(810, 102);
            this.data3.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cliente Comum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Cliente Fisico Cadastrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Cliente Juridico Cadastrado";
            // 
            // ConsultaPProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data3);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.rbtnNF);
            this.Controls.Add(this.rbtnModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnTudo);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "ConsultaPProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta-Produto";
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.RadioButton rbtnTudo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnModelo;
        private System.Windows.Forms.RadioButton rbtnNF;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.DataGridView data3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}