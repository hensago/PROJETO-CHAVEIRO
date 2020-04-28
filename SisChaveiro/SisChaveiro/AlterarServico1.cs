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
    public partial class AlterarServico1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public AlterarServico1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            txtServico.Enabled = false;
            txtLS.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtServico.Enabled = true;
            txtServico.Text = "";
            txtLS.Enabled = false;
            txtLS.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtServico.Enabled = false;
            txtServico.Text = "";
            txtLS.Enabled = true;
            txtLS.Text = "";
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            string servico = txtServico.Text;

            string selecionar = @"SELECT Id_Servico, Servico, Lugar_Servico, Descricao, Preco FROM SERVICO
                WHERE Servico LIKE '%" + servico + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        private void txtLS_TextChanged(object sender, EventArgs e)
        {
            string ls = txtLS.Text;

            string selecionar = @"SELECT Id_Servico, Servico, Lugar_Servico, Descricao, Preco FROM SERVICO
                WHERE Lugar_Servico LIKE '%" + ls + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        int ids;
        string serv, ls, desc;
        double preco;

        private void SelecioneServico(object sender, DataGridViewCellEventArgs e)
        {
            ids = Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value);
            serv = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
            ls = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            desc = Convert.ToString(data.Rows[e.RowIndex].Cells[3].Value);
            preco = Convert.ToDouble(data.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarServico2 frmAlterarServico2 = new AlterarServico2();
            frmAlterarServico2.RecebeServico(ids, serv, ls, desc, preco);
            frmAlterarServico2.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
