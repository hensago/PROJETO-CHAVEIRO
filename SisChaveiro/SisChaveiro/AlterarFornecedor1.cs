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
    public partial class AlterarFornecedor1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarFornecedor1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnAlterar.Enabled = false;
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
        }

        String Nome, Celular, Telefone, Email;
        int IDF, IDE, Numero;
        String Rua, CEP, Complemento, Bairro, Cidade, Estado;

        private void SelecioneFornecedor(object sender, DataGridViewCellEventArgs e)
        {
            IDF = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
            Nome = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
            Email = Convert.ToString(data1.Rows[e.RowIndex].Cells[2].Value);
            Celular = Convert.ToString(data1.Rows[e.RowIndex].Cells[3].Value);
            Telefone = Convert.ToString(data1.Rows[e.RowIndex].Cells[4].Value);

            IDE = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[0].Value);
            Rua = Convert.ToString(data2.Rows[e.RowIndex].Cells[2].Value);
            Numero = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[3].Value);
            CEP = Convert.ToString(data2.Rows[e.RowIndex].Cells[4].Value);
            Complemento = Convert.ToString(data2.Rows[e.RowIndex].Cells[5].Value);
            Bairro = Convert.ToString(data2.Rows[e.RowIndex].Cells[6].Value);
            Cidade = Convert.ToString(data2.Rows[e.RowIndex].Cells[7].Value);
            Estado = Convert.ToString(data2.Rows[e.RowIndex].Cells[8].Value);

            btnAlterar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFornecedor2 frmAlterarFornecedor2 = new AlterarFornecedor2();
            frmAlterarFornecedor2.RecebeDados(IDF, Nome, Email, Celular, Telefone,
                IDE, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado);
            frmAlterarFornecedor2.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
