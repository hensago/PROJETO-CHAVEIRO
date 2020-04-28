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
    public partial class AlterarServico2 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarServico2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        public void RecebeServico(int ids, string serv, string ls, string desc, double preco)
        {
            txtID.Text = Convert.ToString(ids);
            txtServico.Text = serv;
            txtLS.Text = ls;
            txtDescricao.Text = desc;
            txtPreco.Text = Convert.ToString(preco);
        }

        int IDS;
        string Serv, LS, Desc;
        double Preco;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IDS = Convert.ToInt32(txtID.Text);
            Serv = txtServico.Text;
            LS = txtLS.Text;
            Desc = txtDescricao.Text;
            Preco = Convert.ToDouble(txtPreco.Text);

            string update = @"UPDATE SERVICO SET Servico ='" + Serv + "', Lugar_Servico ='" +
                LS + "', Descricao ='" + Desc + "', Preco ='" + Preco + "'WHERE Id_Servico ='" +
                IDS + "';";

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
