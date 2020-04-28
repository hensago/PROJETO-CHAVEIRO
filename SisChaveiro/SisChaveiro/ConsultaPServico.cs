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
    public partial class ConsultaPServico : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaPServico()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            txtLS.Enabled = false;
            txtNF.Enabled = false;
            txtServico.Enabled = false;
        }

        private void rbtnTudo_CheckedChanged(object sender, EventArgs e)
        {
            string selecionar1 = @"SELECT Id_Pedidoserv, Id_Servico, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERV";

            string selecionar2 = @"SELECT Id_Pedidoservcf, Id_Servico, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCF";

            string selecionar3 = @"SELECT Id_Pedidoservcj, Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCJ";

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

        private void rbtnServico_CheckedChanged(object sender, EventArgs e)
        {
            txtLS.Enabled = false;
            txtLS.Text = "";
            txtNF.Enabled = false;
            txtNF.Text = "";
            txtServico.Enabled = true;
            txtServico.Text = "";
        }

        private void rbtnLS_CheckedChanged(object sender, EventArgs e)
        {
            txtLS.Enabled = true;
            txtLS.Text = "";
            txtNF.Enabled = false;
            txtNF.Text = "";
            txtServico.Enabled = false;
            txtServico.Text = "";
        }

        private void rbtnNF_CheckedChanged(object sender, EventArgs e)
        {
            txtLS.Enabled = false;
            txtLS.Text = "";
            txtNF.Enabled = true;
            txtNF.Text = "";
            txtServico.Enabled = false;
            txtServico.Text = "";
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            string servico = txtServico.Text;

            string selecionar1 = @"SELECT Id_Pedidoserv, Id_Servico, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERV WHERE Servico LIKE '%" + servico + "%'";

            string selecionar2 = @"SELECT Id_Pedidoservcf, Id_Servico, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCF WHERE Servico LIKE '%" + servico + "%'";

            string selecionar3 = @"SELECT Id_Pedidoservcj, Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCJ WHERE Servico LIKE '%" + servico + "%'";

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

        private void txtLS_TextChanged(object sender, EventArgs e)
        {
            string ls = txtLS.Text;

            string selecionar1 = @"SELECT Id_Pedidoserv, Id_Servico, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERV WHERE Lugar_Servico like '%" + ls + "%'";

            string selecionar2 = @"SELECT Id_Pedidoservcf, Id_Servico, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCF WHERE Lugar_Servico like '%" + ls + "%'";

            string selecionar3 = @"SELECT Id_Pedidoservcj, Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCJ WHERE Lugar_Servico like '%" + ls + "%'";

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

            string selecionar1 = @"SELECT Id_Pedidoserv, Id_Servico, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERV WHERE Nome_Funcionario LIKE '%" + nf + "%'";

            string selecionar2 = @"SELECT Id_Pedidoservcf, Id_Servico, Id_Clientef, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CPF, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCF WHERE Nome_Funcionario LIKE '%" + nf + "%'";

            string selecionar3 = @"SELECT Id_Pedidoservcj, Id_Servico, Id_Clientej, Id_Funcionario, Nome_Cliente, Nome_Funcionario,
                CNPJ, Servico, Lugar_Servico, Preco, Data_Pedido, Data_Conclusao FROM PEDIDOSERVCJ WHERE Nome_Funcionario LIKE '%" + nf + "%'";

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
            Close();
        }
    }
}
