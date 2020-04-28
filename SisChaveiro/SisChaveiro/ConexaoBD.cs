using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisChaveiro
{
    class ConexaoBD
    {
        public SqlConnection abrir_conexao()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VST\SisChaveiro\SisChaveiro\BdChaveiro.mdf;Integrated Security=True";
                con.Open();
                return con;
            }
            catch(Exception erro)
            {
                return null;
            }
        }

        public void fechar_conexao(SqlConnection con)
        {
            con.Close();
        }
    }
}
