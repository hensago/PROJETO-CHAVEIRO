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
    public partial class ConsultaCFornecedor : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaCFornecedor()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string selecionar1 = @"SELECT Id_Fornecedor, Nome, E_mail, Celular, Telefone FROM FORNECEDOR WHERE Nome LIKE '%" + nome + "%'";
            string selecionar2 = @"SELECT Id_Endforn, Nome_Fornecedor, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFR WHERE Nome_Fornecedor LIKE '%" + nome + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;

            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
