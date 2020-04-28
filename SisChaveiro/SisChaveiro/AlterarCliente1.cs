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
    public partial class AlterarCliente1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarCliente1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = false;
            btnAlterar.Enabled = false;
        }

        int idc, selecao;
        string nome, sobrenome, celular, telefone, email;
        string Cpf, Cnpj;

        string rua, cep, complemento, bairro, cidade, estado;
        int idef, idej, numero;

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

            selecao = 1;
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

            selecao = 2;
        }

        private void SelecioneCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {
                idc = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
                sobrenome = Convert.ToString(data1.Rows[e.RowIndex].Cells[2].Value);
                Cpf = Convert.ToString(data1.Rows[e.RowIndex].Cells[3].Value);
                celular = Convert.ToString(data1.Rows[e.RowIndex].Cells[4].Value);
                telefone = Convert.ToString(data1.Rows[e.RowIndex].Cells[5].Value);
                email = Convert.ToString(data1.Rows[e.RowIndex].Cells[6].Value);

                idef = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[0].Value);
                rua = Convert.ToString(data2.Rows[e.RowIndex].Cells[2].Value);
                numero = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[3].Value);
                cep = Convert.ToString(data2.Rows[e.RowIndex].Cells[4].Value);
                complemento = Convert.ToString(data2.Rows[e.RowIndex].Cells[5].Value);
                bairro = Convert.ToString(data2.Rows[e.RowIndex].Cells[6].Value);
                cidade = Convert.ToString(data2.Rows[e.RowIndex].Cells[7].Value);
                estado = Convert.ToString(data2.Rows[e.RowIndex].Cells[8].Value);

                btnAlterar.Enabled = true;
            }
            else if (selecao == 2)
            {
                idc = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(data1.Rows[e.RowIndex].Cells[1].Value);
                sobrenome = Convert.ToString(data1.Rows[e.RowIndex].Cells[2].Value);
                Cnpj = Convert.ToString(data1.Rows[e.RowIndex].Cells[3].Value);
                celular = Convert.ToString(data1.Rows[e.RowIndex].Cells[4].Value);
                telefone = Convert.ToString(data1.Rows[e.RowIndex].Cells[5].Value);
                email = Convert.ToString(data1.Rows[e.RowIndex].Cells[6].Value);

                idej = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[0].Value);
                rua = Convert.ToString(data2.Rows[e.RowIndex].Cells[2].Value);
                numero = Convert.ToInt32(data2.Rows[e.RowIndex].Cells[3].Value);
                cep = Convert.ToString(data2.Rows[e.RowIndex].Cells[4].Value);
                complemento = Convert.ToString(data2.Rows[e.RowIndex].Cells[5].Value);
                bairro = Convert.ToString(data2.Rows[e.RowIndex].Cells[6].Value);
                cidade = Convert.ToString(data2.Rows[e.RowIndex].Cells[7].Value);
                estado = Convert.ToString(data2.Rows[e.RowIndex].Cells[8].Value);

                btnAlterar.Enabled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (selecao == 1)
            {
                AlterarCliente2 frmAlterarCliente2 = new AlterarCliente2();
                frmAlterarCliente2.RecebeDados1(idc, nome, sobrenome, Cpf, celular, telefone, email,
                    idef, rua, numero, cep, complemento, bairro, cidade, estado);
                frmAlterarCliente2.Show();
                this.Close();
            }
            else if (selecao == 2)
            {
                AlterarCliente2 frmAlterarCliente2 = new AlterarCliente2();
                frmAlterarCliente2.RecebeDados2(idc, nome, sobrenome, Cnpj, celular, telefone, email,
                    idej, rua, numero, cep, complemento, bairro, cidade, estado);
                frmAlterarCliente2.Show();
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
