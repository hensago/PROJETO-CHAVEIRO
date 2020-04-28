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
    public partial class AlterarProduto2 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarProduto2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void RecebeDados(int Idp, int Idf, string nomef, string marca, string modelo, int Quantidade, double precou, double precot)
        {
            txtID.Text = Convert.ToString(Idp);
            txtMarca.Text = marca;
            txtNF.Text = nomef;
            txtModelo.Text = modelo;
            txtIDF.Text = Convert.ToString(Idf);
            txtQuantidade.Text = Convert.ToString(Quantidade);
            txtPU.Text = Convert.ToString(precou);
            txtPT.Text = Convert.ToString(precot);
        }

        int IDP, IDF, Quant;
        double PU, PT;
        string Marca, Modelo, Forn;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IDP = Convert.ToInt32(txtID.Text);
            IDF = Convert.ToInt32(txtIDF.Text);
            Quant = Convert.ToInt32(txtQuantidade.Text);
            PU = Convert.ToDouble(txtPU.Text);
            PT = Convert.ToDouble(txtPT.Text);
            Marca = txtMarca.Text;
            Modelo = txtModelo.Text;
            Forn = txtNF.Text;

            PT = Quant * PU;

            string update = @"UPDATE PRODUTO SET Id_Fornecedor ='" + IDF + "', Nome_Fornecedor ='" + Forn + "', Marca ='" +
             Marca + "', Modelo ='" + Modelo + "', Quantidade ='" + Quant + "', Preco_Unitario ='" + PU + "', Preco_Total ='" +
             PT + "'WHERE Id_Produto ='" + IDP + "';";

            SqlCommand _cmd = new SqlCommand(update, con);
            _cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Atualização Realizada Com Sucesso!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
