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
    public partial class AlterarProduto1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarProduto1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnAlterar.Enabled = false;
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

        int Idp, Idf, Quantidade;
        double precou, precot;
        string nomef, marca, modelo;

        private void SelecioneProduto(object sender, DataGridViewCellEventArgs e)
        {
            Idp = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
            Idf = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            nomef = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            marca = Convert.ToString(data.Rows[e.RowIndex].Cells[3].Value);
            modelo = Convert.ToString(data.Rows[e.RowIndex].Cells[4].Value);
            Quantidade = Convert.ToInt32(data.Rows[e.RowIndex].Cells[5].Value);
            precou = Convert.ToDouble(data.Rows[e.RowIndex].Cells[6].Value);
            precot = Convert.ToDouble(data.Rows[e.RowIndex].Cells[7].Value);
            btnAlterar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarProduto2 frmAlterarProduto2 = new AlterarProduto2();
            frmAlterarProduto2.RecebeDados(Idp, Idf, nomef, marca, modelo, Quantidade, precou, precot);
            frmAlterarProduto2.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
