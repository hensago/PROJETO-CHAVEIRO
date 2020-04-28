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
    public partial class ConsultaCCliente : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaCCliente()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPF.Enabled = true;
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCPF.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = true;
            mtxtCPF.Clear();
            mtxtCNPJ.Clear();
            mtxtCNPJ.Focus();
        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = mtxtCPF.Text;

            string selecionar1 = @"SELECT Id_Clientef, Nome, Sobrenome, CPF, Celular, Telefone, E_mail FROM CLIENTEF WHERE CPF LIKE '%" + cpf + "%'";
            string selecionar2 = @"SELECT Id_Endclif, CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOCF WHERE CPF LIKE '%" + cpf + "%'";

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

        private void mtxtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cnpj = mtxtCNPJ.Text;

            string selecionar = @"SELECT Id_Clientej, Nome, Sobrenome, CNPJ, Celular, Telefone, E_mail FROM CLIENTEJ WHERE CNPJ LIKE '%" + cnpj + "%'";
            string selecionar2 = @"SELECT Id_Endclij, CNPJ, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOCJ WHERE CNPJ LIKE '%" + cnpj + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

            DataTable tabela = new DataTable();
            DataTable tabela2 = new DataTable();

            adaptador.Fill(tabela);
            adaptador2.Fill(tabela2);

            data1.DataSource = tabela;
            data2.DataSource = tabela2;

            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultaCCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
