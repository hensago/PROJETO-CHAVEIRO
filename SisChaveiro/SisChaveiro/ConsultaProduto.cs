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
    public partial class ConsultaProduto : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaProduto()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtModelo.Clear();

            string marca = txtMarca.Text;

            string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM
            PRODUTO WHERE Marca LIKE '%" + marca + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            txtMarca.Clear();

            string modelo = txtModelo.Text;

            string selecionar = @"SELECT Id_Produto, Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total FROM
            PRODUTO WHERE Modelo LIKE '%" + modelo + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
