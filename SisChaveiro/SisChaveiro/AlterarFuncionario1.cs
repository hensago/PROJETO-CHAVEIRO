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
    public partial class AlterarFuncionario1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarFuncionario1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnAlterar.Enabled = false;
        }
       
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
            string selecionar2 = @"SELECT Id_Endfun, Nome_Funcionario,CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOFUN WHERE CPF LIKE '%" + cpf + "%'";

            SqlDataAdapter adaptador1 = new SqlDataAdapter(selecionar1, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

            DataTable tabela1 = new DataTable();
            DataTable tabela2 = new DataTable();

            adaptador1.Fill(tabela1);
            adaptador2.Fill(tabela2);

            data1.DataSource = tabela1;
            data2.DataSource = tabela2;
        }

        int Idf, Ide, Num;
        string nomef, sobrenome, Cpf, celular, telefone, email;
        string rua, Cep, complemento, bairro, cidade, estado;

        private void SelecioneFuncionario1(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;

            Idf = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
            nomef = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
            sobrenome = Convert.ToString(data1.Rows[e.RowIndex].Cells[2].Value);
            Cpf = Convert.ToString(data1.Rows[e.RowIndex].Cells[3].Value);
            celular = Convert.ToString(data1.Rows[e.RowIndex].Cells[4].Value);
            telefone = Convert.ToString(data1.Rows[e.RowIndex].Cells[5].Value);
            email = Convert.ToString(data1.Rows[e.RowIndex].Cells[6].Value);

            Ide = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[0].Value);
            nomef = Convert.ToString(data2.Rows[e.RowIndex].Cells[1].Value);
            Cpf = Convert.ToString(data2.Rows[e.RowIndex].Cells[2].Value);
            rua = Convert.ToString(data2.Rows[e.RowIndex].Cells[3].Value);
            Num = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[4].Value);
            Cep = Convert.ToString(data2.Rows[e.RowIndex].Cells[5].Value);
            complemento = Convert.ToString(data2.Rows[e.RowIndex].Cells[6].Value);
            bairro = Convert.ToString(data2.Rows[e.RowIndex].Cells[7].Value);
            cidade = Convert.ToString(data2.Rows[e.RowIndex].Cells[8].Value);
            estado = Convert.ToString(data2.Rows[e.RowIndex].Cells[9].Value);
                                }                

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFuncionario2 frmAlterarFuncionario2 = new AlterarFuncionario2();
            frmAlterarFuncionario2.RecebeDados(Idf, nomef, sobrenome, Cpf, celular, telefone, email,
                Ide, rua, Num, Cep, complemento, bairro, cidade, estado);
            frmAlterarFuncionario2.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
