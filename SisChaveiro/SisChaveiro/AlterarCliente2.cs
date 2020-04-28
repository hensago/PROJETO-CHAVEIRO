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
    public partial class AlterarCliente2 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarCliente2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = false;
        }

        int selecao;

        public void RecebeDados1(int idc, string nome, string sobrenome, string Cpf, string celular, string telefone, string email,
            int idef, string rua, int numero, string cep, string complemento, string bairro, string cidade, string estado)
        {
            txtID.Text = Convert.ToString(idc);
            txtNome.Text = nome;
            txtSobrenome.Text = sobrenome;
            rbtnCPF.Checked = true;
            mtxtCPF.Text = Cpf;
            mtxtCelular.Text = celular;
            mtxtTelefone.Text = telefone;
            txtEmail.Text = email;

            txtIDE.Text = Convert.ToString(idef);
            txtRua.Text = rua;
            txtNumero.Text = Convert.ToString(numero);
            mtxtCEP.Text = cep;
            txtComplemento.Text = complemento;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;

            selecao = 1;
        }

        public void RecebeDados2(int idc, string nome, string sobrenome, string Cnpj, string celular, string telefone, string email,
            int idej, string rua, int numero, string cep, string complemento, string bairro, string cidade, string estado)
        {
            txtID.Text = Convert.ToString(idc);
            txtNome.Text = nome;
            txtSobrenome.Text = sobrenome;
            rbtnCPF.Checked = true;
            mtxtCPF.Text = Cnpj;
            mtxtCelular.Text = celular;
            mtxtTelefone.Text = telefone;
            txtEmail.Text = email;

            txtIDE.Text = Convert.ToString(idej);
            txtRua.Text = rua;
            txtNumero.Text = Convert.ToString(numero);
            mtxtCEP.Text = cep;
            txtComplemento.Text = complemento;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;

            selecao = 2;
        }

        int IDC, IDE, Numero;
        String Nome, Sobrenome, Celular, Telefone, Email;
        String CPF, CNPJ;
        String Rua, CEP, Complemento, Bairro, Cidade, Estado;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (selecao == 1)
            {
                IDC = Convert.ToInt32(txtID.Text);
                Nome = txtNome.Text;
                Sobrenome = txtSobrenome.Text;
                CPF = mtxtCPF.Text;
                Celular = mtxtCelular.Text;
                Telefone = mtxtTelefone.Text;
                Email = txtEmail.Text;

                IDE = Convert.ToInt32(txtIDE.Text);
                Rua = txtRua.Text;
                Numero = Convert.ToInt32(txtNumero.Text);
                CEP = mtxtCEP.Text;
                Complemento = txtComplemento.Text;
                Bairro = txtBairro.Text;
                Cidade = txtCidade.Text;
                Estado = txtEstado.Text;

                string update = @"UPDATE CLIENTEF SET Nome ='" + Nome + "', Sobrenome ='" + Sobrenome + "', CPF ='" +
                    CPF + "', Celular ='" + Celular + "', Telefone ='" + Telefone + "', E_mail ='" + Email +
                    "'WHERE Id_Clientef ='" + IDC + "';";

                string update2 = @"UPDATE ENDERECOCF SET CPF = '" + CPF + "', Rua ='" + Rua + "', Numero ='" +
                    Numero + "', CEP ='" + CEP + "', Complemento ='" + Complemento + "', Bairro ='" + Bairro +
                    "', Cidade ='" + Cidade + "', Estado ='" + Estado + "'WHERE Id_Endclif ='" + IDE + "';";

                SqlCommand _cmd = new SqlCommand(update, con);
                SqlCommand _cmd2 = new SqlCommand(update2, con);

                _cmd.ExecuteNonQuery();
                _cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Atualização Realizada Com Sucesso!");

            }
            else if (selecao == 2)
            {
                IDC = Convert.ToInt32(txtID.Text);
                Nome = txtNome.Text;
                Sobrenome = txtSobrenome.Text;
                CNPJ = mtxtCNPJ.Text;
                Celular = mtxtCelular.Text;
                Telefone = mtxtTelefone.Text;
                Email = txtEmail.Text;

                IDE = Convert.ToInt32(txtIDE.Text);
                Rua = txtRua.Text;
                Numero = Convert.ToInt32(txtNumero.Text);
                CEP = mtxtCEP.Text;
                Complemento = txtComplemento.Text;
                Bairro = txtBairro.Text;
                Cidade = txtCidade.Text;
                Estado = txtEstado.Text;

                string update = @"UPDATE CLIENTEJ SET Nome ='" + Nome + "', Sobrenome ='" + Sobrenome + "', CNPJ ='" +
                    CNPJ + "', Celular ='" + Celular + "', Telefone ='" + Telefone + "', E_mail ='" + Email +
                    "'WHERE Id_Clientef ='" + IDC + "';";

                string update2 = @"UPDATE ENDERECOCJ SET CNPJ = '" + CNPJ + "', Rua ='" + Rua + "', Numero ='" +
                    Numero + "', CEP ='" + CEP + "', Complemento ='" + Complemento + "', Bairro ='" + Bairro +
                    "', Cidade ='" + Cidade + "', Estado ='" + Estado + "'WHERE Id_Endclif ='" + IDE + "';";

                SqlCommand _cmd = new SqlCommand(update, con);
                SqlCommand _cmd2 = new SqlCommand(update2, con);

                _cmd.ExecuteNonQuery();
                _cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Atualização Realizada Com Sucesso!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
