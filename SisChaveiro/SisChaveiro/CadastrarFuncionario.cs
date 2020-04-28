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
    public partial class CadastrarFuncionario : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public CadastrarFuncionario()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        string nome, sobrenome, email;
        string cpf, celular, telefone;
        string rua, cep, complemento, bairro, cidade, estado;
        int numero;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtSobrenome.Text != "") && (mtxtCelular.Text != "") && (mtxtTelefone.Text != "") &&
                (txtEmail.Text != "") && (txtRua.Text != "") && (txtNumero.Text != "") && (mtxtCEP.Text != "") && (txtBairro.Text != "") &&
                (txtCidade.Text != "") && (txtEstado.Text != ""))
            {
                try
                {
                    nome = txtNome.Text;
                    sobrenome = txtSobrenome.Text;
                    cpf = mtxtCPF.Text;
                    celular = mtxtCelular.Text;
                    telefone = mtxtTelefone.Text;
                    email = txtEmail.Text;

                    rua = txtRua.Text;
                    numero = Convert.ToInt32(txtNumero.Text);
                    cep = mtxtCEP.Text;
                    complemento = txtComplemento.Text;
                    bairro = txtBairro.Text;
                    cidade = txtCidade.Text;
                    estado = txtEstado.Text;


                    string inserir1 = @"INSERT INTO FUNCIONARIO (Nome, Sobrenome, CPF, Celular, Telefone, E_mail) VALUES 
                    ('"+ nome +"','"+ sobrenome + "','" + cpf + "','" + celular + "','" + telefone + "','" + email + "')";

                    string inserir2 = @"INSERT INTO ENDERECOFUN (Nome_Funcionario, CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado) VALUES
                    ('"+nome + "','" + cpf + "','" + rua + "','" + numero + "','" + cep + "','" + complemento + "','" + bairro + "','" + cidade + "','" + estado + "')";

                    SqlCommand _cmd1 = new SqlCommand(inserir1, con);
                    SqlCommand _cmd2 = new SqlCommand(inserir2, con);

                    _cmd1.ExecuteNonQuery();
                    _cmd2.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("FUNCIONÁRIO CADASTRADO COM SUCESSO!");

                    txtNome.Clear();
                    txtSobrenome.Clear();
                    mtxtCPF.Clear();
                    mtxtCelular.Clear();
                    mtxtTelefone.Clear();
                    txtEmail.Clear();
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
            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mtxtCPF.Clear();
            mtxtCelular.Clear();
            mtxtTelefone.Clear();
            txtEmail.Clear();
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
