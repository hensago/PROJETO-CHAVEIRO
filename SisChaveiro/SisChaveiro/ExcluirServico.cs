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
    public partial class ExcluirServico : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public ExcluirServico()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
            txtServico.Enabled = false;
            txtLS.Enabled = false;
        }
        int codigo_servico;

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

        private void SelecioneServico(object sender, DataGridViewCellEventArgs e)
        {
            codigo_servico = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if ((txtLS.Text != "") || (txtServico.Text != ""))
                {
                    string deletar = @"DELETE FROM SERVICO WHERE Id_Servico ='" + codigo_servico + "';";
                    SqlCommand _cmd = new SqlCommand(deletar, con);
                    _cmd.ExecuteNonQuery();
                    txtLS.Text = "";
                    txtServico.Text = "";

                    string selecionar = @"SELECT Id_Servico, Servico, Lugar_Servico, Descricao, Preco FROM SERVICO";
                    SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    data.DataSource = tabela;

                    btnExcluir.Enabled = false;
                }
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }
    }
}
