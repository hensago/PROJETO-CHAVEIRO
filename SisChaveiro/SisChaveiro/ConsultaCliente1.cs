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
    public partial class ConsultaCliente1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ConsultaCliente1()
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

            string selecionar = @"SELECT Id_Clientef, Nome, Sobrenome, CPF, Celular, Telefone, E_mail FROM CLIENTEF WHERE CPF LIKE '%"+cpf+"%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }

        private void mtxtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cnpj = mtxtCNPJ.Text;

            string selecionar = @"SELECT Id_Clientej, Nome, Sobrenome, CNPJ, Celular, Telefone, E_mail FROM CLIENTEJ WHERE CNPJ LIKE '%" + cnpj + "%'";
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
