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
    public partial class ExcluirCliente : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        int codigo_cliente;
        string Cpf, Cnpj;
        public ExcluirCliente()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = false;
            btnExcluir.Enabled = false;
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

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (radioButton1.Checked == true)
                {
                    string deletar = @"DELETE FROM CLIENTEF WHERE Id_Clientef ='" + codigo_cliente + "';";
                    string deletar2 = @"DELETE FROM ENDERECOCF WHERE CPF ='" + Cpf + "';";
                    SqlCommand _cmd = new SqlCommand(deletar, con);
                    SqlCommand _cmd2 = new SqlCommand(deletar2, con);
                    _cmd.ExecuteNonQuery();
                    _cmd2.ExecuteNonQuery();
                    mtxtCPF.Text = "";

                    string selecionar1 = @"SELECT Id_Clientef, Nome, Sobrenome, CPF, Celular, Telefone, E_mail FROM CLIENTEF";
                    string selecionar2 = @"SELECT Id_Endclif, CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOCF";

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
                else if (radioButton2.Checked == true)
                {
                    string deletar1 = @"DELETE FROM CLIENTEJ WHERE Id_Clientej ='" + codigo_cliente + "';";
                    string deletar2 = @"DELETE FROM ENDERECOCJ WHERE CNPJ ='" + Cnpj + "';";
                    SqlCommand _cmd1 = new SqlCommand(deletar1, con);
                    SqlCommand _cmd2 = new SqlCommand(deletar2, con);
                    _cmd1.ExecuteNonQuery();
                    _cmd2.ExecuteNonQuery();
                    mtxtCNPJ.Text = "";

                    string selecionar = @"SELECT Id_Clientej, Nome, Sobrenome, CNPJ, Celular, Telefone, E_mail FROM CLIENTEJ";
                    string selecionar2 = @"SELECT Id_Endclij, CNPJ, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado FROM ENDERECOCJ";


                    SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(selecionar2, con);

                    DataTable tabela = new DataTable();
                    DataTable tabela2 = new DataTable();

                    adaptador.Fill(tabela);
                    adaptador2.Fill(tabela2);

                    data1.DataSource = tabela;
                    data2.DataSource = tabela2;

                    btnExcluir.Enabled = false;
                }
            }
        }

        private void SelecioneCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                codigo_cliente = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
                
                btnExcluir.Enabled = true;
            }
            else if (radioButton2.Checked == true)
            {
                codigo_cliente = Convert.ToInt32(data1.Rows[e.RowIndex].Cells[0].Value);
                
                btnExcluir.Enabled = true;
            }
        }

        private void SelecioneEndereco(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Cpf = Convert.ToString(data2.Rows[e.RowIndex].Cells[1].Value);
                btnExcluir.Enabled = true;
            }
            else if (radioButton2.Checked == true)
            {
                Cnpj = Convert.ToString(data2.Rows[e.RowIndex].Cells[1].Value);
                btnExcluir.Enabled = true;
            }
            }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
