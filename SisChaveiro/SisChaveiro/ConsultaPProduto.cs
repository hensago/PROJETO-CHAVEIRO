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
    public partial class ConsultaPProduto : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaPProduto()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            txtModelo.Enabled = false;
            txtNF.Enabled = false;
        }

        private void rbtnTudo_CheckedChanged(object sender, EventArgs e)
        {
            string selecionar1 = @"SELECT Id_Pedidoprod, Id_Produto, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPROD";

            string selecionar2 = @"SELECT Id_Pedidoprodcf, Id_Produto, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCF";

            string selecionar3 = @"SELECT Id_Pedidoprodcj, Id_Produto, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCJ";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);
            SqlDataAdapter adaptador3 = new SqlDataAdapter(selecionar3, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();
            DataTable tabela3 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);
            adaptador3.Fill(tabela3);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
            data3.DataSource = tabela3;

        }

        private void rbtnModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
            txtModelo.Text = "";
            txtNF.Enabled = false;
            txtNF.Text = "";
            
        }

        private void rbtnNF_CheckedChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = false;
            txtModelo.Text = "";
            txtNF.Enabled = true;
            txtNF.Text = "";
            
        }
                
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;


            string selecionar1 = @"SELECT Id_Pedidoprod, Id_Produto, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPROD WHERE Modelo = '%" + modelo + "%'";

            string selecionar2 = @"SELECT Id_Pedidoprodcf, Id_Produto, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCF WHERE Modelo = '%" + modelo + "%'";

            string selecionar3 = @"SELECT Id_Pedidoprodcj, Id_Produto, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCJ WHERE Modelo = '%" + modelo + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);
            SqlDataAdapter adaptador3 = new SqlDataAdapter(selecionar3, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();
            DataTable tabela3 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);
            adaptador3.Fill(tabela3);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
            data3.DataSource = tabela3;
        }

        private void txtNF_TextChanged(object sender, EventArgs e)
        {
            string nf = txtNF.Text;


            string selecionar1 = @"SELECT Id_Pedidoprod, Id_Produto, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPROD WHERE Nome_Funcionario = '%" + nf + "%'";

            string selecionar2 = @"SELECT Id_Pedidoprodcf, Id_Produto, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCF WHERE Nome_Funcionario = '%" + nf + "%'";

            string selecionar3 = @"SELECT Id_Pedidoprodcj, Id_Produto, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Modelo, Quantidade, Preco_Unitario, Preco_Total, Data FROM PEDIDOPRODCJ WHERE Nome_Funcionario = '%" + nf + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);
            SqlDataAdapter adaptador3 = new SqlDataAdapter(selecionar3, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();
            DataTable tabela3 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);
            adaptador3.Fill(tabela3);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
            data3.DataSource = tabela3;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }
    }
}
