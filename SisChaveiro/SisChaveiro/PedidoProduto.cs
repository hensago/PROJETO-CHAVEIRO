using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisChaveiro
{
    public partial class PedidoProduto : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public PedidoProduto()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            txtIDC.Enabled = false;
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = false;
            txtPU.Enabled = false;
            txtPT.Enabled = false;
        }

        string nomec, nomef, cpf, cnpj, modelo;
        int idPd, idc, idf, quant, quantr, selecao;
        double precou, precot;
        String dataat = Convert.ToString(DateTime.Now);

        private void rbtnCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = true;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCPF.Focus();
            MessageBox.Show("Cliente Cadastrado Confirmado, Aplicando Desconto!");
        }

        private void rbtnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Enabled = true;
            mtxtCPF.Enabled = false;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCNPJ.Focus();
            MessageBox.Show("Cliente Cadastrado Confirmado, Aplicando Desconto!");
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM
            PRODUTO WHERE Modelo LIKE '%" + modelo + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

            selecao = 2;
        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cpf = mtxtCPF.Text;

            string selecionar = @"SELECT Id_Clientef, Nome, CPF FROM CLIENTEF WHERE CPF LIKE '%" + cpf + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

            txtIDC.Enabled = true;

            selecao = 1;
        }

        private void mtxtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cnpj = mtxtCNPJ.Text;

            string selecionar2 = @"SELECT Id_Clientej, Nome, CNPJ FROM CLIENTEJ WHERE CNPJ LIKE '%" + cnpj + "%'";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);
            DataTable tabela2 = new DataTable();
            adaptador2.Fill(tabela2);
            data.DataSource = tabela2;

            txtIDC.Enabled = true;

            selecao = 1;
        }

        private void txtNF_TextChanged(object sender, EventArgs e)
        {
            nomef = txtNF.Text;

            string selecionar4 = @"SELECT Id_Funcionario, Nome, Sobrenome FROM FUNCIONARIO WHERE Nome LIKE '%" + nomef + "%'";
            SqlDataAdapter adaptador4 = new SqlDataAdapter(selecionar4, con);
            DataTable tabela4 = new DataTable();
            adaptador4.Fill(tabela4);
            data.DataSource = tabela4;

            selecao = 3;
        }

        private void Selecione(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {

                nomec = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
                txtNome.Text = nomec;

                idc = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDC.Text = Convert.ToString(idc);

            }
            if (selecao == 2)
            {
                idPd = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDP.Text = Convert.ToString(idPd);

                modelo = Convert.ToString(data.Rows[e.RowIndex].Cells[4].Value);
                txtModelo.Text = modelo;

                quantr = Convert.ToInt32(data.Rows[e.RowIndex].Cells[5].Value);

                precou = Convert.ToDouble(data.Rows[e.RowIndex].Cells[6].Value);
                txtPU.Text = Convert.ToString(precou);


                quant = 1;
                txtQuantidade.Text = Convert.ToString(quant);


            }
            if (selecao == 3)
            {
                nomef = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
                txtNF.Text = nomef;

                idf = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDF.Text = Convert.ToString(idf);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (quant != 1)
            {
                quant = quant - 1;
                txtQuantidade.Text = Convert.ToString(quant);

                if ((rbtnCNPJ.Checked == true) || (rbtnCPF.Checked == true))
                {
                    precot = quant * precou;
                    txtPT.Text = Convert.ToString(precot);
                    precot = precot - ((precot * 5) / 100);
                    txtPT.Text = Convert.ToString(precot);
                }
                else
                {
                    precot = quant * precou;
                    txtPT.Text = Convert.ToString(precot);
                }

            }
            else
            {
                MessageBox.Show("A quantidade não pode ser menor que 1");
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (quant != 50)
            {
                if (quant < quantr)
                {
                    quant = quant + 1;
                    txtQuantidade.Text = Convert.ToString(quant);

                    if ((rbtnCNPJ.Checked == true) || (rbtnCPF.Checked == true))
                    {
                        precot = quant * precou;
                        txtPT.Text = Convert.ToString(precot);
                        precot = precot - ((precot * 5) / 100);
                        txtPT.Text = Convert.ToString(precot);
                    }
                    else
                    {
                        precot = quant * precou;
                        txtPT.Text = Convert.ToString(precot);
                    }
                }
                else
                {
                    MessageBox.Show("A quantidade comprada não pode ser maior do que a quantidade em estoque!");
                }
            }
            else
            {
                MessageBox.Show("A quantidade não pode ser maior que 50");
            }
        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtModelo.Text != "") && (txtIDP.Text != "") &&
                (txtQuantidade.Text != "") && (txtPU.Text != "") && (txtPT.Text != "") &&
                (mtxtData.Text != ""))
            {
                try
                {

                    if (rbtnCPF.Checked == true)
                    {
                        nomec = txtNome.Text;
                        cpf = mtxtCPF.Text;
                        idc = Convert.ToInt32(txtIDC.Text);
                        modelo = txtModelo.Text;
                        idPd = Convert.ToInt32(txtIDP.Text);
                        quant = Convert.ToInt32(txtQuantidade.Text);
                        precou = Convert.ToInt32(txtPU.Text);
                        precot = Convert.ToInt32(txtPT.Text);
                        dataat = Convert.ToString(mtxtData.Text);

                        quantr = quantr - quant;

                        string inserir = @"INSERT INTO PEDIDOPRODCF (Id_Produto, Id_Clientef, Nome_Cliente, CPF, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data) VALUES
                    ('" + idPd + "','" + idc + "','" + nomec + "','" + cpf + "','" + modelo + "','" + quant + "','" + precou + "','" + precot + "','" + dataat + "')";

                        string update = @"UPDATE PRODUTO SET Quantidade ='" + quantr + "'WHERE Id_Produto ='" + idc + "';";


                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        SqlCommand _cmd2 = new SqlCommand(update, con);
                        _cmd2.ExecuteNonQuery();


                        con.Close();

                        MessageBox.Show("PEDIDO REALIZADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtModelo.Clear();
                        txtIDP.Clear();
                        txtQuantidade.Clear();
                        txtPU.Clear();
                        txtPT.Clear();
                        mtxtData.Clear();
                        txtNome.Focus();
                    }
                    else if (rbtnCNPJ.Checked == true)
                    {
                        nomec = txtNome.Text;
                        cnpj = mtxtCNPJ.Text;
                        idc = Convert.ToInt32(txtIDC.Text);
                        modelo = txtModelo.Text;
                        idPd = Convert.ToInt32(txtIDP.Text);
                        quant = Convert.ToInt32(txtQuantidade.Text);
                        precou = Convert.ToInt32(txtPU.Text);
                        precot = Convert.ToInt32(txtPT.Text);
                        dataat = Convert.ToString(mtxtData.Text);

                        quantr = quantr - quant;

                        string inserir = @"INSERT INTO PEDIDOPRODCF (Id_Produto, Id_Clientej, Nome_Cliente, CPF, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data) VALUES
                    ('" + idPd + "','" + idc + "','" + nomec + "','" + cnpj + "','" + modelo + "','" + quant + "','" + precou + "','" + precot + "','" + dataat + "')";
                        string update = @"UPDATE PRODUTO SET Quantidade ='" + quantr + "'WHERE Id_Produto ='" + idc + "';";


                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        SqlCommand _cmd2 = new SqlCommand(update, con);
                        _cmd2.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("PEDIDO REALIZADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtModelo.Clear();
                        txtIDP.Clear();
                        txtQuantidade.Clear();
                        txtPU.Clear();
                        txtPT.Clear();
                        mtxtData.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        nomec = txtNome.Text;
                        modelo = txtModelo.Text;
                        idPd = Convert.ToInt32(txtIDP.Text);
                        quant = Convert.ToInt32(txtQuantidade.Text);
                        precou = Convert.ToInt32(txtPU.Text);
                        precot = Convert.ToInt32(txtPT.Text);
                        dataat = Convert.ToString(mtxtData.Text);

                        quantr = quantr - quant;

                        string inserir = @"INSERT INTO PEDIDOPROD (Id_Produto, Nome_Cliente, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data) VALUES
                    ('" + idPd + "','" + nomec + "','" + modelo + "','" + quant + "','" + precou + "','" + precot + "','" + dataat + "')";
                        string update = @"UPDATE PRODUTO SET Quantidade ='" + quantr + "'WHERE Id_Produto ='" + idc + "';";


                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        SqlCommand _cmd2 = new SqlCommand(update, con);
                        _cmd2.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("PEDIDO REALIZADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtModelo.Clear();
                        txtIDP.Clear();
                        txtQuantidade.Clear();
                        txtPU.Clear();
                        txtPT.Clear();
                        mtxtData.Clear();
                        txtNome.Focus();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Certifique-se que você digitou algum número nos campos certo");
                    txtIDP.Focus();
                }
            }
            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIDC.Clear();
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            txtModelo.Clear();
            txtIDP.Clear();
            txtQuantidade.Clear();
            txtPU.Clear();
            txtPT.Clear();
            mtxtData.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
