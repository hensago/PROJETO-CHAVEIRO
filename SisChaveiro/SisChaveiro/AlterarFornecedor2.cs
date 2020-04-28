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
    public partial class AlterarFornecedor2 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarFornecedor2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void RecebeDados(int IDF, string Nome, string Email, string Celular, string Telefone,
            int IDE, string Rua, int Numero, string CEP, string Complemento, string Bairro,
            string Cidade, string Estado)
        {
            txtID.Text = Convert.ToString(IDF);
            txtNome.Text = Nome;
            mtxtCelular.Text = Celular;
            mtxtTelefone.Text = Telefone;
            txtEmail.Text = Email;

            txtIDE.Text = Convert.ToString(IDE);
            txtRua.Text = Rua;
            txtNumero.Text = Convert.ToString(Numero);
            mtxtCEP.Text = CEP;
            txtComplemento.Text = Complemento;
            txtBairro.Text = Bairro;
            txtCidade.Text = Cidade;
            txtEstado.Text = Estado;
        }

        string nomec, email, celular, telefone;
        int idf, ide, num;
        string rua, cep, complemento, bairro, cidade, estado;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            idf = Convert.ToInt32(txtID.Text);
            nomec = txtNome.Text;
            celular = mtxtCelular.Text;
            telefone = mtxtTelefone.Text;
            email = txtEmail.Text;

            ide = Convert.ToInt32(txtIDE.Text);
            rua = txtRua.Text;
            num = Convert.ToInt32(txtNumero.Text);
            cep = mtxtCEP.Text;
            complemento = txtComplemento.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            estado = txtEstado.Text;


            string update = @"UPDATE FORNECEDOR SET Nome ='" + nomec + "', E_mail ='" + email + "', Celular ='" +
            celular + "', Telefone ='" + telefone + "'WHERE Id_Fornecedor ='" + idf + "';";

            string update2 = @"UPDATE ENDERECOFR SET Nome_Fornecedor = '" + nomec + "', Rua ='" + rua + "', Numero ='" +
                num + "', CEP ='" + cep + "', Complemento ='" + complemento + "', Bairro ='" + bairro + "', Cidade ='" +
                cidade + "', Estado ='" + estado + "'WHERE Id_Endforn ='" + ide + "';";

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
