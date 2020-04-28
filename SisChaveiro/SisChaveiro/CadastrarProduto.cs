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
    public partial class CadastrarProduto : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public CadastrarProduto()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        string nomefornecedor;
        int idfornecedor;

        private void txtNF_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNF.Text;

            string selecionar = @"SELECT Id_Fornecedor, Nome, E_mail, Celular, Telefone FROM FORNECEDOR WHERE Nome LIKE '%" + nome + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        private void txtPU_TextChanged(object sender, EventArgs e)
        {
            double quant, preco, resultado;

            quant = Convert.ToDouble(txtQuantidade.Text);
            preco = Convert.ToDouble(txtPU.Text);

            resultado = preco * quant;

            txtPT.Text = Convert.ToString(resultado);
        }

        private void SelecioneFornecedor(object sender, DataGridViewCellEventArgs e)
        {
            nomefornecedor = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
            txtNF.Text = nomefornecedor;

            idfornecedor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
            txtIDF.Text = Convert.ToString(idfornecedor);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                
                    string marca, modelo, nomeforn;
                    int idforn, quantidade;
                    double precoU, precoT;

                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    nomeforn = txtNF.Text;
                    idforn = Convert.ToInt32(txtIDF.Text);
                    quantidade = Convert.ToInt32(txtQuantidade.Text);
                    precoU = Convert.ToDouble(txtPU.Text);
                    precoT = Convert.ToDouble(txtPT.Text);

                    string inserir = @"INSERT INTO PRODUTO (Id_Fornecedor, Nome_Fornecedor, Marca, Modelo, Quantidade, Preco_Unitario, Preco_Total) VALUES
                        ('" + idforn + "','" + nomeforn + "','" + marca + "','" + modelo + "','" + quantidade + "','" + precoU + "','" + precoT + "')";

                    SqlCommand _cmd = new SqlCommand(inserir, con);
                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO!");

                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtQuantidade.Clear();
                    txtPU.Clear();
                    txtPT.Clear();
                    txtNF.Clear();
                    txtIDF.Clear();
                    txtMarca.Focus();
                
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Certifique-se que você digitou algum número nos campos certo");
                txtQuantidade.Focus();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtQuantidade.Clear();
            txtPU.Clear();
            txtPT.Clear();
            txtNF.Clear();
            txtIDF.Clear();
            txtMarca.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
