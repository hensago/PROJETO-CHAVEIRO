using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisChaveiro
{
    public partial class TelaGerente2 : Form
    {
        public TelaGerente2()
        {
            InitializeComponent();
        }

        private void consultaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCCliente frmConsultaCCliente = new ConsultaCCliente();
            frmConsultaCCliente.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarCliente1 frmAlterarCliente1 = new AlterarCliente1();
            frmAlterarCliente1.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirCliente frmExcluirCliente = new ExcluirCliente();
            frmExcluirCliente.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarProduto1 frmAlterarProduto1 = new AlterarProduto1();
            frmAlterarProduto1.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirProduto frmExcluirProduto = new ExcluirProduto();
            frmExcluirProduto.Show();
        }

        private void consultaCompletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCFornecedor frmConsultaCFornecedor = new ConsultaCFornecedor();
            frmConsultaCFornecedor.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarFornecedor1 frmAlterarFornecedor1 = new AlterarFornecedor1();
            frmAlterarFornecedor1.Show();
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor frmExcluirFornecedor = new ExcluirFornecedor();
            frmExcluirFornecedor.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario frmCadastrarFuncionario = new CadastrarFuncionario();
            frmCadastrarFuncionario.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario frmConsultaFuncionario = new ConsultaFuncionario();
            frmConsultaFuncionario.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AlterarFuncionario1 frmAlterarFuncionario1 = new AlterarFuncionario1();
            frmAlterarFuncionario1.Show();
        }

        private void excluirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario frmExcluirFuncionario = new ExcluirFuncionario();
            frmExcluirFuncionario.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPProduto frmConsultaPProduto = new ConsultaPProduto();
            frmConsultaPProduto.Show();
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPServico frmConsultaPServico = new ConsultaPServico();
            frmConsultaPServico.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarServico frmCadastrarServico = new CadastrarServico();
            frmCadastrarServico.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaServico frmConsultaServico = new ConsultaServico();
            frmConsultaServico.Show();
        }

        private void alterarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AlterarServico1 frmAlterarServico1 = new AlterarServico1();
            frmAlterarServico1.Show();
        }

        private void excluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ExcluirServico frmExcluirServico = new ExcluirServico();
            frmExcluirServico.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
