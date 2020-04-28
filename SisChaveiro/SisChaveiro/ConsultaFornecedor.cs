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
    public partial class ConsultaFornecedor : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaFornecedor()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string selecionar = @"SELECT Id_Fornecedor, Nome, E_mail, Celular, Telefone FROM FORNECEDOR WHERE Nome LIKE '%" + nome + "%'";
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
