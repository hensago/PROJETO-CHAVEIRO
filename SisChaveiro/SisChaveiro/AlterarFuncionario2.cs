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
    public partial class AlterarFuncionario2 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarFuncionario2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void RecebeDados(int Idf, string nomef, string sobrenome, string Cpf, string celular, string telefone, string email,
                int Ide, string rua, int Num, string Cep, string complemento, string bairro, string cidade, string estado)
        {
            txtID.Text = Convert.ToString(Idf);
            txtNome.Text = nomef;
            txtSobrenome.Text = sobrenome;
            mtxtCPF.Text = Cpf;
            mtxtCelular.Text = celular;
            mtxtTelefone.Text = telefone;
            txtEmail.Text = email;

            txtIDE.Text = Convert.ToString(Ide);
            txtRua.Text = rua;
            txtNumero.Text = Convert.ToString(Num);
            mtxtCEP.Text = Cep;
            txtComplemento.Text = complemento;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;

        }

        string Nome, Sobrenome, CPF, Celular, Telefone, Email;

        private void mtxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        int IDF, IDE, Numero;
        string Rua, CEP, Complemento, Bairro, Cidade, Estado;

        private void btnSalvar_Click(object sender, EventArgs e)
                {
            IDF = Convert.ToInt32(txtID.Text);
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

            string update = @"UPDATE FUNCIONARIO SET Nome ='" + Nome + "', Sobrenome ='" + Sobrenome + "', CPF ='" + CPF + "', Celular ='" +
            Celular + "', Telefone ='" + Telefone + "', E_mail ='" + Email + "'WHERE Id_Funcionario ='" + IDF + "';";

            string update2 = @"UPDATE ENDERECOFUN SET Nome_Funcionario = '" + Nome + "', CPF ='" + CPF + "', Rua ='" + Rua + "', Numero ='" +
                Numero + "', CEP ='" + CEP + "', Complemento ='" + Complemento + "', Bairro ='" + Bairro + "', Cidade ='" + Cidade +
                "', Estado ='" + Estado + "'WHERE Id_Endfun ='" + IDE + "';";

            SqlCommand _cmd = new SqlCommand(update, con);
            SqlCommand _cmd2 = new SqlCommand(update2, con);

            _cmd.ExecuteNonQuery();
            _cmd2.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Atualização Realizada Com Sucesso!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
