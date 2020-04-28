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
    public partial class ExcluirFornecedor : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        int codigo_fornecedor;
        string nome_fornecedor;
        public ExcluirFornecedor()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
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

        private void SelecioneFornecedor(object sender, DataGridViewCellEventArgs e)
        {
            codigo_fornecedor = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
            nome_fornecedor = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deletar1 = @"DELETE FROM FORNECEDOR WHERE Id_Fornecedor ='" + codigo_fornecedor + "';";
                string deletar2 = @"DELETE FROM ENDERECOFR WHERE Nome_Fornecedor ='" + nome_fornecedor + "';";
                SqlCommand _cmd1 = new SqlCommand(deletar1, con);
                SqlCommand _cmd2 = new SqlCommand(deletar2, con);
                _cmd1.ExecuteNonQuery();
                _cmd2.ExecuteNonQuery();
                txtNome.Text = "";
                               

                string selecionar1 = @"SELECT Id_Fornecedor, Nome, E_mail, Celular, Telefone FROM FORNECEDOR";
                string selecionar2 = @"SELECT Id_Endforn, Nome_Fornecedor, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFR";

                SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

                DataTable tabela1 = new DataTable();
                DataTable tabela2 = new DataTable();

                adaptador1.Fill(tabela1);
                adaptador2.Fill(tabela2);

                data1.DataSource = tabela1;
                data2.DataSource = tabela2;
                btnExcluir.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
                    }
}
