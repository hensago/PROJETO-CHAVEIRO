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
    public partial class ExcluirFuncionario : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ExcluirFuncionario()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
        }

        int codigo_funcionario;
        string Nome;

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string selecionar1 = @"SELECT Id_Funcionario, Nome, Sobrenome, CPF, Celular, Telefone, E_mail FROM FUNCIONARIO WHERE Nome LIKE '%" + nome + "%'";
            string selecionar2 = @"SELECT Id_Endfun, Nome_Funcionario,CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFUN WHERE Nome_Funcionario LIKE '%" + nome + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = mtxtCPF.Text;

            string selecionar1 = @"SELECT Id_Funcionario, Nome, Sobrenome, CPF, Celular, Telefone, E_mail FROM FUNCIONARIO WHERE CPF LIKE '%" + cpf + "%'";
            string selecionar2 = @"SELECT Id_Endfun, Nome_Funcionario, CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFUN WHERE CPF LIKE '%" + cpf + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
        }

        private void SelecioneFuncionario1(object sender, DataGridViewCellEventArgs e)
        {
            codigo_funcionario = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
            Nome = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }
                
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deletar1 = @"DELETE FROM FUNCIONARIO WHERE Id_Funcionario ='" + codigo_funcionario + "';";
                string deletar2 = @"DELETE FROM ENDERECOFUN WHERE Nome_Funcionario ='" + Nome + "';";
                SqlCommand _cmd1 = new SqlCommand(deletar1, con);
                SqlCommand _cmd2 = new SqlCommand(deletar2, con);
                _cmd1.ExecuteNonQuery();
                _cmd2.ExecuteNonQuery();
                txtNome.Text = "";
                mtxtCPF.Text = "";

                string selecionar1 = @"SELECT Id_Funcionario, Nome, CPF, E_mail, Celular, Telefone FROM FUNCIONARIO";
                string selecionar2 = @"SELECT Id_Endfun, Nome_Funcionario, CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFUN";

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
