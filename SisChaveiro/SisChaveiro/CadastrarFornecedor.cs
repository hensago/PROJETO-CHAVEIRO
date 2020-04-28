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
    public partial class CadastrarFornecedor : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public CadastrarFornecedor()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        string nome, email;
        string celular, telefone;
        string rua, cep, complemento, bairro, cidade, estado;
        int numero;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (mtxtCelular.Text != "") && (mtxtTelefone.Text != "") && (txtEmail.Text != "") &&
                (txtRua.Text != "") && (txtNumero.Text != "") && (mtxtCEP.Text != "") && (txtBairro.Text != "") &&
                (txtCidade.Text != "") && (txtEstado.Text != ""))
            {
                try
                {
                    nome = txtNome.Text;
                    email = txtEmail.Text;
                    celular = mtxtCelular.Text;
                    telefone = mtxtTelefone.Text;

                    rua = txtRua.Text;
                    numero = Convert.ToInt16(txtNumero.Text);
                    cep = mtxtCEP.Text;
                    complemento = txtComplemento.Text;
                    bairro = txtBairro.Text;
                    cidade = txtCidade.Text;
                    estado = txtEstado.Text;

                    string inserir1 = @"INSERT INTO FORNECEDOR (Nome, E_mail, Celular, Telefone) VALUES ('" + nome + "','" + email + "','" + celular + "','" + telefone + "')";
                    string inserir2 = @"INSERT INTO ENDERECOFR (Nome_Fornecedor, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado) VALUES
                    ('" + nome + "','" + rua + "','" + numero + "','" + cep + "','" + complemento + "','" + bairro + "','" + cidade + "','" + estado + "')";

                    SqlCommand _cmd1 = new SqlCommand(inserir1, con);
                    SqlCommand _cmd2 = new SqlCommand(inserir2, con);

                    _cmd1.ExecuteNonQuery();
                    _cmd2.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("FORNECEDOR CADASTRADO COM SUCESSO!");

                    txtNome.Clear();
                    txtEmail.Clear();
                    mtxtCelular.Clear();
                    mtxtTelefone.Clear();
                    txtRua.Clear();
                    txtNumero.Clear();
                    mtxtCEP.Clear();
                    txtComplemento.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtNome.Focus();

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Certifique-se que você digitou algum número nos campos certo");
                    mtxtCelular.Focus();
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            mtxtCelular.Clear();
            mtxtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            mtxtCEP.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
