namespace SisChaveiro
{
    partial class PedidoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoProduto));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.rbtnCNPJ = new System.Windows.Forms.RadioButton();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(688, 548);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 44);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(452, 548);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 44);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(222, 548);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(155, 44);
            this.btnFC.TabIndex = 6;
            this.btnFC.Text = "Finalizar Compra";
            this.btnFC.UseVisualStyleBackColor = true;
            this.btnFC.Click += new System.EventHandler(this.btnFC_Click);
            // 
            // rbtnCNPJ
            // 
            this.rbtnCNPJ.AutoSize = true;
            this.rbtnCNPJ.Location = new System.Drawing.Point(418, 147);
            this.rbtnCNPJ.Name = "rbtnCNPJ";
            this.rbtnCNPJ.Size = new System.Drawing.Size(66, 24);
            this.rbtnCNPJ.TabIndex = 2;
            this.rbtnCNPJ.TabStop = true;
            this.rbtnCNPJ.Text = "CNPJ";
            this.rbtnCNPJ.UseVisualStyleBackColor = true;
            this.rbtnCNPJ.CheckedChanged += new System.EventHandler(this.rbtnCNPJ_CheckedChanged);
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(418, 177);
            this.mtxtCNPJ.Mask = "00.000.000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(155, 25);
            this.mtxtCNPJ.TabIndex = 3;
            this.mtxtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCNPJ_MaskInputRejected);
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(222, 147);
            this.rbtnCPF.Name = "rbtnCPF";
            this.rbtnCPF.Size = new System.Drawing.Size(55, 24);
            this.rbtnCPF.TabIndex = 2;
            this.rbtnCPF.TabStop = true;
            this.rbtnCPF.Text = "CPF";
            this.rbtnCPF.UseVisualStyleBackColor = true;
            this.rbtnCPF.CheckedChanged += new System.EventHandler(this.rbtnCPF_CheckedChanged);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(222, 177);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(155, 25);
            this.mtxtCPF.TabIndex = 3;
            this.mtxtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCPF_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(222, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 25);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Id do Cliente";
            // 
            // txtIDC
            // 
            this.txtIDC.Location = new System.Drawing.Point(688, 89);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(155, 25);
            this.txtIDC.TabIndex = 40;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(603, 134);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(240, 150);
            this.data.TabIndex = 42;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecione);
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(571, 353);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(100, 25);
            this.txtPT.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Preço Total R$";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(222, 353);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(100, 25);
            this.txtQuantidade.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Quantidade";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(391, 353);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(100, 25);
            this.txtPU.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Preço Unitário R$";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(222, 264);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(198, 25);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Data";
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(743, 353);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(100, 25);
            this.mtxtData.TabIndex = 53;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(452, 264);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(100, 25);
            this.txtIDP.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Id do Produto";
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenos.Location = new System.Drawing.Point(177, 354);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(39, 25);
            this.btnMenos.TabIndex = 56;
            this.btnMenos.Text = "–";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnMais.Location = new System.Drawing.Point(328, 354);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(39, 25);
            this.btnMais.TabIndex = 57;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Id do Funcionário";
            // 
            // txtIDF
            // 
            this.txtIDF.Location = new System.Drawing.Point(688, 417);
            this.txtIDF.Name = "txtIDF";
            this.txtIDF.Size = new System.Drawing.Size(155, 25);
            this.txtIDF.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nome do Funcionário";
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(222, 417);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(431, 25);
            this.txtNF.TabIndex = 5;
            this.txtNF.TextChanged += new System.EventHandler(this.txtNF_TextChanged);
            // 
            // PedidoProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFC);
            this.Controls.Add(this.rbtnCNPJ);
            this.Controls.Add(this.mtxtCNPJ);
            this.Controls.Add(this.rbtnCPF);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "PedidoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.RadioButton rbtnCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNF;
    }
}