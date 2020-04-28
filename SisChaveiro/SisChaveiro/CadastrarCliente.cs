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
    public partial class CadastrarCliente : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public CadastrarCliente()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = false;
        }

        string nome, sobrenome, email;
        string cpf, cnpj, celular, telefone;               
        string rua, cep, complemento, bairro, cidade, estado;                
        int numero;

        private void rbtnCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPF.Enabled = true;
            mtxtCNPJ.Enabled = false;
        }

        private void rbtnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Enabled = true;
            mtxtCPF.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtSobrenome.Text != "") && (mtxtCelular.Text != "") && (mtxtTelefone.Text != "") &&
                (txtEmail.Text != "") && (txtRua.Text != "") && (txtNumero.Text != "") && (mtxtCEP.Text != "") && (txtBairro.Text != "") &&
                (txtCidade.Text != "") && (txtEstado.Text != ""))
            {
                try
                {
                    if (rbtnCPF.Checked == true)
                    {
                        if (mtxtCPF.Text != "")
                        {
                            nome = txtNome.Text;
                            sobrenome = txtSobrenome.Text;
                            cpf = mtxtCPF.Text;
                            celular = mtxtCelular.Text;
                            telefone = mtxtTelefone.Text;
                            email = txtEmail.Text;

                            rua = txtRua.Text;
                            numero = Convert.ToInt16(txtNumero.Text);
                            cep = mtxtCEP.Text;
                            complemento = txtComplemento.Text;
                            bairro = txtBairro.Text;
                            cidade = txtCidade.Text;
                            estado = txtEstado.Text;

                            string inserir1 = @"INSERT INTO CLIENTEF (Nome, Sobrenome, CPF, Celular, Telefone, E_mail) VALUES
                            ('" + nome + "','" + sobrenome + "','" + cpf + "','" + celular + "','" + telefone + "','" + email + "')";
                            string inserir2 = @"INSERT INTO ENDERECOCF (CPF, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado) VALUES
                            ('" + cpf + "','" + rua + "','" + numero + "','" + cep + "','" + complemento + "','" + bairro + "','" + cidade + "','" + estado + "')";

                            SqlCommand _cmd1 = new SqlCommand(inserir1, con);
                            SqlCommand _cmd2 = new SqlCommand(inserir2, con);

                            _cmd1.ExecuteNonQuery();
                            _cmd2.ExecuteNonQuery();

                            

                            MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO!");

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
                        else
                        {
                            MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                            txtNome.Focus();
                        }

                    }
                    else if (rbtnCNPJ.Checked == true)
                    {
                        if (mtxtCNPJ.Text != "")
                        {
                            nome = txtNome.Text;
                            sobrenome = txtSobrenome.Text;
                            email = txtEmail.Text;
                            cnpj = mtxtCNPJ.Text;
                            telefone = mtxtTelefone.Text;
                            celular = mtxtCelular.Text;

                            rua = txtRua.Text;
                            numero = Convert.ToInt16(txtNumero.Text);
                            cep = mtxtCEP.Text;
                            complemento = txtComplemento.Text;
                            bairro = txtBairro.Text;
                            cidade = txtCidade.Text;
                            estado = txtEstado.Text;

                            string inserir1 = @"INSERT INTO CLIENTEJ (Nome, Sobrenome, CNPJ, Celular, Telefone, E_mail) VALUES
                            ('" + nome + "','" + sobrenome + "','" + cnpj + "','" + celular + "','" + telefone + "','" + email + "')";
                            string inserir2 = @"INSERT INTO ENDERECOCJ (CNPJ, Rua, Numero, CEP, Complemento, Bairro, Cidade, Estado) VALUES
                            ('" + cnpj + "','" + rua + "','" + numero + "','" + cep + "','" + complemento + "','" + bairro + "','" + cidade + "','" + estado + "')";

                            SqlCommand _cmd1 = new SqlCommand(inserir1, con);
                            SqlCommand _cmd2 = new SqlCommand(inserir2, con);

                            _cmd1.ExecuteNonQuery();
                            _cmd2.ExecuteNonQuery();

                            

                            MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO!");

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
                        else
                        {
                            MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                            txtNome.Focus();
                        }
                    }
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
            con.Close();
            Close();
        }
    }
}
