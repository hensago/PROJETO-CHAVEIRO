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
    public partial class ExcluirProduto : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        int codigo_produto;
        public ExcluirProduto()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;

            string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM
            PRODUTO WHERE Marca LIKE '%" + marca + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;

            string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM
            PRODUTO WHERE Modelo LIKE '%" + modelo + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        private void SelecioneProduto(object sender, DataGridViewCellEventArgs e)
        {
            codigo_produto = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deletar = @"DELETE FROM PRODUTO WHERE Id_Produto ='" + codigo_produto + "';";
                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtMarca.Text = "";
                txtModelo.Text = "";

                string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM PRODUTO";
                SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                data.DataSource = tabela;

                btnExcluir.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
