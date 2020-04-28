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
    public partial class PedidoServico : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public PedidoServico()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            txtIDC.Enabled = false;
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = false;
            txtPreco.Enabled = false;
        }

        string nomec, nomef, servico, ls;
        string cpf, cnpj;
        int idc, idf, ids, selecao;
        double preco;
        String datap = Convert.ToString(DateTime.Now);
        String datac = Convert.ToString(DateTime.Now.AddDays(3));

        private void rbtnCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = true;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCPF.Focus();
        }

        private void rbtnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Enabled = true;
            mtxtCPF.Enabled = false;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCNPJ.Focus();
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

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            servico = txtServico.Text;

            string selecionar3 = @"SELECT Id_Servico, Servico, Lugar_Servico, Preco FROM SERVICO WHERE Servico LIKE '%" + servico + "%'";
            SqlDataAdapter adaptador3 = new SqlDataAdapter(selecionar3, con);
            DataTable tabela3 = new DataTable();
            adaptador3.Fill(tabela3);
            data.DataSource = tabela3;

            selecao = 2;
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

        private void SelecioneCSF(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {
                nomec = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
                txtNome.Text = nomec;

                idc = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDC.Text = Convert.ToString(idc);
            }
            else if (selecao == 2)
            {
                ids = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDS.Text = Convert.ToString(ids);

                servico = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
                txtServico.Text = servico;

                ls = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
                txtLS.Text = ls;

                preco = Convert.ToDouble(data.Rows[e.RowIndex].Cells[3].Value);
                txtPreco.Text = Convert.ToString(preco);

                mtxtDP.Text = datap;
                mtxtDC.Text = datac;

                if ((rbtnCNPJ.Checked == true) || (rbtnCPF.Checked == true))
                {
                    MessageBox.Show("Cliente Cadastrado Confirmado, Aplicando Desconto!");
                    preco = preco - ((preco * 5) / 100);
                    txtPreco.Text = Convert.ToString(preco);
                }


            }
            else if (selecao == 3)
            {
                nomef = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
                txtNF.Text = nomef;

                idf = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
                txtIDF.Text = Convert.ToString(idf);
            }
        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtServico.Text != "") && (txtLS.Text != "") &&
                (txtPreco.Text != "") && (txtNF.Text != "") && (txtIDF.Text != "") &&
                (mtxtDP.Text != "") && (mtxtDC.Text != "") && (txtIDS.Text != ""))
            {
                try
                {
                    if (rbtnCNPJ.Checked == true)
                    {
                        ids = Convert.ToInt32(txtIDS.Text);
                        idf = Convert.ToInt32(txtIDF.Text);
                        idc = Convert.ToInt32(txtIDC.Text);
                        nomec = txtNome.Text;
                        nomef = txtNF.Text;
                        cnpj = mtxtCNPJ.Text;
                        servico = txtServico.Text;
                        ls = txtLS.Text;
                        preco = Convert.ToDouble(txtPreco.Text);
                        datap = Convert.ToString(mtxtDP.Text);
                        datac = Convert.ToString(mtxtDC.Text);

                        string inserir = @"INSERT INTO PEDIDOSERVCJ (Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente,
                    Nome_Funcionario, CNPJ, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao) VALUES
                    ('" + ids + "','" + idc + "','" + idf + "','" + nomec + "','" + nomef + "','" + cnpj + "','" +
                    servico + "','" + ls + "','" + preco + "','" + datap + "','" + datac + "')";

                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        

                        MessageBox.Show("SERVIÇO SOLICITADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtServico.Clear();
                        txtIDS.Clear();
                        txtLS.Clear();
                        txtPreco.Clear();
                        mtxtDP.Clear();
                        mtxtDC.Clear();
                        txtNF.Clear();
                        txtIDF.Clear();
                        txtNome.Focus();
                    }
                    else if (rbtnCPF.Checked == true)
                    {
                        ids = Convert.ToInt32(txtIDS.Text);
                        idf = Convert.ToInt32(txtIDF.Text);
                        idc = Convert.ToInt32(txtIDC.Text);
                        nomec = txtNome.Text;
                        nomef = txtNF.Text;
                        cpf = mtxtCPF.Text;
                        servico = txtServico.Text;
                        ls = txtLS.Text;
                        preco = Convert.ToDouble(txtPreco.Text);
                        datap = Convert.ToString(mtxtDP.Text);
                        datac = Convert.ToString(mtxtDC.Text);

                        string inserir = @"INSERT INTO PEDIDOSERVCF (Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente,
                    Nome_Funcionario, CPF, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao) VALUES
                    ('" + ids + "','" + idc + "','" + idf + "','" + nomec + "','" + nomef + "','" + cpf + "','" +
                    servico + "','" + ls + "','" + preco + "','" + datap + "','" + datac + "')";

                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("SERVIÇO SOLICITADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtServico.Clear();
                        txtIDS.Clear();
                        txtLS.Clear();
                        txtPreco.Clear();
                        mtxtDP.Clear();
                        mtxtDC.Clear();
                        txtNF.Clear();
                        txtIDF.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        ids = Convert.ToInt32(txtIDS.Text);
                        idf = Convert.ToInt32(txtIDF.Text);
                        nomec = txtNome.Text;
                        nomef = txtNF.Text;
                        servico = txtServico.Text;
                        ls = txtLS.Text;
                        preco = Convert.ToDouble(txtPreco.Text);
                        datap = Convert.ToString(mtxtDP.Text);
                        datac = Convert.ToString(mtxtDC.Text);

                        string inserir = @"INSERT INTO PEDIDOSERV (Id_Servico, Id_Funcionario, Nome_Cliente,
                    Nome_Funcionario, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao) VALUES
                    ('" + ids + "','" + idf + "','" + nomec + "','" + nomef + "','" + servico + "','" +
                            ls + "','" + preco + "','" + datap + "','" + datac + "')";

                        SqlCommand _cmd = new SqlCommand(inserir, con);
                        _cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("SERVIÇO SOLICITADO COM SUCESSO!");

                        txtNome.Clear();
                        txtIDC.Clear();
                        mtxtCPF.Clear();
                        mtxtCNPJ.Clear();
                        txtServico.Clear();
                        txtIDS.Clear();
                        txtLS.Clear();
                        txtPreco.Clear();
                        mtxtDP.Clear();
                        mtxtDC.Clear();
                        txtNF.Clear();
                        txtIDF.Clear();
                        txtNome.Focus();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Certifique-se que você digitou algum número nos campos certo");
                    txtIDS.Focus();
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
            txtServico.Clear();
            txtIDS.Clear();
            txtLS.Clear();
            txtPreco.Clear();
            mtxtDP.Clear();
            mtxtDC.Clear();
            txtNF.Clear();
            txtIDF.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }
    }
}
