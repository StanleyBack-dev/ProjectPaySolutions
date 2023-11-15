using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySolutionsDesktop.DAO
{
    class TesteConexao
    {
        static void Main(string[] args)
        {
            using (Conexao conexao = new Conexao())
            {
                try
                {
                    SqlConnection con = conexao.Conectar();
                    Console.WriteLine("Conexão bem sucedida com o banco de dados!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}