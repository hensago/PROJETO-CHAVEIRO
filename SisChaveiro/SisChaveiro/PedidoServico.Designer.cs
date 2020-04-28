namespace SisChaveiro
{
    partial class PedidoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoServico));
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.txtLS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtDC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.rbtnCNPJ = new System.Windows.Forms.RadioButton();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtDP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "Id do Funcionário";
            // 
            // txtIDF
            // 
            this.txtIDF.Location = new System.Drawing.Point(690, 428);
            this.txtIDF.Name = "txtIDF";
            this.txtIDF.Size = new System.Drawing.Size(155, 25);
            this.txtIDF.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 83;
            this.label10.Text = "Nome do Funcionário";
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(224, 428);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(431, 25);
            this.txtNF.TabIndex = 10;
            this.txtNF.TextChanged += new System.EventHandler(this.txtNF_TextChanged);
            // 
            // txtLS
            // 
            this.txtLS.Location = new System.Drawing.Point(224, 364);
            this.txtLS.Name = "txtLS";
            this.txtLS.Size = new System.Drawing.Size(198, 25);
            this.txtLS.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Lugar Realizado";
            // 
            // mtxtDC
            // 
            this.mtxtDC.Location = new System.Drawing.Point(745, 364);
            this.mtxtDC.Mask = "00/00/0000";
            this.mtxtDC.Name = "mtxtDC";
            this.mtxtDC.Size = new System.Drawing.Size(100, 25);
            this.mtxtDC.TabIndex = 9;
            this.mtxtDC.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Data Conclusão";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(454, 364);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 25);
            this.txtPreco.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Preço Total R$";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(224, 275);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(198, 25);
            this.txtServico.TabIndex = 4;
            this.txtServico.TextChanged += new System.EventHandler(this.txtServico_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Serviço";
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(605, 145);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(240, 150);
            this.data.TabIndex = 73;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecioneCSF);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Id do Cliente";
            // 
            // txtIDC
            // 
            this.txtIDC.Location = new System.Drawing.Point(690, 100);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(155, 25);
            this.txtIDC.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nome";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(690, 559);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 44);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(454, 559);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 44);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(224, 559);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(155, 44);
            this.btnFC.TabIndex = 12;
            this.btnFC.Text = "Finalizar Compra";
            this.btnFC.UseVisualStyleBackColor = true;
            this.btnFC.Click += new System.EventHandler(this.btnFC_Click);
            // 
            // rbtnCNPJ
            // 
            this.rbtnCNPJ.AutoSize = true;
            this.rbtnCNPJ.Location = new System.Drawing.Point(420, 158);
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
            this.mtxtCNPJ.Location = new System.Drawing.Point(420, 188);
            this.mtxtCNPJ.Mask = "00.000.000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(155, 25);
            this.mtxtCNPJ.TabIndex = 3;
            this.mtxtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCNPJ_MaskInputRejected);
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(224, 158);
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
            this.mtxtCPF.Location = new System.Drawing.Point(224, 188);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(155, 25);
            this.mtxtCPF.TabIndex = 3;
            this.mtxtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCPF_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(224, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 25);
            this.txtNome.TabIndex = 1;
            // 
            // mtxtDP
            // 
            this.mtxtDP.Location = new System.Drawing.Point(605, 364);
            this.mtxtDP.Mask = "00/00/0000";
            this.mtxtDP.Name = "mtxtDP";
            this.mtxtDP.Size = new System.Drawing.Size(100, 25);
            this.mtxtDP.TabIndex = 8;
            this.mtxtDP.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Data do Pedido";
            // 
            // txtIDS
            // 
            this.txtIDS.Location = new System.Drawing.Point(454, 275);
            this.txtIDS.Name = "txtIDS";
            this.txtIDS.Size = new System.Drawing.Size(100, 25);
            this.txtIDS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Id do Serviço";
            // 
            // PedidoServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.txtIDS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.txtLS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtDC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServico);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "PedidoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.TextBox txtLS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.RadioButton rbtnCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDS;
        private System.Windows.Forms.Label label6;
    }
}