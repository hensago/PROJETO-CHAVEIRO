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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente frmCadastrarCliente = new CadastrarCliente();
            frmCadastrarCliente.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente1 frmConsultaCliente1 = new ConsultaCliente1();
            frmConsultaCliente1.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor frmCadastrarFornecedor = new CadastrarFornecedor();
            frmCadastrarFornecedor.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor frmConsultaFornecedor = new ConsultaFornecedor();
            frmConsultaFornecedor.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto frmCadastrarProduto = new CadastrarProduto();
            frmCadastrarProduto.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProduto frmConsultaProduto = new ConsultaProduto();
            frmConsultaProduto.Show();
        }

        private void gERENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            TelaGerente1 frmTelaGerente1 = new TelaGerente1();
            frmTelaGerente1.Show();
        }
                
        private void btnPProduto_Click(object sender, EventArgs e)
        {
            PedidoProduto frmPedidoProduto = new PedidoProduto();
            frmPedidoProduto.Show();
        }

        private void btnPServico_Click(object sender, EventArgs e)
        {
            PedidoServico frmPedidoServico = new PedidoServico();
            frmPedidoServico.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
