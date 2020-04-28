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
    public partial class TelaGerente1 : Form
    {
        SqlConnection con;
        ConexaoBD banco = new ConexaoBD();
        public TelaGerente1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                int senha = Convert.ToInt32(txtSenha.Text);
                if (senha == 0000)
                {
                    TelaGerente2 frmTelaGerente2 = new TelaGerente2();
                    frmTelaGerente2.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Acesso Negado!");
                }
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
