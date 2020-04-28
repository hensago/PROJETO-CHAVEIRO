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
    public partial class CadastrarServico : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public CadastrarServico()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string servico, ls, desc, preco;
            servico = txtServico.Text;
            ls = txtLS.Text;
            desc = txtDescricao.Text;
            preco = txtPreco.Text;

            string inserir = @"INSERT INTO SERVICO (Servico, Lugar_Servico, Descricao, Preco) VALUES
                ('" + servico + "','" + ls + "','" + desc + "','" + preco + "')";

            SqlCommand _cmd1 = new SqlCommand(inserir, con);
            _cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("SERVIÇO CADASTRADO COM SUCESSO!");

            txtServico.Clear();
            txtLS.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtServico.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtServico.Clear();
            txtLS.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtServico.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
